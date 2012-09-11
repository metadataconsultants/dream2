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
	[ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
	public class SvcValidateUser
	{
		[Description("Returns all the input graph data.")]
		[WebInvoke(UriTemplate = "validateUser/{UserId}/{Password}", Method = "POST")]
		public List<string> validateUser(string UserId, string Password)
			//http://localhost:4559/validate/validateUser/a/b
			//Content-Type: application/text
		{	var retVal = new List<String>();
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
	}
}