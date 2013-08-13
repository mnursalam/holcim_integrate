    using System;
    using System.Collections.Generic;
    
    public partial class Activitylog
    {
        public int id { get; set; }
        public string tbl_name { get; set; }
        public Nullable<int> status { get; set; }
        public string description { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
    }