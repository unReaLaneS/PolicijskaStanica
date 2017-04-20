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

namespace PolicijskaStanica
{
    /// <summary>
    /// Interaction logic for prikazLica.xaml
    /// </summary>
    public partial class prikazLica : Window
    {
        public prikazLica()
        {
            InitializeComponent();
        }

        private void Button_odustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
