using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;

namespace RJ_Manager
{

    public class ListViewColumnSorter : IComparer
    {
        #region 属性

        private CaseInsensitiveComparer _objectCompare;

        private int _sortColumn;
        /// <summary>
        /// 获取或设置要排序的列
        /// </summary>
        public int SortColumn
        {
            get { return _sortColumn; }
            set { _sortColumn = value; }
        }

        private SortOrder _orderType;
        /// <summary>
        /// 获取或设置排序方式
        /// </summary>
        public SortOrder OrderType
        {
            get { return _orderType; }
            set { _orderType = value; }
        }

        private bool _stringNumOrder;
        /// <summary>
        /// 获取或设置字符串中的数字是否按照正常理解顺序排序
        /// </summary>
        public bool StringNumOrder
        {
            get { return _stringNumOrder; }
            set { _stringNumOrder = value; }
        }

        #endregion

        public ListViewColumnSorter()
        {
            _sortColumn = 0;

            _stringNumOrder = false;

            _orderType = SortOrder.None;

            _objectCompare = new CaseInsensitiveComparer();
        }


        public int Compare(object x, object y)
        {
            int compareResult = 0;

            string stringX = ((ListViewItem)x).SubItems[_sortColumn].Text;
            string stringY = ((ListViewItem)y).SubItems[_sortColumn].Text;
            DateTime dtx = new DateTime();
            DateTime dty = new DateTime();
            int intx = new int();
            int inty = new int();
            double doublex = new double();
            double doubley = new double();

            if (DateTime.TryParse(stringX, out dtx) && DateTime.TryParse(stringY, out dty))
            {
                compareResult = _objectCompare.Compare(dtx, dty);
            }
            else if (int.TryParse(stringX, out intx) && int.TryParse(stringY, out inty))
            {
                compareResult = _objectCompare.Compare(intx, inty);
            }
            else if (double.TryParse(stringX, out doublex) && double.TryParse(stringY, out doubley))
            {
                compareResult = _objectCompare.Compare(doublex, doubley);
            }
            else
            {
                if (_stringNumOrder == true)
                    compareResult = StringNumCompare(stringX, stringY);
                if (compareResult == 0)
                    compareResult = _objectCompare.Compare(stringX, stringY);
            }

            if (_orderType == SortOrder.Ascending)
            {
                return compareResult;
            }
            else if (_orderType == SortOrder.Descending)
            {
                return (-compareResult);
            }
            else
            {
                return 0;
            }

        }

        //对字符串中相同位置的数字进行对比
        private int StringNumCompare(string stringX, string stringY)
        {
            int returnValue = 0;
            int stringCount = stringX.Count() > stringY.Count() ? stringY.Count() : stringX.Count();
            for (int i = 0; i < stringCount; i++)
            {
                int tempX;
                int tempY;
                if ((stringX[i] != stringY[i]) && int.TryParse(stringX[i].ToString(), out tempX) && int.TryParse(stringY[i].ToString(), out tempY))
                {
                    tempX = GetStringNum(tempX, i + 1, stringCount, stringX);
                    tempY = GetStringNum(tempY, i + 1, stringCount, stringY);
                    if (tempX > tempY)
                        returnValue = 1;
                    else if (tempX < tempY)
                        returnValue = -1;

                    if (returnValue == 0)
                        continue;
                    else
                        break;
                }
            }

            return returnValue;
        }

        //获取字符串中的数字
        private int GetStringNum(int returnValue, int i, int stringCount, string stringTemp)
        {
            int temp;
            if (i < stringCount && int.TryParse(stringTemp[i].ToString(), out temp))
            {
                returnValue = returnValue * 10 + temp;
                GetStringNum(returnValue, i + 1, stringCount, stringTemp);
            }
            return returnValue;
        }
    }
}