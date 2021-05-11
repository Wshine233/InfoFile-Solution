using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RJ_Manager.CustomControls
{
    public class WebTab : TabControl
    {
        public const int MARGIN = 5;
        public static Font TEXT_FONT = new Font(new FontFamily("等线"), 10);

        public int minimumWidth = 55;
        public int maximumWidth = 200;
        public int tabWidth = 100;

        public WebTab()
        {
            base.SetStyle(
                            ControlStyles.UserPaint |                      // 控件将自行绘制，而不是通过操作系统来绘制  
                            ControlStyles.OptimizedDoubleBuffer |          // 该控件首先在缓冲区中绘制，而不是直接绘制到屏幕上，这样可以减少闪烁  
                            ControlStyles.AllPaintingInWmPaint |           // 控件将忽略 WM_ERASEBKGND 窗口消息以减少闪烁  
                            ControlStyles.ResizeRedraw |                   // 在调整控件大小时重绘控件  
                            ControlStyles.SupportsTransparentBackColor,    // 控件接受 alpha 组件小于 255 的 BackColor 以模拟透明  
            true);                                         // 设置以上值为 true  
            base.UpdateStyles();

            this.MouseClick += WebTab_MouseClick;

            //this.SizeMode = TabSizeMode.Normal;
            //this.ItemSize = new Size(tabWidth, 33);

        }

        private void WebTab_MouseClick(object sender, MouseEventArgs e)
        {
            for(int i = 0; i < TabCount; i++)
            {
                Rectangle bounds = GetTabRect(i);
                int x1 = bounds.X + bounds.Width - MARGIN - 8;
                int x2 = x1 + 8;
                int y1 = bounds.Y + (bounds.Height - 8) / 2;
                int y2 = y1 + 8;

                if (e.X >= x1 && e.X <= x2 && e.Y >= y1 && e.Y <= y2)
                {
                    int id = SelectedIndex;
                    TabPages.Remove(TabPages[i]);
                    SelectedIndex = Math.Min(TabPages.Count - 1, id);
                    return;
                }
            }
        }

        public void AddPage(TabPage page)
        {
            TabPages.Add(page);
            this.ItemSize = new Size(Math.Max(minimumWidth, Math.Min(Width / Math.Max(TabPages.Count, 1), maximumWidth)), 23);
            Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            SizeF textSize;
            PointF textPoint = new PointF();

            Brush textBrush = new SolidBrush(Color.Black);
            for (int i = 0; i < this.TabCount; i++)
            {
                textSize = TextRenderer.MeasureText(this.TabPages[i].Text, TEXT_FONT);
                //this.TabPages[i].Width = (int)Math.Ceiling(textSize.Width) + MARGIN * 2 + 8 + MARGIN;
                String fixedText = fixText(this.TabPages[i].Text);

                Rectangle bounds = this.GetTabRect(i);
                textPoint.X = bounds.X + MARGIN;
                textPoint.Y = bounds.Y + (bounds.Height - textSize.Height) / 2;

                DrawBackground(e.Graphics, bounds);
                if (this.SelectedIndex == i)
                {
                    DrawActiveBackground(e.Graphics, bounds);
                }
                e.Graphics.DrawString(fixedText, TEXT_FONT, textBrush, textPoint);
                //e.Graphics.DrawRectangle(Pens.Red, bounds);
                DrawX(e.Graphics, bounds);
            }
        }

        private string fixText(string text)
        {
            SizeF textSize = TextRenderer.MeasureText(text, TEXT_FONT);
            float targetWidth = ItemSize.Width - (MARGIN * 2 + 8 + MARGIN);

            for(int i = 1; i <= text.Length; i++)
            {
                textSize = TextRenderer.MeasureText(text.Substring(0, i), TEXT_FONT);
                if(textSize.Width > targetWidth)
                {
                    return text.Substring(0, i - 1) + "...";
                }
            }

            return text;
            
        }

        private void DrawActiveBackground(Graphics g, Rectangle bounds)
        {
            Brush backGroundBrush = new SolidBrush(Color.White);

            g.FillRectangle(backGroundBrush, bounds);
        }

        private void DrawBackground(Graphics g, Rectangle bounds)
        {
            Brush backGroundBrush = new SolidBrush(Color.Transparent);

            g.FillRectangle(backGroundBrush, bounds);
        }

        private void DrawX(Graphics g, Rectangle bounds)
        {
            Pen pen = new Pen(Color.Black, (float)1.8);
            int width = 8;
            int margin = MARGIN;
            int x1 = bounds.X + bounds.Width - margin - width;
            int x2 = x1 + width;
            int y1 = bounds.Y + (bounds.Height - width) / 2 ;
            int y2 = y1 + width;

            int x = this.PointToClient(MousePosition).X;
            int y = this.PointToClient(MousePosition).Y;

            //TabPages[0].Text = x.ToString();

            if(x >= x1 && x <= x2 && y >= y1 && y<= y2)
            {
                //pen.Color = Color.White;
                g.DrawLine(pen, x1, y1, x2, y2);
                g.DrawLine(pen, x1, y2, x2, y1);
            }
            else
            {
                g.DrawLine(pen, x1, y1, x2, y2);
                g.DrawLine(pen, x1, y2, x2, y1);
            } 
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            // Send TCM_SETMINTABWIDTH
            SendMessage(this.Handle, 0x1300 + 49, IntPtr.Zero, (IntPtr)10);
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
    }

    public class WebTabPage : TabPage
    {
        public int CalculateWidth = 0;

        public WebTabPage(String title)
        {
            CalculateWidth = TextRenderer.MeasureText(title, WebTab.TEXT_FONT).Width + WebTab.MARGIN * 2 + 8 + WebTab.MARGIN;
            //Size = new Size(CalculateWidth, 23);
        }
    }
}
