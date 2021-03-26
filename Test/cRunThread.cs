using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	public class RunThread
	{
		public DataTable dt { get; set; }
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

		string _ConnectionString = @"Data Source=DESKTOP-G8A1CQA\SQLEXPRESS;Initial Catalog=ShiStock;Integrated Security=True";
		public void RunWithThread(int _start)
		{
			int count = _start + 199;
			using (SqlConnection _Connn = new SqlConnection(_ConnectionString))
			{
				_Connn.Open();
				for (int j = _start; j < count; j++)
				{
					AddRow(_Connn, dt.Rows[j]);
				}
				_Connn.Close();
			}

		}
	}
}
