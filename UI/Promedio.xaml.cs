using System;
using System.Collections;
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

namespace Asignacion3.UI
{
    /// <summary>
    /// Interaction logic for Promedio.xaml
    /// </summary>
    public partial class Promedio : Window
    {
        ArrayList calificaciones = new ArrayList();
        public Promedio()
        {
            InitializeComponent();
        }

        private void BtnAgregarCalificaciones(object sender, RoutedEventArgs e)
        {
            if (TextCalificaciones.Text.Length != 0)
            {
                calificaciones.Add(Convert.ToInt32(TextCalificaciones.Text));
                TextCalificaciones.Text = string.Empty;
                BtnCalcular.IsEnabled = true;

            }
            else
                MessageBox.Show("Calificaciones vacia", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            
        }

        private void BtnCalcularClik(object sender, RoutedEventArgs e)
        {
            
            ArrayList resultados = new ArrayList();
            resultados = Cap7.Promedio(calificaciones);
            TextPromedio.Text = Convert.ToString(resultados[0]);
            TextCalificacionMayor.Text = Convert.ToString(resultados[1]);
            TextCalificacionMenor.Text = Convert.ToString(resultados[2]);
            calificaciones = new ArrayList();
            BtnCalcular.IsEnabled = false;
           
            
        }

        private void BtnNuevo_Click_1(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            TextPromedio.Text = string.Empty;
            TextCalificacionMayor.Text = string.Empty;
            TextCalificacionMenor.Text = string.Empty;
            calificaciones = new ArrayList();
            BtnCalcular.IsEnabled = false;
        }

       

        
    }
}
