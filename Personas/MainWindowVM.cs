using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System.Windows.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    class MainWindowVM : ObservableObject
    {
        public RelayCommand NewPersonCommand { get; }
        public RelayCommand ListPersonsCommand { get; }

        private ServicioNavegacion servicio;

        public MainWindowVM()
        {
            servicio = new ServicioNavegacion();
            NewPersonCommand = new RelayCommand(AbrirNewPerson);

        }

        private UserControl ventanaVisible;

        public UserControl VentanaVisible
        {
            get { return ventanaVisible; }
            set { SetProperty(ref ventanaVisible, value); }
        }

        private void AbrirNewPerson()
        {
            VentanaVisible = servicio.AbrirNewPerson();
        }

    }
}
