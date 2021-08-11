using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJ_Manager
{
    public class Utils
    {

        public static void Encrypt(FileInfo info, String pw)
        {

        }

        public static void Decrypt(FileInfo info, String pw) //以后可能会通过添加校验值来判断是否解密成功
        {

        }

        public static string FileSize(long length)
        {
            long m = length;
            int level = 0;
            double a = (double)m;
            String[] unit = { "B", "KB", "MB", "GB", "TB" };
            while (m / 1024 > 0)
            {
                m /= 1024;
                level++;
                a /= 1024.0;
            }
            return a.ToString("0.##") + unit[level];
        }

        public static List<FileInfo> ScanFiles()
        {
            List<FileInfo> allFiles = new List<FileInfo>();

            foreach (String folder in FolderManager.loadList())
            {
                DirectoryInfo info = new DirectoryInfo(folder);
                if (info.Exists)
                {
                    foreach (FileInfo f in info.GetFiles())
                    {
                        allFiles.Add(f);
                    }
                }
            }

            return allFiles;
        }

    }
}
