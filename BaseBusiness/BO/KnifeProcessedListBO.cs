
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class KnifeProcessedListBO : BaseBO
	{
		private KnifeProcessedListFacade facade = KnifeProcessedListFacade.Instance;
		protected static KnifeProcessedListBO instance = new KnifeProcessedListBO();

		protected KnifeProcessedListBO()
		{
			this.baseFacade = facade;
		}

		public static KnifeProcessedListBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	