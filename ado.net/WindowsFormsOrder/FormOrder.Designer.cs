
namespace WindowsFormsOrder
{
    partial class FormOrder
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
            this.lbl值日生 = new System.Windows.Forms.Label();
            this.cbox班級 = new System.Windows.Forms.ComboBox();
            this.lbox品項 = new System.Windows.Forms.ListBox();
            this.lbox店家 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl金額 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl值日生
            // 
            this.lbl值日生.AutoSize = true;
            this.lbl值日生.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl值日生.Location = new System.Drawing.Point(424, 29);
            this.lbl值日生.Name = "lbl值日生";
            this.lbl值日生.Size = new System.Drawing.Size(88, 16);
            this.lbl值日生.TabIndex = 0;
            this.lbl值日生.Text = "值日生登入";
            // 
            // cbox班級
            // 
            this.cbox班級.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox班級.FormattingEnabled = true;
            this.cbox班級.Location = new System.Drawing.Point(13, 29);
            this.cbox班級.Name = "cbox班級";
            this.cbox班級.Size = new System.Drawing.Size(121, 24);
            this.cbox班級.TabIndex = 1;
            this.cbox班級.SelectedIndexChanged += new System.EventHandler(this.cbox班級_SelectedIndexChanged);
            // 
            // lbox品項
            // 
            this.lbox品項.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbox品項.FormattingEnabled = true;
            this.lbox品項.ItemHeight = 16;
            this.lbox品項.Location = new System.Drawing.Point(13, 75);
            this.lbox品項.Name = "lbox品項";
            this.lbox品項.Size = new System.Drawing.Size(402, 196);
            this.lbox品項.TabIndex = 2;
            // 
            // lbox店家
            // 
            this.lbox店家.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbox店家.FormattingEnabled = true;
            this.lbox店家.ItemHeight = 16;
            this.lbox店家.Location = new System.Drawing.Point(15, 312);
            this.lbox店家.Name = "lbox店家";
            this.lbox店家.Size = new System.Drawing.Size(400, 68);
            this.lbox店家.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(269, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "總金額 :";
            // 
            // lbl金額
            // 
            this.lbl金額.AutoSize = true;
            this.lbl金額.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl金額.Location = new System.Drawing.Point(339, 283);
            this.lbl金額.Name = "lbl金額";
            this.lbl金額.Size = new System.Drawing.Size(46, 16);
            this.lbl金額.TabIndex = 5;
            this.lbl金額.Text = "label3";
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(545, 414);
            this.Controls.Add(this.lbl金額);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbox店家);
            this.Controls.Add(this.lbox品項);
            this.Controls.Add(this.cbox班級);
            this.Controls.Add(this.lbl值日生);
            this.Name = "FormOrder";
            this.Text = "訂單管理";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl值日生;
        private System.Windows.Forms.ComboBox cbox班級;
        private System.Windows.Forms.ListBox lbox品項;
        private System.Windows.Forms.ListBox lbox店家;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl金額;
    }
}