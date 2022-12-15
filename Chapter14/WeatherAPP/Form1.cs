using Newtonsoft.Json;
using System;
using System.Net;
using System.Text;
using System.Windows.Forms;
using WeatherApp;

namespace WeatherApp {
    public partial class Form1 : Form {
        public Form1() {

            InitializeComponent();

        }

        private void btGetWeather_Click(object sender, EventArgs e) {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            var dString1 = " ";
            var dString2 = " ";

            switch (cbTihou.SelectedItem) {
                case "宗谷地方":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/011000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/011000.json");
                    break;
                case "上川・留萌地方":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/012000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/012000.json");
                    break;
                case "網走・北見・紋別地方":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/013000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/013000.json");
                    break;
                case "十勝地方":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/013000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/013000.json");
                    break;
                case "釧路・根室地方":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/014100.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/014100.json");
                    break;
                case "胆振・日高地方":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/015000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/015000.json");
                    break;
                case "石狩・空知・後志地方":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/016000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/016000.json");
                    break;
                case "渡島・檜山地方":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/017000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/017000.json");
                    break;
                case "青森県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/020000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/020000.json");
                    break;
                case "岩手県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/030000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/030000.json");
                    break;
                case "宮城県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/040000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/040000.json");
                    break;
                case "秋田県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/050000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/050000.json");
                    break;
                case "山形県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/060000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/060000.json");
                    break;
                case "福島県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/070000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/070000.json");
                    break;
                case "茨城県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/080000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/080000.json");
                    break;
                case "栃木県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/090000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/090000.json");
                    break;
                case "群馬県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/100000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/100000.json");
                    break;
                case "埼玉県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/110000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/110000.json");
                    break;
                case "千葉県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/120000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/120000.json");
                    break;
                case "東京都":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/130000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/130000.json");
                    break;
                case "神奈川県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/140000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/140000.json");
                    break;
                case "新潟県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/150000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/150000.json");
                    break;
                case "富山県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/160000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/160000.json");
                    break;
                case "石川県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/170000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/170000.json");
                    break;
                case "福井県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/180000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/180000.json");
                    break;
                case "山梨県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/190000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/190000.json");
                    break;
                case "長野県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/200000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/200000.json");
                    break;
                case "岐阜県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/210000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/210000.json");
                    break;
                case "静岡県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/220000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/220000.json");
                    break;
                case "愛知県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/230000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/230000.json");
                    break;
                case "三重県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/240000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/240000.json");
                    break;
                case "滋賀県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/250000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/250000.json");
                    break;
                case "京都府":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/260000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/260000.json");
                    break;
                case "大阪府":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/270000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/270000.json");
                    break;
                case "兵庫県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/280000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/280000.json");
                    break;
                case "奈良県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/290000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/290000.json");
                    break;
                case "和歌山県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/300000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/300000.json");
                    break;
                case "佐賀県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/410000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/410000.json");
                    break;
                case "鳥取県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/310000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/310000.json");
                    break;
                case "島根県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/320000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/320000.json");
                    break;
                case "岡山県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/330000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/330000.json");
                    break;
                case "広島県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/340000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/340000.json");
                    break;
                case "山口県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/350000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/350000.json");
                    break;
                case "徳島県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/360000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/360000.json");
                    break;
                case "香川県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/370000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/370000.json");
                    break;
                case "愛媛県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/380000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/380000.json");
                    break;
                case "高知県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/390000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/390000.json");
                    break;
                case "福岡県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/400000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/400000.json");
                    break;

                case "長崎県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/420000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/420000.json");
                    break;
                case "熊本県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/430000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/430000.json");
                    break;
                case "大分県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/440000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/440000.json");
                    break;
                case "宮崎県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/450000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/450000.json");
                    break;
                case "鹿児島県":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/460100.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/460100.json");
                    break;
                default:
                    break;
                case "沖縄本島地方":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/471000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/471000.json");
                    break;
                case "大東島地方":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/472000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/472000.json");
                    break;
                case "宮古島地方":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/473000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/473000.json");
                    break;
                case "八重山地方":
                    dString1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/474000.json");
                    dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/474000.json");
                    break;
            }





            var json1 = JsonConvert.DeserializeObject<Rootobject>(dString1);
            var json2 = JsonConvert.DeserializeObject<Class1[]>(dString2);

           


            if (json1 == null) {
                tbWeatherinfo.Text = "地域を選択してください。";
            }
            else {


                tbWeatherinfo.Text = json1.text; 
                DateTime today = DateTime.Today;
                label2.Text = (today.Month.ToString() + "/" + today.Day.ToString());
                DateTime tomorrow = DateTime.Today.AddDays(1);
                label3.Text = (tomorrow.Month.ToString() + "/" + tomorrow.Day.ToString());
                DateTime dayaftertomorrow = DateTime.Today.AddDays(2);
                label4.Text = (dayaftertomorrow.Month.ToString() + "/" + dayaftertomorrow.Day.ToString());
                DateTime now = DateTime.Now;
                tbWeather1.Text = json2[0].timeSeries[0].areas[0].weathers[0];
                tbWeather2.Text = json2[0].timeSeries[0].areas[0].weathers[1];
                tbWeather3.Text = json2[0].timeSeries[0].areas[0].weathers[2];
                pbTenki1.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + json2[0].timeSeries[0].areas[0].weatherCodes[0] + ".png";
                pbTenki2.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + json2[0].timeSeries[0].areas[0].weatherCodes[1] + ".png";
                pbTenki3.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + json2[0].timeSeries[0].areas[0].weatherCodes[2] + ".png";

            }


        }



        private void Form1_Load(object sender, EventArgs e) {

            



            this.Text = "天気情報";
          
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

      
        
    }
}
