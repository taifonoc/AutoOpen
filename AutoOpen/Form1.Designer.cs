namespace AutoOpen
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.MM = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.SLOT = new System.Windows.Forms.TextBox();
            this.PORT = new System.Windows.Forms.TextBox();
            this.ONT_ID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SN = new System.Windows.Forms.TextBox();
            this.DES = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "圖書館",
            "一般用戶"});
            this.comboBox1.Location = new System.Drawing.Point(31, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "專案類型";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // MM
            // 
            this.MM.Location = new System.Drawing.Point(168, 69);
            this.MM.Name = "MM";
            this.MM.Size = new System.Drawing.Size(100, 22);
            this.MM.TabIndex = 1;
            this.MM.Text = "M";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(480, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "頻寬%數";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(167, 130);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(413, 224);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "T100 (中正區)",
            "T103 (大同區)",
            "T104 (中山區)",
            "T105 (松山區)",
            "T106 (大安區)",
            "T108 (萬華區)",
            "T110 (信義區)",
            "T111 (士林區)",
            "T112 (北投區)",
            "T114 (內湖區)",
            "T115 (南港區)",
            "T116 (文山區)"});
            this.comboBox2.Location = new System.Drawing.Point(31, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.Text = "行政區";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(158, 13);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 20);
            this.comboBox3.TabIndex = 5;
            // 
            // SLOT
            // 
            this.SLOT.Location = new System.Drawing.Point(31, 39);
            this.SLOT.Name = "SLOT";
            this.SLOT.Size = new System.Drawing.Size(100, 22);
            this.SLOT.TabIndex = 6;
            this.SLOT.Text = "slot";
            // 
            // PORT
            // 
            this.PORT.Location = new System.Drawing.Point(146, 39);
            this.PORT.Name = "PORT";
            this.PORT.Size = new System.Drawing.Size(100, 22);
            this.PORT.TabIndex = 7;
            this.PORT.Text = "port";
            // 
            // ONT_ID
            // 
            this.ONT_ID.Location = new System.Drawing.Point(258, 39);
            this.ONT_ID.Name = "ONT_ID";
            this.ONT_ID.Size = new System.Drawing.Size(100, 22);
            this.ONT_ID.TabIndex = 8;
            this.ONT_ID.Text = "ont-id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(694, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "確認";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(694, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "導入";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // SN
            // 
            this.SN.Location = new System.Drawing.Point(374, 39);
            this.SN.Name = "SN";
            this.SN.Size = new System.Drawing.Size(100, 22);
            this.SN.TabIndex = 11;
            this.SN.Text = "SN";
            // 
            // DES
            // 
            this.DES.Location = new System.Drawing.Point(480, 39);
            this.DES.Name = "DES";
            this.DES.Size = new System.Drawing.Size(100, 22);
            this.DES.TabIndex = 12;
            this.DES.Text = "des";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(12, 130);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(140, 22);
            this.textBox8.TabIndex = 13;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(12, 158);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(140, 22);
            this.textBox9.TabIndex = 14;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(12, 186);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(140, 22);
            this.textBox10.TabIndex = 15;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(12, 214);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(140, 22);
            this.textBox11.TabIndex = 16;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(12, 242);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(140, 22);
            this.textBox12.TabIndex = 17;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(12, 270);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(140, 22);
            this.textBox13.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.DES);
            this.Controls.Add(this.SN);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ONT_ID);
            this.Controls.Add(this.PORT);
            this.Controls.Add(this.SLOT);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.MM);
            this.Controls.Add(this.comboBox1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox MM;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox SLOT;
        private System.Windows.Forms.TextBox PORT;
        private System.Windows.Forms.TextBox ONT_ID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox SN;
        private System.Windows.Forms.TextBox DES;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
    }
}

