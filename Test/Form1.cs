using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private int count = 0;
		private BackgroundWorker backgroundWorker = null;
		Form2 form2 = null;
		private void DoWork(object sender, DoWorkEventArgs e)
		{
			
			do
			{
				/*form2 = new Form2();
				form2.Show();*/
				//frmSonLoading.ShowSplashScreen();
				backgroundWorker.ReportProgress(count);
				form2.ProgressValue = count;
				count += 1;
				Thread.Sleep(100);
			} while (count<=100);
		}

		public void ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			this.progressBar1.Value = e.ProgressPercentage;
		}
		public void RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.Cursor = Cursors.Default;
			button1.Enabled = true;
			form2.Close();
		}

		// Nếu gọi lệnh mở form ở đây thì form loading sẽ được mở trên cùng 1 tiến trình với BackgroundWorker
		// do đó khi chúng ta gọi lệnh form close thì lệnh mới được phép chạy do lệnh khởi tạo/mở và đóng cùng trên
		// một tiến trình	(do BGW DoWork với BGW RunWorkerComplete chạy trên 2 thread khác nhau)

		// Proof: https://stackoverflow.com/questions/46209741/how-does-backgroundworker-decide-on-which-thread-to-run-the-runworkercompleted-h

		// Còn nếu chúng ta ném vào DoWork thì dù có dùng delegate, chương trình cũng không biết được thread nào chứa lệnh khởi tạo
		// để hủy (do có 2 thread đang chạy là DoWork và thread Application chính), do đó chương trình sẽ gây lỗi
		private void button1_Click(object sender, EventArgs e)
		{
			form2 = new Form2();
			form2.Show();
			count = 0;
			this.Cursor = Cursors.WaitCursor;
			button1.Enabled = false;
			backgroundWorker = new BackgroundWorker();
			backgroundWorker.DoWork += DoWork;
			backgroundWorker.ProgressChanged += ProgressChanged;
			backgroundWorker.RunWorkerCompleted += RunWorkerCompleted;
			backgroundWorker.WorkerReportsProgress = true;
			backgroundWorker.RunWorkerAsync();
		}
		SqlConnection Conn = null;
		DataTable dt = null;

		public DataTable GetDataTable(string sqlQuery)
		{
			DataSet ds = new DataSet();
			DataTable dt = null;
			try
			{
				SqlDataAdapter da = new SqlDataAdapter(sqlQuery, Conn);
				da.Fill(ds);
				dt = ds.Tables[0];
			}
			catch (Exception)
			{
				dt = null;
			}
			return dt;
		}
		string _ConnectionString = @"Data Source=DESKTOP-G8A1CQA\SQLEXPRESS;Initial Catalog=ShiStock;Integrated Security=True";
		private void button2_Click(object sender, EventArgs e)
		{
			
			Conn = new SqlConnection(_ConnectionString);
			Conn.Open();
			dt = GetDataTable("SELECT TOP 1 * FROM Test");
			dt.TableName = "Test";
			dt.Clear();
			for (int i = 0; i < 1000; i++)
			{
				dt.Rows.Add(new object[] { "TEST", 1, 2.8888, true });
			}
		}
		public bool AddRow(DataRow Row)
		{
			try
			{
				bool Result = false;

				SqlCommand cmd = new SqlCommand();
				cmd.Connection = Conn;

				string sSQL = "INSERT INTO " + Row.Table.TableName + " VALUES(";
				foreach (DataColumn item in Row.Table.Columns)
				{
					sSQL = sSQL + "@" + item.ColumnName + ",";
					cmd.Parameters.AddWithValue(item.ColumnName, Row[item]);
				}
				cmd.CommandText = sSQL.Substring(0, sSQL.Length - 1) + ")";
				cmd.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
				return false;
			}

		}
		public bool AddRow(SqlConnection _Conn, DataRow Row)
		{
			try
			{
				bool Result = false;

				SqlCommand cmd = new SqlCommand();
				cmd.Connection = _Conn;

				string sSQL = "INSERT INTO " + Row.Table.TableName + " VALUES(";
				foreach (DataColumn item in Row.Table.Columns)
				{
					sSQL = sSQL + "@" + item.ColumnName + ",";
					cmd.Parameters.AddWithValue(item.ColumnName, Row[item]);
				}
				cmd.CommandText = sSQL.Substring(0, sSQL.Length - 1) + ")";
				cmd.ExecuteNonQuery();
				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return false;
			}

		}
		public bool AddRowWithStringBuilder(DataRowCollection Rows)
		{
			try
			{
				bool Result = false;

				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("BEGIN \n");
				string sSQL = "INSERT INTO Test VALUES('{0}',{1},{2},{3});\n";
				foreach (DataRow  row in Rows)
				{
					stringBuilder.Append(string.Format(sSQL, new object[] { row["C1"], row["C2"], row["C3"], (bool)row["C4"] ? 1 : 0 }));
				}
				stringBuilder.Append("END");

				SqlCommand cmd = new SqlCommand();
				cmd.Connection = Conn;
				cmd.CommandText = stringBuilder.ToString();
				cmd.ExecuteNonQuery();
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}

		}

		public bool AddRowWithStringBuilderAndTrans(DataRowCollection Rows)
		{
			SqlTransaction trans = null;
			try
			{
				bool Result = false;

				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("BEGIN \n ");
				string sSQL = "INSERT INTO Test VALUES('{0}',{1},{2},{3});\n";
				foreach (DataRow row in Rows)
				{
					stringBuilder.Append(string.Format(sSQL, new object[] { row["C1"], row["C2"], row["C3"], (bool)row["C4"] ? 1 : 0 }));
				}
				stringBuilder.Append("END");
				trans= Conn.BeginTransaction();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = Conn;
				cmd.CommandText = stringBuilder.ToString();
				cmd.Transaction = trans;
				cmd.ExecuteNonQuery();
				trans.Commit();
				return true;
			}
			catch (Exception ex)
			{
				trans.Rollback();
				return false;
			}
		}
		private void button3_Click(object sender, EventArgs e)
		{
			Stopwatch st = new Stopwatch();
			st.Start();

			foreach (DataRow row in dt.Rows)
			{
				AddRow(row);
			}

			st.Stop();
			label2.Text = st.ElapsedMilliseconds.ToString();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Stopwatch st = new Stopwatch();
			st.Start();
			AddRowWithStringBuilder(dt.Rows);
			st.Stop();
			label3.Text = st.ElapsedMilliseconds.ToString();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Stopwatch st = new Stopwatch();
			st.Start();
			AddRowWithStringBuilderAndTrans(dt.Rows);
			st.Stop();
			label4.Text = st.ElapsedMilliseconds.ToString();
		}
		async void Run()
		{
			Stopwatch st = new Stopwatch();
			st.Start();

			var threads = new List<Thread>(5);
			for (int p = 0; p <=4; p++)
			{
				RunThread runThread = new RunThread();
				threads.Add(new Thread(() => runThread.RunWithThread(p * 200)));
			}
			foreach (var thread in threads) thread.Start();
			foreach (var thread in threads) thread.Join();

			st.Stop();
			label5.Text = st.ElapsedMilliseconds.ToString();
		}
		private void button6_Click(object sender, EventArgs e)
		{

			Run();

		}
	}
}
