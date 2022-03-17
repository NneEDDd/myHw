
namespace WindowsFormsOrder
{
    partial class FormAdm
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
            this.lbox菜單 = new System.Windows.Forms.ListBox();
            this.cbox店家 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt菜名 = new System.Windows.Forms.TextBox();
            this.txt價錢 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn移除品項 = new System.Windows.Forms.Button();
            this.btn新增菜色 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn刪除全部 = new System.Windows.Forms.Button();
            this.btn移除店家 = new System.Windows.Forms.Button();
            this.btn新增店家 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt電話 = new System.Windows.Forms.TextBox();
            this.txt店名 = new System.Windows.Forms.TextBox();
            this.lbox店家資訊 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbox菜單
            // 
            this.lbox菜單.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbox菜單.FormattingEnabled = true;
            this.lbox菜單.ItemHeight = 16;
            this.lbox菜單.Location = new System.Drawing.Point(34, 77);
            this.lbox菜單.Name = "lbox菜單";
            this.lbox菜單.Size = new System.Drawing.Size(297, 260);
            this.lbox菜單.TabIndex = 0;
            this.lbox菜單.SelectedIndexChanged += new System.EventHandler(this.lbox菜單_SelectedIndexChanged);
            // 
            // cbox店家
            // 
            this.cbox店家.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox店家.FormattingEnabled = true;
            this.cbox店家.Location = new System.Drawing.Point(34, 29);
            this.cbox店家.Name = "cbox店家";
            this.cbox店家.Size = new System.Drawing.Size(121, 24);
            this.cbox店家.TabIndex = 1;
            this.cbox店家.SelectedIndexChanged += new System.EventHandler(this.cbox店家_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(621, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "管理員登入";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(381, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "菜色名稱 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(381, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "價錢 :";
            // 
            // txt菜名
            // 
            this.txt菜名.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt菜名.Location = new System.Drawing.Point(479, 119);
            this.txt菜名.Name = "txt菜名";
            this.txt菜名.Size = new System.Drawing.Size(166, 27);
            this.txt菜名.TabIndex = 5;
            // 
            // txt價錢
            // 
            this.txt價錢.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt價錢.Location = new System.Drawing.Point(479, 165);
            this.txt價錢.Name = "txt價錢";
            this.txt價錢.Size = new System.Drawing.Size(166, 27);
            this.txt價錢.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(749, 411);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SeaShell;
            this.tabPage1.Controls.Add(this.btn移除品項);
            this.tabPage1.Controls.Add(this.btn新增菜色);
            this.tabPage1.Controls.Add(this.txt菜名);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbox店家);
            this.tabPage1.Controls.Add(this.txt價錢);
            this.tabPage1.Controls.Add(this.lbox菜單);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(741, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "菜單管理";
            // 
            // btn移除品項
            // 
            this.btn移除品項.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn移除品項.ForeColor = System.Drawing.Color.Maroon;
            this.btn移除品項.Location = new System.Drawing.Point(585, 267);
            this.btn移除品項.Name = "btn移除品項";
            this.btn移除品項.Size = new System.Drawing.Size(110, 35);
            this.btn移除品項.TabIndex = 8;
            this.btn移除品項.Text = "移除品項";
            this.btn移除品項.UseVisualStyleBackColor = true;
            this.btn移除品項.Click += new System.EventHandler(this.btn移除品項_Click);
            // 
            // btn新增菜色
            // 
            this.btn新增菜色.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增菜色.ForeColor = System.Drawing.Color.Maroon;
            this.btn新增菜色.Location = new System.Drawing.Point(384, 267);
            this.btn新增菜色.Name = "btn新增菜色";
            this.btn新增菜色.Size = new System.Drawing.Size(110, 35);
            this.btn新增菜色.TabIndex = 7;
            this.btn新增菜色.Text = "新增菜色";
            this.btn新增菜色.UseVisualStyleBackColor = true;
            this.btn新增菜色.Click += new System.EventHandler(this.btn新增菜色_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SeaShell;
            this.tabPage2.Controls.Add(this.btn刪除全部);
            this.tabPage2.Controls.Add(this.btn移除店家);
            this.tabPage2.Controls.Add(this.btn新增店家);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txt電話);
            this.tabPage2.Controls.Add(this.txt店名);
            this.tabPage2.Controls.Add(this.lbox店家資訊);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(741, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "店家管理";
            // 
            // btn刪除全部
            // 
            this.btn刪除全部.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除全部.ForeColor = System.Drawing.Color.Maroon;
            this.btn刪除全部.Location = new System.Drawing.Point(217, 338);
            this.btn刪除全部.Name = "btn刪除全部";
            this.btn刪除全部.Size = new System.Drawing.Size(205, 32);
            this.btn刪除全部.TabIndex = 8;
            this.btn刪除全部.Text = "移除該店家及其所有菜單";
            this.btn刪除全部.UseVisualStyleBackColor = true;
            this.btn刪除全部.Click += new System.EventHandler(this.btn刪除全部_Click);
            // 
            // btn移除店家
            // 
            this.btn移除店家.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn移除店家.ForeColor = System.Drawing.Color.Maroon;
            this.btn移除店家.Location = new System.Drawing.Point(602, 224);
            this.btn移除店家.Name = "btn移除店家";
            this.btn移除店家.Size = new System.Drawing.Size(93, 38);
            this.btn移除店家.TabIndex = 7;
            this.btn移除店家.Text = "移除店家";
            this.btn移除店家.UseVisualStyleBackColor = true;
            this.btn移除店家.Click += new System.EventHandler(this.btn移除店家_Click);
            // 
            // btn新增店家
            // 
            this.btn新增店家.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增店家.ForeColor = System.Drawing.Color.Maroon;
            this.btn新增店家.Location = new System.Drawing.Point(469, 224);
            this.btn新增店家.Name = "btn新增店家";
            this.btn新增店家.Size = new System.Drawing.Size(93, 38);
            this.btn新增店家.TabIndex = 6;
            this.btn新增店家.Text = "新增店家";
            this.btn新增店家.UseVisualStyleBackColor = true;
            this.btn新增店家.Click += new System.EventHandler(this.btn新增店家_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(451, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "電話 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(451, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "店名 :";
            // 
            // txt電話
            // 
            this.txt電話.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt電話.Location = new System.Drawing.Point(535, 163);
            this.txt電話.Name = "txt電話";
            this.txt電話.Size = new System.Drawing.Size(160, 27);
            this.txt電話.TabIndex = 3;
            // 
            // txt店名
            // 
            this.txt店名.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt店名.Location = new System.Drawing.Point(535, 118);
            this.txt店名.Name = "txt店名";
            this.txt店名.Size = new System.Drawing.Size(160, 27);
            this.txt店名.TabIndex = 2;
            // 
            // lbox店家資訊
            // 
            this.lbox店家資訊.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbox店家資訊.FormattingEnabled = true;
            this.lbox店家資訊.ItemHeight = 16;
            this.lbox店家資訊.Location = new System.Drawing.Point(38, 56);
            this.lbox店家資訊.Name = "lbox店家資訊";
            this.lbox店家資訊.Size = new System.Drawing.Size(384, 260);
            this.lbox店家資訊.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(620, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "管理員登入";
            // 
            // FormAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(773, 435);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAdm";
            this.Text = "店家管理";
            this.Load += new System.EventHandler(this.FormAdm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbox菜單;
        private System.Windows.Forms.ComboBox cbox店家;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt菜名;
        private System.Windows.Forms.TextBox txt價錢;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn移除品項;
        private System.Windows.Forms.Button btn新增菜色;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn移除店家;
        private System.Windows.Forms.Button btn新增店家;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt電話;
        private System.Windows.Forms.TextBox txt店名;
        private System.Windows.Forms.ListBox lbox店家資訊;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn刪除全部;
    }
}