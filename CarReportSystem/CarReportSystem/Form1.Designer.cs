
namespace CarReportSystem {
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
            this.cbName = new System.Windows.Forms.ComboBox();
            this.cbCar = new System.Windows.Forms.ComboBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rb = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvArticle = new System.Windows.Forms.DataGridView();
            this.btOpen = new System.Windows.Forms.Button();
            this.btEnd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btOpen2 = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btRevision = new System.Windows.Forms.Button();
            this.btDelete2 = new System.Windows.Forms.Button();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.btSave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(57, 65);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(121, 20);
            this.cbName.TabIndex = 0;
            // 
            // cbCar
            // 
            this.cbCar.FormattingEnabled = true;
            this.cbCar.Location = new System.Drawing.Point(67, 122);
            this.cbCar.Name = "cbCar";
            this.cbCar.Size = new System.Drawing.Size(121, 20);
            this.cbCar.TabIndex = 1;
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(57, 31);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 19);
            this.dtp.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "日付:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "記録者:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "メーカー:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "レポート:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "車名:";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // rb
            // 
            this.rb.AutoSize = true;
            this.rb.Location = new System.Drawing.Point(80, 100);
            this.rb.Name = "rb";
            this.rb.Size = new System.Drawing.Size(47, 16);
            this.rb.TabIndex = 6;
            this.rb.TabStop = true;
            this.rb.Text = "トヨタ";
            this.rb.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(141, 100);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "日産";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(206, 100);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(51, 16);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "ホンダ";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(274, 100);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(52, 16);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "スバル";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(332, 100);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(47, 16);
            this.radioButton5.TabIndex = 6;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "外車";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(396, 100);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(54, 16);
            this.radioButton6.TabIndex = 6;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "その他";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "記事一覧:";
            // 
            // dgvArticle
            // 
            this.dgvArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticle.Location = new System.Drawing.Point(86, 288);
            this.dgvArticle.Name = "dgvArticle";
            this.dgvArticle.RowTemplate.Height = 21;
            this.dgvArticle.Size = new System.Drawing.Size(710, 150);
            this.dgvArticle.TabIndex = 7;
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(-1, 295);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(75, 23);
            this.btOpen.TabIndex = 8;
            this.btOpen.Text = "開く";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btEnd
            // 
            this.btEnd.Location = new System.Drawing.Point(-1, 392);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(75, 23);
            this.btEnd.TabIndex = 8;
            this.btEnd.Text = "終了";
            this.btEnd.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(522, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "画像:";
            // 
            // btOpen2
            // 
            this.btOpen2.Location = new System.Drawing.Point(599, 36);
            this.btOpen2.Name = "btOpen2";
            this.btOpen2.Size = new System.Drawing.Size(75, 23);
            this.btOpen2.TabIndex = 8;
            this.btOpen2.Text = "開く";
            this.btOpen2.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(703, 36);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 8;
            this.btDelete.Text = "削除";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(489, 228);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 8;
            this.btAdd.Text = "追加";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btRevision
            // 
            this.btRevision.Location = new System.Drawing.Point(599, 228);
            this.btRevision.Name = "btRevision";
            this.btRevision.Size = new System.Drawing.Size(75, 23);
            this.btRevision.TabIndex = 8;
            this.btRevision.Text = "修正";
            this.btRevision.UseVisualStyleBackColor = true;
            // 
            // btDelete2
            // 
            this.btDelete2.Location = new System.Drawing.Point(713, 228);
            this.btDelete2.Name = "btDelete2";
            this.btDelete2.Size = new System.Drawing.Size(75, 23);
            this.btDelete2.TabIndex = 8;
            this.btDelete2.Text = "削除";
            this.btDelete2.UseVisualStyleBackColor = true;
            // 
            // pbPicture
            // 
            this.pbPicture.Location = new System.Drawing.Point(514, 72);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(264, 144);
            this.pbPicture.TabIndex = 9;
            this.pbPicture.TabStop = false;
            this.pbPicture.Click += new System.EventHandler(this.pbPicture_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(-1, 345);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 8;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 19);
            this.textBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btEnd);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btDelete2);
            this.Controls.Add(this.btRevision);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btOpen2);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.dgvArticle);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.rb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.cbCar);
            this.Controls.Add(this.cbName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.ComboBox cbCar;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rb;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvArticle;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btEnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btOpen2;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btRevision;
        private System.Windows.Forms.Button btDelete2;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox textBox1;
    }
}

