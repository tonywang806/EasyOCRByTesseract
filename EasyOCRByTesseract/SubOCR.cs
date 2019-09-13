using System;
using System.Drawing;
using System.Windows.Forms;

namespace EasyOCRByTesseract
{
    public partial class SubOCR : Form
    {
        public SubOCR()
        {
            InitializeComponent();
        }

        private Bitmap showPartpic;
        private string selectedLang;
        private string ocrResult;
        public Bitmap DisplayPartation
        {
            get
            {
                return showPartpic;
            }

            set
            {
                showPartpic = value;
            }
        }
        public string SelectedLang
        {
            get
            {
                return selectedLang;
            }

            set
            {
                selectedLang = value;
            }
        }
        public string OcrResult
        {
            get
            {
                return ocrResult;
            }

            set
            {
                ocrResult = value;
            }
        }

        private string resultEng = string.Empty;
        private string resultJpn = string.Empty;

        public void InitializedOCR() {
            try
            {
                resultEng = OCRHelper.ExecuteOCR(DisplayPartation, Rectangle.Empty, "eng");
                resultJpn = OCRHelper.ExecuteOCR(DisplayPartation, Rectangle.Empty, "jpn");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void SubOCR_Load(object sender, EventArgs e)
        {
            pbDisplayPartation.Image = DisplayPartation;
            txtEng.Text = resultEng;
            txtJpn.Text = resultJpn;            
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            SelectedLang =string.Empty;
            OcrResult = string.Empty;

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (rdbEng.Checked)
            {
                SelectedLang = "英数字";
                OcrResult = txtEng.Text;
            }
            else
            {
                SelectedLang = "日本語";
                OcrResult = txtJpn.Text;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
