
namespace WindowsFormsApp1
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
            this.txt = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.FLP = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(29, 30);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(100, 22);
            this.txt.TabIndex = 0;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(29, 90);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(100, 47);
            this.btn.TabIndex = 1;
            this.btn.Text = "Show All Button";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // FLP
            // 
            this.FLP.AutoScroll = true;
            this.FLP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FLP.Location = new System.Drawing.Point(167, 30);
            this.FLP.Name = "FLP";
            this.FLP.Size = new System.Drawing.Size(408, 324);
            this.FLP.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 366);
            this.Controls.Add(this.FLP);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.FlowLayoutPanel FLP;
    }
}

