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
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {
        IEnumerable<string> xTitle, xLink;
        public Form1() {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void btRssGet_Click(object sender, EventArgs e) {
            using (var wc = new WebClient()) {


                var stream = wc.OpenRead(cbRssUrl.Text);

                var xdoc = XDocument.Load(stream);
                var xTitle = xdoc.Root.Descendants("item").Select(x => (string)x.Element("title"));
                var xLink = xdoc .Descendants("item").Select(x => (string)x.Element("link"));
                foreach (var data in xTitle) {


                    lbRssTitle.Items.Add(data);

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e) {

            btBack.Enabled = wvBrowser.CanGoBack;
            btFoward.Enabled = wvBrowser.CanGoForward;

        }

        private void wbBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {

        }

        private void Forward_Click(object sender, EventArgs e) {
            wbBrowser.GoForward();
        }

       

        private void btBack_Click(object sender, EventArgs e) {
            wbBrowser.GoBack();
        }

        private void wvBrowser_NavigationCompleted(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationCompletedEventArgs e) {
            btBack.Enabled = wvBrowser.CanGoBack;
            btFoward.Enabled = wvBrowser.CanGoForward;
        }

        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {


            int index = lbRssTitle.SelectedIndex; //選択した箇所のインデックスを取得(0～ )
            var url = xLink.ElementAt(index);
            // wbBrowser.Navigate(url);
            // webView1.Sourse
            wvBrowser.Source = new Uri(url);
           




        }
    }
}
