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


namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private laba1Entities context = new laba1Entities();
        List<Krasivo> krasivos = new List<Krasivo>();


        public MainWindow()
        {
            InitializeComponent();

            foreach (var item in context.Users.ToList())
            {
                krasivos.Add(new Krasivo(item));
            }
            UsersDgr.ItemsSource = krasivos;
        }
    }
}
