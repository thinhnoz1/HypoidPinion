
using System;
namespace BMS.Model
{
	public class KnifeDetailListModel : BaseModel
	{
		private int iD;
		private string knifeCode;
		private string knifeName;
		private string description;
		private DateTime? importedDate;
		private int workerID;
		private int sTD;
		private int aTC;
		private bool status;
		private int currentSTD;
		private int currentATC;
		private DateTime? updatedDate;
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public string KnifeCode
		{
			get { return knifeCode; }
			set { knifeCode = value; }
		}
	
		public string KnifeName
		{
			get { return knifeName; }
			set { knifeName = value; }
		}
	
		public string Description
		{
			get { return description; }
			set { description = value; }
		}
	
		public DateTime? ImportedDate
		{
			get { return importedDate; }
			set { importedDate = value; }
		}
	
		public int WorkerID
		{
			get { return workerID; }
			set { workerID = value; }
		}
	
		public int STD
		{
			get { return sTD; }
			set { sTD = value; }
		}
	
		public int ATC
		{
			get { return aTC; }
			set { aTC = value; }
		}
	
		public bool Status
		{
			get { return status; }
			set { status = value; }
		}
	
		public int CurrentSTD
		{
			get { return currentSTD; }
			set { currentSTD = value; }
		}
	
		public int CurrentATC
		{
			get { return currentATC; }
			set { currentATC = value; }
		}
	
		public DateTime? UpdatedDate
		{
			get { return updatedDate; }
			set { updatedDate = value; }
		}
	
	}
}
	