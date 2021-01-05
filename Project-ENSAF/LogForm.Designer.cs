
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogForm));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonImprimer = new System.Windows.Forms.Button();
            this.btnEnregister = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.panelHeader.Controls.Add(this.button3);
            this.panelHeader.Controls.Add(this.button2);
            this.panelHeader.Controls.Add(this.button1);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.listView1);
            this.panelHeader.Controls.Add(this.buttonImprimer);
            this.panelHeader.Controls.Add(this.btnEnregister);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(490, 445);
            this.panelHeader.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(366, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 26);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(421, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 24);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(390, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 26);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.label1.Location = new System.Drawing.Point(119, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Journalisation des activités";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.HideSelection = false;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(18, 36);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(454, 345);
            this.listView1.TabIndex = 4;
            this.listView1.TileSize = new System.Drawing.Size(168, 30);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Evénement";
            this.columnHeader1.Width = 500;
            // 
            // buttonImprimer
            // 
            this.buttonImprimer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonImprimer.BackColor = System.Drawing.Color.White;
            this.buttonImprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImprimer.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImprimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.buttonImprimer.Location = new System.Drawing.Point(257, 397);
            this.buttonImprimer.Name = "buttonImprimer";
            this.buttonImprimer.Size = new System.Drawing.Size(215, 36);
            this.buttonImprimer.TabIndex = 3;
            this.buttonImprimer.Text = "Imprimer";
            this.buttonImprimer.UseVisualStyleBackColor = false;
            this.buttonImprimer.Click += new System.EventHandler(this.buttonImprimer_Click);
            // 
            // btnEnregister
            // 
            this.btnEnregister.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEnregister.BackColor = System.Drawing.Color.White;
            this.btnEnregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregister.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnEnregister.Location = new System.Drawing.Point(18, 397);
            this.btnEnregister.Name = "btnEnregister";
            this.btnEnregister.Size = new System.Drawing.Size(208, 36);
            this.btnEnregister.TabIndex = 2;
            this.btnEnregister.Text = "Enregistrer ";
            this.btnEnregister.UseVisualStyleBackColor = false;
            this.btnEnregister.Click += new System.EventHandler(this.btnEnregister_Click);
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(490, 445);
            this.Controls.Add(this.panelHeader);
            this.Name = "LogForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Journalisation";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnEnregister;
        private System.Windows.Forms.Button buttonImprimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
