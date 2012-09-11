using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ComponentModel;
using System.ServiceModel.Web;

namespace SaleXPService
{
	[ServiceContract ]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
	public class SvcLogin
	{

		[Description("Returns a collection of UserNames.")]
		[WebGet(UriTemplate = "users")]
		public List<String> GetUserNames()
		{
			var retVal = new List<String>();
			try
			{
				retVal.Add("Shilpy");
				retVal.Add("Rajeev");
				retVal.Add("Sahil");
			}
			catch (Exception innerExp)
			{ 

			}
			return retVal;
		}

		[Description("Returns a collection of UserNames.")]
		[WebGet(UriTemplate = "users/{UserId}")]
		public String GetPasswordByUserId(String UserId)
		{
			var retVal = "";
			try
			{
				retVal=UserId + "@123";
			}
			catch (Exception innerExp)
			{ 

			}
			return retVal;
		}

	}
}