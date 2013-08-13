using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.EntityModel;
using System.Data.Entity;
using log4net;

namespace BusinessLogic
{
    public class ClsLogic
    {
        ClsData m_lyr = null;
        public ClsLogic()
        {
            m_lyr = new ClsData();
        }

        public String[] AddDistributors(Distributor _dst)
        {
            string[] arrStr = null;
            try
            {
                IQueryable<Distributor> dst = m_lyr.getLastDistributors();
                string id = "dst-1";
                if (dst.ToList().Count > 0)
                {
                    id = Autoincrement(dst.First().DistributorID, '-');  
                }    
                _dst.DistributorID = id;
                m_lyr.Distributors.Add(_dst);
                m_lyr.Saving();
                SaveLog(1, "Success create distributor", "Distributors");
                arrStr = log_for_net("1", "Success saving create to Distributors");
            }
            catch(Exception e)
            {                
                arrStr = log_for_net("2",e.Message);
            }
            return arrStr;
        }

        public String[] UpdateDistributors(Distributor _dst)
        {
            string[] arrStr = null;
            try
            {                
                m_lyr.Entry(_dst).State = System.Data.EntityState.Modified;
                m_lyr.Saving();
                SaveLog(1, "Success update distributor", "Distributors");
                arrStr = log_for_net("1", "Success saving update to Distributors");
            }
            catch (Exception e)
            {
                arrStr = log_for_net("2", e.Message);
            }
            return arrStr;
        }

        public String[] AddRetailers(Retailer _ret)
        {
            string[] arrStr = null;
            try
            {
                IQueryable<Retailer> ret = m_lyr.getLastRetailers();
                string id = "1";
                if (ret.ToList().Count > 0)
                {
                    id = (Convert.ToInt16(ret.First().retailerId) + 1).ToString();
                }    
                _ret.retailerId = id;
                m_lyr.Retailers.Add(_ret);
                m_lyr.Saving();
                SaveLog(1, "Success create retailer", "Retailers");
                arrStr = log_for_net("1", "Success saving create to Retailers");
            }
            catch (Exception e)
            {
                arrStr = log_for_net("2", e.Message);
            }
            return arrStr;
        }

        public String[] UpdateRetailers(Retailer _ret)
        {
            string[] arrStr = null;
            try
            {
                m_lyr.Entry(_ret).State = System.Data.EntityState.Modified;
                m_lyr.Saving();
                SaveLog(1, "Success update retailer", "Retailers");
                arrStr = log_for_net("1", "Success saving create to Retailers");
            }
            catch (Exception e)
            {
                arrStr = log_for_net("2", e.Message);
            }
            return arrStr;
        }

        public String[] AddProspect(Prospect _pros)
        {
            string[] arrStr = null;
            try
            {
                IQueryable<Prospect> pros = m_lyr.getLastProspects();
                string id = "1";
                if (pros.ToList().Count > 0)
                {
                    id = (Convert.ToInt16(pros.First().prospectId) + 1).ToString();
                }
                _pros.prospectId = id;
                m_lyr.Prospects.Add(_pros);
                m_lyr.Saving();
                SaveLog(1, "Success create prospect", "Prospects");
                arrStr = log_for_net("1", "Success saving create to prospects");
            }
            catch (Exception e)
            {
                arrStr = log_for_net("2", e.Message);
            }
            return arrStr;
        }

        public String[] UpdateProspects(Prospect _pro)
        {
            string[] arrStr = null;
            try
            {
                m_lyr.Entry(_pro).State = System.Data.EntityState.Modified;
                m_lyr.Saving();
                SaveLog(1, "Success update prospects", "Prospects");
                arrStr = log_for_net("1", "Success saving update to prospects");
            }
            catch (Exception e)
            {
                arrStr = log_for_net("2", e.Message);
            }
            return arrStr;
        }

        public String[] AddContacts(Contact _ctc)
        {
            string[] arrStr = null;// new string[] { "1", "success" };
            try
            {
                IQueryable<Contact> ret = m_lyr.getLastContacts();
                string id = "1";
                if (ret.ToList().Count > 0)
                {
                    id = (Convert.ToInt16(ret.First().contactId) + 1).ToString();
                }
                _ctc.contactId = id;
                m_lyr.Contacts.Add(_ctc);
                m_lyr.Saving();
                SaveLog(1, "Success create contact", "Contacts");
                arrStr = log_for_net("1", "Success saving create to Contacts");
            }
            catch (Exception e)
            {
                arrStr = log_for_net("2", e.Message);
            }
            return arrStr;
        }

        public String[] UpdateContacts(Contact _ctc)
        {
            string[] arrStr = null;// new string[] { "1", "success" };
            try
            {
                m_lyr.Entry(_ctc).State = System.Data.EntityState.Modified;
                m_lyr.Saving();
                SaveLog(1, "Success update contacts", "Contacts");
                arrStr = log_for_net("1", "Success saving update to Contacts");
            }
            catch (Exception e)
            {
                arrStr = log_for_net("2", e.Message);
            }
            return arrStr;
        }

        public String[] AddSalesAreas(Salesarea _slsArea)
        {
            string[] arrStr = null;
            try
            {
                IQueryable<Salesarea> slsArea = m_lyr.getLastSalesareas();
                string id = "1";
                if (slsArea.ToList().Count > 0)
                {
                    id = (Convert.ToInt16(slsArea.First().salesareaId) + 1).ToString();
                }
                _slsArea.salesareaId = id;
                m_lyr.Salesareas.Add(_slsArea);
                m_lyr.Saving();
                SaveLog(1, "Success create", "SalesAreas");
                arrStr = log_for_net("1", "Success saving to Salesareas");
            }
            catch (Exception e)
            {
                arrStr = log_for_net("2", e.Message);
            }
            return arrStr;
        }

        public String[] UpdateSalesAreas(Salesarea _slsArea)
        {
            string[] arrStr = null;
            try
            {
                m_lyr.Entry(_slsArea).State = System.Data.EntityState.Modified;
                m_lyr.Saving();
                SaveLog(1, "Success update salesarea", "SalesAreas");
                arrStr = log_for_net("1", "Success saving to Salesareas");
            }
            catch (Exception e)
            {
                arrStr = log_for_net("2", e.Message);
            }
            return arrStr;
        }

        public String[] AddContactToContact(Contacttocontact _ctct)
        {
            string[] arrStr = null;
            try
            {
                IQueryable<Contacttocontact> ctct = m_lyr.getLastContactToContact();
                string id = "1";
                if (ctct.ToList().Count > 0)
                {
                    id = (Convert.ToInt16(ctct.First().contactToContactId) + 1).ToString();
                }
                _ctct.contactToContactId = id;
                m_lyr.Contacttocontacts.Add(_ctct);
                m_lyr.Saving();
                SaveLog(1, "Success create relations", "contacttocontact");
                arrStr = log_for_net("1", "Success saving create to contacttocontact");
            }
            catch (Exception e)
            {
                arrStr = log_for_net("2", e.Message);
            }
            return arrStr;
        }

        public String[] UpdateContactToContact(Contacttocontact _ctct)
        {
            string[] arrStr = null;
            try
            {
                m_lyr.Entry(_ctct).State = System.Data.EntityState.Modified;
                m_lyr.Saving();
                SaveLog(1, "Success update contactrelation", "contacttocontact");
                arrStr = log_for_net("1", "Success update to contactrelation");
            }
            catch (Exception e)
            {
                arrStr = log_for_net("2", e.Message);
            }
            return arrStr;
        }

        public String[] AddWarehouse(Warehouse _wrhs)
        {
            string[] arrStr = null;
            try
            {
                IQueryable<Warehouse> wrhs = m_lyr.getLastWarehouse();
                string id = "1";
                if (wrhs.ToList().Count > 0)
                {
                    id = (Convert.ToInt16(wrhs.First().wirehouseId) + 1).ToString();
                }
                _wrhs.wirehouseId = id;
                m_lyr.Warehouses.Add(_wrhs);
                m_lyr.Saving();
                SaveLog(1, "Success create warehouse", "Warehouses");
                arrStr = log_for_net("1", "Success saving create to Warehouses");
            }
            catch (Exception e)
            {
                arrStr = log_for_net("2", e.Message);
            }
            return arrStr;
        }

        public String[] UpdateWarehouse(Warehouse _wrhs)
        {
            string[] arrStr = null;
            try
            {
                m_lyr.Entry(_wrhs).State = System.Data.EntityState.Modified;
                m_lyr.Saving();
                SaveLog(1, "Success update warehouse", "Warehouses");
                arrStr = log_for_net("1", "Success saving create to Warehouse");
            }
            catch (Exception e)
            {
                arrStr = log_for_net("2", e.Message);
            }
            return arrStr;
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
            return  new string[] { _status, _msg };
        }

        // ====== method testing

        public IList<TypeActivity> getLogicAllTypeActivity()        
        {            
            IList<TypeActivity> acts = m_lyr.getDataJoinTypeActivityAndDistributor().ToList(); 
            /*foreach (TypeActivity ac in acts)
            {
                ac.Distributors = m_lyr.getDistributorQueryByTypeActivity(ac.DistirbutorId).ToList();
            }*/
            return acts; 
        }

        private String Autoincrement(string _data, char _separate)
        {
            string[] words = _data.Split(_separate);
            return (words[0] + "-" + (Convert.ToInt16(words[1]) + 1).ToString());
        }
    }    
}
