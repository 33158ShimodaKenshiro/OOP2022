
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System;
using static CarReportSystem.CarReport;

namespace CarReportSystem {
    public partial class Form1 : Form {

        //設定情報保存用オブジェクト
        Settings settings = Settings.getInstance();

        //住所データ管理用リスト
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            //dgv.DataSource = listCarReport;
        }

        private void btOpen2(object sender, EventArgs e) {


            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
            }
        }
        //終了コマンド
        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }



        private void btAddPerson_Click(object sender, EventArgs e) {

        }


        public void setCbRecorder(string Recorder) {
            if (!cbRecorder.Items.Contains(Recorder)) {
                //まだ登録されていなければ登録処理
                cbRecorder.Items.Add(Recorder);

            }
        }

        //コンボボックスに車種名を登録する（重複なし）
        private void setCbCarName(string CarName) {
            if (!cbCarName.Items.Contains(CarName)) {
                //まだ登録されていなければ登録処理
                cbCarName.Items.Add(CarName);

            }
        }

        
        //ラジオボックスにセットされている値をリストとして取り出す

        private string GetRadioButton() {
            var selectedKindNumber = "その他";

            if (rbSubaru.Checked) {
                selectedKindNumber = "スバル";
            }
            if (rbToyota.Checked) {
                selectedKindNumber = "トヨタ";
            }
            if (rbNissan.Checked) {
                selectedKindNumber = "日産";
            }
            if (rbHonda.Checked) {
                selectedKindNumber = "ホンダ";
            }
            if (rbForeign.Checked) {
                selectedKindNumber = "外国車";
            }
            return selectedKindNumber = "その他";
        }


        //データグリッドビューをクリックした時のイベントハンドラ
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            //if (dgv.CurrentRow == null) return;

            //int index = dgv.CurrentRow.Index;


            //cbRecorder.Text = listCarReport[index].Auther;
            //cbCarName.Text = listCarReport[index].CarName;
            //tbReport.Text = listCarReport[index].Report;
            //pbPicture.Image = listCarReport[index].Picture;

            //groupCheckBoxAllClear(); //グループチェックボックスを一旦初期化

            //GetCarMaker(index);

        }

        private void GetCarMaker() {

            if ((string)carReportDBDataGridView.CurrentRow.Cells[3].Value == "トヨタ" ){
                rbToyota.Checked = true;
            }
            if ((string)carReportDBDataGridView.CurrentRow.Cells[3].Value == "日産") {
                rbNissan.Checked = true;
            }
            if ((string)carReportDBDataGridView.CurrentRow.Cells[3].Value == "ホンダ") {
                rbHonda.Checked = true;
            }
            if ((string)carReportDBDataGridView.CurrentRow.Cells[3].Value == "スバル") {
                rbSubaru.Checked = true;
            }
            if ((string)carReportDBDataGridView.CurrentRow.Cells[3].Value == "外車") {
                rbForeign.Checked = true;
            }
            if ((string)carReportDBDataGridView.CurrentRow.Cells[3].Value == "その他") {
                rbEtc.Checked = true;
            }
        }

        private void groupCheckBoxAllClear() {
            rbEtc.Checked = rbForeign.Checked = rbHonda.Checked = rbNissan.Checked = rbSubaru.Checked = rbToyota.Checked = false;
        }

        //更新ボタンが押された時の処理
        private void btUpdate_Click(object sender, EventArgs e) {
           // listCarReport[dgv.CurrentRow.Index].Date = dtpDate.Value;
           // listCarReport[dgv.CurrentRow.Index].Auther = cbRecorder.Text;
            // listCarReport[dgv.CurrentRow.Index].Maker = GetRadioButton();
            //listCarReport[dgv.CurrentRow.Index].CarName = cbCarName.Text;
           // listCarReport[dgv.CurrentRow.Index].Report = tbReport.Text;
           // listCarReport[dgv.CurrentRow.Index].Picture = pbPicture.Image;

            //dgv.Refresh(); //データグリッドビュー更新
        }
        //削除ボタンが押された時の処理
        private void btDelete_Click(object sender, EventArgs e) {
            //DialogResult result = MessageBox.Show(
            //"本当に削除しますか？", "確認",
            //MessageBoxButtons.YesNo, // ボタンの設定
            //MessageBoxIcon.Question); // アイコンの設定

            //if (result == DialogResult.Yes) {
            //    MessageBox.Show("[はい] が選択されました。", "結果");
            //}
            //else if (result == DialogResult.No) {
            //    MessageBox.Show("[いいえ] が選択されました。", "結果");
            //}

            DataGridViewSelectedRowCollection src = carReportDBDataGridView.SelectedRows;
            for (int i = src.Count - 1; i >= 0; i--) {
                carReportDBDataGridView.Rows.RemoveAt(src[i].Index);
            }

            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.infosys202213DataSet1);

            //listCarReport.RemoveAt(dgv.CurrentRow.Index);
            //if (listCarReport.Count() == 0) {
            //    btDelete.Enabled = false; //削除ボタンをマスク
            //    btRevision.Enabled = false; //更新ボタンをマスク

            //}
        }


        //更新・削除ボタンのマスク処理行う（マスク判定含む）
        private void EnabledCheck() {
            //btRevision.Enabled = btDelete.Enabled = listCarReport.Count() > 0 ? true : false;
        }

        private void btPictureClear_Click_1(object sender, EventArgs e) {
            pbPicture.Image = null;
        }



        private void btSave_Click(object sender, EventArgs e) {


            if (sfdSaveDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(sfdSaveDialog.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listCarReport);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btOpen_Click(object sender, EventArgs e) {

            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式で逆シリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(ofdFileOpenDialog.FileName, FileMode.Open, FileAccess.Read)) {
                        //逆シリアル化して読み込む
                        listCarReport = (BindingList<CarReport>)bf.Deserialize(fs);
                        //dgv.DataSource = null;
                       // dgv.DataSource = listCarReport;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                cbCarName.Items.Clear(); //コンボボックスのアイテム消去
                                         //コンボボックスへ新規登録
                foreach (var item in listCarReport.Select(p => p.CarName)) {
                    setCbCarName(item); //存在する会社を登録
                }
            }
            EnabledCheck(); //マスク処理呼び出し
        }

        private void tsMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }

        private void btAdd_Click(object sender, EventArgs e) {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            //設定ファイルをシリアル化

            using (var writer = XmlWriter.Create("Settings.xml")) {
                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(writer, settings);

            }

            
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e) {
            //try {
            //    using (var reader = XmlReader.Create("Settings.xml")) {
            //        var serializer = new XmlSerializer(typeof(Settings));
            //        settings = serializer.Deserialize(reader) as Settings;
            //        BackColor = Color.FromArgb(settings.MainFormColor);
            //    }

            //}
            //catch (Exception) {

            //}
            //finally {
            //    EnabledCheck();//マスク処理呼び出し

            //}


        }

        private void Form1_Load(object sender, EventArgs e) {
            //設定ファイルを逆シリアル化 307
            try {
                using (var reader = XmlReader.Create("Settings.xml")) {
                    var serializer = new XmlSerializer(typeof(Settings));
                    settings = serializer.Deserialize(reader) as Settings;
                    BackColor = Color.FromArgb(settings.MainFormColor);
                }
            }
            catch (Exception) {
            }

            //EnabledCheck();

            //btDBAdd.Enabled = btUpDate.Enabled = true;


        }

        private void dgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e) {

        }

        private void tbReport_TextChanged(object sender, EventArgs e) {

        }

        private void aaToolStripMenuItem_Click(object sender, EventArgs e) {
            //色設定ダイアログの表示
            if (cdColorSelect.ShowDialog() == DialogResult.OK) {
                BackColor = cdColorSelect.Color;
                settings.MainFormColor = cdColorSelect.Color.ToArgb();//;cdColorSelect.Color;   //設定オブジェクトへセット
            }
        }

        private void dgv_CellContentClick_2(object sender, DataGridViewCellEventArgs e) {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void データベース接続ToolStripMenuItem_Click(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202213DataSet.AddressTable' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportDBTableAdapter1.Fill(this.infosys202213DataSet1.CarReportDB);

            for (int i = 0; i < carReportDBDataGridView.RowCount; i++) {
                setCbRecorder(carReportDBDataGridView.Rows[i].Cells[2].Value.ToString());
                setCbCarName(carReportDBDataGridView.Rows[i].Cells[4].Value.ToString());
            }
            btUpDate.Enabled = true;
            btDBAdd.Enabled = true;
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e) {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e) {

        }

        private void carReportDBBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.infosys202213DataSet1);

        }

        private void carReportDBDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void btUpDate_Click(object sender, EventArgs e) {

            if (carReportDBDataGridView.CurrentRow == null) {
                return;
            }

            carReportDBDataGridView.CurrentRow.Cells[1].Value = dtpDate.Text;
            carReportDBDataGridView.CurrentRow.Cells[2].Value = cbRecorder.Text;
            carReportDBDataGridView.CurrentRow.Cells[3].Value = GetRadioButton();
            carReportDBDataGridView.CurrentRow.Cells[4].Value = cbCarName.Text;
            carReportDBDataGridView.CurrentRow.Cells[5].Value = tbReport.Text;
            carReportDBDataGridView.CurrentRow.Cells[6].Value = ImageToByteArray(pbPicture.Image);

            //データセットの中をデータベースへ反映（保存）
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.infosys202213DataSet1);
        }

        private void btDBAdd_Click(object sender, EventArgs e) {
            DataRow newRow = infosys202213DataSet1.CarReportDB.NewRow();
            newRow[1] = dtpDate.Text;
            newRow[2] = cbRecorder.Text;
            newRow[3] = GetRadioButton();
            newRow[4] = cbCarName.Text;
            newRow[5] = tbReport.Text;
            newRow[6] = ImageToByteArray(pbPicture.Image);

            infosys202213DataSet1.CarReportDB.Rows.Add(newRow);

            this.carReportDBTableAdapter1.Update(this.infosys202213DataSet1.CarReportDB);

            setCbRecorder(cbRecorder.Text);
            setCbCarName(cbCarName.Text);
        }
        private void carReportDBDateGridView_Click(object sender, EventArgs e) {

        }

        private void cbRecorder_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void dtpDateTime_ValueChanged(object sender, EventArgs e) {

        }

        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b) {
            try {
                ImageConverter imgconv = new ImageConverter();
                Image img = (Image)imgconv.ConvertFrom(b);
                return img;
            }
            catch (Exception) {
                return null;
            }        
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }
        //エラー回避
        private void carReportDBDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) {

        }

        private void btClear_Click(object sender, EventArgs e) {
            groupCheckBoxAllClear();
            dtpDate.Text = null;
            cbRecorder.Text = null;
            cbCarName.Text = null;
            tbReport.Text = null;
        }

        private void carReportDBDataGridView_Click(object sender, EventArgs e) {
            if (carReportDBDataGridView.CurrentRow == null)
                return;


            dtpDate.Text = carReportDBDataGridView.CurrentRow.Cells[1].Value.ToString();
            cbRecorder.Text = carReportDBDataGridView.CurrentRow.Cells[2].Value.ToString();
            groupCheckBoxAllClear();
            
            cbCarName.Text = carReportDBDataGridView.CurrentRow.Cells[4].Value.ToString();
            tbReport.Text = carReportDBDataGridView.CurrentRow.Cells[5].Value.ToString();
            //画像表示処理
            if (!(carReportDBDataGridView.CurrentRow.Cells[6].Value is DBNull))
                pbPicture.Image = ByteArrayToImage((byte[])carReportDBDataGridView.CurrentRow.Cells[6].Value);
            else
                pbPicture.Image = null;

        }
    }
}
    


