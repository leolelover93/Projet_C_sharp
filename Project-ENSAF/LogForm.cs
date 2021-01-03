using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Windows.Forms;

namespace Project_ENSAF
{
    public partial class LogForm : Form
    {
        public LogForm()        {
            InitializeComponent();
            String filePath = Path.Combine(Directory.GetCurrentDirectory(), "log.txt");
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
                listView1.Items.Add(line);
            }
        }

        private void btnEnregister_Click(object sender, EventArgs e)
        {
            String Filepath = Path.Combine(Directory.GetCurrentDirectory(), "log.txt");
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = saveFileDialog1.OpenFile()) != null)
                    {
                        myStream.Close();
                        File.Copy(Filepath, saveFileDialog1.FileName, true);
                    }
                }
                this.Close();

            }
            catch (Exception )
            {
                MessageBox.Show("SVP CHOISIE UN AUTRE PROPRE NOM POUR LE FICHIER !","Attention", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
           

        }

        private void buttonImprimer_Click(object sender, EventArgs e)
        {
            String Filepath = Path.Combine(Directory.GetCurrentDirectory(), "log.txt");

            using (PrintDialog Dialog = new PrintDialog())
            {
                Dialog.ShowDialog();

                ProcessStartInfo printProcessInfo = new ProcessStartInfo()
                {
                    Verb = "print",
                    CreateNoWindow = true,
                    FileName = Filepath,
                    WindowStyle = ProcessWindowStyle.Hidden
                };

                Process printProcess = new Process();
                printProcess.StartInfo = printProcessInfo;
                printProcess.Start();

                printProcess.WaitForInputIdle();

                Thread.Sleep(3000);

                  /*if (printProcess != null &&  printProcess.CloseMainWindow()==false)
                   {
                       printProcess.Kill();
                   }*/
            }
            this.Close();
        }
    }
}
