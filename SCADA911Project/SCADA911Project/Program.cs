using System;
using System.Collections.Generic; 
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCADA911Project
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
            //Uncomment line below for main windows form to be present 
            //Application.Run(new MainMenuForm());
            Application.Run(new Schedule());
            Schedule ScheduleObj = new Schedule();  

            
        }   
    }
}
