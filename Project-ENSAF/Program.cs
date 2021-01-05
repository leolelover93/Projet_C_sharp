using System;
using System.Windows.Forms;

namespace Project_ENSAF
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            catch (Exception e)
            {
                MessageBox.Show("Error! The app cant be loaded:\n" + e.Message);
            }
           
        }
    }
}
