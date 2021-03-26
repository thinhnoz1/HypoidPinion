
using System;
namespace BMS.Model
{
	public class StageModel : BaseModel
	{
		private int iD;
		private string stageCode;
		private int managerID;
		private string managerCode;
		private int departmentID;
		private string departmentCode;
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public string StageCode
		{
			get { return stageCode; }
			set { stageCode = value; }
		}
	
		public int ManagerID
		{
			get { return managerID; }
			set { managerID = value; }
		}
	
		public string ManagerCode
		{
			get { return managerCode; }
			set { managerCode = value; }
		}
	
		public int DepartmentID
		{
			get { return departmentID; }
			set { departmentID = value; }
		}
	
		public string DepartmentCode
		{
			get { return departmentCode; }
			set { departmentCode = value; }
		}
	
	}
}
	