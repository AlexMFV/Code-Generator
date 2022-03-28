using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gen
{
    public static class GlobalFunctions
    {
        #region Variables

        //STRINGS
        public static string PROJECTS_FOLDER_NAME = "xGen";
        public static string PROJECTS_FOLDER_LOCATION = "D:\\";

        //BOOLEANS
        public static bool USE_MAIN_DISK = true;

        #endregion

        /// <summary>
        /// This function should be used to treat Exceptions, just call this function and pass the Exceptionn reference!
        /// </summary>
        /// <param name="ex">Reference of the Exception</param>
        public static void SendException(Exception ex)
        {
            MessageBox.Show(ex.TargetSite.Name, ex.Message, MessageBoxButtons.OK);
        }
    }
}
