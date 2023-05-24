using System;
using System.Collections.Generic;
using System.IO;
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
using FunctionalLib;

namespace Libss
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Serialize_click(object sender, RoutedEventArgs e)
        {
            Person personKasha = new Person
            {
                Name = "Каша",
                Age = 17
            };

            Json.Serialize("person.json", personKasha);
        }

        private void Deserialize_click(object sender, RoutedEventArgs e)
        {
            Json.Deserialize<Person>("person.json");
        }
    }
}
