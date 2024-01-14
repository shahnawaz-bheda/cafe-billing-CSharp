using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace signIn_form1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           // Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new splash_screen());
         // Application.Run(new neworder());
            //Application.Run(new Billing());
           // Application.Run(new Product());
            //Application.Run(new Home());
          // Application.Run(new Registration());
          // Application.Run(new neworder());
          //  Application.Run(new LOGIN());
           // Application.Run(new category());
       //  Application.Run(new subcategory());
            
        }
    }
}
