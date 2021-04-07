using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace InfoFileViewer.EventHandlers
{
    public static class TemplateImageEventHandlers
    {

        /// <summary>   
        /// 获取鼠标的坐标   
        /// </summary>   
        /// <param name="lpPoint">传址参数，坐标point类型</param>   
        /// <returns>获取成功返回真</returns>   
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool GetCursorPos(out Point pt);

        public static void toolTip_Closing(object sender, ToolTipEventArgs e)
        {
            Image im = sender as Image;
            if (im.IsMouseOver)
            {
                (im.ToolTip as ToolTip).Visibility = Visibility.Visible;
                
            }
            

        }
    }
}
