
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class StageWorkerFacade : BaseFacade
	{
		protected static StageWorkerFacade instance = new StageWorkerFacade(new StageWorkerModel());
		protected StageWorkerFacade(StageWorkerModel model) : base(model)
		{
		}
		public static StageWorkerFacade Instance
		{
			get { return instance; }
		}
		protected StageWorkerFacade():base() 
		{ 
		} 
	
	}
}
	