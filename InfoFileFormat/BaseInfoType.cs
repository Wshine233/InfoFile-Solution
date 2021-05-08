using System;
using System.Collections.Generic;
using System.Text;

namespace InfoFileFormat
{
    [Serializable]
    public abstract class BaseInfoType
    {
        public enum InfoType
        {
            LiteralText = 0,
            Picture = 1,
            RichText = 2,
            Tag = 3,
            NecessaryInfo = 4,
            InfoGroup = 5
        }

        public const String UPDATE_TIME = "latest_update_time";
        /**
         * 需要记录的元数据有：该项的最后更新时间
         */
        //Dictionary<String, Object> metadata
        public Dictionary<String, Object> Metadata { get; } = new Dictionary<String, object>();


        //Info项的名字
        protected String name;
        public String Name 
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        //Info项的数据
        protected byte[] data;
        public byte[] Data 
        {
            get
            {
                return data;
            }
        }

        public BaseInfoType()
        {
            UpdateTime();
        }

        public void SetData(byte[] data)
        {
            this.data = data;
        }

        protected void UpdateTime()
        {
            if (this.Metadata.ContainsKey(UPDATE_TIME))
            {
                this.Metadata[UPDATE_TIME] = DateTime.Now;
            }
            else
            {
                this.Metadata.Add(UPDATE_TIME, DateTime.Now);
            }
        }

        public abstract InfoType GetInfoType();
    }
}
