
namespace WeatherApp {
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
            this.tbWeatherinfo = new System.Windows.Forms.TextBox();
            this.cbTihou = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btGetWeather = new System.Windows.Forms.Button();
            this.tbWeather1 = new System.Windows.Forms.TextBox();
            this.tbWeather2 = new System.Windows.Forms.TextBox();
            this.tbWeather3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbTenki1 = new System.Windows.Forms.PictureBox();
            this.pbTenki2 = new System.Windows.Forms.PictureBox();
            this.pbTenki3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTenki1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTenki2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTenki3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbWeatherinfo
            // 
            this.tbWeatherinfo.Location = new System.Drawing.Point(33, 336);
            this.tbWeatherinfo.Multiline = true;
            this.tbWeatherinfo.Name = "tbWeatherinfo";
            this.tbWeatherinfo.Size = new System.Drawing.Size(440, 185);
            this.tbWeatherinfo.TabIndex = 0;
            // 
            // cbTihou
            // 
            this.cbTihou.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbTihou.FormattingEnabled = true;
            this.cbTihou.Location = new System.Drawing.Point(33, 59);
            this.cbTihou.Name = "cbTihou";
            this.cbTihou.Size = new System.Drawing.Size(121, 29);
            this.cbTihou.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(29, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "天気概況";
            // 
            // btGetWeather
            // 
            this.btGetWeather.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btGetWeather.Location = new System.Drawing.Point(203, 59);
            this.btGetWeather.Name = "btGetWeather";
            this.btGetWeather.Size = new System.Drawing.Size(75, 32);
            this.btGetWeather.TabIndex = 9;
            this.btGetWeather.Text = "取得";
            this.btGetWeather.UseVisualStyleBackColor = true;
            this.btGetWeather.Click += new System.EventHandler(this.btGetWeather_Click);
            // 
            // tbWeather1
            // 
            this.tbWeather1.Location = new System.Drawing.Point(33, 241);
            this.tbWeather1.Multiline = true;
            this.tbWeather1.Name = "tbWeather1";
            this.tbWeather1.Size = new System.Drawing.Size(100, 42);
            this.tbWeather1.TabIndex = 10;
            // 
            // tbWeather2
            // 
            this.tbWeather2.Location = new System.Drawing.Point(203, 241);
            this.tbWeather2.Multiline = true;
            this.tbWeather2.Name = "tbWeather2";
            this.tbWeather2.Size = new System.Drawing.Size(100, 42);
            this.tbWeather2.TabIndex = 10;
            // 
            // tbWeather3
            // 
            this.tbWeather3.Location = new System.Drawing.Point(373, 241);
            this.tbWeather3.Multiline = true;
            this.tbWeather3.Name = "tbWeather3";
            this.tbWeather3.Size = new System.Drawing.Size(100, 42);
            this.tbWeather3.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(31, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "‐";
            this.label2.BackColorChanged += new System.EventHandler(this.btGetWeather_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(201, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "‐";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(371, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "‐";
            // 
            // pbTenki1
            // 
            this.pbTenki1.BackColor = System.Drawing.SystemColors.Control;
            this.pbTenki1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbTenki1.Location = new System.Drawing.Point(33, 151);
            this.pbTenki1.Name = "pbTenki1";
            this.pbTenki1.Size = new System.Drawing.Size(100, 84);
            this.pbTenki1.TabIndex = 5;
            this.pbTenki1.TabStop = false;
            // 
            // pbTenki2
            // 
            this.pbTenki2.BackColor = System.Drawing.SystemColors.Control;
            this.pbTenki2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbTenki2.Location = new System.Drawing.Point(203, 151);
            this.pbTenki2.Name = "pbTenki2";
            this.pbTenki2.Size = new System.Drawing.Size(100, 84);
            this.pbTenki2.TabIndex = 5;
            this.pbTenki2.TabStop = false;
            // 
            // pbTenki3
            // 
            this.pbTenki3.BackColor = System.Drawing.Color.Transparent;
            this.pbTenki3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbTenki3.Location = new System.Drawing.Point(373, 151);
            this.pbTenki3.Name = "pbTenki3";
            this.pbTenki3.Size = new System.Drawing.Size(100, 84);
            this.pbTenki3.TabIndex = 5;
            this.pbTenki3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WeatherAPP.Properties.Resources._7e2e1db5;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(508, 533);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 533);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbWeather3);
            this.Controls.Add(this.tbWeather2);
            this.Controls.Add(this.tbWeather1);
            this.Controls.Add(this.btGetWeather);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbTenki1);
            this.Controls.Add(this.pbTenki2);
            this.Controls.Add(this.pbTenki3);
            this.Controls.Add(this.cbTihou);
            this.Controls.Add(this.tbWeatherinfo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTenki1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTenki2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTenki3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWeatherinfo;
        private System.Windows.Forms.ComboBox cbTihou;
        private System.Windows.Forms.PictureBox pbTenki3;
        private System.Windows.Forms.PictureBox pbTenki2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbTenki1;
        private System.Windows.Forms.Button btGetWeather;
        private System.Windows.Forms.TextBox tbWeather1;
        private System.Windows.Forms.TextBox tbWeather2;
        private System.Windows.Forms.TextBox tbWeather3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

