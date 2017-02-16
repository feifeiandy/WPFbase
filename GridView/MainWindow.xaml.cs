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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GridView
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        List<MyClass> myList;
        public MainWindow()
        {
            InitializeComponent();
             myList = new List<MyClass>() { 
        new MyClass(){ MyProperty=true, Name="张三"},
        new MyClass(){MyProperty=false, Name="李四"}
        };
             this.gd.ItemsSource = myList;
            //this.listview.ItemsSource = myList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(myList[0].MyProperty.ToString());
        }



    }

    class MyClass
    {
        public bool MyProperty { get; set; }
        public string Name { get; set; }
    }
}
