    using System;
    using System.Collections.Generic;
    
    public partial class Prospect
    {
        public string prospectId { get; set; }
        public string account_name { get; set; }
        public string account_owner { get; set; }
        public string stars_prospect_id { get; set; }
        public string sap_account_number { get; set; }
        public string sap_account_status { get; set; }
        public string account_type { get; set; }
        public string account_subtype { get; set; }
        public string primary_sold_to { get; set; }
        public string address_1 { get; set; }
        public string address_2 { get; set; }
        public string address_3 { get; set; }
        public string country { get; set; }
        public string region { get; set; }
        public string city { get; set; }
        public string postal_code { get; set; }
        public string latitude { get; set; }
        public string email { get; set; }
        public string extension_1 { get; set; }
        public string fax { get; set; }
        public string mobile_1 { get; set; }
        public string phone { get; set; }
        public Nullable<long> sap_created_by { get; set; }
        public Nullable<System.DateTime> sap_created_date { get; set; }
        public Nullable<long> sap_last_modified_by { get; set; }
        public Nullable<System.DateTime> sap_last_modified_date { get; set; }
    }