    using System;
    using System.Collections.Generic;
    
    public partial class Distributor
    {
        public string DistributorID { get; set; }
        public string account_name { get; set; }
        public string account_owner { get; set; }
        public string sap_account_number { get; set; }
        public string sap_account_status { get; set; }
        public string account_type { get; set; }
        public string account_subtype { get; set; }
        public string primary_sold_to { get; set; }
        public string sap_term_of_payment { get; set; }
        public string sap_credit_limit { get; set; }
        public string sap_remaining_credit { get; set; }
        public string address_1 { get; set; }
        public string address_2 { get; set; }
        public string address_3 { get; set; }
        public string country { get; set; }
        public string region { get; set; }
        public string city { get; set; }
        public string postal_code { get; set; }
        public string latitude { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string extension_1 { get; set; }
        public string fax { get; set; }
        public string mobile_1 { get; set; }
        public string sap_created_by { get; set; }
        public Nullable<System.DateTime> sap_created_date { get; set; }
        public string sap_last_modified_by { get; set; }
        public Nullable<System.DateTime> sap_last_modified_date { get; set; }
        public string account_site { get; set; }
        public string account_source { get; set; }
        public string annual_revenue { get; set; }
        public string billing_address { get; set; }
        public string created_by { get; set; }
        public string data_com_key { get; set; }
        public string description { get; set; }
        public string employees { get; set; }
        public string industry { get; set; }
        public string last_modified_by { get; set; }
        public string ownership { get; set; }
        public string rating { get; set; }
        public string shipping_address { get; set; }
        public string sic_code { get; set; }
        public string sic_description { get; set; }
        public string ticker_symbol { get; set; }
        public string website { get; set; }
        public string active { get; set; }
        public string customer_priority { get; set; }
        public string number_of_location { get; set; }
        public string sla { get; set; }
        public Nullable<System.DateTime> sla_expiration_date { get; set; }
        public string sla_serial_number { get; set; }
        public string transportation { get; set; }
        public string upsell_opportunity { get; set; }
    }