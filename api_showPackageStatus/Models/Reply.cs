using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api_showPackageStatus.Models
{
    public class Reply
    {
        public int Result { get; set; }
        public string Message { get; set; }
        public PackageStatus package_Status{ get; set; }
    }
}