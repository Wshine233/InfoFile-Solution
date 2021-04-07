using InfoFileFormat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using InfoFileViewer.EventHandlers;

namespace InfoFileViewer
{
    class ValueSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            DataTemplate dt = new DataTemplate();
            if (item != null && item is Context)
            {
                BaseInfoType model = (item as Context).info;
                MainWindow window = (MainWindow)Application.Current.MainWindow;
                if (model.GetInfoType().Equals(BaseInfoType.InfoType.LiteralText))
                {
                    //实例化标签控件
                    FrameworkElementFactory label = new FrameworkElementFactory(typeof(Label));
                    label.SetBinding(Label.ContentProperty, new Binding()
                    {
                        Path = new PropertyPath("Content"),
                        Mode = BindingMode.TwoWay,
                        UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
                    });
                    label.SetValue(Label.ForegroundProperty, Brushes.Black);
                    label.SetValue(Label.HorizontalAlignmentProperty, HorizontalAlignment.Center);
                    TextBlock tb = new TextBlock();        
                    ToolTip tt = new ToolTip();
                    tb = new TextBlock();
                    tb.MaxWidth = 700;
                    tb.TextWrapping = TextWrapping.Wrap;
                    tt.Content = tb;
                    label.SetValue(Label.ToolTipProperty, tt);
                    label.AddHandler(UIElement.MouseMoveEvent, new MouseEventHandler(TemplateLabelEventHandlers.label_MouseMove));
                    label.AddHandler(UIElement.MouseLeaveEvent, new MouseEventHandler(TemplateLabelEventHandlers.label_MouseLeave));
                    dt.VisualTree = label;

                }
                else if (model.GetInfoType().Equals(BaseInfoType.InfoType.Picture))
                {
                    //实例化图像框控件
                    FrameworkElementFactory image = new FrameworkElementFactory(typeof(Image));
                    image.SetBinding(Image.SourceProperty, new Binding()
                    {
                        Path = new PropertyPath("Source"),
                        Mode = BindingMode.TwoWay,
                        UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
                    });
                    Image im = new Image();
                    im.MaxWidth = 700;
                    im.MaxHeight = 700;
                    im.Stretch = Stretch.Uniform;
                    im.SetBinding(Image.SourceProperty, new Binding()
                    {
                        Path = new PropertyPath("Source"),
                        Mode = BindingMode.TwoWay,
                        UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
                    });
                    ToolTip tt = new ToolTip();
                    tt.Content = im;
                    image.SetValue(Image.ToolTipProperty, tt);
                    image.AddHandler(Image.ToolTipClosingEvent, new ToolTipEventHandler(TemplateImageEventHandlers.toolTip_Closing));
                    image.SetValue(Image.StretchProperty, Stretch.Uniform);
                    dt.VisualTree = image;
                }
                else
                {
                    //实例化文本控件
                    FrameworkElementFactory txtBox = new FrameworkElementFactory(typeof(TextBox));
                    txtBox.SetBinding(TextBox.TextProperty, new Binding()
                    {
                        Path = new PropertyPath("Content"),
                        Mode = BindingMode.TwoWay,
                        UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
                    });
                    txtBox.SetValue(TextBox.ForegroundProperty, Brushes.White);
                    txtBox.SetValue(TextBox.BackgroundProperty, new SolidColorBrush(Colors.Transparent));
                    dt.VisualTree = txtBox;
                }
            }
            return dt;
        }
    }
}
