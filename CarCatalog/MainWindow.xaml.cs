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


namespace CarCatalog
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Frame Mfc { get; set; }
        public static Image Logo { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Mfc = MainFrameCatalog;//set;
            MainFrameCatalog.Source =
                new Uri("Pages/Catalog.xaml", UriKind.RelativeOrAbsolute);
            
        }
    }
}
