using getmethod_single_perabtter_called.Views_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace getmethod_single_perabtter_called
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        var pra = Convert.ToInt32(providerID);
            if (pra <= 0)
                return null;
            var Providess = (from a in endocDataContext.Providers.Where(x => x.Deleted !=true && x.ProviderID == pra
                             )
                             select
                             new
                             {
                                 a.ProviderID,
                                 a.NPI,
                                 a.AddressLine1,
                                 a.AddressLine2,
                                 a.Country,
                                 a.BillingState,
                                 a.BillingZIP,
                                 a.City,
                                 a.CreatedBy,
                                 a.CreatedDate,
                                 a.Deleted,
                                 a.County,
                                 a.BirthDate,
                                 a.BillingCity,
                                 a.AlternatePhone,
                                 a.Credential,
                                 a.Email,
                                 a.IsBillingForeign,
                                 a.IsForeign,
                                 a.IsSameAsMailingAddress,
                                 a.LanguageID,
                                 a.MedicaidID,
                                 a.MedicareID,
                                 a.ModifiedBy,
                                 a.ModifiedDate,
                                 a.MothersMaidenName,
                                 a.NameFirst,
                                 a.NameLast,
                                 a.NamePrefix,
                                 a.NameSuffix,
                                 a.BillingAddressLine1,
                                 a.BillingAddressLine2,
                                 a.BillingCountry



                             }).AsEnumerable().Select(ss => new Providers
                             {
                                 ProviderID = ss.ProviderID,
                                 AddressLine1 = ss.AddressLine1,
                                 AddressLine2 = ss.AddressLine2,
                                 Country = ss.Country,
                                 BillingState = ss.BillingState,
                                 BillingZIP = ss.BillingZIP,
                                 City = ss.City,
                                 CreatedBy = ss.CreatedBy,
                                 CreatedDate = ss.CreatedDate,
                                 Deleted = ss.Deleted,
                                 County = ss.County,
                                 BirthDate = ss.BirthDate,
                                 BillingCity = ss.BillingCity,
                                 BillingCountry = ss.BillingCountry
                             }).ToList();
            return Providess; 
    }
}
