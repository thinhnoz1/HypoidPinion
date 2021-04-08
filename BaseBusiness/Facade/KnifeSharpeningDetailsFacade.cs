
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class KnifeSharpeningDetailsFacade : BaseFacade
	{
		protected static KnifeSharpeningDetailsFacade instance = new KnifeSharpeningDetailsFacade(new KnifeSharpeningDetailsModel());
		protected KnifeSharpeningDetailsFacade(KnifeSharpeningDetailsModel model) : base(model)
		{
		}
		public static KnifeSharpeningDetailsFacade Instance
		{
			get { return instance; }
		}
		protected KnifeSharpeningDetailsFacade():base() 
		{ 
		} 
	
	}
}
	