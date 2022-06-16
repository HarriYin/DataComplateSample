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

namespace DataComplateSample
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnTrigger_Click(object sender, RoutedEventArgs e)
        {
            List<Student> data = new List<Student>();

            data.Add(new Student() { Name = "Amy", Sex = "Woman" });
            data.Add(new Student() { Name = "Bob", Sex = "Man" });
            data.Add(new Student() { Name = "Candy", Sex = "Woman" });
            data.Add(new Student() { Name = "Eyer", Sex = "Woman" });
            data.Add(new Student() { Name = "Frank", Sex = "Man" });


            this.cbbTest.ItemsSource = data;

        }
    }

    public class Student
    {
        public string Name { get; set; }
        public string Sex { get; set; }
    }
}
