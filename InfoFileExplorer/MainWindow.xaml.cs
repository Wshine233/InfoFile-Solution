using InfoFileFormat;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InfoFileViewer
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] args = null;
        InfoFile file;
        string pathC = "";

        public static ObservableCollection<Context> bind = new ObservableCollection<Context>();

        Dictionary<string, string> dic = new Dictionary<string, string>();
        Dictionary<string, string> Dic 
        {
            get
            {
                return dic;
            }
            set
            {
                dic = value;
                SaveDic();
            }
        }


        public MainWindow()
        {
            InitializeComponent();
            dataGrid.ItemsSource = bind;
            
        }
        public MainWindow(string[] args)
        {
            InitializeComponent();
            this.args = args;
            foreach(string a in args)
            {
                MessageBox.Show(a);
            }
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            Init();

            string command = Environment.CommandLine;
            MessageBox.Show(command);
            string[] para = command.Split('\"');
            if (para.Length > 3)
            {
                pathC = para[3];
                FileInfo info = new FileInfo(pathC);
                file = GetInfoFile(pathC);
                //MessageBox.Show(info.Length.ToString());
                Refresh();

            }
            else
            {
                this.file = InfoFile.TEST_VALUE;
                Refresh();
            }
            
            
        }

        private void Init()
        {
            DirectoryInfo d = new DirectoryInfo("InfoFolder");
            if (!d.Exists) { d.Create(); };

            FileInfo info = new FileInfo("dics.db");
            if (info.Exists)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream stream = info.OpenRead();

                Dictionary<string, string> cache = formatter.Deserialize(stream) as Dictionary<string, string>;
                stream.Close();
                this.Dic = cache;
                
                if (Dic == null)
                {
                    Dic = new Dictionary<string, string>();
                }
            }
        }

        private void SaveDic()
        {
            FileInfo info = new FileInfo("dics.db");
            FileStream stream = info.Open(FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream,Dic);
            stream.Close();
        }

        private InfoFile GetInfoFile(string pathC)
        {
            if (!Dic.ContainsKey(pathC))
            {
                Dic.Add(pathC, "InfoFolder\\" + DateTime.Now.Ticks.ToString()) ;
                SaveDic();
                InfoFile file = new InfoFile(new FileInfo(pathC));
                file.Serialize(new FileInfo(Dic[pathC]));
                return file;
            }
            else
            {
                return InfoFile.Parse(Dic[pathC]);
            }
        }

        private void Refresh()
        {
            
            bind.Clear();
            foreach(BaseInfoType v in file.Infos())
            {
                bind.Add(new Context(v));
            }
            //dataGrid.ItemsSource = null;
            //dataGrid.ItemsSource = bind;
            //label1.Content = dic[pathC];
        }

        private void Window_DragEnter(object sender, DragEventArgs e)
        {
            
        }

        private void Window_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
                this.pathC = files[0];
                this.file = GetInfoFile(files[0]);
                Refresh();
            }
        }

        private void Add_Text_Click(object sender, RoutedEventArgs e)
        {
            bind.Add(new Context(new LiteralText("", "")));
            DataGridCell cell = dataGrid.GetCell(bind.Count - 1, 0);
            cell.Focus();
            cell.IsSelected = true;
            dataGrid.IsReadOnly = false;
            dataGrid.BeginEdit();
            //MessageBox.Show("233");
            //dataGrid.ItemsSource = null;
            //dataGrid.ItemsSource = bind;
        }

        private void Add_Image_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog fileDialog = new System.Windows.Forms.OpenFileDialog();
            fileDialog.Filter = "picture files (*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff)|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff";
            fileDialog.FilterIndex = 0;
            if (fileDialog.ShowDialog().Equals(System.Windows.Forms.DialogResult.OK))
            {
                Context con = new Context(new Picture("", new FileInfo(fileDialog.FileName)));
                bind.Add(con);
                DataGridCell cell = dataGrid.GetCell(bind.Count - 1, 0);
                cell.Focus();
                cell.IsSelected = true;
                dataGrid.IsReadOnly = false;
                dataGrid.BeginEdit();
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            file.Info.Clear();
            foreach(Context v in bind)
            {
                if (file.Info.ContainsKey(v.Name))
                {
                    MessageBox.Show("检查到重复的键\""+v.Name+"\"，请自行删除");
                }
                else
                {
                    file.Info.Add(v.Name, v.info);
                }
            }


            if (Dic.ContainsKey(pathC))
            {
                FileInfo info = new FileInfo(Dic[this.pathC]);
                file.Serialize(info);
                MessageBox.Show("保存完毕");
            }
            else
            {
                MessageBox.Show("未找到源文件与信息文件的关联");
            }


 
        }

        private void dataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Point p = e.GetPosition(dataGrid);
            DataGrid grid = sender as DataGrid;
            IInputElement element = grid.InputHitTest(p);
            DependencyObject target = element as DependencyObject;
            while (target != null)
            {
                if (target is DataGridCell)
                {
                    DataGridCell cell = target as DataGridCell;
                    if ((cell.Content as ContentPresenter) != null)
                    {
                        Context context = (cell.Content as ContentPresenter).Content as Context;
                        if (context != null && context.info.GetInfoType().Equals(BaseInfoType.InfoType.Picture))
                        {
                            System.Windows.Forms.OpenFileDialog fileDialog = new System.Windows.Forms.OpenFileDialog();
                            fileDialog.Filter = "picture files (*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff)|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff";
                            fileDialog.FilterIndex = 0;
                            if (fileDialog.ShowDialog().Equals(System.Windows.Forms.DialogResult.OK))
                            {
                                (context.info as Picture).SetData(System.Drawing.Image.FromFile(fileDialog.FileName));
                                context.Refresh();
                                dataGrid.IsReadOnly = false;
                                dataGrid.BeginEdit();
                                dataGrid.CancelEdit();
                            }
                        }
                        else
                        {
                            TextWindow tw = new TextWindow(this , ref context);
                            tw.Show();
                        }
                    }
                    else
                    {
                        dataGrid.IsReadOnly = false;
                        dataGrid.BeginEdit();
                    }
                    break;
                }
                target = VisualTreeHelper.GetParent(target);
            }
            
        }

        private void dataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            dataGrid.IsReadOnly = true;
        }

        private void dataGrid_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {
            
        }

    }
}
