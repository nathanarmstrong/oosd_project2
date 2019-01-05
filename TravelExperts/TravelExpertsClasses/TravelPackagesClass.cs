using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsClasses
{
    // Travel Packages Class
    public class TravelPackagesClass
    {
        // Private data for packages class
        private string pkgName;
        private string pkgStartDate;
        private string pkgEndDate;
        private string pkgDesc;
        private decimal pkgBasePrice;
        private decimal pkgAgencyCommission;

        // Public getters and setters
        public string PkgName
        {
            get { return pkgName; }
            set { pkgName = value; }
        }

        public string PkgStartDate
        {
            get { return pkgStartDate; }
            set { pkgStartDate = value; }
        }

        public string PkgEndDate
        {
            get { return pkgEndDate; }
            set { pkgEndDate = value; }
        }

        public string PkgDesc
        {
            get { return pkgDesc; }
            set { pkgDesc = value; }
        }

        public decimal PkgBasePrice
        {
            get { return pkgBasePrice; }
            set { pkgBasePrice = value; }
        }

        public decimal PkgAgencyCommission
        {
            get { return pkgAgencyCommission; }
            set { pkgAgencyCommission = value; }
        }
    }
}
