using System;
using System.Collections.Generic;
using System.Text;

namespace InfoFileFormat
{
    [Serializable]
    public abstract class BaseInfoType
    {
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
        }

        //Info项的数据
        private byte[] data;
        public byte[] Data 
        {
            get
            {
                return data;
            }
        }

        public void setData(byte[] data)
        {
            this.data = data;
        }

        protected void updateTime()
        {
            this.Metadata.Add(UPDATE_TIME, DateTime.Now);
        }
    }
}
