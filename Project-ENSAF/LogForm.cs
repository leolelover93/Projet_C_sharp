using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Project_ENSAF
{
    public partial class LogForm : Form
    {
        string[] lines;


        public LogForm()
        {
            //Set the intial settong to true
            InitializeComponent();

            automatingDeletingLog();


            String filePath = Path.Combine(Directory.GetCurrentDirectory(), "log.txt");
            lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
                listView1.Items.Add(line);
            }


        }

        public static void automatingDeletingLog()
        {
            DateTime lastDate = DateTime.Now;
            if (Properties.Settings.Default.DateDelteLog != "")
            {
                lastDate = DateTime.Parse(Properties.Settings.Default.DateDelteLog);
            }
            String filePath = Path.Combine(Directory.GetCurrentDirectory(), "log.txt");
            int nbDay = Convert.ToInt32(Properties.Settings.Default.NombreDayToDeleteLog.ToString());
            if ((DateTime.Now - lastDate).TotalDays > nbDay)
            {
                StreamWriter writer = new StreamWriter(filePath, false);
                writer.Write("");
                writer.Close();
                Properties.Settings.Default.DateDelteLog = DateTime.Now.ToString();
                Properties.Settings.Default.Save();

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
            catch (Exception)
            {
                MessageBox.Show("SVP CHOISIE UN AUTRE PROPRE NOM POUR LE FICHIER !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SettingsLog a = new SettingsLog();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Toute la journalisation sera supprimé définitivement, Continue?", "Effacer Log", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                listView1.Clear();
                String Filepath = Path.Combine(Directory.GetCurrentDirectory(), "log.txt");
                StreamWriter writer = new StreamWriter(Filepath, false);
                writer.Write(DateTime.Now + " : Log Effacé\n");
                writer.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            String Filepath = Path.Combine(Directory.GetCurrentDirectory(), "log.txt");
            string[] lignes = File.ReadAllLines(Filepath);
            listView1.Items.Clear();
            /**/
            foreach (string line in lignes)
            {
                // Console.WriteLine(line);
                listView1.Items.Add(line);
            }
        }
    }
}

