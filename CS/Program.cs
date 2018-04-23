using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

namespace RichEditLoadingSpeed {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Thread thread = new Thread(delegate() {
                EditForm editForm = new EditForm();
                //MessageBox.Show("EditForm has been initialized.");
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Priority = ThreadPriority.Highest;
            thread.IsBackground = true;
            thread.Start();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}