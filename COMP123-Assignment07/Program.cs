using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Course Name: COMP123-Assignment07
 * Application Name: Movies Online Stream
 * Authoer: LI XU 300735072
 * App Creation Date: April 7, 2015
 * Date: April 11, 2015
 * 
 */
namespace COMP123_Assignment07
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashForm());
        }
    }
}
