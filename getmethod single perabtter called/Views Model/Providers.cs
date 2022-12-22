﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace getmethod_single_perabtter_called.Views_Model
{
    public class Providers
    {
        public int ProviderID { get; set; }
        public string NPI { get; set; }
        public string TaxID { get; set; }
        public string NameLast { get; set; }
        public string NameFirst { get; set; }
        public string NameMiddle { get; set; }
        public string NamePrefix { get; set; }
        public string NameSuffix { get; set; }
        public string Credential { get; set; }
        public string Title { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public Nullable<int> GenderID { get; set; }
        public string MedicareID { get; set; }
        public string UPIN { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string County { get; set; }
        public string ZIP { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string AlternatePhone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string BillingAddressLine1 { get; set; }
        public string BillingAddressLine2 { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
        public string BillingCounty { get; set; }
        public string BillingZIP { get; set; }
        public string BillingCountry { get; set; }
        public bool IsActive { get; set; }
        public bool SubscriptionFlag { get; set; }
        public bool Deleted { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsSameAsMailingAddress { get; set; }
        public Nullable<int> LanguageID { get; set; }
        public Nullable<int> PreferredLanguageID { get; set; }
        public string MothersMaidenName { get; set; }
        public string MedicaidID { get; set; }
        public string WebsiteName { get; set; }
        //Foreign Address Implementation Properties
        public bool IsForeign { get; set; }
        public bool IsBillingForeign { get; set; }
        public int FeeScheduleToUse { get; set; }
    }
}