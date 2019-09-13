using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.IO;
using EasyOCRByTesseract.DataSet;

namespace EasyOCRByTesseract
{
    public partial class MainForm : Form
    {

        private bool isDuringIdentiting = false;
        private bool isDrag = false;
        Rectangle rect = Rectangle.Empty;
        Bitmap image = null;

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            object[] listdatasource = new[]
            {
                new { Text = "英数字", Value ="eng" },
                new { Text = "日本語", Value = "jpn" }
            };

            cbLangs.DataSource = listdatasource;
            cbLangs.DisplayMember = "Text";
            cbLangs.ValueMember = "Value";
            cbLangs.SelectedIndex = 0;

            flgOCRResults.Styles[CellStyleEnum.Normal].WordWrap = true;
            flgOCRResults.AllowResizing = AllowResizingEnum.Rows;
            flgOCRResults.ExtendLastCol = true;

        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ret = openImagefile.ShowDialog();
            if (ret == DialogResult.OK)
            {
                picBox.Load(openImagefile.FileName);
                cbLangs.Enabled = true;
                btnStartOCR.Enabled = true;
                image = new Bitmap(openImagefile.FileName);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStartOCR_Click(object sender, EventArgs e)
        {
            if (picBox.Image == null)
            {
                return;
            }

            StartIdentity();
            try
            {
                string result = OCRHelper.ExecuteOCR(
                    image, Rectangle.Empty, cbLangs.SelectedValue.ToString());
                AddOCRResult(picBox.Bounds, cbLangs.Text, result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "OCR処理エラーが発生しました",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                EndIdentity();
            }
        }

        private void picBox_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Console.WriteLine("picBox_MouseDown start isDrag:{0}", isDrag);
            if (picBox.Image != null)
            {

                if (isDuringIdentiting)
                {
                    return;
                }

                picBox.Refresh();

                isDrag = true;
                rect.X = e.X;
                rect.Y = e.Y;
                rect.Width = 0;
                rect.Height = 0;
            }
            Console.WriteLine("picBox_MouseDown end isDrag:{0}", isDrag);
        }

        private void picBox_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (isDrag)
            {
                Console.WriteLine("picBox_MouseMove isDrag:{0}", isDrag);
                // Create rectangle.
                rect.Width = e.X - rect.Left;
                rect.Height = e.Y - rect.Top;

                if (rect.Left + rect.Width > picBox.Width) rect.Width = picBox.Width - rect.Left;
                if (rect.Left + rect.Width < 0) rect.Width = -rect.Left;


                if (rect.Top + rect.Height > picBox.Width) rect.Height = picBox.Height - rect.Top;
                if (rect.Top + rect.Height < 0) rect.Height = -rect.Top;

                MyDrawing();
            }

        }

        private void picBox_MouseUp(object sender, MouseEventArgs e)
        {
            base.OnMouseUp(e);

            Console.WriteLine("picBox_MouseUp start isDrag:{0}", isDrag);
            if (isDrag)
            {
                //MyDrawing();

                if (rect.Width == 0 || rect.Height == 0)
                {
                    isDrag = false;
                    return;
                }

                Rectangle mouseRect = new Rectangle(
                    Math.Min(rect.Left, e.X),
                    Math.Min(rect.Top, e.Y),
                    Math.Abs(rect.Width),
                    Math.Abs(rect.Height)
                    );

                using (Bitmap newPic = image.Clone(mouseRect, image.PixelFormat))
                {
                    try
                    {
                        StartIdentity();
                        SubOCR subform = new SubOCR();
                        subform.DisplayPartation = newPic;
                        subform.InitializedOCR();

                        DialogResult ret = subform.ShowDialog();
                        if (ret == DialogResult.OK)
                        {
                            if (subform.OcrResult == string.Empty)
                            {
                                MessageBox.Show("識別結果は空白です。","識別結果",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(string.Format("識別結果は「{0}」です。",subform.OcrResult), "識別結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                AddOCRResult(mouseRect, subform.SelectedLang, subform.OcrResult);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message,
                            "OCR処理エラーが発生しました",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    finally
                    {
                        EndIdentity();
                    }
                    isDrag = false;
                    picBox.Refresh();
                }
            }

            Console.WriteLine("picBox_MouseUp end isDrag:{0}", isDrag);
        }

        private void MyDrawing()
        {
            picBox.SuspendLayout();

            picBox.Refresh();

            Rectangle mouseRect = picBox.RectangleToScreen(rect);
            ControlPaint.DrawReversibleFrame(mouseRect, Color.White, FrameStyle.Dashed);

            picBox.ResumeLayout();
        }



        private void StartIdentity()
        {
            isDuringIdentiting = true;
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
        }
        private void EndIdentity()
        {
            isDuringIdentiting = false;
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
        }
        private void AddOCRResult(Rectangle rect, string lang, string result)
        {
            DataSet.OCRResult.OCR_ResultRow r = oCRResult.OCR_Result.NewOCR_ResultRow();
            r.no = oCRResult.OCR_Result.Rows.Count + 1;
            r.x = rect.X;
            r.y = rect.Y;
            r.width = rect.Width;
            r.height = rect.Height;
            r.lang = lang;
            r.result = result;

            oCRResult.OCR_Result.AddOCR_ResultRow(r);
            oCRResult.OCR_Result.AcceptChanges();

            flgOCRResults.AutoSizeRows();
        }

        private void picBox_Paint(object sender, PaintEventArgs e)
        {

            //base.OnPaint(e);

            //using (Graphics g = picBox.CreateGraphics())
            //{
            //    Pen p = new Pen(Color.Red, 1);
            //    foreach (OCRResult.OCR_ResultRow r in oCRResult.OCR_Result)
            //    {
            //        g.DrawRectangle(p, r.x, r.y, r.width, r.height);
            //    }
            //}

            //picBox.Refresh();

        }
    }
}
