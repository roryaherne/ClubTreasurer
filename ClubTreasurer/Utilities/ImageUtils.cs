using System;
using System.Drawing;
using System.IO;

namespace ClubTreasurer.Utilities
{
    public static class ImageUtils
    {
        public static byte[] ResizeImage(byte[] imageBytes, int width, int height)
        {
            MemoryStream myMemStream = new MemoryStream(imageBytes);
            Image fullsizeImage = Image.FromStream(myMemStream);
            Image newImage = fullsizeImage.GetThumbnailImage(width, height, null, IntPtr.Zero);
            MemoryStream myResult = new MemoryStream();
            newImage.Save(myResult, System.Drawing.Imaging.ImageFormat.Jpeg);
            return myResult.ToArray();
        }
    }
}
