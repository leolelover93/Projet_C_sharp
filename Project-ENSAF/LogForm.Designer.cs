
namespace Project_ENSAF
{
    partial class LogForm
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnEnregister = new System.Windows.Forms.Button();
            this.buttonImprimer = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.panelHeader.Controls.Add(this.buttonImprimer);
            this.panelHeader.Controls.Add(this.btnEnregister);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(726, 139);
            this.panelHeader.TabIndex = 8;
            // 
            // btnEnregister
            // 
            this.btnEnregister.BackColor = System.Drawing.Color.White;
            this.btnEnregister.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEnregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregister.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btnEnregister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnEnregister.Location = new System.Drawing.Point(0, 0);
            this.btnEnregister.Name = "btnEnregister";
            this.btnEnregister.Size = new System.Drawing.Size(379, 139);
            this.btnEnregister.TabIndex = 2;
            this.btnEnregister.Text = "Enregistrer ";
            this.btnEnregister.UseVisualStyleBackColor = false;
            this.btnEnregister.Click += new System.EventHandler(this.btnEnregister_Click);
            // 
            // buttonImprimer
            // 
            this.buttonImprimer.BackColor = System.Drawing.Color.White;
            this.buttonImprimer.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonImprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImprimer.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.buttonImprimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.buttonImprimer.Location = new System.Drawing.Point(385, 0);
            this.buttonImprimer.Name = "buttonImprimer";
            this.buttonImprimer.Size = new System.Drawing.Size(341, 139);
            this.buttonImprimer.TabIndex = 3;
            this.buttonImprimer.Text = "Imprimer";
            this.buttonImprimer.UseVisualStyleBackColor = false;
            this.buttonImprimer.Click += new System.EventHandler(this.buttonImprimer_Click);
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(726, 139);
            this.Controls.Add(this.panelHeader);
            this.MaximumSize = new System.Drawing.Size(742, 178);
            this.Name = "LogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mangment Fichier de Log";
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnEnregister;
        private System.Windows.Forms.Button buttonImprimer;
    }
}