
namespace WeatherAPP {
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
            this.btWeatherGet = new System.Windows.Forms.Button();
            this.cbTihou = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbWeather = new System.Windows.Forms.TextBox();
            this.tbWeather2 = new System.Windows.Forms.TextBox();
            this.tbWeather3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbWeatherinfo
            // 
            this.tbWeatherinfo.Location = new System.Drawing.Point(542, 298);
            this.tbWeatherinfo.Multiline = true;
            this.tbWeatherinfo.Name = "tbWeatherinfo";
            this.tbWeatherinfo.Size = new System.Drawing.Size(233, 140);
            this.tbWeatherinfo.TabIndex = 0;
            this.tbWeatherinfo.TextChanged += new System.EventHandler(this.tbWeatherinfo_TextChanged);
            // 
            // btWeatherGet
            // 
            this.btWeatherGet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btWeatherGet.BackgroundImage = global::WeatherAPP.Properties.Resources.istockphoto_531327234_612x612;
            this.btWeatherGet.Enabled = false;
            this.btWeatherGet.Location = new System.Drawing.Point(306, 41);
            this.btWeatherGet.Name = "btWeatherGet";
            this.btWeatherGet.Size = new System.Drawing.Size(85, 30);
            this.btWeatherGet.TabIndex = 1;
            this.btWeatherGet.Text = "取得";
            this.btWeatherGet.UseVisualStyleBackColor = false;
            this.btWeatherGet.Click += new System.EventHandler(this.btWeatherGet_Click);
            // 
            // cbTihou
            // 
            this.cbTihou.FormattingEnabled = true;
            this.cbTihou.Location = new System.Drawing.Point(104, 47);
            this.cbTihou.Name = "cbTihou";
            this.cbTihou.Size = new System.Drawing.Size(121, 20);
            this.cbTihou.TabIndex = 4;
            this.cbTihou.SelectedIndexChanged += new System.EventHandler(this.cbTihou_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(639, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 84);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(508, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 84);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(540, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "天気概況";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbWeather
            // 
            this.tbWeather.Location = new System.Drawing.Point(376, 169);
            this.tbWeather.Multiline = true;
            this.tbWeather.Name = "tbWeather";
            this.tbWeather.Size = new System.Drawing.Size(121, 41);
            this.tbWeather.TabIndex = 7;
            // 
            // tbWeather2
            // 
            this.tbWeather2.Location = new System.Drawing.Point(528, 169);
            this.tbWeather2.Multiline = true;
            this.tbWeather2.Name = "tbWeather2";
            this.tbWeather2.Size = new System.Drawing.Size(118, 33);
            this.tbWeather2.TabIndex = 0;
            this.tbWeather2.TextChanged += new System.EventHandler(this.tbWeatherinfo_TextChanged);
            // 
            // tbWeather3
            // 
            this.tbWeather3.Location = new System.Drawing.Point(672, 161);
            this.tbWeather3.Multiline = true;
            this.tbWeather3.Name = "tbWeather3";
            this.tbWeather3.Size = new System.Drawing.Size(103, 41);
            this.tbWeather3.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbWeather3);
            this.Controls.Add(this.tbWeather);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbTihou);
            this.Controls.Add(this.btWeatherGet);
            this.Controls.Add(this.tbWeather2);
            this.Controls.Add(this.tbWeatherinfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWeatherinfo;
        private System.Windows.Forms.Button btWeatherGet;
        private System.Windows.Forms.ComboBox cbTihou;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbWeather;
        private System.Windows.Forms.TextBox tbWeather2;
        private System.Windows.Forms.TextBox tbWeather3;
    }
}

