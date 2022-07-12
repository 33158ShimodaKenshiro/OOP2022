using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {


        }

        
            private void btAdd_Click(object sender, EventArgs e) {
                //氏名が未入力なら登録しない
                if (String.IsNullOrWhiteSpace(cbName.Text)) {
                    MessageBox.Show("氏名が入力されていません");
                    return;
                }
            }

        private void pbPicture_Click(object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
            }
        }

       
            private void btOpen_Click(object sender, EventArgs e) {
                if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                    try {
                        //バイナリ形式で逆シリアル化
                        var bf = new BinaryFormatter();
                        using (FileStream fs = File.Open(ofdFileOpenDialog.FileName, FileMode.Open, FileAccess.Read)) {
                        }
    }
    }
}
