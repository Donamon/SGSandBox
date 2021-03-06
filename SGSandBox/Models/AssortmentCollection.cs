﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SGSandbox.Models
{

    public class Assortment
    {

        [JsonProperty("Assortment")]
        public string AssortmentId { get; set; }

        [JsonProperty("ItemId")]
        public string ItemId { get; set; }

        [JsonProperty("InventQty")]
        public string InventQty { get; set; }

        [JsonProperty("CustAccount")]
        public string CustAccount { get; set; }

        [JsonProperty("Location")]
        public string Location { get; set; }

        [JsonProperty("PlannedPurchase")]
        public string PlannedPurchase { get; set; }

        [JsonProperty("BonusMark")]
        public string BonusMark { get; set; }

        [JsonProperty("AgreementMark")]
        public string AgreementMark { get; set; }

        [JsonProperty("CampaignMarkFromDate")]
        public string CampaignMarkFromDate { get; set; }

        [JsonProperty("SpecialMarkToDate")]
        public string SpecialMarkToDate { get; set; }

        [JsonProperty("SpecialMarkFromDate")]
        public string SpecialMarkFromDate { get; set; }

        [JsonProperty("CampaignMarkToDate")]
        public string CampaignMarkToDate { get; set; }

        [JsonProperty("BestBuy")]
        public string BestBuy { get; set; }

        [JsonProperty("DataAreaid")]
        public string DataAreaid { get; set; }

        [JsonProperty("RecVersion")]
        public string RecVersion { get; set; }

        [JsonProperty("RecId")]
        public string RecId { get; set; }
    }

    public class AssortmentCollection
    {

        [JsonProperty("Assortments")]
        public Assortment[] Assortments { get; set; }
    }

}
