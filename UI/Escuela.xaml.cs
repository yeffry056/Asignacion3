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

namespace Asignacion3.UI
{
    /// <summary>
    /// Interaction logic for Escuela.xaml
    /// </summary>
    public partial class Escuela : Window
    {
        private int CantidadSalones = 0;
       
        private int contador = 0;
        private int cont = 0;
        private int[][] ArrayJagged;
        public Escuela()
        {
            InitializeComponent();
        }
       

        private void BtnAgregarSalones(object sender, RoutedEventArgs e)
        {
            
            if(TextCantidadSalones.Text.Length == 0)
            {
                MessageBox.Show("Cantidad de salones vacia", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (Convert.ToInt32(TextCantidadSalones.Text) != 0)
            {
                CantidadSalones = Convert.ToInt32(TextCantidadSalones.Text);
               
                ArrayJagged = new int[CantidadSalones][];
                
                BtnSalones.IsEnabled = false;
                TextCantidadSalones.IsEnabled = false;
                BtnAlumnos.IsEnabled = true;
                TextCantidadAlumnos.IsEnabled = true;
                BtnNuevo.IsEnabled = true;
                MessageBox.Show("Cantidad de salones agregada", "Existo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("Debe de agregar una cantidad de salones mayor que 0", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);

        }

        private void BtnAgregarAlumnos(object sender, RoutedEventArgs e)
        {
            if(TextCantidadAlumnos.Text.Length == 0)
            {
                MessageBox.Show("Cantidad de alumnos vacia", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }else if(Convert.ToInt32(TextCantidadAlumnos.Text) == 0)
            {
                MessageBox.Show("La cantidad de alumnos debe ser mayor que 0", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (cont != CantidadSalones)
            {
                ArrayJagged[cont] = new int[Convert.ToInt32(TextCantidadAlumnos.Text)];
                cont++;
                if (cont == CantidadSalones)
                {
                    BtnAlumnos.IsEnabled = false;
                    TextCantidadAlumnos.IsEnabled = false;
                    BtnCalificaciones.IsEnabled = true;
                    TextCalificaciones.IsEnabled = true;
                    cont = 0;
                    MessageBox.Show("Cantidad de alumnos Completada", "Existo", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                    TextCantidadAlumnos.Text = string.Empty;
                    
            }
            
            
            
        }

        private void BtnAgregarCalificaciones(object sender, RoutedEventArgs e)
        {
            if (cont != CantidadSalones)
            {

                if (contador != ArrayJagged[cont].GetLength(0))
                {
                    ArrayJagged[cont][contador] = Convert.ToInt32(TextCalificaciones.Text);
                    contador++;
                    if (contador == ArrayJagged[cont].GetLength(0))
                    {
                        cont++;
                        if (cont == CantidadSalones)
                        {
                            BtnCalificaciones.IsEnabled = false;
                            TextCalificaciones.IsEnabled = false;
                            BtnCalcular.IsEnabled = true;
                        }
                        else
                            TextCalificaciones.Text = string.Empty;
                        contador = 0;
                    }
                    else
                        TextCalificaciones.Text = string.Empty;
                }
            }
           
            //MessageBox.Show(Convert.ToString(ArrayJagged[1].GetLength(0)), "Prueba", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnCalcularClik(object sender, RoutedEventArgs e)
        {
            int[] resultados = new int[3];
            resultados = Cap6.Calcular(ArrayJagged);

            TextPromedio.Text = Convert.ToString(resultados[0]);
            TextCalificacionMayor.Text = Convert.ToString(resultados[1]);
            TextCalificacionMenor.Text = Convert.ToString(resultados[2]);
            
        }

        private void BtnNuevoClik(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            TextCalificaciones.Text = string.Empty;
            TextCalificacionMayor.Text = string.Empty;
            TextCalificacionMenor.Text = string.Empty;
            TextCantidadAlumnos.Text = string.Empty;
            TextCantidadSalones.Text = string.Empty;
            TextPromedio.Text = string.Empty;
            BtnAlumnos.IsEnabled = false;
            TextCantidadAlumnos.IsEnabled = false;
            BtnCalificaciones.IsEnabled = false;
            TextCalificaciones.IsEnabled = false;
            BtnSalones.IsEnabled = true;
            TextCantidadSalones.IsEnabled = true;
        }
    }
}
