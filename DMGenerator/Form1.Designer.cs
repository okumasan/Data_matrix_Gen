namespace DMGenerator
{
    partial class DataMatrixGenerator
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.inputFileEdit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.browseInputBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.outputDirEdit = new System.Windows.Forms.TextBox();
            this.browseOutputBtn = new System.Windows.Forms.Button();
            this.matrixSizeCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pointSizeCB = new System.Windows.Forms.ComboBox();
            this.genBtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // inputFileEdit
            // 
            this.inputFileEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputFileEdit.Location = new System.Drawing.Point(71, 12);
            this.inputFileEdit.Name = "inputFileEdit";
            this.inputFileEdit.Size = new System.Drawing.Size(331, 21);
            this.inputFileEdit.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "输入文件";
            // 
            // browseInputBtn
            // 
            this.browseInputBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseInputBtn.Location = new System.Drawing.Point(408, 10);
            this.browseInputBtn.Name = "browseInputBtn";
            this.browseInputBtn.Size = new System.Drawing.Size(75, 23);
            this.browseInputBtn.TabIndex = 2;
            this.browseInputBtn.Text = "浏览";
            this.browseInputBtn.UseVisualStyleBackColor = true;
            this.browseInputBtn.Click += new System.EventHandler(this.browseInputBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "输出目录";
            // 
            // outputDirEdit
            // 
            this.outputDirEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputDirEdit.Location = new System.Drawing.Point(71, 52);
            this.outputDirEdit.Name = "outputDirEdit";
            this.outputDirEdit.Size = new System.Drawing.Size(331, 21);
            this.outputDirEdit.TabIndex = 4;
            // 
            // browseOutputBtn
            // 
            this.browseOutputBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseOutputBtn.Location = new System.Drawing.Point(408, 50);
            this.browseOutputBtn.Name = "browseOutputBtn";
            this.browseOutputBtn.Size = new System.Drawing.Size(75, 23);
            this.browseOutputBtn.TabIndex = 5;
            this.browseOutputBtn.Text = "浏览";
            this.browseOutputBtn.UseVisualStyleBackColor = true;
            this.browseOutputBtn.Click += new System.EventHandler(this.browseOutputBtn_Click);
            // 
            // matrixSizeCB
            // 
            this.matrixSizeCB.FormattingEnabled = true;
            this.matrixSizeCB.Items.AddRange(new object[] {
            "0",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "32"});
            this.matrixSizeCB.Location = new System.Drawing.Point(119, 92);
            this.matrixSizeCB.Name = "matrixSizeCB";
            this.matrixSizeCB.Size = new System.Drawing.Size(121, 20);
            this.matrixSizeCB.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "尺寸（0=自动）";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "半径";
            // 
            // pointSizeCB
            // 
            this.pointSizeCB.FormattingEnabled = true;
            this.pointSizeCB.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.pointSizeCB.Location = new System.Drawing.Point(119, 131);
            this.pointSizeCB.Name = "pointSizeCB";
            this.pointSizeCB.Size = new System.Drawing.Size(121, 20);
            this.pointSizeCB.TabIndex = 9;
            // 
            // genBtn
            // 
            this.genBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.genBtn.Location = new System.Drawing.Point(336, 88);
            this.genBtn.Name = "genBtn";
            this.genBtn.Size = new System.Drawing.Size(145, 63);
            this.genBtn.TabIndex = 10;
            this.genBtn.Text = "生成";
            this.genBtn.UseVisualStyleBackColor = true;
            this.genBtn.Click += new System.EventHandler(this.genBtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(13, 166);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(468, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // DataMatrixGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 201);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.genBtn);
            this.Controls.Add(this.pointSizeCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.matrixSizeCB);
            this.Controls.Add(this.browseOutputBtn);
            this.Controls.Add(this.outputDirEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.browseInputBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputFileEdit);
            this.Name = "DataMatrixGenerator";
            this.Text = "DataMatrix生成器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputFileEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browseInputBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox outputDirEdit;
        private System.Windows.Forms.Button browseOutputBtn;
        private System.Windows.Forms.ComboBox matrixSizeCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox pointSizeCB;
        private System.Windows.Forms.Button genBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

