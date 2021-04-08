
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class KnifeSharpeningDetailsBO : BaseBO
	{
		private KnifeSharpeningDetailsFacade facade = KnifeSharpeningDetailsFacade.Instance;
		protected static KnifeSharpeningDetailsBO instance = new KnifeSharpeningDetailsBO();

		protected KnifeSharpeningDetailsBO()
		{
			this.baseFacade = facade;
		}

		public static KnifeSharpeningDetailsBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	