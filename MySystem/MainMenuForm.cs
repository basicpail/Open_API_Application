using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySystem
{
    public partial class MainMenuForm : MetroForm
    {
        public MainMenuForm()
        {
            InitializeComponent();

            pictureBox1.Load(@"H:\DEV\StudyC#\StudyCSharp\StudyCSharp\MySystem\1.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            //Font = new Font(@"NanumGothic", 10, FontStyle.Regular);
            
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            ShowAllForm SearchItem = new ShowAllForm();
            SearchItem.Location = this.Location;
            SearchItem.ShowDialog();

            this.Close();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("준비중 입니다.","준비중",MessageBoxButtons.OK);
        }
    }
}
