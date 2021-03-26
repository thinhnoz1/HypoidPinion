
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class AreaFacade : BaseFacade
	{
		protected static AreaFacade instance = new AreaFacade(new AreaModel());
		protected AreaFacade(AreaModel model) : base(model)
		{
		}
		public static AreaFacade Instance
		{
			get { return instance; }
		}
		protected AreaFacade():base() 
		{ 
		} 
	
	}
}
	