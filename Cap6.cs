using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Asignacion3
{
    public class Cap6
    {
        public static int[] Calcular(int[][] arrayjagged)
        {
            int[] resultados = new int[3];
            int suma = 0, mayor = 0, menor = 0, cantidad = 0;
            for(int i = 0; i < arrayjagged.Length; i++)
            {
                for(int j =0; j < arrayjagged[i].GetLength(0); j++)
                {

                    suma += arrayjagged[i][j];
                    cantidad++;
                    if (arrayjagged[i][j] > mayor)
                        mayor = arrayjagged[i][j];


                }
            }
           // MessageBox.Show(Convert.ToString(suma), "Prueba", MessageBoxButton.OK, MessageBoxImage.Information);
        
        menor = mayor;
            for (int i = 0; i < arrayjagged.Length; i++)
            {
                for (int j = 0; j < arrayjagged[i].GetLength(0); j++)
                {
                
                    if (arrayjagged[i][j] != 0 && arrayjagged[i][j] < menor)
                        menor = arrayjagged[i][j];


                }
            }
            resultados[0] = suma / cantidad;
            resultados[1] = mayor;
            resultados[2] = menor;
            return resultados;
        }
    }
}
