using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MySystem
{
    public partial class ShowAllForm : MetroForm
    {
        public ShowAllForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        

        private void TxtSearchItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) //enter누르면
            {
                BtlShow_Click(sender, new EventArgs());
            }
        }

        private void TxtSearchItem_Click(object sender, EventArgs e)
        {

        }

        private void DgvSearchItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void BtlShow_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient { Encoding = Encoding.UTF8 };
            XmlDocument doc = new XmlDocument();

            StringBuilder str = new StringBuilder();
        
            str.Append("http://apis.data.go.kr/6260000/BusanPblcPrkngInfoService/getPblcPrkngInfo"); //OpenApi 기본 주소
            str.Append("?ServiceKey=HT5y8I2UbypgQm8M5E3xjxPMoCRIgy0KfMqD4dp6rt2%2BWif9M8Tlqq02Bbk0vRFclOk6u0IwkOB6xI5OrRBIcA%3D%3D");// 인증키
            str.Append("&pageNo=2");//페이지 수
            str.Append("&numOfRows=300");//읽어올 데이터
            //str.Append("&violPlcNm="+ TxtSearchItem.Text);
            //str.Append("violPlcNm=");

            string xml = wc.DownloadString(str.ToString());
            doc.LoadXml(xml);

            XmlElement root = doc.DocumentElement;
            XmlNodeList items = doc.GetElementsByTagName("item");


            DgvSearchItems.Rows.Clear();

            try
            {
                foreach (XmlNode item in items)
                {
                    DgvSearchItems.Rows.Add(
                        item["pkNam"].InnerText,
                        item["doroAddr"].InnerText,
                        item["jibunAddr"].InnerText,
                        item["oprt_fm"].InnerText,
                        item["tponNum"].InnerText,
                        item["xCdnt"].InnerText,
                        item["yCdnt"].InnerText) ;
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"에러발생:{ex.Message}", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            DgvSearchItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }


        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;


            MainMenuForm main = new MainMenuForm();
            main.ShowDialog();
            main.Location = this.Location;

            this.Close();
        }
    }
}
