using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices.ActiveDirectory;
using System.DirectoryServices;

namespace Domain
{
    class Domain
    {
        private System.DirectoryServices.ActiveDirectory.Domain CurrentDomain;

        public Domain()
        {
            CurrentDomain = System.DirectoryServices.ActiveDirectory.Domain.GetCurrentDomain();
        }

        public DomainControllerCollection GetDomainControllers()
        {
            return CurrentDomain.DomainControllers;
        }

        public SearchResultCollection GetUserPrincipalName(string Anr)
        {
            DirectorySearcher ds = new DirectorySearcher(CurrentDomain.Name);
            ds.Filter = "(anr=Anr)";

            SearchResultCollection Results = ds.FindAll();

            return Results;
        }

        public DateTime GetLastLogonDate(string UserPrincipalName, DomainController DC)
        {
            DirectorySearcher ds = new DirectorySearcher(string.Format("LDAP://{0}",DC.Name));
            ds.Filter = string.Format("(userprincipalname={0})", UserPrincipalName);
            ds.PropertiesToLoad.Add("LastLogonDate");
            SearchResult result = ds.FindOne();

            DateTime LLD = (DateTime) result.Properties["LastLogonDate"][0];

            return LLD;
        }
    }
}
