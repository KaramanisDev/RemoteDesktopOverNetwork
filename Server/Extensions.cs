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
        public static TResult SafeInvoke<T, TResult>(this T isi, Func<T, TResult> callFunction)
            where T : ISynchronizeInvoke
        {
            try
            {
                if (isi.InvokeRequired)
                {
                    IAsyncResult result = isi.BeginInvoke(callFunction, new object[] { isi });
                    object endResult = isi.EndInvoke(result);
                    return (TResult)endResult;
                }
                else
                {
                    return callFunction(isi);
                }
            }
            catch (Exception)
            {
                return callFunction(isi);
            }
        }

        public static void SafeInvoke<T>(this T isi, Action<T> callFunction) where T : ISynchronizeInvoke
        {
            try
            {
                if (isi.InvokeRequired) isi.BeginInvoke(callFunction, new object[] { isi });
                else
                    callFunction(isi);
            }
            catch (Exception) { }
        }
    }

}
