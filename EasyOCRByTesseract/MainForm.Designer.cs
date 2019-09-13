namespace EasyOCRByTesseract
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.flgOCRResults = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oCRResult = new EasyOCRByTesseract.DataSet.OCRResult();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLangs = new System.Windows.Forms.ComboBox();
            this.btnStartOCR = new System.Windows.Forms.Button();
            this.openImagefile = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flgOCRResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCRResult)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1249, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveTextToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(130, 6);
            // 
            // saveTextToolStripMenuItem
            // 
            this.saveTextToolStripMenuItem.Name = "saveTextToolStripMenuItem";
            this.saveTextToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.saveTextToolStripMenuItem.Text = "Save Text";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.picBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flgOCRResults);
            this.splitContainer1.Size = new System.Drawing.Size(1249, 538);
            this.splitContainer1.SplitterDistance = 800;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(0, 0);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(600, 538);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            this.picBox.Paint += new System.Windows.Forms.PaintEventHandler(this.picBox_Paint);
            this.picBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseDown);
            this.picBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseMove);
            this.picBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseUp);
            // 
            // flgOCRResults
            // 
            this.flgOCRResults.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.flgOCRResults.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
            this.flgOCRResults.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.flgOCRResults.AutoClipboard = true;
            this.flgOCRResults.ColumnInfo = resources.GetString("flgOCRResults.ColumnInfo");
            this.flgOCRResults.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "lang", true));
            this.flgOCRResults.DataSource = this.bindingSource;
            this.flgOCRResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flgOCRResults.ExtendLastCol = true;
            this.flgOCRResults.Location = new System.Drawing.Point(0, 0);
            this.flgOCRResults.Name = "flgOCRResults";
            this.flgOCRResults.Rows.Count = 1;
            this.flgOCRResults.Rows.DefaultSize = 18;
            this.flgOCRResults.Size = new System.Drawing.Size(442, 536);
            this.flgOCRResults.StyleInfo = resources.GetString("flgOCRResults.StyleInfo");
            this.flgOCRResults.TabIndex = 0;
            // 
            // bindingSource
            // 
            this.bindingSource.DataMember = "OCR_Result";
            this.bindingSource.DataSource = this.oCRResult;
            // 
            // oCRResult
            // 
            this.oCRResult.DataSetName = "OCRResult";
            this.oCRResult.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "言語";
            // 
            // cbLangs
            // 
            this.cbLangs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLangs.Enabled = false;
            this.cbLangs.FormattingEnabled = true;
            this.cbLangs.Location = new System.Drawing.Point(133, 1);
            this.cbLangs.Name = "cbLangs";
            this.cbLangs.Size = new System.Drawing.Size(121, 20);
            this.cbLangs.TabIndex = 1;
            // 
            // btnStartOCR
            // 
            this.btnStartOCR.Enabled = false;
            this.btnStartOCR.Location = new System.Drawing.Point(260, 0);
            this.btnStartOCR.Name = "btnStartOCR";
            this.btnStartOCR.Size = new System.Drawing.Size(75, 23);
            this.btnStartOCR.TabIndex = 0;
            this.btnStartOCR.Text = "OCR";
            this.btnStartOCR.UseVisualStyleBackColor = true;
            this.btnStartOCR.Click += new System.EventHandler(this.btnStartOCR_Click);
            // 
            // openImagefile
            // 
            this.openImagefile.FileName = "openFileDialog1";
            this.openImagefile.Filter = "\"PNG|*.png|JPG|*.jpg\"";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 562);
            this.Controls.Add(this.btnStartOCR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.cbLangs);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "EasyOCR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flgOCRResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCRResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btnStartOCR;
        private System.Windows.Forms.OpenFileDialog openImagefile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLangs;
        private System.Windows.Forms.BindingSource bindingSource;
        private DataSet.OCRResult oCRResult;
        private C1.Win.C1FlexGrid.C1FlexGrid flgOCRResults;
    }
}

