namespace BitlyShortURL
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShortUrl = new System.Windows.Forms.Button();
            this.txtLongUrl = new System.Windows.Forms.TextBox();
            this.txtShortUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShortUrl
            // 
            this.btnShortUrl.Location = new System.Drawing.Point(245, 70);
            this.btnShortUrl.Name = "btnShortUrl";
            this.btnShortUrl.Size = new System.Drawing.Size(75, 23);
            this.btnShortUrl.TabIndex = 0;
            this.btnShortUrl.Text = "Short URL";
            this.btnShortUrl.UseVisualStyleBackColor = true;
            this.btnShortUrl.Click += new System.EventHandler(this.BtnShortUrl_Click);
            // 
            // txtLongUrl
            // 
            this.txtLongUrl.Location = new System.Drawing.Point(88, 18);
            this.txtLongUrl.Name = "txtLongUrl";
            this.txtLongUrl.Size = new System.Drawing.Size(232, 20);
            this.txtLongUrl.TabIndex = 1;
            // 
            // txtShortUrl
            // 
            this.txtShortUrl.Location = new System.Drawing.Point(88, 44);
            this.txtShortUrl.Name = "txtShortUrl";
            this.txtShortUrl.ReadOnly = true;
            this.txtShortUrl.Size = new System.Drawing.Size(232, 20);
            this.txtShortUrl.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Long URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Short URL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 114);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtShortUrl);
            this.Controls.Add(this.txtLongUrl);
            this.Controls.Add(this.btnShortUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShortUrl;
        private System.Windows.Forms.TextBox txtLongUrl;
        private System.Windows.Forms.TextBox txtShortUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

