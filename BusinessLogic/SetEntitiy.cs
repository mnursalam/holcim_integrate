using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class SetEntitiy
    {
        public Distributor m_dst = null;
        public Retailer m_ret = null;
        public warehouse m_wrh = null;
        public void AccountEntitas(string _account_name,
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

            m_dst = new Distributor();
            m_dst.account_name = _account_name;
            m_dst.account_owner = _account_owner;
            m_dst.sap_account_number = _sap_account_number;
            m_dst.sap_account_status = _sap_account_status;
            m_dst.account_type = _account_type;
            m_dst.account_subtype = _account_subtype;
            m_dst.sap_term_of_payment = _sap_term_of_payment;
            m_dst.sap_credit_limit = _sap_credit_limit;
            m_dst.sap_remaining_credit = _sap_remaining_credit;
            m_dst.address_1 = _address_1;
            m_dst.address_2 = _address_2;
            m_dst.address_3 = _address_3;
            m_dst.country = _country;
            m_dst.region = _region;
            m_dst.city = _city;
            m_dst.postal_code = _postal_code;
            m_dst.longitude = _longitude;
            m_dst.latitude = _latitude;
            m_dst.email = _email;
            m_dst.extension_1 = _extension_1;
            m_dst.fax = _fax;
            m_dst.mobile_1 = _mobile_1;
            m_dst.phone = _phone;
            m_dst.sap_created_by = _sap_created_by;
            m_dst.sap_created_date = _sap_created_Date;
            m_dst.sap_last_modified_by = _sap_last_modified_by;
            m_dst.sap_last_modified_date = _sap_last_modified_date;

            m_ret = new Retailer();
            m_ret.account_name = _account_name;
            m_ret.account_owner = _account_owner;
            m_ret.stars_prospect_id = _stars_prospect_id;
            m_ret.sap_account_number = _sap_account_number;
            m_ret.sap_account_status = _sap_account_status;
            m_ret.account_type = _account_type;
            m_ret.account_subtype = _account_subtype;
            m_ret.primary_sold_to = _primary_sold_to;
            m_ret.address_1 = _address_1;
            m_ret.address_2 = _address_2;
            m_ret.address_3 = _address_3;
            m_ret.country = _country;
            m_ret.region = _region;
            m_ret.city = _city;
            m_ret.postal_code = _postal_code;
            m_ret.longitude = _longitude;
            m_ret.latitude = _latitude;
            m_ret.email = _email;
            m_ret.extension_1 = _extension_1;
            m_ret.fax = _fax;
            m_ret.mobile_1 = _mobile_1;
            m_ret.phone = _phone;
            m_ret.sap_created_by = _sap_created_by;
            m_ret.sap_created_date = _sap_created_Date;
            m_ret.sap_last_modified_by = _sap_last_modified_by;
            m_ret.sap_last_modified_date = _sap_last_modified_date;

            m_wrh = new warehouse();
            m_wrh.account_name = _account_name;
            m_wrh.account_owner = _account_owner;
            m_wrh.sap_account_number = _sap_account_number;
            m_wrh.sap_account_status = _sap_account_status;
            m_wrh.account_type = _account_type;
            m_wrh.account_subtype = _account_subtype;
            m_wrh.primary_sold_to = _primary_sold_to;
            m_wrh.address_1 = _address_1;
            m_wrh.address_2 = _address_2;
            m_wrh.address_3 = _address_3;
            m_wrh.country = _country;
            m_wrh.region = _region;
            m_wrh.city = _city;
            m_wrh.postal_code = _postal_code;
            m_wrh.longitude = _longitude;
            m_wrh.latitude = _latitude;
            m_wrh.sap_created_by = _sap_created_by;
            m_wrh.sap_created_date = _sap_created_Date;
            m_wrh.sap_last_modified_by = _sap_last_modified_by;
            m_wrh.sap_last_modified_date = _sap_last_modified_date;
        }
    }    

}
