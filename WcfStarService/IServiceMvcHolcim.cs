using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfStarService
{
    [ServiceContract]
    public interface IServiceMvcHolcim
    {

        [OperationContract]
        string[] ws_stars_account(string account_name,
             string account_owner,
             string stars_prospect_id,
             string sap_account_number,
             string sap_account_status,
             string account_type,
             string account_subtype,
             string primary_sold_to,
             string sap_term_of_payment,
             string sap_credit_limit,
             string sap_remaining_credit,
             string address_1,
             string address_2,
             string address_3,
             string country,
             string region,
             string city,
             string postal_code,
             string longitude,
             string latitude,
             string email,
             string extension_1,
             string fax,
             string mobile_1,
             string phone,
             long sap_created_by,
             DateTime sap_created_Date,
             long sap_last_modified_by,
             DateTime sap_last_modified_date);

        [OperationContract]
        string[] ws_stars_contact(
            string contactId,
            string sap_contact_number,
            string firstname,
            string lastname,
            string name,
            string title,
            DateTime birthdate,
            string sex,
            string marital_status,
            string account_number,
            string account_name,
            string phone,
            string phone_2,
            string mobile,
            string fax,
            string extension,
            string email,
            long sap_created_by,
            DateTime sap_created_date,
            long sap_last_modified_by,
            DateTime sap_last_modified_date);

        [OperationContract]
        string[] ws_stars_salesarea(string sales_organization,
            string segmen_code,
            string segmen_description,
            string distribution_channel,
            string division,
            string sales_district,
            string customer_group,
            string sales_group,
            string account_group,
            string sales_office,
            string region,
            string deletion);        
    }
}
