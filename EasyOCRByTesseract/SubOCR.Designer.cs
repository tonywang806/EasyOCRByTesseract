namespace EasyOCRByTesseract
{
    partial class SubOCR
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
            this.pbDisplayPartation = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.gbResults = new System.Windows.Forms.GroupBox();
            this.rdbEng = new System.Windows.Forms.RadioButton();
            this.rdbJpn = new System.Windows.Forms.RadioButton();
            this.txtJpn = new System.Windows.Forms.TextBox();
            this.txtEng = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplayPartation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbDisplayPartation
            // 
            this.pbDisplayPartation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDisplayPartation.Location = new System.Drawing.Point(0, 0);
            this.pbDisplayPartation.Name = "pbDisplayPartation";
            this.pbDisplayPartation.Size = new System.Drawing.Size(472, 156);
            this.pbDisplayPartation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDisplayPartation.TabIndex = 0;
            this.pbDisplayPartation.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pbDisplayPartation);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnOk);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancle);
            this.splitContainer1.Panel2.Controls.Add(this.gbResults);
            this.splitContainer1.Size = new System.Drawing.Size(474, 301);
            this.splitContainer1.SplitterDistance = 158;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(376, 98);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(376, 66);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 4;
            this.btnCancle.Text = "キャンセル";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // gbResults
            // 
            this.gbResults.Controls.Add(this.rdbEng);
            this.gbResults.Controls.Add(this.rdbJpn);
            this.gbResults.Controls.Add(this.txtJpn);
            this.gbResults.Controls.Add(this.txtEng);
            this.gbResults.Location = new System.Drawing.Point(3, 3);
            this.gbResults.Name = "gbResults";
            this.gbResults.Size = new System.Drawing.Size(353, 129);
            this.gbResults.TabIndex = 3;
            this.gbResults.TabStop = false;
            this.gbResults.Text = "識別結果";
            // 
            // rdbEng
            // 
            this.rdbEng.AutoSize = true;
            this.rdbEng.Checked = true;
            this.rdbEng.Location = new System.Drawing.Point(16, 27);
            this.rdbEng.Name = "rdbEng";
            this.rdbEng.Size = new System.Drawing.Size(59, 16);
            this.rdbEng.TabIndex = 2;
            this.rdbEng.TabStop = true;
            this.rdbEng.Text = "英数字";
            this.rdbEng.UseVisualStyleBackColor = true;
            // 
            // rdbJpn
            // 
            this.rdbJpn.AutoSize = true;
            this.rdbJpn.Location = new System.Drawing.Point(16, 74);
            this.rdbJpn.Name = "rdbJpn";
            this.rdbJpn.Size = new System.Drawing.Size(59, 16);
            this.rdbJpn.TabIndex = 2;
            this.rdbJpn.Text = "日本語";
            this.rdbJpn.UseVisualStyleBackColor = true;
            // 
            // txtJpn
            // 
            this.txtJpn.Location = new System.Drawing.Point(81, 68);
            this.txtJpn.Multiline = true;
            this.txtJpn.Name = "txtJpn";
            this.txtJpn.Size = new System.Drawing.Size(258, 51);
            this.txtJpn.TabIndex = 1;
            // 
            // txtEng
            // 
            this.txtEng.Location = new System.Drawing.Point(81, 16);
            this.txtEng.Multiline = true;
            this.txtEng.Name = "txtEng";
            this.txtEng.Size = new System.Drawing.Size(258, 51);
            this.txtEng.TabIndex = 1;
            // 
            // SubOCR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 301);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SubOCR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "識別結果確認";
            this.Load += new System.EventHandler(this.SubOCR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplayPartation)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbResults.ResumeLayout(false);
            this.gbResults.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDisplayPartation;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.GroupBox gbResults;
        private System.Windows.Forms.RadioButton rdbEng;
        private System.Windows.Forms.RadioButton rdbJpn;
        private System.Windows.Forms.TextBox txtJpn;
        private System.Windows.Forms.TextBox txtEng;
    }
}