using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    class NewPersonVM : ObservableObject
    {
        public RelayCommand AbrirDialogo { get; }

        private readonly ServicioNavegacion servicio;

        public NewPersonVM()
        {
            servicio = new ServicioNavegacion();
            AbrirDialogo = new RelayCommand(AbrirDialogoNacionalidad);
        }

        private void AbrirDialogoNacionalidad()
        {
            servicio.AbrirDialogoNacionalidad();
        }
    }
}
