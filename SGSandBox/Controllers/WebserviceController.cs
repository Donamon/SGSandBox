using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using SGSandBox.AxTestService;

namespace SGSandbox.Controllers
{
    public class WebserviceController : Controller
    {
        public List<PriceObject> priceObjectsList = new List<PriceObject>();
        public List<RequestObject> requestObjectList = new List<RequestObject>();
        public ActionResult Index()
        {
            //BuildTheDb();

            //PopulateTheCustomerPriceTable();
            GetRequestObjects();

            BuildPriceObjects();

            return View(priceObjectsList);
        }

        private void BuildPriceObjects()
        {
            AxTestServiceSoapClient client = new AxTestServiceSoapClient();

            foreach (var ro in requestObjectList)
            {
                var json = client.GetItemPrice(Convert.ToInt32(ro.ItemId), Convert.ToInt32(ro.CustomerId));
                priceObjectsList.Add(JsonConvert.DeserializeObject<PriceObject>(json));
            }
        }

        private void GetRequestObjects()
        {
            using (var sqlite = new SQLiteConnection(@"Data Source=C:\Testfiler\WebServiceDB.db"))
            {
                sqlite.Open();
                string sql = "Select * from CustomerPrice";

                using (SQLiteCommand command = new SQLiteCommand(sql, sqlite))
                {
                    command.ExecuteNonQuery();

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            requestObjectList.Add(new RequestObject
                            {
                                CustomerId = reader["CustomerNo"].ToString(),
                                ItemId = reader["ItemId"].ToString()
                            });
                        }
                    }
                }
            }
        }

        private void PopulateTheCustomerPriceTable()
        {
            using (var sqlite = new SQLiteConnection(@"Data Source=C:\Testfiler\WebServiceDb.sqlite"))
            {
                sqlite.Open();
                string sql = "create table CustomerPrice (CustomerNo varchar(40), ItemId varchar(40), PriceValue double, PriceString varchar(100), Updated boolean)";
                SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                command.ExecuteNonQuery();
            }
        }

        private void BuildTheDb()
        {
            //SQLiteConnection.CreateFile("CustomerPrice.sqlite");
            if (!System.IO.File.Exists(@"C:\Testfiler\WebServiceDb.sqlite")) //@"C:\Testfiler\assortments1.json"
            {
                SQLiteConnection.CreateFile(@"C:\Testfiler\WebServiceDb.sqlite");

                using (var sqlite = new SQLiteConnection(@"Data Source=C:\Testfiler\WebServiceDb.sqlite"))
                {
                    sqlite.Open();
                    string sql = "create table CustomerPrice (CustomerNo varchar(40), ItemId varchar(40), PriceValue double, PriceString varchar(100), Updated boolean)";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}