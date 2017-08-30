namespace WindowsFormsApplication1
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
            this.urlString = new System.Windows.Forms.TextBox();
            this.Go = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.EncryptTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EncryptBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DecryptBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStockInfo = new System.Windows.Forms.Label();
            this.StockSvcBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CmpnyTxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // urlString
            // 
            this.urlString.Location = new System.Drawing.Point(13, 13);
            this.urlString.Name = "urlString";
            this.urlString.Size = new System.Drawing.Size(1079, 20);
            this.urlString.TabIndex = 0;
            // 
            // Go
            // 
            this.Go.Location = new System.Drawing.Point(1099, 9);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(75, 23);
            this.Go.TabIndex = 1;
            this.Go.Text = "Go";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(13, 40);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1161, 466);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // EncryptTxt
            // 
            this.EncryptTxt.Location = new System.Drawing.Point(6, 26);
            this.EncryptTxt.Name = "EncryptTxt";
            this.EncryptTxt.Size = new System.Drawing.Size(329, 20);
            this.EncryptTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter text to be encrypted";
            // 
            // EncryptBtn
            // 
            this.EncryptBtn.Location = new System.Drawing.Point(6, 52);
            this.EncryptBtn.Name = "EncryptBtn";
            this.EncryptBtn.Size = new System.Drawing.Size(75, 23);
            this.EncryptBtn.TabIndex = 5;
            this.EncryptBtn.Text = "Encrypt";
            this.EncryptBtn.UseVisualStyleBackColor = true;
            this.EncryptBtn.Click += new System.EventHandler(this.EncryptBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "EncDecText";
            // 
            // DecryptBtn
            // 
            this.DecryptBtn.Location = new System.Drawing.Point(6, 96);
            this.DecryptBtn.Name = "DecryptBtn";
            this.DecryptBtn.Size = new System.Drawing.Size(75, 23);
            this.DecryptBtn.TabIndex = 7;
            this.DecryptBtn.Text = "Decrypt";
            this.DecryptBtn.UseVisualStyleBackColor = true;
            this.DecryptBtn.Click += new System.EventHandler(this.DecryptBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.lblStockInfo);
            this.panel1.Controls.Add(this.StockSvcBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CmpnyTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DecryptBtn);
            this.panel1.Controls.Add(this.EncryptTxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.EncryptBtn);
            this.panel1.Location = new System.Drawing.Point(13, 499);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 122);
            this.panel1.TabIndex = 8;
            // 
            // lblStockInfo
            // 
            this.lblStockInfo.AutoSize = true;
            this.lblStockInfo.Location = new System.Drawing.Point(742, 82);
            this.lblStockInfo.Name = "lblStockInfo";
            this.lblStockInfo.Size = new System.Drawing.Size(155, 13);
            this.lblStockInfo.TabIndex = 11;
            this.lblStockInfo.Text = "Stock Information appears here";
            // 
            // StockSvcBtn
            // 
            this.StockSvcBtn.Location = new System.Drawing.Point(742, 52);
            this.StockSvcBtn.Name = "StockSvcBtn";
            this.StockSvcBtn.Size = new System.Drawing.Size(124, 23);
            this.StockSvcBtn.TabIndex = 10;
            this.StockSvcBtn.Text = "Get Stocks Information";
            this.StockSvcBtn.UseVisualStyleBackColor = true;
            this.StockSvcBtn.Click += new System.EventHandler(this.StockSvc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(739, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter company name";
            // 
            // CmpnyTxt
            // 
            this.CmpnyTxt.Location = new System.Drawing.Point(742, 25);
            this.CmpnyTxt.Name = "CmpnyTxt";
            this.CmpnyTxt.Size = new System.Drawing.Size(399, 20);
            this.CmpnyTxt.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 633);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.urlString);
            this.Name = "Form1";
            this.Text = "Web-Browser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlString;
        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox EncryptTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EncryptBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DecryptBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CmpnyTxt;
        private System.Windows.Forms.Button StockSvcBtn;
        private System.Windows.Forms.Label lblStockInfo;
    }
}

