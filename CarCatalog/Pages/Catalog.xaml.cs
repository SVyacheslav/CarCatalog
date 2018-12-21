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


namespace CarCatalog.Pages
{
    /// <summary>
    /// Логика взаимодействия для Catalog.xaml
    /// </summary>
    public partial class Catalog : Page
    {
        

        public Catalog()
        {
            InitializeComponent();
        }

        private void Lb01_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow.Logo = new Image
            {
                Source = audi.Source
            };
            MainWindow.Mfc.NavigationService.Navigate(new Uri("Pages/SearchIntoCatalog.xaml", UriKind.Relative));
        }

        private void Lb02_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow.Logo = new Image
            {
                Source = bmw.Source
            };
            MainWindow.Mfc.NavigationService.Navigate(new Uri("Pages/SearchIntoCatalog.xaml", UriKind.Relative));
        }

        private void Lb03_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow.Logo = new Image
            {
                Source = bmwmotor.Source
            };
            MainWindow.Mfc.NavigationService.Navigate(new Uri("Pages/SearchIntoCatalog.xaml", UriKind.Relative));
        }

        private void Lb04_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow.Logo = new Image
            {
                Source = chrysler.Source
            };
            MainWindow.Mfc.NavigationService.Navigate(new Uri("Pages/SearchIntoCatalog.xaml", UriKind.Relative));
        }

        private void Lb05_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow.Logo = new Image
            {
                Source = citroen.Source
            };
            MainWindow.Mfc.NavigationService.Navigate(new Uri("Pages/SearchIntoCatalog.xaml", UriKind.Relative));
        }

        private void Lb06_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow.Logo = new Image
            {
                Source = dacia.Source
            };
            MainWindow.Mfc.NavigationService.Navigate(new Uri("Pages/SearchIntoCatalog.xaml", UriKind.Relative));
        }

        private void Lb07_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow.Logo = new Image
            {
                Source = dodge.Source
            };
            MainWindow.Mfc.NavigationService.Navigate(new Uri("Pages/SearchIntoCatalog.xaml", UriKind.Relative));
        }

        private void Lb08_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
               MainWindow.Logo = new Image
            {
                Source = honda.Source
            };
            MainWindow.Mfc.NavigationService.Navigate(new Uri("Pages/SearchIntoCatalog.xaml", UriKind.Relative));
        }

        private void Lb09_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow.Logo = new Image
            {
                Source = hyundai.Source
            };
            MainWindow.Mfc.NavigationService.Navigate(new Uri("Pages/SearchIntoCatalog.xaml", UriKind.Relative));
        }

        private void Lb10_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow.Logo = new Image
            {
                Source = infiniti.Source
            };
            MainWindow.Mfc.NavigationService.Navigate(new Uri("Pages/SearchIntoCatalog.xaml", UriKind.Relative));
        }

        private void Lb11_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow.Logo = new Image
            {
                Source = isuzu.Source
            };
            MainWindow.Mfc.NavigationService.Navigate(new Uri("Pages/SearchIntoCatalog.xaml", UriKind.Relative));
        }

        private void Lb12_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow.Logo = new Image
            {
                Source = jaguar.Source
            };
            MainWindow.Mfc.NavigationService.Navigate(new Uri("Pages/SearchIntoCatalog.xaml", UriKind.Relative));
        }

        private void Lb13_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow.Logo = new Image
            {
                Source = jeep.Source
            };
            MainWindow.Mfc.NavigationService.Navigate(new Uri("Pages/SearchIntoCatalog.xaml", UriKind.Relative));
        }

        private void Lb14_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow.Logo = new Image
            {
                Source = kia.Source
            };
            MainWindow.Mfc.NavigationService.Navigate(new Uri("Pages/SearchIntoCatalog.xaml", UriKind.Relative));
        }

        private void Lb15_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow.Logo = new Image
            {
                Source = landrover.Source
            };
            MainWindow.Mfc.NavigationService.Navigate(new Uri("Pages/SearchIntoCatalog.xaml", UriKind.Relative));
        }

        private void Lb16_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow.Logo = new Image
            {
                Source = lexus.Source
            };
            MainWindow.Mfc.NavigationService.Navigate(new Uri("Pages/SearchIntoCatalog.xaml", UriKind.Relative));
        }

        private void Lb17_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow.Logo = new Image
            {
                Source = mazda.Source
            };
            MainWindow.Mfc.NavigationService.Navigate(new Uri("Pages/SearchIntoCatalog.xaml", UriKind.Relative));
        }

        private void Lb18_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow.Logo = new Image
            {
                Source = mersedes.Source
            };
            MainWindow.Mfc.NavigationService.Navigate(new Uri("Pages/SearchIntoCatalog.xaml", UriKind.Relative));
        }

        private void Lb19_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow.Logo = new Image
            {
                Source = mini.Source
            };
            MainWindow.Mfc.NavigationService.Navigate(new Uri("Pages/SearchIntoCatalog.xaml", UriKind.Relative));
        }

        private void Lb20_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow.Logo = new Image
            {
                Source = mitsubishi.Source
            };
            MainWindow.Mfc.NavigationService.Navigate(new Uri("Pages/SearchIntoCatalog.xaml", UriKind.Relative));
        }

        private void Lb21_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow.Logo = new Image
            {
                Source = nissan.Source
            };
            MainWindow.Mfc.NavigationService.Navigate(new Uri("Pages/SearchIntoCatalog.xaml", UriKind.Relative));
        }

        private void Lb22_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow.Logo = new Image
            {
                Source = peugeot.Source
            };
            MainWindow.Mfc.NavigationService.Navigate(new Uri("Pages/SearchIntoCatalog.xaml", UriKind.Relative));
        }

        private void Lb23_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow.Logo = new Image
            {
                Source = porsche.Source
            };
            MainWindow.Mfc.NavigationService.Navigate(new Uri("Pages/SearchIntoCatalog.xaml", UriKind.Relative));
        }

        private void Lb24_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow.Logo = new Image
            {
                Source = ram.Source
            };
            MainWindow.Mfc.NavigationService.Navigate(new Uri("Pages/SearchIntoCatalog.xaml", UriKind.Relative));
        }

        private void Lb25_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow.Logo = new Image
            {
                Source = renault.Source
            };
            MainWindow.Mfc.NavigationService.Navigate(new Uri("Pages/SearchIntoCatalog.xaml", UriKind.Relative));
        }

        private void Lb26_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
             MainWindow.Logo = new Image
            {
                Source = rollsroyce.Source
            };
            MainWindow.Mfc.NavigationService.Navigate(new Uri("Pages/SearchIntoCatalog.xaml", UriKind.Relative));
        }

        private void Lb27_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow.Logo = new Image
            {
                Source = seat.Source
            };
            MainWindow.Mfc.NavigationService.Navigate(new Uri("Pages/SearchIntoCatalog.xaml", UriKind.Relative));
        }

        private void Lb28_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow.Logo = new Image
            {
                Source = skoda.Source
            };
            MainWindow.Mfc.NavigationService.Navigate(new Uri("Pages/SearchIntoCatalog.xaml", UriKind.Relative));
        }

        private void Lb29_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow.Logo = new Image
            {
                Source = smart.Source
            };
            MainWindow.Mfc.NavigationService.Navigate(new Uri("Pages/SearchIntoCatalog.xaml", UriKind.Relative));
        }

        private void Lb30_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow.Logo = new Image
            {
                Source = ssangyong.Source
            };
            MainWindow.Mfc.NavigationService.Navigate(new Uri("Pages/SearchIntoCatalog.xaml", UriKind.Relative));
        }

        private void Lb31_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow.Logo = new Image
            {
                Source = suzuki.Source
            };
            MainWindow.Mfc.NavigationService.Navigate(new Uri("Pages/SearchIntoCatalog.xaml", UriKind.Relative));
        }

        private void Lb32_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow.Logo = new Image
            {
                Source = toyota.Source
            };
            MainWindow.Mfc.NavigationService.Navigate(new Uri("Pages/SearchIntoCatalog.xaml", UriKind.Relative));
        }

        private void Lb33_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow.Logo = new Image
            {
                Source = volkswagen.Source
            };
            MainWindow.Mfc.NavigationService.Navigate(new Uri("Pages/SearchIntoCatalog.xaml", UriKind.Relative));
        }

        private void Lb34_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow.Logo = new Image
            {
                Source = volvo.Source
            };
            MainWindow.Mfc.NavigationService.Navigate(new Uri("Pages/SearchIntoCatalog.xaml", UriKind.Relative));
        }
    }
}
