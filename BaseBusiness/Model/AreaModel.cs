
using System;
namespace BMS.Model
{
	public class AreaModel : BaseModel
	{
		private int iD;
		private string areaCode;
		private int managerID;
		private string managerCode;
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public string AreaCode
		{
			get { return areaCode; }
			set { areaCode = value; }
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
	
	}
}
	