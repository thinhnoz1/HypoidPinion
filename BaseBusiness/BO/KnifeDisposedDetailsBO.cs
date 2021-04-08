
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class KnifeDisposedDetailsBO : BaseBO
	{
		private KnifeDisposedDetailsFacade facade = KnifeDisposedDetailsFacade.Instance;
		protected static KnifeDisposedDetailsBO instance = new KnifeDisposedDetailsBO();

		protected KnifeDisposedDetailsBO()
		{
			this.baseFacade = facade;
		}

		public static KnifeDisposedDetailsBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	