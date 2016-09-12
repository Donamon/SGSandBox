using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.ServiceModel;
using System.Web;
using System.Web.Mvc;
using SGSandBox.AxItemService;

namespace SGSandBox.Controllers
{
    public class AxWebserviceController : Controller
    {
        // GET: AxWebservice
        public ActionResult Index()
        {
            var tapp = getData();

            return View();
        }

        private BindingList<AxdEntity_InventTable> getData()
        {
            using (ItemServiceClient client = new ItemServiceClient())
            {

                client.ClientCredentials.UserName.UserName = @"ezone\netcommerce_sg";
                client.ClientCredentials.UserName.Password = @"Plu10plikasjon";
                //client..
                //CallContext context = new CallContext();


                //var binding = new BasicHttpBinding();
                //binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Windows;
                //binding.Security.Transport.ProxyCredentialType = HttpProxyCredentialType.None;
                //binding.Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;
                //var address = new EndpointAddress(new Uri("http://dynamicsserver/salesorderservice.svc"));
                //var client = new SalesOrderServiceClient(binding, address);
                //client.ClientCredentials.Windows.ClientCredential = new NetworkCredential("admin", "pass", "domain);
                
                //AxItemService client = new

                                AxdItem item = new AxdItem();
                AxdEntity_InventTable inventTable;
                QueryCriteria query = new QueryCriteria();

                System.Collections.IEnumerator enumeratorInventTable;

                BindingList<AxdEntity_InventTable> collection = new BindingList<AxdEntity_InventTable>();

                //client.ClientCredentials.Windows.ClientCredential = new System.Net.NetworkCredential(@"ezone\netcommerce_sg", @"Plu10plikasjon"); //,@"urn:netC"

                //using SysSvcmod = System.ServiceModel.Description;

                //SysSvcmod.ClientCredentials clientCredentials = new SysSvcmod.ClientCredentials();
                //clientCredentials.UserName.UserName = "user_name";
                //clientCredentials.UserName.Password = "pass_word";

                //m_client.ChannelFactory.Endpoint.Behaviors.RemoveAt(1);
                //m_client.ChannelFactory.Endpoint.Behaviors.Add(clientCredentials);

                //client.Open();
                if (client == null)
                {
                    throw new Exception("Cannot instantiate service");
                }

                query = PrepareGrid_QueryCriteria();
                item = client.find(query);

                enumeratorInventTable = item.InventTable.GetEnumerator();
                while (enumeratorInventTable.MoveNext())
                {
                    inventTable = (AxdEntity_InventTable)enumeratorInventTable.Current;
                    collection.Add(inventTable);
                }

                client.Close();
                return collection;
            }

        }

        protected QueryCriteria PrepareGrid_QueryCriteria()
        {
            QueryCriteria queryCriteria;
            CriteriaElement[] criteriaElements;

            criteriaElements = new CriteriaElement[1];
            criteriaElements[0] = new CriteriaElement();

            criteriaElements[0].DataSourceName = "InventTable";
            criteriaElements[0].FieldName = "ModifiedDateTime";
            criteriaElements[0].Operator = Operator.Greater;
            criteriaElements[0].Value1 = new DateTime(2016, 9, 5).ToLongDateString();

            //CriteriaElement.DataSourceName = "InventTable";
            //CriteriaElement.FieldName = "ModifiedDateTime";
            //CriteriaElement.Operator = Operator.Greater;
            //CriteriaElement.Value1 = new DateTime(2016, 9, 5).ToLongDateString();

            //CriteriaElement.DataSourceName = "InventTable";
            //CriteriaElement.FieldName = "EO_netCommerce";
            //CriteriaElement.Operator = Operator.Equal;
            //CriteriaElement.Value1 = "No";

            //CriteriaElement.DataSourceName = "InventTable";
            //CriteriaElement.FieldName = "AltItemId";
            //CriteriaElement.Operator = Operator.NotEqual;
            //CriteriaElement.Value1 = ""

            //CriteriaElement.DataSourceName = "InventTable";
            //CriteriaElement.FieldName = "UseAltItemId";
            //CriteriaElement.Operator = Operator.Equal;
            //CriteriaElement.Value1 = "";


            //criteriaElements[0].DataSourceName = "InventTable";
            //criteriaElements[0].FieldName = "ItemId";
            //criteriaElements[0].Operator = Operator.Range;
            //criteriaElements[0].Value1 = "ITEM-000000";
            //criteriaElements[0].Value2 = "ITEM-000010";

            queryCriteria = new QueryCriteria();
            queryCriteria.CriteriaElement = criteriaElements;
            return queryCriteria;
        }
    }
}