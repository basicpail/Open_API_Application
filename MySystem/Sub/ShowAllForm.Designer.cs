namespace MySystem
{
    partial class ShowAllForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BtlShow = new MetroFramework.Controls.MetroButton();
            this.DgvSearchItems = new System.Windows.Forms.DataGridView();
            this.BtnBack = new MetroFramework.Controls.MetroButton();
            this.pkNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jibunAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doroAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oprt_fm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tponNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCdnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yCdnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchItems)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(12, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 539);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.BtnBack);
            this.splitContainer1.Panel1.Controls.Add(this.BtlShow);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DgvSearchItems);
            this.splitContainer1.Size = new System.Drawing.Size(1028, 539);
            this.splitContainer1.SplitterDistance = 35;
            this.splitContainer1.TabIndex = 0;
            // 
            // BtlShow
            // 
            this.BtlShow.Location = new System.Drawing.Point(734, 2);
            this.BtlShow.Name = "BtlShow";
            this.BtlShow.Size = new System.Drawing.Size(116, 31);
            this.BtlShow.TabIndex = 0;
            this.BtlShow.Text = "주차장 보기";
            this.BtlShow.Click += new System.EventHandler(this.BtlShow_Click);
            // 
            // DgvSearchItems
            // 
            this.DgvSearchItems.AllowUserToAddRows = false;
            this.DgvSearchItems.AllowUserToDeleteRows = false;
            this.DgvSearchItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvSearchItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkNam,
            this.jibunAddr,
            this.doroAddr,
            this.oprt_fm,
            this.tponNum,
            this.xCdnt,
            this.yCdnt});
            this.DgvSearchItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvSearchItems.Location = new System.Drawing.Point(0, 0);
            this.DgvSearchItems.Name = "DgvSearchItems";
            this.DgvSearchItems.RowTemplate.Height = 23;
            this.DgvSearchItems.Size = new System.Drawing.Size(1028, 500);
            this.DgvSearchItems.TabIndex = 1;
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(856, 3);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(100, 29);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Text = "뒤로가기";
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // pkNam
            // 
            this.pkNam.HeaderText = "주차장명";
            this.pkNam.Name = "pkNam";
            // 
            // jibunAddr
            // 
            this.jibunAddr.FillWeight = 120F;
            this.jibunAddr.HeaderText = "지번주소";
            this.jibunAddr.Name = "jibunAddr";
            this.jibunAddr.Width = 150;
            // 
            // doroAddr
            // 
            this.doroAddr.FillWeight = 120F;
            this.doroAddr.HeaderText = "도로명 주소";
            this.doroAddr.Name = "doroAddr";
            this.doroAddr.Width = 150;
            // 
            // oprt_fm
            // 
            this.oprt_fm.FillWeight = 110F;
            this.oprt_fm.HeaderText = "운영형태";
            this.oprt_fm.Name = "oprt_fm";
            this.oprt_fm.Width = 110;
            // 
            // tponNum
            // 
            this.tponNum.FillWeight = 120F;
            this.tponNum.HeaderText = "전화번호";
            this.tponNum.Name = "tponNum";
            this.tponNum.Width = 120;
            // 
            // xCdnt
            // 
            this.xCdnt.FillWeight = 110F;
            this.xCdnt.HeaderText = "위도";
            this.xCdnt.Name = "xCdnt";
            this.xCdnt.Width = 160;
            // 
            // yCdnt
            // 
            this.yCdnt.FillWeight = 110F;
            this.yCdnt.HeaderText = "경도";
            this.yCdnt.Name = "yCdnt";
            this.yCdnt.Width = 160;
            // 
            // ShowAllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 625);
            this.Controls.Add(this.panel1);
            this.Name = "ShowAllForm";
            this.Text = "모든 주차장 보기";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton BtlShow;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView DgvSearchItems;
        private MetroFramework.Controls.MetroButton BtnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn jibunAddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn doroAddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn oprt_fm;
        private System.Windows.Forms.DataGridViewTextBoxColumn tponNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCdnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn yCdnt;
    }
}

