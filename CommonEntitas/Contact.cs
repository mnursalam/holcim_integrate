    using System;
    using System.Collections.Generic;
    
    public partial class Contact
    {
        public string contactId { get; set; }
        public string sap_contact_number { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public Nullable<System.DateTime> birthdate { get; set; }
        public string sex { get; set; }
        public string marital_status { get; set; }
        public string account_number { get; set; }
        public string account_name { get; set; }
        public string phone { get; set; }
        public string phone_2 { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string Extension { get; set; }
        public string Email { get; set; }
        public Nullable<long> sap_created_by { get; set; }
        public Nullable<System.DateTime> sap_created_date { get; set; }
        public Nullable<long> sap_last_modify_by { get; set; }
        public Nullable<System.DateTime> sap_last_modify_date { get; set; }
    }