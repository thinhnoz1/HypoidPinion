
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class KnifeDisposedDetailsFacade : BaseFacade
	{
		protected static KnifeDisposedDetailsFacade instance = new KnifeDisposedDetailsFacade(new KnifeDisposedDetailsModel());
		protected KnifeDisposedDetailsFacade(KnifeDisposedDetailsModel model) : base(model)
		{
		}
		public static KnifeDisposedDetailsFacade Instance
		{
			get { return instance; }
		}
		protected KnifeDisposedDetailsFacade():base() 
		{ 
		} 
	
	}
}
	