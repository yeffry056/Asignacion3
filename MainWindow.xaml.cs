using Asignacion3.UI;
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

namespace Asignacion3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Promedio_Clik(object sender, RoutedEventArgs e)
        {
            Escuela escuela = new Escuela();
            escuela.Show();
        }

        private void Promedio_ArrayListClik(object sender, RoutedEventArgs e)
        {
            Promedio promedio = new Promedio();
            promedio.Show();

        }

        private void AgendaTelefonica_Clik(object sender, RoutedEventArgs e)
        {
            rAgenda a = new rAgenda();
            a.Show();
        }

       
    }
}
