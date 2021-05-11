using RJ_Manager.CustomControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RJ_Manager.Factories
{
    public enum TabType
    {
        Content = 0
    }

    public class TabFactory
    {
        public static TabPage GetNewTabPage(String title, TabType type)
        {
            TabPage page = new TabPage(title);
            page.Width = TextRenderer.MeasureText(title, WebTab.TEXT_FONT).Width + WebTab.MARGIN * 2 + 8 + WebTab.MARGIN;

            switch (type)
            {
                case TabType.Content:
                    page.Controls.Add(new ContentPage());
                    break;
            }

            return page;
        }
    }

    
}
