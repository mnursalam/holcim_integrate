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
        public string[] ws_stars_create_distributor(
             string _account_name,
             string _account_owner,
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
             string _latitude,
             string _email,
             string _phone,
             string _extension_1,
             string _fax,
             string _mobile_1,
             string _sap_created_by,
             DateTime _sap_created_Date,
             string _sap_last_modified_by,
             DateTime _sap_last_modified_date,
             string _account_site,
             string _account_source,
             string _annual_revenue,
             string _billing_address,
             string _created_by,
             string _data_com_key,
             string _description,
             string _employees,
             string _industry,
             string _last_modified_by,
             string _ownership,
             string _rating,
             string _shipping_address,
             string _sic_code,
             string _sic_description,
             string _ticker_symbol,
             string _website,
             string _active,
             string _customer_priority,
             string _number_of_location,
             string _sla,
             DateTime _sla_expiration_date,
             string _sla_serial_number,
             string _tranportation,
             string _upsell_opportunity)
        {
            Distributor dst = new Distributor();
            dst.account_name = _account_name;
            dst.account_owner = _account_owner;
            dst.sap_account_number = _sap_account_number;
            dst.sap_account_status = _sap_account_status;
            dst.account_type =_account_type;
            dst.account_subtype =_account_subtype;
            dst.primary_sold_to = _primary_sold_to;
            dst.sap_term_of_payment = _sap_term_of_payment;
            dst.sap_credit_limit = _sap_credit_limit;
            dst.address_1 = _address_1;
            dst.address_2 = _address_2;
            dst.address_3 = _address_3;
            dst.country = _country;
            dst.region = _region;
            dst.city = _city;
            dst.postal_code = _postal_code;
            dst.latitude = _latitude;
            dst.email = _email;
            dst.phone = _phone;
            dst.extension_1 = _extension_1;
            dst.fax = _fax;
            dst.mobile_1 = _mobile_1;
            dst.sap_created_by = _sap_created_by;
            dst.sap_created_date = _sap_created_Date;
            dst.sap_last_modified_by = _sap_last_modified_by;
            dst.sap_last_modified_date = _sap_last_modified_date;
            dst.account_site = _account_site;
            dst.account_source = _account_source;
            dst.annual_revenue = _annual_revenue;
            dst.billing_address = _billing_address;
            dst.created_by = _created_by;
            dst.data_com_key = _data_com_key;
            dst.description = _description;
            dst.employees = _employees;
            dst.industry = _industry;
            dst.last_modified_by = _last_modified_by;
            dst.ownership = _ownership;
            dst.rating = _rating;
            dst.shipping_address = _shipping_address;
            dst.sic_code = _sic_code;
            dst.sic_description = _sic_description;
            dst.ticker_symbol = _ticker_symbol;
            dst.website = _website;
            dst.active = _active;
            dst.customer_priority = _customer_priority;
            dst.number_of_location = _number_of_location;
            dst.sla = _sla;
            dst.sla_expiration_date = _sla_expiration_date;
            dst.sla_serial_number = _sla_serial_number;
            dst.transportation = _tranportation;
            dst.upsell_opportunity = _upsell_opportunity;
            string[] arrStr = { "", "" };
            ClsLogic logic = new ClsLogic();
            arrStr = logic.AddDistributors(dst);
            return arrStr;
        }

        public string[] ws_stars_update_distributor(string _distributorId,
             string _account_name,
             string _account_owner,
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
             string _latitude,
             string _email,
             string _phone,
             string _extension_1,
             string _fax,
             string _mobile_1,
             string _sap_created_by,
             DateTime _sap_created_Date,
             string _sap_last_modified_by,
             DateTime _sap_last_modified_date,
             string _account_site,
             string _account_source,
             string _annual_revenue,
             string _billing_address,
             string _created_by,
             string _data_com_key,
             string _description,
             string _employees,
             string _industry,
             string _last_modified_by,
             string _ownership,
             string _rating,
             string _shipping_address,
             string _sic_code,
             string _sic_description,
             string _ticker_symbol,
             string _website,
             string _active,
             string _customer_priority,
             string _number_of_location,
             string _sla,
             DateTime _sla_expiration_date,
             string _sla_serial_number,
             string _tranportation,
             string _upsell_opportunity)
        {
            Distributor dst = new Distributor();
            dst.DistributorID = _distributorId;
            dst.account_name = _account_name;
            dst.account_owner = _account_owner;
            dst.sap_account_number = _sap_account_number;
            dst.sap_account_status = _sap_account_status;
            dst.account_type = _account_type;
            dst.account_subtype = _account_subtype;
            dst.primary_sold_to = _primary_sold_to;
            dst.sap_term_of_payment = _sap_term_of_payment;
            dst.sap_credit_limit = _sap_credit_limit;
            dst.address_1 = _address_1;
            dst.address_2 = _address_2;
            dst.address_3 = _address_3;
            dst.country = _country;
            dst.region = _region;
            dst.city = _city;
            dst.postal_code = _postal_code;
            dst.latitude = _latitude;
            dst.email = _email;
            dst.phone = _phone;
            dst.extension_1 = _extension_1;
            dst.fax = _fax;
            dst.mobile_1 = _mobile_1;
            dst.sap_created_by = _sap_created_by;
            dst.sap_created_date = _sap_created_Date;
            dst.sap_last_modified_by = _sap_last_modified_by;
            dst.sap_last_modified_date = _sap_last_modified_date;
            dst.account_site = _account_site;
            dst.account_source = _account_source;
            dst.annual_revenue = _annual_revenue;
            dst.billing_address = _billing_address;
            dst.created_by = _created_by;
            dst.data_com_key = _data_com_key;
            dst.description = _description;
            dst.employees = _employees;
            dst.industry = _industry;
            dst.last_modified_by = _last_modified_by;
            dst.ownership = _ownership;
            dst.rating = _rating;
            dst.shipping_address = _shipping_address;
            dst.sic_code = _sic_code;
            dst.sic_description = _sic_description;
            dst.ticker_symbol = _ticker_symbol;
            dst.website = _website;
            dst.active = _active;
            dst.customer_priority = _customer_priority;
            dst.number_of_location = _number_of_location;
            dst.sla = _sla;
            dst.sla_expiration_date = _sla_expiration_date;
            dst.sla_serial_number = _sla_serial_number;
            dst.transportation = _tranportation;
            dst.upsell_opportunity = _upsell_opportunity;
            string[] arrStr = { "", "" };
            ClsLogic logic = new ClsLogic();
            arrStr = logic.UpdateDistributors(dst);
            return arrStr;
        }

        public string[] ws_stars_create_retailer(string _account_name,
            string _account_owner,
            string _stars_prospect_id,
            string _sap_account_number,
            string _sap_account_status,
            string _account_type,
            string _account_subtype,
            string _primary_sold_to,
            string _address_1,
            string _address_2,
            string _address_3,
            string _country,
            string _region,
            string _city,
            string _postal_code,
            string _latitude,
            string _email,
            string _extension_1,
            string _fax,
            string _mobile_1,
            string _phone,
            long _sap_created_by,
            DateTime _sap_created_date,
            string _sap_last_modified_by,
            DateTime _sap_last_modified_date )
        {
            Retailer rtl = new Retailer();
            rtl.account_name= _account_name;
            rtl.account_owner = _account_owner;
            rtl.stars_prospect_id = _stars_prospect_id;
            rtl.sap_account_number = _sap_account_number;
            rtl.sap_account_status = _sap_account_status;
            rtl.account_type = _account_type;
            rtl.account_type = _account_type;
            rtl.primary_sold_to = _primary_sold_to;
            rtl.address_1 = _address_1;
            rtl.address_2 = _address_2;
            rtl.address_3 = _address_3;
            rtl.country = _country;
            rtl.region = _region;
            rtl.city = _city;
            rtl.postal_code = _postal_code;
            rtl.latitude = _latitude;
            rtl.email = _email;
            rtl.extension_1 = _extension_1;
            rtl.fax = _fax;
            rtl.mobile_1 = _mobile_1;
            rtl.phone = _phone;
            rtl.sap_created_by = _sap_created_by;
            rtl.sap_created_date = _sap_created_date;
            rtl.sap_last_modified_date = _sap_last_modified_date;            
            string[] arrStr = { "", "" };
            ClsLogic logic = new ClsLogic();
            arrStr = logic.AddRetailers(rtl);
            return arrStr;
        }

        public string[] ws_stars_update_retailer(string _retailerId,
            string _account_name,
            string _account_owner,
            string _stars_prospect_id,
            string _sap_account_number,
            string _sap_account_status,
            string _account_type,
            string _account_subtype,
            string _primary_sold_to,
            string _address_1,
            string _address_2,
            string _address_3,
            string _country,
            string _region,
            string _city,
            string _postal_code,
            string _latitude,
            string _email,
            string _extension_1,
            string _fax,
            string _mobile_1,
            string _phone,
            long _sap_created_by,
            DateTime _sap_created_date,
            string _sap_last_modified_by,
            DateTime _sap_last_modified_date)
        {
            Retailer rtl = new Retailer();
            rtl.retailerId = _retailerId;
            rtl.account_name = _account_name;
            rtl.account_owner = _account_owner;
            rtl.stars_prospect_id = _stars_prospect_id;
            rtl.sap_account_number = _sap_account_number;
            rtl.sap_account_status = _sap_account_status;
            rtl.account_type = _account_type;
            rtl.account_type = _account_type;
            rtl.primary_sold_to = _primary_sold_to;
            rtl.address_1 = _address_1;
            rtl.address_2 = _address_2;
            rtl.address_3 = _address_3;
            rtl.country = _country;
            rtl.region = _region;
            rtl.city = _city;
            rtl.postal_code = _postal_code;
            rtl.latitude = _latitude;
            rtl.email = _email;
            rtl.extension_1 = _extension_1;
            rtl.fax = _fax;
            rtl.mobile_1 = _mobile_1;
            rtl.phone = _phone;
            rtl.sap_created_by = _sap_created_by;
            rtl.sap_created_date = _sap_created_date;
            rtl.sap_last_modified_date = _sap_last_modified_date;
            string[] arrStr = { "", "" };
            ClsLogic logic = new ClsLogic();
            arrStr = logic.UpdateRetailers(rtl);
            return arrStr;
        }

        public string[] ws_stars_create_prospect(string _account_name,
            string _account_owner,
            string _stars_prospect_id,
            string _sap_account_number,
            string _sap_account_status,
            string _account_type,
            string _account_subtype,
            string _primary_sold_to,
            string _address_1,
            string _address_2,
            string _address_3,
            string _country,
            string _region,
            string _city,
            string _postal_code,
            string _latitude,
            string _email,
            string _extension_1,
            string _fax,
            string _mobile_1,
            string _phone,
            long _sap_created_by,
            DateTime _sap_created_date,
            string _sap_last_modified_by,
            DateTime _sap_last_modified_date)
        {
            Prospect rtl = new Prospect();            
            rtl.account_name = _account_name;
            rtl.account_owner = _account_owner;
            rtl.stars_prospect_id = _stars_prospect_id;
            rtl.sap_account_number = _sap_account_number;
            rtl.sap_account_status = _sap_account_status;
            rtl.account_type = _account_type;
            rtl.account_type = _account_type;
            rtl.primary_sold_to = _primary_sold_to;
            rtl.address_1 = _address_1;
            rtl.address_2 = _address_2;
            rtl.address_3 = _address_3;
            rtl.country = _country;
            rtl.region = _region;
            rtl.city = _city;
            rtl.postal_code = _postal_code;
            rtl.latitude = _latitude;
            rtl.email = _email;
            rtl.extension_1 = _extension_1;
            rtl.fax = _fax;
            rtl.mobile_1 = _mobile_1;
            rtl.phone = _phone;
            rtl.sap_created_by = _sap_created_by;
            rtl.sap_created_date = _sap_created_date;
            rtl.sap_last_modified_date = _sap_last_modified_date;
            string[] arrStr = { "", "" };
            ClsLogic logic = new ClsLogic();
            arrStr = logic.AddProspect(rtl);
            return arrStr;
        }

        public string[] ws_stars_update_prospect(string _prospectId,
            string _account_name,
            string _account_owner,
            string _stars_prospect_id,
            string _sap_account_number,
            string _sap_account_status,
            string _account_type,
            string _account_subtype,
            string _primary_sold_to,
            string _address_1,
            string _address_2,
            string _address_3,
            string _country,
            string _region,
            string _city,
            string _postal_code,
            string _latitude,
            string _email,
            string _extension_1,
            string _fax,
            string _mobile_1,
            string _phone,
            long _sap_created_by,
            DateTime _sap_created_date,
            string _sap_last_modified_by,
            DateTime _sap_last_modified_date)
        {
            Prospect rtl = new Prospect();
            rtl.prospectId = _prospectId;
            rtl.account_name = _account_name;
            rtl.account_owner = _account_owner;
            rtl.stars_prospect_id = _stars_prospect_id;
            rtl.sap_account_number = _sap_account_number;
            rtl.sap_account_status = _sap_account_status;
            rtl.account_type = _account_type;
            rtl.account_type = _account_type;
            rtl.primary_sold_to = _primary_sold_to;
            rtl.address_1 = _address_1;
            rtl.address_2 = _address_2;
            rtl.address_3 = _address_3;
            rtl.country = _country;
            rtl.region = _region;
            rtl.city = _city;
            rtl.postal_code = _postal_code;
            rtl.latitude = _latitude;
            rtl.email = _email;
            rtl.extension_1 = _extension_1;
            rtl.fax = _fax;
            rtl.mobile_1 = _mobile_1;
            rtl.phone = _phone;
            rtl.sap_created_by = _sap_created_by;
            rtl.sap_created_date = _sap_created_date;
            rtl.sap_last_modified_date = _sap_last_modified_date;
            string[] arrStr = { "", "" };
            ClsLogic logic = new ClsLogic();
            arrStr = logic.UpdateProspects(rtl);
            return arrStr;
        }

        public string[] ws_stars_create_contact(string _sap_contact_number,
            string _name,
            string _title,
            DateTime _birthdate,
            string _sex,
            string _marital_status,
            string _account_name,
            string _phone,
            string _phone_2,
            string _mobile,
            string _fax,
            string _extension,
            string _email,
            string _sap_created_by,
            DateTime _sap_created_date,
            string _sap_last_modified_by,
            DateTime _sap_last_modified_date)
        {
            Contact ctc = new Contact();
            ctc.sap_contact_number = _sap_contact_number;
            ctc.name = _name;
            ctc.title = _title;
            ctc.birthdate = _birthdate;
            ctc.sex = _sex;
            ctc.marital_status = _marital_status;
            ctc.account_name = _account_name;
            ctc.phone = _phone;
            ctc.phone_2 = _phone_2;
            ctc.Mobile = _mobile;
            ctc.Fax = _fax;
            ctc.Extension = _extension;
            ctc.Email = _email;
            ctc.sap_created_by = _sap_created_by;
            ctc.sap_created_date = _sap_created_date;
            ctc.sap_last_modify_by = _sap_last_modified_by;
            ctc.sap_last_modify_date = _sap_last_modified_date;
            string[] arrStr = { "", "" };
            ClsLogic logic = new ClsLogic();
            arrStr = logic.AddContacts(ctc);
            return arrStr;
        }

        public string[] ws_stars_update_contact(string _contactId,
            string _sap_contact_number,
            string _name,
            string _title,
            DateTime _birthdate,
            string _sex,
            string _marital_status,
            string _account_name,
            string _phone,
            string _phone_2,
            string _mobile,
            string _fax,
            string _extension,
            string _email,
            string _sap_created_by,
            DateTime _sap_created_date,
            string _sap_last_modified_by,
            DateTime _sap_last_modified_date)
        {
            Contact ctc = new Contact();
            ctc.contactId = _contactId;
            ctc.sap_contact_number = _sap_contact_number;
            ctc.name = _name;
            ctc.title = _title;
            ctc.birthdate = _birthdate;
            ctc.sex = _sex;
            ctc.marital_status = _marital_status;
            ctc.account_name = _account_name;
            ctc.phone = _phone;
            ctc.phone_2 = _phone_2;
            ctc.Mobile = _mobile;
            ctc.Fax = _fax;
            ctc.Extension = _extension;
            ctc.Email = _email;
            ctc.sap_created_by = _sap_created_by;
            ctc.sap_created_date = _sap_created_date;
            ctc.sap_last_modify_by = _sap_last_modified_by;
            ctc.sap_last_modify_date = _sap_last_modified_date;
            string[] arrStr = { "", "" };
            ClsLogic logic = new ClsLogic();
            arrStr = logic.UpdateContacts(ctc);
            return arrStr;
        }

        public string[] ws_stars_create_salesarea(string _sales_organization,
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
            string _deletion)
        {
            Salesarea sla = new Salesarea();
            sla.sales_organization = _sales_organization;
            sla.segment_code = _segmen_code;
            sla.segment_description = _segmen_description;
            sla.distribution_channel = _distribution_channel;
            sla.division = _division;
            sla.sales_district = _sales_district;
            sla.customer_group = _customer_group;
            sla.sales_group = _sales_group;
            sla.account_group = _account_group;
            sla.sales_office = _sales_office;
            sla.region = _region;
            sla.deletion = _deletion;
            string[] arrStr = {"",""};
            ClsLogic logic = new ClsLogic();
            arrStr = logic.AddSalesAreas(sla);
            return arrStr;
        }

        public string[] ws_create_contact_relation(string _sap_number_contact,
            string _decision_maker,
            string _relation_category,
            string _rev_contact_number,
            string _created_by,
            string _last_modify_by,
            string _source_system)
        {
            Contacttocontact ctct = new Contacttocontact();
            ctct.sap_contact_number = _sap_number_contact;
            ctct.dicision_maker = _decision_maker;
            ctct.relation_category = _relation_category;
            ctct.rev_contact_number = _rev_contact_number;
            ctct.created_by = _created_by;
            ctct.created_date = DateTime.Now;
            ctct.last_modified_by = _last_modify_by;
            ctct.last_modified_date = DateTime.Now;
            ctct.source_system = _source_system;
            string[] arrStr = { "", "" };
            ClsLogic logic = new ClsLogic();
            arrStr = logic.AddContactToContact(ctct);
            return arrStr;
        }


        public string[] ws_update_contact_relation(string _contactToContactId,
            string _sap_number_contact,
            string _decision_maker,
            string _relation_category,
            string _rev_contact_number,
            string _created_by,
            string _last_modify_by,
            string _source_system)
        {
            Contacttocontact ctct = new Contacttocontact();
            ctct.contactToContactId = "1";
            ctct.sap_contact_number = _sap_number_contact;
            ctct.dicision_maker = _decision_maker;
            ctct.relation_category = _relation_category;
            ctct.rev_contact_number = _rev_contact_number;
            ctct.created_by = _created_by;
            ctct.created_date = DateTime.Now;
            ctct.last_modified_by = _last_modify_by;
            ctct.last_modified_date = DateTime.Now;
            ctct.source_system = _source_system;
            string[] arrStr = { "", "" };
            ClsLogic logic = new ClsLogic();
            arrStr = logic.UpdateContactToContact(ctct);
            return arrStr;
        }

        public string[] ws_create_warehouse(string _holcim_warehouse_id,
            string _holcim_warehouse_name,
            string _primary_sold_to,
            string _address_1,
            string _address_2,
            string _address_3,
            string _country,
            string _region,
            string _city,
            string _postal_code)
        {
            Warehouse whs = new Warehouse();
            whs.holcim_wirehouse_id = _holcim_warehouse_id;
            whs.holcim_wirehouse_name = _holcim_warehouse_name;
            whs.primary_sold_to = _primary_sold_to;
            whs.address_1 = _address_1;
            whs.address_2 = _address_2;
            whs.address_3 = _address_3;
            whs.country = _country;
            whs.region = _region;
            whs.city = _city;
            whs.postal_code = _postal_code;
            string[] arrStr = { "", "" };
            ClsLogic logic = new ClsLogic();
            arrStr = logic.AddWarehouse(whs);
            return arrStr;
        }

        public string[] ws_update_warehouse(
            string _warehouseId,
            string _holcim_warehouse_id,
            string _holcim_warehouse_name,
            string _primary_sold_to,
            string _address_1,
            string _address_2,
            string _address_3,
            string _country,
            string _region,
            string _city,
            string _postal_code)
        {
            Warehouse whs = new Warehouse();
            whs.wirehouseId = _warehouseId;
            whs.holcim_wirehouse_id = _holcim_warehouse_id;
            whs.holcim_wirehouse_name = _holcim_warehouse_name;
            whs.primary_sold_to = _primary_sold_to;
            whs.address_1 = _address_1;
            whs.address_2 = _address_2;
            whs.address_3 = _address_3;
            whs.country = _country;
            whs.region = _region;
            whs.city = _city;
            whs.postal_code = _postal_code;
            string[] arrStr = { "", "" };
            ClsLogic logic = new ClsLogic();
            arrStr = logic.UpdateWarehouse(whs);
            return arrStr;
        }

        public IList<TypeActivity> getServiceAllTypeActivity()
        {
            ClsLogic logic = new ClsLogic();
            IList<TypeActivity> rv = logic.getLogicAllTypeActivity();
            return rv;
        }
              

    }
}
