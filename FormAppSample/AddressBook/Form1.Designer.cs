﻿
namespace AddressBook {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvPersons = new System.Windows.Forms.DataGridView();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbCompany = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbMailAddress = new System.Windows.Forms.TextBox();
            this.cbFamily = new System.Windows.Forms.CheckBox();
            this.cbOther = new System.Windows.Forms.CheckBox();
            this.cbFriend = new System.Windows.Forms.CheckBox();
            this.cbWork = new System.Windows.Forms.CheckBox();
            this.btAddPerson = new System.Windows.Forms.Button();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.btPictureClear = new System.Windows.Forms.Button();
            this.btPictureOpen = new System.Windows.Forms.Button();
            this.ofdFileOpenDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label1.Location = new System.Drawing.Point(102, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "名前";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "メールアドレス";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label3.Location = new System.Drawing.Point(102, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "住所";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label4.Location = new System.Drawing.Point(102, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "会社";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label5.Location = new System.Drawing.Point(80, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "グループ";
            // 
            // dgvPersons
            // 
            this.dgvPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersons.Location = new System.Drawing.Point(39, 274);
            this.dgvPersons.Name = "dgvPersons";
            this.dgvPersons.RowTemplate.Height = 21;
            this.dgvPersons.Size = new System.Drawing.Size(749, 154);
            this.dgvPersons.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.tbName.Location = new System.Drawing.Point(184, 9);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(313, 29);
            this.tbName.TabIndex = 2;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // tbCompany
            // 
            this.tbCompany.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.tbCompany.Location = new System.Drawing.Point(184, 172);
            this.tbCompany.Name = "tbCompany";
            this.tbCompany.Size = new System.Drawing.Size(313, 29);
            this.tbCompany.TabIndex = 2;
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.tbAddress.Location = new System.Drawing.Point(184, 98);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(313, 59);
            this.tbAddress.TabIndex = 2;
            // 
            // tbMailAddress
            // 
            this.tbMailAddress.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.tbMailAddress.Location = new System.Drawing.Point(184, 63);
            this.tbMailAddress.Name = "tbMailAddress";
            this.tbMailAddress.Size = new System.Drawing.Size(313, 29);
            this.tbMailAddress.TabIndex = 2;
            // 
            // cbFamily
            // 
            this.cbFamily.AutoSize = true;
            this.cbFamily.Location = new System.Drawing.Point(209, 228);
            this.cbFamily.Name = "cbFamily";
            this.cbFamily.Size = new System.Drawing.Size(48, 16);
            this.cbFamily.TabIndex = 3;
            this.cbFamily.Text = "家族";
            this.cbFamily.UseVisualStyleBackColor = true;
            // 
            // cbOther
            // 
            this.cbOther.AutoSize = true;
            this.cbOther.Location = new System.Drawing.Point(401, 228);
            this.cbOther.Name = "cbOther";
            this.cbOther.Size = new System.Drawing.Size(55, 16);
            this.cbOther.TabIndex = 3;
            this.cbOther.Text = "その他";
            this.cbOther.UseVisualStyleBackColor = true;
            // 
            // cbFriend
            // 
            this.cbFriend.AutoSize = true;
            this.cbFriend.Location = new System.Drawing.Point(280, 228);
            this.cbFriend.Name = "cbFriend";
            this.cbFriend.Size = new System.Drawing.Size(48, 16);
            this.cbFriend.TabIndex = 3;
            this.cbFriend.Text = "友人";
            this.cbFriend.UseVisualStyleBackColor = true;
            // 
            // cbWork
            // 
            this.cbWork.AutoSize = true;
            this.cbWork.Location = new System.Drawing.Point(334, 228);
            this.cbWork.Name = "cbWork";
            this.cbWork.Size = new System.Drawing.Size(48, 16);
            this.cbWork.TabIndex = 3;
            this.cbWork.Text = "仕事";
            this.cbWork.UseVisualStyleBackColor = true;
            // 
            // btAddPerson
            // 
            this.btAddPerson.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.btAddPerson.Location = new System.Drawing.Point(615, 220);
            this.btAddPerson.Name = "btAddPerson";
            this.btAddPerson.Size = new System.Drawing.Size(125, 35);
            this.btAddPerson.TabIndex = 4;
            this.btAddPerson.Text = "追加";
            this.btAddPerson.UseVisualStyleBackColor = true;
            this.btAddPerson.Click += new System.EventHandler(this.btAddPerson_Click);
            // 
            // pbPicture
            // 
            this.pbPicture.Location = new System.Drawing.Point(624, 12);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(116, 145);
            this.pbPicture.TabIndex = 5;
            this.pbPicture.TabStop = false;
            // 
            // btPictureClear
            // 
            this.btPictureClear.Location = new System.Drawing.Point(696, 163);
            this.btPictureClear.Name = "btPictureClear";
            this.btPictureClear.Size = new System.Drawing.Size(75, 23);
            this.btPictureClear.TabIndex = 6;
            this.btPictureClear.Text = "クリア";
            this.btPictureClear.UseVisualStyleBackColor = true;
            // 
            // btPictureOpen
            // 
            this.btPictureOpen.Location = new System.Drawing.Point(624, 163);
            this.btPictureOpen.Name = "btPictureOpen";
            this.btPictureOpen.Size = new System.Drawing.Size(75, 23);
            this.btPictureOpen.TabIndex = 6;
            this.btPictureOpen.Text = "開く...";
            this.btPictureOpen.UseVisualStyleBackColor = true;
            this.btPictureOpen.Click += new System.EventHandler(this.btPictureOpen_Click);
            // 
            // ofdFileOpenDialog
            // 
            this.ofdFileOpenDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btPictureOpen);
            this.Controls.Add(this.btPictureClear);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.btAddPerson);
            this.Controls.Add(this.cbWork);
            this.Controls.Add(this.cbFriend);
            this.Controls.Add(this.cbOther);
            this.Controls.Add(this.cbFamily);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbCompany);
            this.Controls.Add(this.tbMailAddress);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.dgvPersons);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvPersons;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbCompany;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbMailAddress;
        private System.Windows.Forms.CheckBox cbFamily;
        private System.Windows.Forms.CheckBox cbOther;
        private System.Windows.Forms.CheckBox cbFriend;
        private System.Windows.Forms.CheckBox cbWork;
        private System.Windows.Forms.Button btAddPerson;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.Button btPictureClear;
        private System.Windows.Forms.Button btPictureOpen;
        private System.Windows.Forms.OpenFileDialog ofdFileOpenDialog;
    }
}

