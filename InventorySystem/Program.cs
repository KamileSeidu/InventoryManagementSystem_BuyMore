using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystemCsharp
{
    static class Program
    {
        
        /// Application entry point
        /// KAMILE SEIDU IS MY NAME, I COME FROM WA IN THEE UPPER WEST REGION OF GHANA. 
        /// C_SHARP_SHARP
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
