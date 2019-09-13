using System;
using System.Text;
using System.Drawing;
using Tesseract;

namespace EasyOCRByTesseract
{
    public class OCRHelper
    {

        public static string ExecuteOCR(Bitmap image, Rectangle scope,String lang)
        {
            try
            {
                // jpn.traineddataの格納フォルダ
                using (var engine = new TesseractEngine(@".\tessdata", lang, EngineMode.Default))
                {
                    Page page = null;
                    if (scope == Rectangle.Empty)
                    {
                        // 処理領域の指定なし
                        page = engine.Process(image);
                    }
                    else
                    {
                        //// 処理領域の指定あり
                        var rect = new Tesseract.Rect(scope.X, scope.Y, scope.Width, scope.Height);
                        page = engine.Process(image, rect);
                    }

                    using (page)
                    {
                        var ocrText = page.GetText();
                        var resultStringArray = ocrText.Split('\n');
                        StringBuilder sb = new StringBuilder();
                        foreach (var s in resultStringArray)
                        {
                            sb.AppendLine(s);
                        }
                        return sb.ToString().Trim();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw new UnidentifidContentException(ex.Message,ex);
            }

        }
    }
}
