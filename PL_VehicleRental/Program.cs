using PL_VehicleRental.Forms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL_VehicleRental
{
    internal static class Program
    {
        //public static void EncryptConnectionString()
        //{
        //    Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        //    ConfigurationSection section = config.GetSection("connectionStrings");

        //    if (!section.SectionInformation.IsProtected)
        //    {
        //        section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
        //        section.SectionInformation.ForceSave = true;
        //        config.Save(ConfigurationSaveMode.Full);
        //    }
        //}
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
            //EncryptConnectionString();
        }
    }
}
