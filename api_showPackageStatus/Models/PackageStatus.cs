using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api_showPackageStatus.Models
{
    public class PackageStatus
    {
        public DateTime Reception_Date { get; set; }

        public string Customer_information { get; set; }

        public string Name_Addressee { get; set; }

        public string Name_Store { get; set; }

        public string Status { get; set; }


    }
}