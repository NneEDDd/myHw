
namespace WindowsFormsOrder
{
    partial class FormStu
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.訂購頁面 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl總價 = new System.Windows.Forms.Label();
            this.lbl單價 = new System.Windows.Forms.Label();
            this.txt數量 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn訂購 = new System.Windows.Forms.Button();
            this.lbox品項 = new System.Windows.Forms.ListBox();
            this.lbl學員1 = new System.Windows.Forms.Label();
            this.cbox店家 = new System.Windows.Forms.ComboBox();
            this.查看訂單 = new System.Windows.Forms.TabPage();
            this.lbl總金額 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt刪除 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl學員2 = new System.Windows.Forms.Label();
            this.btn清除訂單 = new System.Windows.Forms.Button();
            this.btn刪除項目 = new System.Windows.Forms.Button();
            this.lbox訂單 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.訂購頁面.SuspendLayout();
            this.查看訂單.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.訂購頁面);
            this.tabControl1.Controls.Add(this.查看訂單);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(488, 405);
            this.tabControl1.TabIndex = 0;
            // 
            // 訂購頁面
            // 
            this.訂購頁面.BackColor = System.Drawing.Color.PowderBlue;
            this.訂購頁面.Controls.Add(this.label4);
            this.訂購頁面.Controls.Add(this.label3);
            this.訂購頁面.Controls.Add(this.label1);
            this.訂購頁面.Controls.Add(this.lbl總價);
            this.訂購頁面.Controls.Add(this.lbl單價);
            this.訂購頁面.Controls.Add(this.txt數量);
            this.訂購頁面.Controls.Add(this.label2);
            this.訂購頁面.Controls.Add(this.btn訂購);
            this.訂購頁面.Controls.Add(this.lbox品項);
            this.訂購頁面.Controls.Add(this.lbl學員1);
            this.訂購頁面.Controls.Add(this.cbox店家);
            this.訂購頁面.Location = new System.Drawing.Point(4, 22);
            this.訂購頁面.Name = "訂購頁面";
            this.訂購頁面.Padding = new System.Windows.Forms.Padding(3);
            this.訂購頁面.Size = new System.Drawing.Size(480, 379);
            this.訂購頁面.TabIndex = 0;
            this.訂購頁面.Text = "訂購頁面";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(283, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "登入帳號 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(315, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "總價 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(243, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "單價 :";
            // 
            // lbl總價
            // 
            this.lbl總價.AutoSize = true;
            this.lbl總價.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl總價.Location = new System.Drawing.Point(323, 291);
            this.lbl總價.Name = "lbl總價";
            this.lbl總價.Size = new System.Drawing.Size(40, 16);
            this.lbl總價.TabIndex = 7;
            this.lbl總價.Text = "總價";
            // 
            // lbl單價
            // 
            this.lbl單價.AutoSize = true;
            this.lbl單價.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl單價.Location = new System.Drawing.Point(251, 291);
            this.lbl單價.Name = "lbl單價";
            this.lbl單價.Size = new System.Drawing.Size(40, 16);
            this.lbl單價.TabIndex = 6;
            this.lbl單價.Text = "單價";
            // 
            // txt數量
            // 
            this.txt數量.Location = new System.Drawing.Point(91, 291);
            this.txt數量.Name = "txt數量";
            this.txt數量.Size = new System.Drawing.Size(112, 22);
            this.txt數量.TabIndex = 5;
            this.txt數量.TextChanged += new System.EventHandler(this.txt數量_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(29, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "數量 :";
            // 
            // btn訂購
            // 
            this.btn訂購.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn訂購.ForeColor = System.Drawing.Color.Maroon;
            this.btn訂購.Location = new System.Drawing.Point(31, 329);
            this.btn訂購.Name = "btn訂購";
            this.btn訂購.Size = new System.Drawing.Size(90, 26);
            this.btn訂購.TabIndex = 3;
            this.btn訂購.Text = "訂購";
            this.btn訂購.UseVisualStyleBackColor = true;
            this.btn訂購.Click += new System.EventHandler(this.btn訂購_Click);
            // 
            // lbox品項
            // 
            this.lbox品項.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbox品項.FormattingEnabled = true;
            this.lbox品項.ItemHeight = 16;
            this.lbox品項.Location = new System.Drawing.Point(31, 77);
            this.lbox品項.Name = "lbox品項";
            this.lbox品項.Size = new System.Drawing.Size(332, 164);
            this.lbox品項.TabIndex = 2;
            this.lbox品項.SelectedIndexChanged += new System.EventHandler(this.lbox品項_SelectedIndexChanged);
            // 
            // lbl學員1
            // 
            this.lbl學員1.AutoSize = true;
            this.lbl學員1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl學員1.Location = new System.Drawing.Point(370, 20);
            this.lbl學員1.Name = "lbl學員1";
            this.lbl學員1.Size = new System.Drawing.Size(72, 16);
            this.lbl學員1.TabIndex = 1;
            this.lbl學員1.Text = "學員登入";
            // 
            // cbox店家
            // 
            this.cbox店家.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox店家.FormattingEnabled = true;
            this.cbox店家.Location = new System.Drawing.Point(31, 35);
            this.cbox店家.Name = "cbox店家";
            this.cbox店家.Size = new System.Drawing.Size(121, 24);
            this.cbox店家.TabIndex = 0;
            this.cbox店家.SelectedIndexChanged += new System.EventHandler(this.cbox店家_SelectedIndexChanged);
            // 
            // 查看訂單
            // 
            this.查看訂單.BackColor = System.Drawing.Color.PowderBlue;
            this.查看訂單.Controls.Add(this.lbl總金額);
            this.查看訂單.Controls.Add(this.label6);
            this.查看訂單.Controls.Add(this.txt刪除);
            this.查看訂單.Controls.Add(this.label5);
            this.查看訂單.Controls.Add(this.lbl學員2);
            this.查看訂單.Controls.Add(this.btn清除訂單);
            this.查看訂單.Controls.Add(this.btn刪除項目);
            this.查看訂單.Controls.Add(this.lbox訂單);
            this.查看訂單.Location = new System.Drawing.Point(4, 22);
            this.查看訂單.Name = "查看訂單";
            this.查看訂單.Padding = new System.Windows.Forms.Padding(3);
            this.查看訂單.Size = new System.Drawing.Size(480, 379);
            this.查看訂單.TabIndex = 1;
            this.查看訂單.Text = "查看訂單";
            // 
            // lbl總金額
            // 
            this.lbl總金額.AutoSize = true;
            this.lbl總金額.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl總金額.Location = new System.Drawing.Point(115, 19);
            this.lbl總金額.Name = "lbl總金額";
            this.lbl總金額.Size = new System.Drawing.Size(46, 16);
            this.lbl總金額.TabIndex = 7;
            this.lbl總金額.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(13, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "訂單總金額 :";
            // 
            // txt刪除
            // 
            this.txt刪除.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt刪除.Location = new System.Drawing.Point(39, 295);
            this.txt刪除.Name = "txt刪除";
            this.txt刪除.Size = new System.Drawing.Size(148, 27);
            this.txt刪除.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(283, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "登入帳號 :";
            // 
            // lbl學員2
            // 
            this.lbl學員2.AutoSize = true;
            this.lbl學員2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl學員2.Location = new System.Drawing.Point(371, 19);
            this.lbl學員2.Name = "lbl學員2";
            this.lbl學員2.Size = new System.Drawing.Size(72, 16);
            this.lbl學員2.TabIndex = 3;
            this.lbl學員2.Text = "學員登入";
            // 
            // btn清除訂單
            // 
            this.btn清除訂單.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清除訂單.ForeColor = System.Drawing.Color.Maroon;
            this.btn清除訂單.Location = new System.Drawing.Point(360, 328);
            this.btn清除訂單.Name = "btn清除訂單";
            this.btn清除訂單.Size = new System.Drawing.Size(93, 32);
            this.btn清除訂單.TabIndex = 2;
            this.btn清除訂單.Text = "清除訂單";
            this.btn清除訂單.UseVisualStyleBackColor = true;
            this.btn清除訂單.Click += new System.EventHandler(this.btn清除訂單_Click);
            // 
            // btn刪除項目
            // 
            this.btn刪除項目.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除項目.ForeColor = System.Drawing.Color.Maroon;
            this.btn刪除項目.Location = new System.Drawing.Point(210, 290);
            this.btn刪除項目.Name = "btn刪除項目";
            this.btn刪除項目.Size = new System.Drawing.Size(93, 32);
            this.btn刪除項目.TabIndex = 1;
            this.btn刪除項目.Text = "刪除項目";
            this.btn刪除項目.UseVisualStyleBackColor = true;
            this.btn刪除項目.Click += new System.EventHandler(this.btn刪除項目_Click);
            // 
            // lbox訂單
            // 
            this.lbox訂單.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbox訂單.FormattingEnabled = true;
            this.lbox訂單.ItemHeight = 16;
            this.lbox訂單.Location = new System.Drawing.Point(15, 46);
            this.lbox訂單.Name = "lbox訂單";
            this.lbox訂單.Size = new System.Drawing.Size(399, 228);
            this.lbox訂單.TabIndex = 0;
            // 
            // FormStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(512, 429);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormStu";
            this.Text = "便當訂購";
            this.Load += new System.EventHandler(this.FormStu_Load);
            this.tabControl1.ResumeLayout(false);
            this.訂購頁面.ResumeLayout(false);
            this.訂購頁面.PerformLayout();
            this.查看訂單.ResumeLayout(false);
            this.查看訂單.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage 訂購頁面;
        private System.Windows.Forms.TabPage 查看訂單;
        private System.Windows.Forms.Label lbl總價;
        private System.Windows.Forms.Label lbl單價;
        private System.Windows.Forms.TextBox txt數量;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn訂購;
        private System.Windows.Forms.ListBox lbox品項;
        private System.Windows.Forms.Label lbl學員1;
        private System.Windows.Forms.ComboBox cbox店家;
        private System.Windows.Forms.Button btn清除訂單;
        private System.Windows.Forms.Button btn刪除項目;
        private System.Windows.Forms.ListBox lbox訂單;
        private System.Windows.Forms.Label lbl學員2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt刪除;
        private System.Windows.Forms.Label lbl總金額;
        private System.Windows.Forms.Label label6;
    }
}