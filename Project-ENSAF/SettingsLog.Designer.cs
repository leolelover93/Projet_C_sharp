
namespace Project_ENSAF
{
    partial class SettingsLog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonImprimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.checkBoxCustom = new System.Windows.Forms.CheckBox();
            this.checkBoxAns = new System.Windows.Forms.CheckBox();
            this.checkBoxMois = new System.Windows.Forms.CheckBox();
            this.checkBoxJour = new System.Windows.Forms.CheckBox();
            this.numericUpDownJour = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJour)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonImprimer
            // 
            this.buttonImprimer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonImprimer.BackColor = System.Drawing.Color.White;
            this.buttonImprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImprimer.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Bold);
            this.buttonImprimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.buttonImprimer.Location = new System.Drawing.Point(295, 175);
            this.buttonImprimer.Name = "buttonImprimer";
            this.buttonImprimer.Size = new System.Drawing.Size(167, 45);
            this.buttonImprimer.TabIndex = 3;
            this.buttonImprimer.Text = "Appliquer";
            this.buttonImprimer.UseVisualStyleBackColor = false;
            this.buttonImprimer.Click += new System.EventHandler(this.buttonImprimer_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Paramètres de Fichier Log ";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.panelHeader.Controls.Add(this.checkBoxCustom);
            this.panelHeader.Controls.Add(this.checkBoxAns);
            this.panelHeader.Controls.Add(this.checkBoxMois);
            this.panelHeader.Controls.Add(this.checkBoxJour);
            this.panelHeader.Controls.Add(this.numericUpDownJour);
            this.panelHeader.Controls.Add(this.label3);
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.buttonImprimer);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(484, 232);
            this.panelHeader.TabIndex = 9;
            // 
            // checkBoxCustom
            // 
            this.checkBoxCustom.AutoSize = true;
            this.checkBoxCustom.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.checkBoxCustom.ForeColor = System.Drawing.Color.White;
            this.checkBoxCustom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxCustom.Location = new System.Drawing.Point(31, 150);
            this.checkBoxCustom.Name = "checkBoxCustom";
            this.checkBoxCustom.Size = new System.Drawing.Size(93, 21);
            this.checkBoxCustom.TabIndex = 15;
            this.checkBoxCustom.Text = "Personalisé";
            this.checkBoxCustom.UseVisualStyleBackColor = true;
            this.checkBoxCustom.CheckedChanged += new System.EventHandler(this.checkBoxAns_CheckedChanged);
            // 
            // checkBoxAns
            // 
            this.checkBoxAns.AutoSize = true;
            this.checkBoxAns.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.checkBoxAns.ForeColor = System.Drawing.Color.White;
            this.checkBoxAns.Location = new System.Drawing.Point(31, 126);
            this.checkBoxAns.Name = "checkBoxAns";
            this.checkBoxAns.Size = new System.Drawing.Size(48, 21);
            this.checkBoxAns.TabIndex = 14;
            this.checkBoxAns.Text = "Ans";
            this.checkBoxAns.UseVisualStyleBackColor = true;
            this.checkBoxAns.CheckedChanged += new System.EventHandler(this.checkBoxAns_CheckedChanged);
            // 
            // checkBoxMois
            // 
            this.checkBoxMois.AutoSize = true;
            this.checkBoxMois.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.checkBoxMois.ForeColor = System.Drawing.Color.White;
            this.checkBoxMois.Location = new System.Drawing.Point(31, 99);
            this.checkBoxMois.Name = "checkBoxMois";
            this.checkBoxMois.Size = new System.Drawing.Size(54, 21);
            this.checkBoxMois.TabIndex = 13;
            this.checkBoxMois.Text = "Mois";
            this.checkBoxMois.UseVisualStyleBackColor = true;
            this.checkBoxMois.CheckedChanged += new System.EventHandler(this.checkBoxAns_CheckedChanged);
            // 
            // checkBoxJour
            // 
            this.checkBoxJour.AutoSize = true;
            this.checkBoxJour.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.checkBoxJour.ForeColor = System.Drawing.Color.White;
            this.checkBoxJour.Location = new System.Drawing.Point(31, 72);
            this.checkBoxJour.Name = "checkBoxJour";
            this.checkBoxJour.Size = new System.Drawing.Size(52, 21);
            this.checkBoxJour.TabIndex = 12;
            this.checkBoxJour.Text = "Jour";
            this.checkBoxJour.UseVisualStyleBackColor = true;
            this.checkBoxJour.CheckedChanged += new System.EventHandler(this.checkBoxAns_CheckedChanged);
            // 
            // numericUpDownJour
            // 
            this.numericUpDownJour.Location = new System.Drawing.Point(130, 150);
            this.numericUpDownJour.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownJour.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownJour.Name = "numericUpDownJour";
            this.numericUpDownJour.Size = new System.Drawing.Size(67, 20);
            this.numericUpDownJour.TabIndex = 11;
            this.numericUpDownJour.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(203, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "jours ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Suppression de Contenu Chaque :";
            // 
            // SettingsLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 232);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Paramètres Log ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SettingsLog_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonImprimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.CheckBox checkBoxAns;
        private System.Windows.Forms.CheckBox checkBoxMois;
        private System.Windows.Forms.CheckBox checkBoxJour;
        private System.Windows.Forms.NumericUpDown numericUpDownJour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxCustom;
    }
}