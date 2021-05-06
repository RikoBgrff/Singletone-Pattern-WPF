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

namespace Singletone_Pattern_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Car> cars { get; set; } = new List<Car>();
        public MainWindow()
        {
            this.DataContext = this;
            InitializeComponent();

            //Singletone.Instance.DeleteCar(cars, car);
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            Car car = new Car
            {
                Vendor = VendorTextBox.Text,
                Model = ModelTextBox.Text,
                Year = YearTextBox.Text
           };
            Singletone.Instance.AddCar(cars, car);
            listbox.ItemsSource = cars;
        }

        private void VendorTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
