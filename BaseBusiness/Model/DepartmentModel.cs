
using System;
namespace BMS.Model
{
	public class DepartmentModel : BaseModel
	{
		private int iD;
		private string departmentCode;
		private int managerID;
		private string managerCode;
		private int areaID;
		private string areaCode;
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public string DepartmentCode
		{
			get { return departmentCode; }
			set { departmentCode = value; }
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
	
		public int AreaID
		{
			get { return areaID; }
			set { areaID = value; }
		}
	
		public string AreaCode
		{
			get { return areaCode; }
			set { areaCode = value; }
		}
	
	}
}
	