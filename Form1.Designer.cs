namespace _1_1
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
            this.showans = new System.Windows.Forms.Button();
            this.retry = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showans
            // 
            this.showans.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showans.Location = new System.Drawing.Point(53, 188);
            this.showans.Name = "showans";
            this.showans.Size = new System.Drawing.Size(121, 55);
            this.showans.TabIndex = 0;
            this.showans.Text = "顯示答案";
            this.showans.UseVisualStyleBackColor = true;
            this.showans.Click += new System.EventHandler(this.button1_Click);
            // 
            // retry
            // 
            this.retry.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.retry.Location = new System.Drawing.Point(305, 188);
            this.retry.Name = "retry";
            this.retry.Size = new System.Drawing.Size(121, 55);
            this.retry.TabIndex = 1;
            this.retry.Text = "重猜";
            this.retry.UseVisualStyleBackColor = true;
            this.retry.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("細明體_HKSCS-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(61, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 74);
            this.label1.TabIndex = 2;
            this.label1.Text = "飲水思源，猜一個台灣地名";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 358);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.retry);
            this.Controls.Add(this.showans);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showans;
        private System.Windows.Forms.Button retry;
        private System.Windows.Forms.Label label1;
    }
}

