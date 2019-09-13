using System;
using System.Runtime.Serialization;

namespace EasyOCRByTesseract
{
    [Serializable()]
    public class UnidentifidContentException: Exception
    {
        public UnidentifidContentException() : base()
        {
        }
        public UnidentifidContentException(string message): base(message)
        {
        }
        public UnidentifidContentException(string message, Exception innerException): base(message, innerException)
        {
        }
        //逆シリアル化コンストラクタ。このクラスの逆シリアル化のために必須。
        //アクセス修飾子をpublicにしないこと！（詳細は後述）
        protected UnidentifidContentException(SerializationInfo info, StreamingContext context): base(info, context)
        {
        }
    }
}
