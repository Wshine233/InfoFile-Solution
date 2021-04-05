using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Drawing;

namespace InfoFileFormat
{
    public class InfoFile
    {
        public static InfoFile TEST_VALUE;
        public const String LATEST_VERSION = "0.1";
        private String VERSION;

        [Serializable]
        protected struct InfoFileStructure
        {
            public NecessaryInfo necessaryInfo;
            public Dictionary<String, BaseInfoType> info;
        }

        protected NecessaryInfo necessaryInfo;
        public NecessaryInfo NecessaryInfo
        {
            get
            {
                return necessaryInfo;
            }
        }

        protected Dictionary<String, BaseInfoType> info;
        public Dictionary<String, BaseInfoType> Info
        {
            get
            {
                return info;
            }
        }

        protected InfoFile(InfoFileStructure infoStruct)
        {
            this.necessaryInfo = infoStruct.necessaryInfo;
            this.info = infoStruct.info;
            this.VERSION = this.necessaryInfo.Info["Version"];
        }

       /* public InfoFile(string path)
        {
            FileInfo fInfo = new FileInfo(path);
        }*/

        static InfoFile()
        {
            InfoFile infoFile = new InfoFile();
            LiteralText text = new LiteralText("My First Test Text", "Hello!");
            infoFile.AddMetaData(text);

            Picture picture = new Picture("FirstPic", Image.FromFile("C:\\Users\\atbwc\\Desktop\\wallhaven-ymz61d.jpg"));
            infoFile.AddMetaData(picture);
            TEST_VALUE = infoFile;
        }

        protected InfoFile()
        {
            VERSION = LATEST_VERSION;
            this.necessaryInfo = new NecessaryInfo(VERSION, null, null, null);
            this.info = new Dictionary<string, BaseInfoType>();
        }

        public InfoFile(FileInfo file)
        {
            VERSION = LATEST_VERSION;

            if (file.Exists)
            {
                this.necessaryInfo = new NecessaryInfo(VERSION, file.FullName, file.Length.ToString(), null);
                this.info = new Dictionary<string, BaseInfoType>();
            }
            else
            {
                //file.Create().Close();
                throw new FileNotFoundException("无法找到源文件");
            }
        }

        private InfoFile(FileInfo file, String version)
        {
            VERSION = version;
            if (file.Exists)
            {
                this.necessaryInfo = new NecessaryInfo(VERSION, file.FullName, file.Length.ToString(), null);
                this.info = new Dictionary<string, BaseInfoType>();
            }
            else
            {
                file.Create().Close();
                throw new FileNotFoundException("无法找到源文件");
            }
        }

        public void AddMetaData(BaseInfoType info)
        {
            this.info.Add(info.Name, info);
        }

        public bool HasInfo(String key)
        {
            return this.info.ContainsKey(key);
        }

        public BaseInfoType GetInfo(String key)
        {
            return this.info[key];
        }

        public BaseInfoType[] Infos()
        {
            BaseInfoType[] a = new BaseInfoType[info.Count];
            info.Values.CopyTo(a, 0);
            return a;
        }

        private void AddNecessaryInfo()
        {
            
        }

        public byte[] Serialize()
        {
            AddNecessaryInfo();

            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream memoryStream = new MemoryStream();
            InfoFileStructure fileStructure;
            fileStructure.necessaryInfo = this.necessaryInfo;
            fileStructure.info = this.info;

            formatter.Serialize(memoryStream, fileStructure);
            byte[] data = memoryStream.ToArray();
            memoryStream.Close();
            return data;
        }

        public void Serialize(FileInfo fInfo)
        {
            AddNecessaryInfo();

            BinaryFormatter formatter = new BinaryFormatter();
            

            FileStream stream = fInfo.Open(FileMode.Create);
            InfoFileStructure fileStructure;
            fileStructure.necessaryInfo = this.necessaryInfo;
            fileStructure.info = this.info;
            formatter.Serialize(stream, fileStructure);
            stream.Close();
            
           
        }

        private static InfoFile Deserialize(byte[] data)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream memStream = new MemoryStream(data);
            memStream.Position = 0;
            InfoFileStructure infoDic = (InfoFileStructure)formatter.Deserialize(memStream);
            memStream.Close();

            return new InfoFile(infoDic);
        }

        private void ParseNecessaryInfo()
        {
            
        }

        public static InfoFile Parse(String path)
        {
            FileInfo info = new FileInfo(path);
            if (info.Exists)
            {
                FileStream reader = info.OpenRead();
                byte[] data = new byte[info.Length];
                reader.Read(data,0,data.Length);
                reader.Close();

                return Deserialize(data);
            }
            else
            {
                throw new FileNotFoundException("指定的信息文件不存在");
            }
        }

        public static InfoFile Parse(byte[] data)
        {
            return Deserialize(data);
        }
        
    }
}
