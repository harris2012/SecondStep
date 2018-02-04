namespace SecondStep
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btMatch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btSetup = new System.Windows.Forms.Button();
            this.qrBox = new System.Windows.Forms.PictureBox();
            this.setupBox = new System.Windows.Forms.TextBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qrBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btMatch
            // 
            this.btMatch.Location = new System.Drawing.Point(63, 615);
            this.btMatch.Name = "btMatch";
            this.btMatch.Size = new System.Drawing.Size(75, 23);
            this.btMatch.TabIndex = 0;
            this.btMatch.Text = "Match";
            this.btMatch.UseVisualStyleBackColor = true;
            this.btMatch.Click += new System.EventHandler(this.btMatch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Key";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.keyTextBox.Location = new System.Drawing.Point(115, 56);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(491, 44);
            this.keyTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Setup";
            // 
            // btSetup
            // 
            this.btSetup.Location = new System.Drawing.Point(63, 449);
            this.btSetup.Name = "btSetup";
            this.btSetup.Size = new System.Drawing.Size(75, 23);
            this.btSetup.TabIndex = 5;
            this.btSetup.Text = "Setup";
            this.btSetup.UseVisualStyleBackColor = true;
            this.btSetup.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // qrBox
            // 
            this.qrBox.Location = new System.Drawing.Point(53, 188);
            this.qrBox.Name = "qrBox";
            this.qrBox.Size = new System.Drawing.Size(200, 200);
            this.qrBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qrBox.TabIndex = 6;
            this.qrBox.TabStop = false;
            // 
            // setupBox
            // 
            this.setupBox.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.setupBox.Location = new System.Drawing.Point(115, 105);
            this.setupBox.Name = "setupBox";
            this.setupBox.Size = new System.Drawing.Size(491, 44);
            this.setupBox.TabIndex = 7;
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(115, 555);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(410, 21);
            this.inputBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 558);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "Code";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(551, 564);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(101, 12);
            this.resultLabel.TabIndex = 10;
            this.resultLabel.Text = "input code here.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 722);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.setupBox);
            this.Controls.Add(this.qrBox);
            this.Controls.Add(this.btSetup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btMatch);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.qrBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btMatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSetup;
        private System.Windows.Forms.PictureBox qrBox;
        private System.Windows.Forms.TextBox setupBox;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resultLabel;
    }
}

