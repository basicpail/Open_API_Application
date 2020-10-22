namespace MySystem
{
    partial class MainMenuForm
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
            this.ShowAll = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowAll
            // 
            this.ShowAll.ForeColor = System.Drawing.SystemColors.Control;
            this.ShowAll.Location = new System.Drawing.Point(391, 147);
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(152, 82);
            this.ShowAll.Style = MetroFramework.MetroColorStyle.Purple;
            this.ShowAll.TabIndex = 0;
            this.ShowAll.Text = "모든 주차장보기";
            this.ShowAll.Click += new System.EventHandler(this.ShowAll_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.Location = new System.Drawing.Point(549, 147);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(106, 150);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile2.TabIndex = 1;
            this.metroTile2.Text = "주차장 검색";
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(79, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 203);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 460);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.ShowAll);
            this.Name = "MainMenuForm";
            this.Text = "주차장 검색";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile ShowAll;
        private MetroFramework.Controls.MetroTile metroTile2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}