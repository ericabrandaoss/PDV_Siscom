using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV.Siscom
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NjI1NTcwQDMyMzAyZTMxMmUzMGNYdEZXK3NKcmRSMkJSVGp1SkdFdXkydCtnQUhFMDZQZnZYb25zSjArY0E9;NjI1NTcxQDMyMzAyZTMxMmUzMG9ydC9vOVRCM2lXRkRQbkxEM0lPL0ZtTXdRSWJMN2pqRUxKVTdrbFh0MVk9");
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmVendaPdv());
        }
    }
}
