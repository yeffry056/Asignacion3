using Asignacion3.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Asignacion3
{
    public class Cap7 
    {
        public static ArrayList Promedio(ArrayList calificaciones)
        {
            ArrayList resultados= new ArrayList();
            int suma = 0, mayor =0, menor;
            foreach(int i in calificaciones)
            {
                suma += i;
                if (i > mayor)
                    mayor = i;
            }
            menor = mayor;
            foreach (int i in calificaciones)
            {
                
                if (i != 0 && i < menor)
                    menor = i;
            }
            MessageBox.Show(Convert.ToString(calificaciones.Count), "Prueba", MessageBoxButton.OK, MessageBoxImage.Information);
            resultados.Add(suma / calificaciones.Count);
            resultados.Add(mayor);
            resultados.Add(menor);
            return resultados;
        }

        /*public static ArrayList Agenda1(T P)
        {
            AgendaPersonas p = new AgendaPersonas();
            ArrayList<P> dat = new ArrayList<P>();
            //dat.Add();
            return dat;
        }*/
    }
}
