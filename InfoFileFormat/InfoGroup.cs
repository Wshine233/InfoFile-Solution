using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoFileFormat
{
    [Serializable]
    public class InfoGroup<E> : BaseInfoType, IEnumerable<E> where E : BaseInfoType
    {
        public Dictionary<String, E> InfoList
        {
            get;
            set;

        } = new Dictionary<String, E>();


        public InfoGroup(String name) 
        {
            this.Name = name;
        }


        public int Count()
        {
            return InfoList.Count;
        }


        public int GetIndex(String name)
        {
            int i = 0;
            foreach(String n in InfoList.Keys)
            {
                if (n.Equals(name))
                {
                    return i;
                }
                i++;
            }

            return -1;
        }


        public E[] ToInfoArray()
        {
            E[] array = new E[Count()];

            foreach(KeyValuePair<String, E> info in InfoList)
            {
                array.Append(info.Value);
            }

            return array;
        }

        public override string ToString()
        {
            String s = "InfoGroup:" + Name + "\n";

            foreach(E info in InfoList.Values)
            {
                s += info.ToString() + "\n";
            }

            return s;
        }

        public override InfoType GetInfoType()
        {
            return InfoType.InfoGroup;
        }

        public IEnumerator<E> GetEnumerator()
        {
            GroupEnumerator<E> e = new GroupEnumerator<E>(this.InfoList.Values.ToArray());

            return e;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


    class GroupEnumerator<E> : IEnumerator<E>
    {
        public E[] arr;
        private int pos = -1;

        public E Current
        {
            get
            {
                return arr[pos];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return arr[pos];
            }
        }

        public GroupEnumerator(E[] array)
        {
            arr = array;
        }

        public void Dispose()
        {
            return;
        }

        public bool MoveNext()
        {
            if(pos + 1 >= arr.Length)
            {
                return false;
            }
            pos++;
            return true;
        }

        public void Reset()
        {
            pos = -1;
        }
    }
}
