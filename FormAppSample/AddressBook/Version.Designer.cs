
namespace AddressBook {
    partial class lbVersion {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btVersion
            // 
            this.btVersion.AutoSize = true;
            this.btVersion.Location = new System.Drawing.Point(58, 78);
            this.btVersion.Name = "btVersion";
            this.btVersion.Size = new System.Drawing.Size(50, 12);
            this.btVersion.TabIndex = 0;
            this.btVersion.Text = "バージョン";
            // 
            // lbVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 172);
            this.Controls.Add(this.btVersion);
            this.Name = "lbVersion";
            this.Text = "Version";
            this.Load += new System.EventHandler(this.Version_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btVersion;
    }
}