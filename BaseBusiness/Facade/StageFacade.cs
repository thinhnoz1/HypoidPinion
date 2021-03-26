
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class StageFacade : BaseFacade
	{
		protected static StageFacade instance = new StageFacade(new StageModel());
		protected StageFacade(StageModel model) : base(model)
		{
		}
		public static StageFacade Instance
		{
			get { return instance; }
		}
		protected StageFacade():base() 
		{ 
		} 
	
	}
}
	