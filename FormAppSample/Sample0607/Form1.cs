using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0607 {
    public partial class Form1 : Form {

        Random rand = new Random();
        //コンストラクタ
        public Form1() {
            InitializeComponent();
        }

      
        private void button1_Click_1(object sender, EventArgs e) {

            Number.Value = rand.Next(minValue: (int)int.MaxValue,maxValue: (int)int.MinValue);

           

        }
        //イベントハンドラ(起動時に一度だけ実行）
        private void Form1_Load(object sender, EventArgs e) {

        }

       
        }
    }

