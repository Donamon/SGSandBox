using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using SGSandbox.Models;
using SGSandbox.Models.Customer;

namespace SGSandbox.Controllers
{
    public class HomeController : Controller
    {
        private AssortmentCollection _assortmentCollection;
        private CustomerCollection _customerCollection;
        private MainChainCollection _mainchainCollection;

        public ActionResult Index()
        {
            LoadAssortmentJson();

            LoadCustomerJson();

            LoadMainChainJson();

            DoSomeWebServiceShit();

            ViewBag.Assortments = _assortmentCollection;
            ViewBag.Customers = _customerCollection;
            ViewBag.mainchains = _mainchainCollection;

            DateTime test = new DateTime();

            return View();
        }

        private void DoSomeWebServiceShit()
        {
            //ProteinTrackerServiceSoapClient service = new ProteinTrackerServiceSoapClient();

            //service.
        }

        public void LoadAssortmentJson()
        {
            using (StreamReader r = new StreamReader(@"C:\Testfiler\assortments1.json"))
            {
                string json = r.ReadToEnd();
                _assortmentCollection = JsonConvert.DeserializeObject<AssortmentCollection>(json);
            }
        }

        public void LoadCustomerJson()
        {
            using (StreamReader r = new StreamReader(@"C:\Testfiler\customers1.json"))
            {
                string json = r.ReadToEnd();
                _customerCollection = JsonConvert.DeserializeObject<CustomerCollection>(json);
            }
        }

        public void LoadMainChainJson()
        {
            using (StreamReader r = new StreamReader(@"C:\Testfiler\mainchains1.json"))
            {
                string json = r.ReadToEnd();
                _mainchainCollection = JsonConvert.DeserializeObject<MainChainCollection>(json);
            }
        }
    }
}