using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Drawing;
using System.Collections.Generic;

namespace l9l.Data.Helpers
{
    public class UploadHelper
    {
        public static string[] Extension = new string[]
        {
            ".jpg",
            ".png",
            ".jpej"
        };

        public static string Upload(IFormFile Img
            , string Folder, IHostingEnvironment env)
        {

            string FileName = Guid.NewGuid().ToString()
                + Path.GetExtension(Img.FileName);

            Bitmap Logo = GetImage(Img);
            Image res = Image.FromFile(GetFolder(Values.TPath, env) + RandomColor());

            Graphics graph = Graphics.FromImage(res);
            graph.DrawImage(Logo, Values.Location.X,
                Values.Location.Y, Values.Width, Values.Height);
            graph.Dispose();

            string path = Path.Combine(Folder, FileName);
            res.Save(path);
            //Img.CopyTo(new FileStream(path, FileMode.Create));
            return FileName;
        }

        public static string GetFolder(string FolderName, IHostingEnvironment env)
        {
            return env.WebRootPath + FolderName;
        }

        public static bool IsImage(string FileName)
        {
            string ext = Path.GetExtension(FileName).ToLower();
            for (int i = 0; i < Extension.Length; i++)
                if (ext.Equals(Extension[i].ToLower()))
                    return true;
            return false;
        }

        public static Bitmap GetImage(IFormFile Img)
        {
            Bitmap ans
                = new Bitmap(Values.Width, Values.Height);

            using (MemoryStream stream = new MemoryStream())
            {
                Img.CopyTo(stream);
                Image ret = Image.FromStream(stream);
                Graphics g = Graphics.FromImage(ans);
                g.DrawImage(ret, 0, 0, Values.Width, Values.Height);
                g.Dispose();
            }
            return ans;
        }
        public static string RandomColor()
        {
            List<string> lst = Values.Random();
            Random rand = new Random();
            int index = rand.Next() % lst.Count;
            return "\\" + lst[index];
        }

        public static string UploadCat(IFormFile file, string CFolder, IHostingEnvironment env)
        {
            string ans = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            string ret = CFolder + ans;
            file.CopyTo(new FileStream(ret, FileMode.Create));
            return ans;
        }
    }


}
