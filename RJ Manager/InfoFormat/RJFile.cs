using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RJ_Manager.InfoFormat
{
    public class RJFile
    {
        public String RJ;
        public String fullPath;
        public bool? fuzzy;
        public Dictionary<String, RJInfo> info = new Dictionary<String, RJInfo>();

        public RJFile()
        {
            this.RJ = "?";
            this.fullPath = "";
            this.fuzzy = null;
        }
        
        public RJFile(FileInfo file)
        {
            String pattern = @"[rR][jJ][0-9]{6}";
            String pattern2 = @"(?<!\d)(\d{6}(?!\d))";

            this.fullPath = file.FullName;
            this.RJ = "";
            foreach (Match match in Regex.Matches(file.Name, pattern))
            {
                if (this.RJ.Length > 0)
                {
                    this.RJ = this.RJ + ',';
                }
                this.RJ = this.RJ + match.ToString().ToUpper();
            }
            this.fuzzy = false;


            if (this.RJ == "" && Regex.Matches(file.Name, pattern2).Count >= 1)
            {
                foreach (Match match in Regex.Matches(file.Name, pattern2))
                {
                    if (this.RJ.Length > 0)
                    {
                        this.RJ = this.RJ + ',';
                    }
                    this.RJ = this.RJ + "RJ" + match.ToString();
                }
                this.fuzzy = true;
            }
            else if (this.RJ == "")
            {
                this.RJ = "?";
                this.fuzzy = null;
            }
        }
    }
}
