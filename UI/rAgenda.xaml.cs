using Asignacion3.Entidades;
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
    /// Interaction logic for rAgenda.xaml
    /// </summary>
    public partial class rAgenda : Window
    {
        
        private ArrayList datos = new ArrayList();
       
        public rAgenda()
        {
            InitializeComponent();
            
            
        }
        private void Limpiar()
        {
            TextNombre.Text = string.Empty;
            TextTelefono.Text = string.Empty;
        }
        private bool Validar()
        {
            bool vacio = false;
            if(TextTelefono.Text.Length == 0 || TextNombre.Text.Length == 0)
            {
                MessageBox.Show("Campo vacio", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
                vacio = true;
            }
            return vacio;
        }
        private void BtnGuardar(object sender, RoutedEventArgs e)
        {
            AgendaPersonas agenda = new AgendaPersonas();
            if (Validar())
                return;
            agenda.Nombre = TextNombre.Text;
            agenda.Telefono = TextTelefono.Text;
            datos.Add(agenda);
            ListaGri.ItemsSource = ArrayList.Adapter(datos);          
          
            

        }
    }
}
