using Microsoft.Toolkit.Mvvm.Input;
using System.Windows;

namespace Personas
{
    /// <summary>
    /// Lógica de interacción para DialogoNacionalidad.xaml
    /// </summary>
    public partial class DialogoNacionalidad : Window
    {
        public RelayCommand Cerrar { get; }

        public DialogoNacionalidad()
        {
            InitializeComponent();
            Cerrar = new RelayCommand(CerrarDialogo);
            this.DataContext = this;
        }

        private void CerrarDialogo()
        {
            this.Close();
        }
    }
}
