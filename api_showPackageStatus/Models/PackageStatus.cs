using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api_showPackageStatus.Models
{
    public class PackageStatus
    {
        public DateTime Reception_Date { get; set; }

        public string Customer { get; set; }

        public string Recipient { get; set; }

        public string Warehouse { get; set; }

        public string Status { get; set; }


    }
}