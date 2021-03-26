
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class StageWorkerBO : BaseBO
	{
		private StageWorkerFacade facade = StageWorkerFacade.Instance;
		protected static StageWorkerBO instance = new StageWorkerBO();

		protected StageWorkerBO()
		{
			this.baseFacade = facade;
		}

		public static StageWorkerBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	