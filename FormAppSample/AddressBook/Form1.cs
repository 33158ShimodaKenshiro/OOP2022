﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook {
    public partial class Form1 : Form {

        BindingList<Person> listPerson = new BindingList<Person>();
        public Form1() {
            InitializeComponent();
            dgvPersons.DataSource = listPerson;
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btPictureOpen_Click(object sender, EventArgs e) {


            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) ;
            {

                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
            }


        }

        private void tbName_TextChanged(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void btAddPerson_Click(object sender, EventArgs e) {

            Person newPerson = new Person {

                Name = tbName.Text,
                MailAddress = tbMailAddress.Text,
                Address = tbAddress.Text,
                Company = tbCompany.Text,
                Picture = pbPicture.Image,
                listGroup = GetCheckBoxGroup(),

            };
            listPerson.Add(newPerson);
            
        }

        //チェックボックスにセットされている値をリストとして取り出す
        private List<Person.GroupType> GetCheckBoxGroup() {
            var listGroup = new List<Person.GroupType>();
            if (cbFamily.Checked) {
                listGroup.Add(Person.GroupType.家族);
            }
            if (cbFriend.Checked) {
                listGroup.Add(Person.GroupType.友人);
            }
            if (cbWork.Checked) {
                listGroup.Add(Person.GroupType.仕事);
            }
            if (cbOther.Checked) {
                listGroup.Add(Person.GroupType.その他);
            }






            return listGroup;
        }

        private void pbPicture_Click(object sender, EventArgs e) {

            pbPicture.Image = null;


        }
        //データグリッドビューをクリックしたときのイベントハンドラ
        private void dgvPersons_Click(object sender, EventArgs e)
            {
            if (dgvPersons.CurrentRow == null) return;
            int index = dgvPersons.CurrentRow.Index;
            tbName.Text = listPerson[index].Name;
            tbMailAddress.Text = listPerson[index].MailAddress;
            tbAddress.Text = listPerson[index].Address;
            tbCompany.Text = listPerson[index].Company;
            pbPicture.Image = listPerson[index].Picture;

            groupCheckBoxAllClear();






            foreach (var group in listPerson[index].listGroup) 
                {
                switch (group) {
                    case Person.GroupType.家族:
                        cbFamily.Checked = true;
                        break;
                    case Person.GroupType.友人:
                        cbFriend.Checked = true;
                        break;
                    case Person.GroupType.仕事:
                        cbWork.Checked = true;
                        break;
                    case Person.GroupType.その他:
                        cbOther.Checked = true;
                        break;
                    default:
                        break;
                }



            }


           





        }

        private void groupCheckBoxAllClear() {
            cbFamily.Checked = cbFriend.Checked = cbWork.Checked = cbOther.Checked = false;

        }
        //更新ボタンが押されたときの処理
        private void btUpdate_Click(object sender, EventArgs e) {
            listPerson[dgvPersons.CurrentRow.Index].Name = tbName.Text;
            listPerson[dgvPersons.CurrentRow.Index].MailAddress = tbAddress.Text;
            listPerson[dgvPersons.CurrentRow.Index].Address = tbAddress.Text;
            listPerson[dgvPersons.CurrentRow.Index].Company = tbCompany.Text;
            listPerson[dgvPersons.CurrentRow.Index].listGroup = GetCheckBoxGroup();
            listPerson[dgvPersons.CurrentRow.Index].Picture = pbPicture.Image;

            dgvPersons.Refresh();//データグリッドビュー更新



        }
        //削除ボタン
        private void btDelete_Click(object sender, EventArgs e) {

            listPerson.RemoveAt(dgvPersons.CurrentRow.Index);

        }

        private void Form1_Lord(object sender,EventArgs e) { 

        }

    }
}
