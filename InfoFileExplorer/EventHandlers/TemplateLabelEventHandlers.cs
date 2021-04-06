using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace InfoFileViewer.EventHandlers
{
    public static class TemplateLabelEventHandlers
    {
        public static void label_MouseMove(object sender, MouseEventArgs e)
        {
            Label label = sender as Label;
            ToolTip tt = label.ToolTip as ToolTip;
            //tt.Content = label.Content;
            ((TextBlock)tt.Content).Text = label.Content as String;
            tt.IsOpen = true;

        }

        public static void label_MouseLeave(object sender, MouseEventArgs e)
        {
            Label label = sender as Label;
            ToolTip tt = label.ToolTip as ToolTip;
            tt.IsOpen = false;
        }
    }
}
