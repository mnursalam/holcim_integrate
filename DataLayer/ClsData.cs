using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using System.Data.Entity;

namespace BusinessLogic
{
    public class ClsData : ServiceEntities9
    {
        public ClsData()
        {
        }       

        public void Saving()
        {
            this.SaveChanges();
        }

        public IQueryable<Distributor> getLastDistributors()
        {
            IQueryable<Distributor> sql = this.Distributors.OrderByDescending(e => e.DistributorID).Skip(0).Take(1);
            return sql;
        }

        public IQueryable<Retailer> getLastRetailers()
        {
            IQueryable<Retailer> sql = this.Retailers.OrderByDescending(e => e.retailerId).Skip(0).Take(1);
            return sql;
        }

        public IQueryable<Prospect> getLastProspects()
        {
            IQueryable<Prospect> sql = this.Prospects.OrderByDescending(e => e.prospectId).Skip(0).Take(1);
            return sql;
        }

        public IQueryable<Contact> getLastContacts()
        {
            IQueryable<Contact> sql = this.Contacts.OrderByDescending(e => e.contactId).Skip(0).Take(1);
            return sql;
        }

        public IQueryable<Salesarea> getLastSalesareas()
        {
            IQueryable<Salesarea> sql = this.Salesareas.OrderByDescending(e => e.salesareaId).Skip(0).Take(1);
            return sql;
        }

        
        public IQueryable<Contacttocontact> getLastContactToContact()
        {
            IQueryable<Contacttocontact> sql = this.Contacttocontacts.OrderByDescending(e => e.contactToContactId).Skip(0).Take(1);
            return sql;
        }

        public IQueryable<Warehouse> getLastWarehouse()
        {
            IQueryable<Warehouse> sql = this.Warehouses.OrderByDescending(e => e.wirehouseId).Skip(0).Take(1);
            return sql;
        }

        // ============test method

        public IQueryable<TypeActivity> getDataJoinTypeActivityAndDistributor()
        {
            /*IQueryable<TypeActivity> strQuery = from s in this.TypeActivities
                                                join e in this.Distributors
                                                on s.DistirbutorId equals e.DistributorID
                                                select s;*/
            IQueryable<TypeActivity> strQuery = null;
            return strQuery;
        }

        public IQueryable<Distributor> getDistributorQueryByTypeActivity(long id)
        {
            return null;//this.Distributors.Where(e => e.DistributorID == id);
        }

        
    }
}
