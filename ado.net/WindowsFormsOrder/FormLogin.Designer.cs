
namespace WindowsFormsOrder
{
    partial class FormLogin
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
            this.btn學員 = new System.Windows.Forms.Button();
            this.btn值日生 = new System.Windows.Forms.Button();
            this.btn管理員 = new System.Windows.Forms.Button();
            this.txt帳號 = new System.Windows.Forms.TextBox();
            this.txt密碼 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn關閉 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn學員
            // 
            this.btn學員.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn學員.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn學員.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn學員.Location = new System.Drawing.Point(168, 207);
            this.btn學員.Name = "btn學員";
            this.btn學員.Size = new System.Drawing.Size(156, 53);
            this.btn學員.TabIndex = 0;
            this.btn學員.Text = "學員登入";
            this.btn學員.UseVisualStyleBackColor = false;
            this.btn學員.Click += new System.EventHandler(this.btn學員_Click);
            // 
            // btn值日生
            // 
            this.btn值日生.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn值日生.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn值日生.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btn值日生.Location = new System.Drawing.Point(168, 290);
            this.btn值日生.Name = "btn值日生";
            this.btn值日生.Size = new System.Drawing.Size(156, 53);
            this.btn值日生.TabIndex = 1;
            this.btn值日生.Text = "值日生登入";
            this.btn值日生.UseVisualStyleBackColor = false;
            this.btn值日生.Click += new System.EventHandler(this.btn值日生_Click);
            // 
            // btn管理員
            // 
            this.btn管理員.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn管理員.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn管理員.ForeColor = System.Drawing.Color.Tomato;
            this.btn管理員.Location = new System.Drawing.Point(168, 371);
            this.btn管理員.Name = "btn管理員";
            this.btn管理員.Size = new System.Drawing.Size(156, 53);
            this.btn管理員.TabIndex = 2;
            this.btn管理員.Text = "管理員登入";
            this.btn管理員.UseVisualStyleBackColor = false;
            this.btn管理員.Click += new System.EventHandler(this.btn管理員_Click);
            // 
            // txt帳號
            // 
            this.txt帳號.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt帳號.Location = new System.Drawing.Point(143, 78);
            this.txt帳號.Name = "txt帳號";
            this.txt帳號.Size = new System.Drawing.Size(205, 27);
            this.txt帳號.TabIndex = 3;
            // 
            // txt密碼
            // 
            this.txt密碼.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt密碼.Location = new System.Drawing.Point(143, 122);
            this.txt密碼.Name = "txt密碼";
            this.txt密碼.PasswordChar = '*';
            this.txt密碼.Size = new System.Drawing.Size(205, 27);
            this.txt密碼.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(75, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "帳號 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(75, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "密碼 :";
            // 
            // btn關閉
            // 
            this.btn關閉.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn關閉.Location = new System.Drawing.Point(452, 12);
            this.btn關閉.Name = "btn關閉";
            this.btn關閉.Size = new System.Drawing.Size(33, 23);
            this.btn關閉.TabIndex = 7;
            this.btn關閉.Text = "X";
            this.btn關閉.UseVisualStyleBackColor = true;
            this.btn關閉.Click += new System.EventHandler(this.btn關閉_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(497, 465);
            this.Controls.Add(this.btn關閉);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt密碼);
            this.Controls.Add(this.txt帳號);
            this.Controls.Add(this.btn管理員);
            this.Controls.Add(this.btn值日生);
            this.Controls.Add(this.btn學員);
            this.Name = "FormLogin";
            this.Text = "登入";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn值日生;
        private System.Windows.Forms.Button btn管理員;
        private System.Windows.Forms.TextBox txt帳號;
        private System.Windows.Forms.TextBox txt密碼;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn關閉;
        private System.Windows.Forms.Button btn學員;
    }
}

