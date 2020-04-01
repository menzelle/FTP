using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace ftpDELETEME
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Create Object Instance */
            ftp ftpClient = new ftp(@"ftp://ftp.aeroxchange.com/", "aerocontrols_admin", "@er0cnt_ftp");

            /* Upload a File */
            ftpClient.upload("test.xlsx", @"\\aci-cluster\D$\VOL1\SHARE\SALES\GENERAL\REPORTS\AeroXChangeUploads\AeroRepairUploadFromProcessor.xlsx");


            /* Release Resources */
            ftpClient = null;
        }
    }
}
