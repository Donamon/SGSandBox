using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Newtonsoft.Json;

namespace WebServiceTest
{
    /// <summary>
    /// Summary description for AxTestService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AxTestService : System.Web.Services.WebService
    {

        static Random _random = new Random();

        [WebMethod(Description = "Returns the price of the given item for the given customer")]
        public string GetItemPrice(int itemId, int customerId)
        {
            PriceObject returnPrice = new PriceObject
            {
                CustomerId = customerId,
                ItemId = itemId,
                ItemPrice = GimmeAPrice(20, 500)
            };

            return JsonConvert.SerializeObject(returnPrice);
        }

        public double GimmeAPrice(double minimum, double maximum)
        {
            return _random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}
