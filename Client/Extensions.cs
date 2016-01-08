using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace RPON.Extensions
{
    public static class BitmapExtension
    {
        public static byte[] ToByteArray(this Bitmap image, ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                return ms.ToArray();
            }
        }
    }

    public static class ByteExtension
    {
        public static Bitmap toBitmap(this byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                return new Bitmap(ms);
            }
        }
    }

    public static class InvokeExtension
    {
        public static TResult safeInvoke<T, TResult>(this T isi, Func<T, TResult> callFunction)
            where T : ISynchronizeInvoke
        {
            if (isi.InvokeRequired)
            {
                IAsyncResult result = isi.BeginInvoke(callFunction, new object[] {isi});
                object endResult = isi.EndInvoke(result);
                return (TResult) endResult;
            }
            else
                return callFunction(isi);
        }

        public static void safeInvoke<T>(this T isi, Action<T> callFunction) where T : ISynchronizeInvoke
        {
            if (isi.InvokeRequired) isi.BeginInvoke(callFunction, new object[] {isi});
            else
                callFunction(isi);
        }
    }

}
