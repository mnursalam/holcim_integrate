using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.EntityModel;
using System.Data.Entity;
using log4net;
using System.Diagnostics;
//using System.Threading;

namespace BusinessLogic
{
    public class ClsLogic : SetEntitiy
    {
        ClsData m_lyr = null;        
        EventLog m_log = null;
            
        public ClsLogic()
        {
            m_lyr = new ClsData();
            m_log = new EventLog();
            m_log.Source = "MySource";
        }

        public String[] AddAccount(string _account_name,
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

             AccountEntitas(_account_name,
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
            string[] arrStr = null;
            try
            {
                string msgdist = DistributorLogic();
                string msgret = RetailerLogic();
                string msgwrhs = WarehouseLogic();
                m_lyr.Saving();
                SaveLog(1, "Success " + msgdist + " distributor", "Distributors");
                SaveLog(1, "Success " + msgret + " retailer", "Retailers");
                SaveLog(1, "Success " + msgwrhs + " warehouse", "Warehouses");
                arrStr = log_for_net("1", "Success saving for ( " + msgdist + " Distributors, " + msgret + " retailer, " + msgwrhs + "warehouse)");
            }
            catch (Exception e)
            {
                arrStr = log_for_net("2", e.Message);
            }
            return arrStr;            
        }

        public string[] AddContact(string _contactId,
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
            string[] arrStr = null;
            try
            {
                Contact ctc = new Contact();
                ctc.contactId = _contactId;
                ctc.sap_contact_number = _sap_contact_number;
                ctc.firstname = _firstname;
                ctc.lastname = _lastname;
                ctc.name = _name;
                ctc.title = _title;
                ctc.birthdate = _birthdate;
                ctc.sex = _sex;
                ctc.marital_status = _marital_status;
                ctc.account_number = _account_number;
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
                String strCtc = ContactLogic(ctc);                
                m_lyr.Saving();                
                SaveLog(1, "Success " + strCtc + " contact", "Contacts");
                arrStr = log_for_net("1", "Success saving " + strCtc + " contacts");
            }
            catch (Exception e)
            {                
                arrStr = log_for_net("2", e.Message);
            }
            return arrStr;
        }

        public string[] AddSalesArea(string _sales_organization,
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
            string[] arrStr = null;
            Salesarea sls = new Salesarea();
            sls.sales_organization = _sales_organization;
            sls.segment_code = _segmen_code;
            sls.segment_description = _segmen_description;
            sls.distribution_channel = _distribution_channel;
            sls.division = _division;
            sls.sales_district = _sales_district;
            sls.customer_group = _customer_group;
            sls.sales_group = _sales_group;
            sls.account_group = _account_group;
            sls.sales_office = _sales_office;
            sls.region = _region;
            sls.deletion = _deletion;
            try
            {
                IQueryable<Salesarea> sql = m_lyr.LastSalesArea();
                string id = "1";
                if (sql.Count() > 0)
                {
                    id = Autoincrement(sql.First().salesareaId, '-');
                }
                sls.salesareaId = id;
                m_lyr.Salesareas.Add(sls);
                m_lyr.Saving();
                SaveLog(1, "Success create salesarea", "Salesareas");
                arrStr = log_for_net("1", "Success saving create salesarea");
            }
            catch (Exception e)
            {
                arrStr = log_for_net("2", e.Message);
            }
            
            Console.WriteLine("2 ===================================================");
            return arrStr;
        }

        private string DistributorLogic()
        {
            String msg = "";
            IQueryable<Distributor> dst = m_lyr.DistributorBySapID(m_dst.sap_account_number);
            if (dst.Count() == 0)
            {
                m_lyr.Distributors.Add(m_dst);
                msg = "create";
            }
            else
            {
                m_lyr.Entry(m_dst).State = System.Data.EntityState.Modified;
                msg = "update";
            }
            return msg;
        }

        private string RetailerLogic()
        {
            String msg = "";
            IQueryable<Retailer> ret = m_lyr.RetailerBySapID(m_dst.sap_account_number);
            if (ret.Count() == 0)
            {
                m_lyr.Retailers.Add(m_ret);
                msg = "create";
            }
            else
            {
                m_lyr.Entry(m_ret).State = System.Data.EntityState.Modified;
                msg = "update";
            }
            return msg;
        }

        private string WarehouseLogic()
        {
            String msg = "";
            IQueryable<warehouse> wrhs = m_lyr.WarehouseBySapID(m_dst.sap_account_number);
            if (wrhs.Count() == 0)
            {
                m_lyr.warehouses.Add(m_wrh);
                msg = "create";
            }
            else
            {
                m_lyr.Entry(m_wrh).State = System.Data.EntityState.Modified;
                msg = "update";
            }
            return msg;
        }

        private string ContactLogic(Contact _ctc)
        {
            String msg = "";
            IQueryable<Contact> ctc = m_lyr.ContactBySapID(_ctc.sap_contact_number);            
            if (ctc.Count() == 0)
            {                
                m_lyr.Contacts.Add(_ctc);
                msg = "create";
            }
            else
            {
                m_lyr.Entry(_ctc).State = System.Data.EntityState.Modified;
                msg = "update";
            }
            return msg;
        }

        private void SaveLog(int _status, string _msg, string _tblName)
        {
            Activitylog log = new Activitylog();
            log.status = _status;
            log.description = _msg;
            log.tbl_name = _tblName;
            log.created_at = DateTime.Now;
            ClsData db = new ClsData();
            db.Activitylogs.Add(log);
            db.Saving();
        }
        
        private string[] log_for_net(string _status, string _msg)
        {                
            ILog log = LogManager.GetLogger(typeof(ClsLogic));
            log4net.Config.XmlConfigurator.Configure();
            log.Info("[" + DateTime.Now + "]" + "[ " + _status + " ] " + _msg);
            m_log.WriteEntry("[" + DateTime.Now + "]" + "[ " + _status + " ] " + _msg);
            return  new string[] { _status, _msg };
        }

        // ====== method testing
        
        /*public IList<TypeActivity> getLogicAllTypeActivity()        
        {            
            IList<TypeActivity> acts = m_lyr.getDataJoinTypeActivityAndDistributor().ToList(); 
            foreach (TypeActivity ac in acts)
            {
                ac.Distributors = m_lyr.getDistributorQueryByTypeActivity(ac.DistirbutorId).ToList();
            }
            return acts; 
        }*/

        private String Autoincrement(string _data, char _separate)
        {
            string[] words = _data.Split(_separate);
            string id = "";
            if (words.Count() == 2)
            {
                id = (words[0] + "-" + (Convert.ToInt16(words[1]) + 1).ToString());
            }
            else
            {
                id = (Convert.ToInt16(_data) + 1).ToString();
            }
            return id;
        }
    }    
}
