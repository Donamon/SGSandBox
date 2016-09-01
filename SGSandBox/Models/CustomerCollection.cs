﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SGSandbox.Models
{

    public class Customer
    {

        [JsonProperty("AccountNum")]
        public string AccountNum { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Address")]
        public string Address { get; set; }

        [JsonProperty("Phone")]
        public string Phone { get; set; }

        [JsonProperty("Assortment")]
        public string[] Assortment { get; set; }

        [JsonProperty("LicenseCode")]
        public string[] LicenseCode { get; set; }

        [JsonProperty("Telefax")]
        public string Telefax { get; set; }

        [JsonProperty("InvoiceAccount")]
        public string InvoiceAccount { get; set; }

        [JsonProperty("CustGroup")]
        public string CustGroup { get; set; }

        [JsonProperty("LineDisc")]
        public string LineDisc { get; set; }

        [JsonProperty("PaymTermId")]
        public string PaymTermId { get; set; }

        [JsonProperty("Currency")]
        public string Currency { get; set; }

        [JsonProperty("SalesGroup")]
        public string SalesGroup { get; set; }

        [JsonProperty("Blocked")]
        public string Blocked { get; set; }

        [JsonProperty("OneTimeCustomer")]
        public string OneTimeCustomer { get; set; }

        [JsonProperty("CreditMax")]
        public string CreditMax { get; set; }

        [JsonProperty("MandatoryCreditLimit")]
        public string MandatoryCreditLimit { get; set; }

        [JsonProperty("VendAccount")]
        public string VendAccount { get; set; }

        [JsonProperty("Telex")]
        public string Telex { get; set; }

        [JsonProperty("PriceGroup")]
        public string PriceGroup { get; set; }

        [JsonProperty("MultiLineDisc")]
        public string MultiLineDisc { get; set; }

        [JsonProperty("EndDisc")]
        public string EndDisc { get; set; }

        [JsonProperty("VatNum")]
        public string VatNum { get; set; }

        [JsonProperty("CountryRegionId")]
        public string CountryRegionId { get; set; }

        [JsonProperty("DlvTerm")]
        public string DlvTerm { get; set; }

        [JsonProperty("DlvMode")]
        public string DlvMode { get; set; }

        [JsonProperty("MarkupGroup")]
        public string MarkupGroup { get; set; }

        [JsonProperty("ZipCode")]
        public string ZipCode { get; set; }

        [JsonProperty("Url")]
        public string Url { get; set; }

        [JsonProperty("Email")]
        public string Email { get; set; }

        [JsonProperty("CellularPhone")]
        public string CellularPhone { get; set; }

        [JsonProperty("PhoneLocal")]
        public string PhoneLocal { get; set; }

        [JsonProperty("TaxGroup")]
        public string TaxGroup { get; set; }

        [JsonProperty("PaymMode")]
        public string PaymMode { get; set; }

        [JsonProperty("BankAccount")]
        public string BankAccount { get; set; }

        [JsonProperty("ContactPersonId")]
        public string ContactPersonId { get; set; }

        [JsonProperty("InvoiceAddress")]
        public string InvoiceAddress { get; set; }

        [JsonProperty("OurAccountNum")]
        public string OurAccountNum { get; set; }

        [JsonProperty("SalesPoolId")]
        public string SalesPoolId { get; set; }

        [JsonProperty("InclTax")]
        public string InclTax { get; set; }

        [JsonProperty("LanguageId")]
        public string LanguageId { get; set; }

        [JsonProperty("City")]
        public string City { get; set; }

        [JsonProperty("Street")]
        public string Street { get; set; }

        [JsonProperty("Sms")]
        public string Sms { get; set; }

        [JsonProperty("SalesCalendarId")]
        public string SalesCalendarId { get; set; }

        [JsonProperty("CustClassificationId")]
        public string CustClassificationId { get; set; }

        [JsonProperty("InventSiteId")]
        public string InventSiteId { get; set; }

        [JsonProperty("PartyId")]
        public string PartyId { get; set; }

        [JsonProperty("Memo")]
        public string Memo { get; set; }

        [JsonProperty("SalesDistrictId")]
        public string SalesDistrictId { get; set; }

        [JsonProperty("SegmentId")]
        public string SegmentId { get; set; }

        [JsonProperty("SubSegmentId")]
        public string SubSegmentId { get; set; }

        [JsonProperty("CompanyChainId")]
        public string CompanyChainId { get; set; }

        [JsonProperty("MainContactId")]
        public string MainContactId { get; set; }

        [JsonProperty("PaymIdType")]
        public string PaymIdType { get; set; }

        [JsonProperty("Eo_BreakAddition")]
        public string EoBreakAddition { get; set; }

        [JsonProperty("Eo_PriorityCode")]
        public string EoPriorityCode { get; set; }

        [JsonProperty("Eo_PriorityDlvTime")]
        public string EoPriorityDlvTime { get; set; }

        [JsonProperty("Eo_EanLocationCust")]
        public string EoEanLocationCust { get; set; }

        [JsonProperty("Eo_CustNoInChain")]
        public string EoCustNoInChain { get; set; }

        [JsonProperty("Eo_InvoiceType")]
        public string EoInvoiceType { get; set; }

        [JsonProperty("Eo_CustPurchaseOrder")]
        public string EoCustPurchaseOrder { get; set; }

        [JsonProperty("Eo_CustRef")]
        public string EoCustRef { get; set; }

        [JsonProperty("Eo_NoBreakage")]
        public string EoNoBreakage { get; set; }

        [JsonProperty("Eo_EanLocationUnb")]
        public string EoEanLocationUnb { get; set; }

        [JsonProperty("Eo_EanLocationDp")]
        public string EoEanLocationDp { get; set; }

        [JsonProperty("Eo_EdiCode")]
        public string EoEdiCode { get; set; }

        [JsonProperty("Eo_MainChainId")]
        public string EoMainChainId { get; set; }

        [JsonProperty("Eo_NetCommerce")]
        public string EoNetCommerce { get; set; }

        [JsonProperty("Eo_WebPct")]
        public string EoWebPct { get; set; }

        [JsonProperty("Eo_ChainCustomer")]
        public string EoChainCustomer { get; set; }

        [JsonProperty("Eo_AssortmentOnlyCust")]
        public string EoAssortmentOnlyCust { get; set; }

        [JsonProperty("Eo_InvoiceSumGrouping")]
        public string EoInvoiceSumGrouping { get; set; }

        [JsonProperty("Eo_ModifiedDateSssortment")]
        public string EoModifiedDateSssortment { get; set; }

        [JsonProperty("Eo_CustomsTransitApproved")]
        public string EoCustomsTransitApproved { get; set; }

        [JsonProperty("Eo_CrmExternalId")]
        public string EoCrmExternalId { get; set; }

        [JsonProperty("Eo_ChainGroupId")]
        public string EoChainGroupId { get; set; }

        [JsonProperty("ModifiedDateTime")]
        public string ModifiedDateTime { get; set; }

        [JsonProperty("CreatedDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("DataAreaId")]
        public string DataAreaId { get; set; }
    }

    public class CustomerCollection
    {

        [JsonProperty("Customers")]
        public Customer[] Customers { get; set; }
    }

}