using System;
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

            int index = dgvPersons.CurrentRow.Index;
            tbName.Text = listPerson[index].Name;
            tbMailAddress.Text = listPerson[index].MailAddress;
            tbAddress.Text = listPerson[index].Address;
            tbCompany.Text = listPerson[index].Company;
            pbPicture.Image = listPerson[index].Picture;

            foreach (var group in listPerson[index].listGroup) 
                {
                switch (group) {
                    case Person.GroupType.家族:
                        cbFamily.Checked = true;
                        break;
                    case Person.GroupType.友人:
                        break;
                    case Person.GroupType.仕事:
                        break;
                    case Person.GroupType.その他:
                        break;
                    default:
                        break;
                }



            }


           





        }
    }
}
