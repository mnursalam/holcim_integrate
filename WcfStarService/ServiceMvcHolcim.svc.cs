using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using log4net;
using BusinessLogic;

namespace WcfStarService
{
    public class Service1 : IServiceMvcHolcim
    {
        public string[] ws_stars_account(string _account_name,
             string _account_owner,
             string _stars_prospect_id,
             string _sap_account_number,
             string _sap_account_status,
             string _account_type,
             string _account_subtype,
             string _primary_sold_to,
             string _sap_term_of_payment,
             string _sap_credit_limit,
             string _sap_remaining_credit,
             string _address_1,
             string _address_2,
             string _address_3,
             string _country,
             string _region,
             string _city,
             string _postal_code,
             string _longitude,
             string _latitude,
             string _email,
             string _extension_1,
             string _fax,
             string _mobile_1,
             string _phone,
             long _sap_created_by,
             DateTime _sap_created_Date,
             long _sap_last_modified_by,
             DateTime _sap_last_modified_date)
        {
            string[] arrStr = { "", "" };
            ClsLogic lgc = new ClsLogic();
            arrStr = lgc.AddAccount(_account_name,
             _account_owner,
             _stars_prospect_id,
             _sap_account_number,
             _sap_account_status,
             _account_type,
             _account_subtype,
             _primary_sold_to,
             _sap_term_of_payment,
             _sap_credit_limit,
             _sap_remaining_credit,
             _address_1,
             _address_2,
             _address_3,
             _country,
             _region,
             _city,
             _postal_code,
             _longitude,
             _latitude,
             _email,
             _extension_1,
             _fax,
             _mobile_1,
             _phone,
             _sap_created_by,
             _sap_created_Date,
             _sap_last_modified_by,
             _sap_last_modified_date);
            return arrStr;
        }

         public string[] ws_stars_contact(string _contactId,
            string _sap_contact_number,
            string _firstname,
            string _lastname,
            string _name,
            string _title,
            DateTime _birthdate,
            string _sex,
            string _marital_status,
            string _account_number,
            string _account_name,
            string _phone,
            string _phone_2,
            string _mobile,
            string _fax,
            string _extension,
            string _email,
            long _sap_created_by,
            DateTime _sap_created_date,
            long _sap_last_modified_by,
            DateTime _sap_last_modified_date)
        {
            string[] arrStr = { "", "" };
            ClsLogic logic = new ClsLogic();
            Console.WriteLine("==========================================" + _sap_contact_number);
            arrStr = logic.AddContact(_contactId,
            _sap_contact_number,
            _firstname,
            _lastname,
            _name,
            _title,
            _birthdate,
            _sex,
            _marital_status,
            _account_number,
            _account_name,
            _phone,
            _phone_2,
            _mobile,
            _fax,
            _extension,
            _email,
            _sap_created_by,
            _sap_created_date,
            _sap_last_modified_by,
            _sap_last_modified_date);
            return arrStr;
        }

         public string[] ws_stars_salesarea(string _sales_organization,
            string _segmen_code,
            string _segmen_description,
            string _distribution_channel,
            string _division,
            string _sales_district,
            string _customer_group,
            string _sales_group,
            string _account_group,
            string _sales_office,
            string _region,
            string _deletion)        {
            
            string[] arrStr = { "", "" };
            ClsLogic logic = new ClsLogic();
            Console.WriteLine("1 ===================================================");
            arrStr = logic.AddSalesArea(_sales_organization,
            _segmen_code,
            _segmen_description,
            _distribution_channel,
            _division,
            _sales_district,
            _customer_group,
            _sales_group,
            _account_group,
            _sales_office,
            _region,
            _deletion);
            return arrStr;
        }        
    }
}
