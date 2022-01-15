using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Personas
{
    class ServicioNavegacion
    {

        public ServicioNavegacion()
        {
        }

        internal UserControl AbrirNewPerson()
        {
            return new NewPerson();
        }

        public bool? AbrirDialogoNacionalidad()
        {
            DialogoNacionalidad ventana = new DialogoNacionalidad();
            ventana.Owner = Application.Current.MainWindow;
            return ventana.ShowDialog();
        }

    }
}
