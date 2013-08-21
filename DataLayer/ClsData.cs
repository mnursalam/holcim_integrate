using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using System.Data.Entity;

namespace BusinessLogic
{
    public class ClsData : ServiceEntities13
    {
        public ClsData()
        {
        }       

        public void Saving()
        {
            this.SaveChanges();
        }

        public IQueryable<Distributor> DistributorBySapID(string _sap_account_number)
        {
            IQueryable<Distributor> sql = this.Distributors.Where(e => e.sap_account_number == _sap_account_number);
            return sql;
        }

        public IQueryable<Retailer> RetailerBySapID(string _sap_account_number)
        {
            IQueryable<Retailer> sql = this.Retailers.Where(e => e.sap_account_number == _sap_account_number);
            return sql;
        }

        public IQueryable<warehouse> WarehouseBySapID(string _sap_account_number)
        {
            IQueryable<warehouse> sql = this.warehouses.Where(e => e.sap_account_number == _sap_account_number);
            return sql;
        }

        public IQueryable<Contact> ContactBySapID(string _sap_contact_number)
        {
            IQueryable<Contact> sql = this.Contacts.Where(e => e.sap_contact_number == _sap_contact_number);
            return sql;
        }


        public IQueryable<Salesarea> LastSalesArea()
        {
            IQueryable<Salesarea> sql = this.Salesareas.OrderByDescending(e => e.salesareaId);
            return sql;
        }

        
        /*public IQueryable<TypeActivity> getDataJoinTypeActivityAndDistributor()
        {
            IQueryable<TypeActivity> strQuery = from s in this.TypeActivities
                                                join e in this.Distributors
                                                on s.DistirbutorId equals e.DistributorID
                                                select s;
            IQueryable<TypeActivity> strQuery = null;
            return strQuery;
        }*/

        
    }
}
