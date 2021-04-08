
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class KnifeDetailListFacade : BaseFacade
	{
		protected static KnifeDetailListFacade instance = new KnifeDetailListFacade(new KnifeDetailListModel());
		protected KnifeDetailListFacade(KnifeDetailListModel model) : base(model)
		{
		}
		public static KnifeDetailListFacade Instance
		{
			get { return instance; }
		}
		protected KnifeDetailListFacade():base() 
		{ 
		} 
	
	}
}
	