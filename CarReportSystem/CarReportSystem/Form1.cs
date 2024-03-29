﻿
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

namespace CarReportSystem {
    public partial class Form1 : Form {

        //設定情報保存用オブジェクト
        Settings settings = Settings.getInstance();

        //住所データ管理用リスト
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgv.DataSource = listCarReport;
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

            //氏名が未入力なら登録しない
            if (String.IsNullOrWhiteSpace(cbRecorder.Text)) {
                MessageBox.Show("記録者が入力されていません");
                return;
            }

            CarReport newCarReport = new CarReport {
                Date = dtpDate.Value,
                Auther = cbRecorder.Text,
                Maker = GetRadioButton(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image,
            };
            listCarReport.Add(newCarReport);
            dgv.Rows[dgv.RowCount - 1].Selected = true;

            EnabledCheck(); //マスク処理呼び出し

            setCbCarName(cbCarName.Text);
        }


        //コンボボックスに車種名を登録する（重複なし）
        private void setCbCarName(string CarName) {
            if (!cbCarName.Items.Contains(CarName)) {
                //まだ登録されていなければ登録処理
                cbCarName.Items.Add(CarName);

            }
        }

        //ラジオボックスにセットされている値をリストとして取り出す

        private CarReport.MakerGroup GetRadioButton() {
            var selectedKindNumber = CarReport.MakerGroup.その他;

            if (rbSubaru.Checked) {
                selectedKindNumber = CarReport.MakerGroup.スバル;
            }
            if (rbToyota.Checked) {
                selectedKindNumber = CarReport.MakerGroup.トヨタ;
            }
            if (rbNissan.Checked) {
                selectedKindNumber = CarReport.MakerGroup.日産;
            }
            if (rbHonda.Checked) {
                selectedKindNumber = CarReport.MakerGroup.ホンダ;
            }
            if (rbForeign.Checked) {
                selectedKindNumber = CarReport.MakerGroup.外国車;
            }
            return selectedKindNumber;
        }


        //データグリッドビューをクリックした時のイベントハンドラ
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (dgv.CurrentRow == null) return;

            int index = dgv.CurrentRow.Index;


            cbRecorder.Text = listCarReport[index].Auther;
            cbCarName.Text = listCarReport[index].CarName;
            tbReport.Text = listCarReport[index].Report;
            pbPicture.Image = listCarReport[index].Picture;

            groupCheckBoxAllClear(); //グループチェックボックスを一旦初期化

            GetCarMaker(index);

        }

        private void GetCarMaker(int index) {
            switch (listCarReport[index].Maker) {
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.その他:
                    rbEtc.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void groupCheckBoxAllClear() {
            rbEtc.Checked = rbForeign.Checked = rbHonda.Checked = rbNissan.Checked = rbSubaru.Checked = rbToyota.Checked = false;
        }

        //更新ボタンが押された時の処理
        private void btUpdate_Click(object sender, EventArgs e) {
            listCarReport[dgv.CurrentRow.Index].Date = dtpDate.Value;
            listCarReport[dgv.CurrentRow.Index].Auther = cbRecorder.Text;
            listCarReport[dgv.CurrentRow.Index].Maker = GetRadioButton();
            listCarReport[dgv.CurrentRow.Index].CarName = cbCarName.Text;
            listCarReport[dgv.CurrentRow.Index].Report = tbReport.Text;
            listCarReport[dgv.CurrentRow.Index].Picture = pbPicture.Image;

            dgv.Refresh(); //データグリッドビュー更新
        }
        //削除ボタンが押された時の処理
        private void btDelete_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show(
            "本当に削除しますか？", "確認",
            MessageBoxButtons.YesNo, // ボタンの設定
            MessageBoxIcon.Question); // アイコンの設定

            if (result == DialogResult.Yes) {
                MessageBox.Show("[はい] が選択されました。", "結果");
            }
            else if (result == DialogResult.No) {
                MessageBox.Show("[いいえ] が選択されました。", "結果");
            }

            listCarReport.RemoveAt(dgv.CurrentRow.Index);
            if (listCarReport.Count() == 0) {
                btDelete.Enabled = false; //削除ボタンをマスク
                btRevision.Enabled = false; //更新ボタンをマスク

            }
        }


        //更新・削除ボタンのマスク処理行う（マスク判定含む）
        private void EnabledCheck() {
            btRevision.Enabled = btDelete.Enabled = listCarReport.Count() > 0 ? true : false;
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
                        dgv.DataSource = null;
                        dgv.DataSource = listCarReport;
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

            using (var writer = XmlWriter.Create("settings.xml"))
            {
                var serializer = new XmlSerializer(settings.GetType()); 
                serializer.Serialize(writer, settings);
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e) {
            try 
                {
                using (var reader = XmlReader.Create("settings.xml")) {
                    var serializer = new XmlSerializer(typeof(Settings));
                    settings = serializer.Deserialize(reader) as Settings;
                    BackColor = Color.FromArgb(settings.MainFormColor);
                }

            }
            catch(Exception) 
            {

            }
            finally {
                EnabledCheck();//マスク処理呼び出し

            }
           

        }

        private void Form1_Load(object sender, EventArgs e) {
            //設定ファイルを逆シリアル化 307
            using (var reader = XmlReader.Create("settings.xml")) {
                var serializer = new XmlSerializer(typeof(Settings));
                settings = serializer.Deserialize(reader) as Settings;
                BackColor = Color.FromArgb(settings.MainFormColor);
            }
            EnabledCheck();
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

        private void cbRecorder_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void cbCarName_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
    }


