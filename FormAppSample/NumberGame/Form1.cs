using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGame {
    public partial class Form1 : Form {

        private Random rand = new Random(); //乱数オブジェクト生成

        //乱数
        private int randomNumber;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            //乱数取得
            getRandom();

        }

        private void NewMethod() {
            randomNumber = rand.Next(1, (int.MaxValue));
            this.Text = randomNumber.ToString();
        }

        private void button1_Click(object sender, EventArgs e) {

            

            //入力した値とあらかじめ取得した乱数を比較し結果を表示

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
            getRandom();
        }

        private void getRandom() {
            randomNumber = rand.Next(1, int.MaxValue);
            this.Text = randomNumber.ToString();
        }

       
    }
}
