using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace InfoFileViewer
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class TextWindow : Window
    {
        Context cache;
        MainWindow sender;

        public TextWindow(Window sender, ref Context content)
        {
            InitializeComponent();
            this.sender = sender as MainWindow; 
            this.cache = content;
            textBox.Text = content.Content;
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            cache.Content = textBox.Text;
            if(this.sender != null)
            {
                this.sender.dataGrid.ItemsSource = null;
                this.sender.dataGrid.ItemsSource = MainWindow.bind;
            }
            this.Close();
        }
    }
}
