using System;
using System.Windows.Forms;

namespace Project_ENSAF
{
    public partial class SettingsLog : Form
    {
        public SettingsLog()
        {
            InitializeComponent();
            numericUpDownJour.Enabled = checkBoxCustom.Checked;

        }

        private void buttonImprimer_Click(object sender, EventArgs e)
        {
            if (checkBoxJour.Checked) Properties.Settings.Default.NombreDayToDeleteLog = "1";
            if (checkBoxMois.Checked) Properties.Settings.Default.NombreDayToDeleteLog = "31";
            if (checkBoxAns.Checked) Properties.Settings.Default.NombreDayToDeleteLog = "365";
            if (checkBoxCustom.Checked) Properties.Settings.Default.NombreDayToDeleteLog = numericUpDownJour.Value + "";
            if (Properties.Settings.Default.inTialSettings)
            {
                Properties.Settings.Default.DateDelteLog = DateTime.Now.ToString();
                Properties.Settings.Default.inTialSettings = false;
            }
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void checkBoxAns_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                if ((sender as CheckBox).Checked)
                {
                    if ((sender as CheckBox) != checkBoxAns) checkBoxAns.Checked = false;
                    if ((sender as CheckBox) != checkBoxJour) checkBoxJour.Checked = false;
                    if ((sender as CheckBox) != checkBoxMois) checkBoxMois.Checked = false;
                    if ((sender as CheckBox) != checkBoxCustom) checkBoxCustom.Checked = false;
                }
            }
            numericUpDownJour.Enabled = checkBoxCustom.Checked;
        }

        private void SettingsLog_Load(object sender, EventArgs e)
        {
            switch (Properties.Settings.Default.NombreDayToDeleteLog.ToString())
            {
                case "1":
                    checkBoxJour.Checked = true;
                    break;
                case "31":
                    checkBoxMois.Checked = true;
                    break;
                case "365":
                    checkBoxAns.Checked = true;
                    break;
                default:
                    checkBoxCustom.Checked = true;
                    numericUpDownJour.Value = int.Parse(Properties.Settings.Default.NombreDayToDeleteLog.ToString());
                    break;

            }
        }
    }
}
