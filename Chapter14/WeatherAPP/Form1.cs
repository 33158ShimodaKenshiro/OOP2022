using Newtonsoft.Json;
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

namespace WeatherAPP {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        WebClient wc = new WebClient() {


            Encoding = Encoding.UTF8
        };

        

        private void btWeatherGet_Click(object sender, EventArgs e) {

            try {
                var dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/011000.json ");
                var json = JsonConvert.DeserializeObject<Rootobject>(dString);
                var json1 = JsonConvert.DeserializeObject<Class1[]>(dString);




                tbWeather.Text = json1[0].timeSeries[0].areas[0].weathers[0];
                tbWeather2.Text = json1[0].timeSeries[0].areas[0].weathers[1];
                tbWeather3.Text = json1[0].timeSeries[0].areas[0].weathers[2];
            }
            catch (Exception) {

                
            }
            




            

            

            

            


        }

        private void Form1_Load(object sender, EventArgs e) {
            cbTihou.Items.Add("宗谷地方");
            cbTihou.Items.Add("上川・留萌地方");
            cbTihou.Items.Add("網走・北見・紋別地方");
            cbTihou.Items.Add("十勝地方");
            cbTihou.Items.Add("釧路・根室地方");
            cbTihou.Items.Add("胆振・日高地方");
            cbTihou.Items.Add("石狩・空知・後志地方");
            cbTihou.Items.Add("渡島・檜山地方");
            cbTihou.Items.Add("青森県");
            cbTihou.Items.Add("岩手県");
            cbTihou.Items.Add("宮城県");
            cbTihou.Items.Add("秋田県");
            cbTihou.Items.Add("山形県");
            cbTihou.Items.Add("福島県");
            cbTihou.Items.Add("茨城県");
            cbTihou.Items.Add("栃木県");
            cbTihou.Items.Add("群馬県");
            cbTihou.Items.Add("埼玉県");
            cbTihou.Items.Add("千葉県");
            cbTihou.Items.Add("東京都");
            cbTihou.Items.Add("神奈川県");
            cbTihou.Items.Add("山梨県");
            cbTihou.Items.Add("長野県");
            cbTihou.Items.Add("岐阜県");
            cbTihou.Items.Add("静岡県");
            cbTihou.Items.Add("愛知県");
            cbTihou.Items.Add("三重県");
            cbTihou.Items.Add("新潟県");
            cbTihou.Items.Add("富山県");
            cbTihou.Items.Add("石川県");
            cbTihou.Items.Add("福井県");
            cbTihou.Items.Add("滋賀県");
            cbTihou.Items.Add("京都府");
            cbTihou.Items.Add("大阪府");
            cbTihou.Items.Add("兵庫県");
            cbTihou.Items.Add("奈良県");
            cbTihou.Items.Add("和歌山県");
            cbTihou.Items.Add("鳥取県");
            cbTihou.Items.Add("島根県");
            cbTihou.Items.Add("岡山県");
            cbTihou.Items.Add("広島県");
            cbTihou.Items.Add("徳島県");
            cbTihou.Items.Add("香川県");
            cbTihou.Items.Add("愛媛県");
            cbTihou.Items.Add("高知県");
            cbTihou.Items.Add("山口県");
            cbTihou.Items.Add("福岡県");
            cbTihou.Items.Add("佐賀県");
            cbTihou.Items.Add("長崎県");
            cbTihou.Items.Add("熊本県");
            cbTihou.Items.Add("大分県");
            cbTihou.Items.Add("宮崎県");
            cbTihou.Items.Add("奄美地方");
            cbTihou.Items.Add("鹿児島県");
            cbTihou.Items.Add("沖縄本島地方");
            cbTihou.Items.Add("大東島地方");
            cbTihou.Items.Add("宮古島地方");
            cbTihou.Items.Add("八重山地方");
            



            
        }

        

       

        private void cbTihou_SelectedIndexChanged(object sender, EventArgs e) {

            btWeatherGet.Enabled = true;
            int index = cbTihou.SelectedIndex;
            switch (index) {
                case 0:
                    var dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/011000.json ");
                    var cString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/011000.json ");


                    var json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    var json1 = JsonConvert.DeserializeObject<Class1[]>(cString);


                    tbWeatherinfo.Text = json.text;
                    tbWeather.Text = json1[0].timeSeries[0].areas[0].weathers[0];
                    tbWeather2.Text = json1[0].timeSeries[0].areas[0].weathers[1];
                    tbWeather3.Text = json1[0].timeSeries[0].areas[0].weathers[2];




                    break;
                case 1:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/012000.json ");
                    cString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/011000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    json1 = JsonConvert.DeserializeObject<Class1[]>(cString);


                    tbWeatherinfo.Text = json.text;
                    
                    break;
                case 2:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/013000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 3:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/014030.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 4:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/014100.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 5:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/015000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 6:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/016000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 7:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/017000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 8:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/020000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 9:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/030000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 10:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/040000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 11:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/050000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 12:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/060000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 13:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/070000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 14:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/080000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 15:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/090000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 16:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/100000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 17:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/110000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 18:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/120000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 19:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/130000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 20:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/140000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 21:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/190000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 22:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/200000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 23:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/210000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 24:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/220000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 25:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/230000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 26:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/240000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 27:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/150000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 28:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/160000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 29:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/170000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 30:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/180000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 31:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/250000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 32:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/260000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 33:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/270000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 34:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/280000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 35:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/290000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 36:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/300000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 37:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/310000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 38:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/320000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 39:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/330000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 40:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/340000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 41:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/360000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 42:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/370000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 43:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/380000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 44:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/390000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 45:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/350000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 46:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/400000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 47:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/410000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 48:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/420000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 49:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/430000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 50:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/440000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 51:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/450000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 52:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/460040.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 53:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/460100.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 54:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/471000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 55:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/472000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
                case 56:
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/473000.json ");
                    json = JsonConvert.DeserializeObject<Rootobject>(dString);
                    tbWeatherinfo.Text = json.text;
                    break;
               


            }

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void tbWeatherinfo_TextChanged(object sender, EventArgs e) {

        }
    }

}

