using System;
using System.Collections.ObjectModel; //
using System.ComponentModel; //
using System.Windows.Input;//
using kalum2021.Models; //
using System.Windows;//
using kalum2021.Views;//
using MahApps.Metro.Controls.Dialogs;


namespace kalum2021.ModelView
{
    public class UsuariosViewModel : INotifyPropertyChanged, ICommand
    {
        public ObservableCollection<Usuarios> usuarios { get; set; }
        public UsuariosViewModel Instancia { get; set; }
        public Usuarios Seleccionado { get; set; }
        private IDialogCoordinator dialogCoordinator;
        public UsuariosViewModel(IDialogCoordinator instance)
        {
            this.Instancia = this;
            this.dialogCoordinator = instance;
            this.usuarios = new ObservableCollection<Usuarios>();
            this.usuarios.Add(new Usuarios(1, "hlopez", true, "Hector Leonel", "Lopez Temaj", "leohec@hotmail.com"));
            this.usuarios.Add(new Usuarios(2, "gsunu", true, "Gloria", "Sunu", "gsunu@gmail.com"));
        }

        //inicio INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotificarCambio(string propiedad)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propiedad));
            }
        }
        //fin INotifyPropertyChanged
        public void AgregarElemento(Usuarios nuevo)
        {
            this.usuarios.Add(nuevo);
        }

        //inicio Icommand
        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parametro)
        {
            return true;
        }

        public async void Execute(object parametro)
        {
            if (parametro.Equals("Nuevo"))
            {
                this.Seleccionado = null;
                UsuarioView nuevoUsuario = new UsuarioView(Instancia);
                nuevoUsuario.Show();
            }
            else if (parametro.Equals("Eliminar"))
            {
                if (this.Seleccionado == null)
                {
                    await this.dialogCoordinator.ShowMessageAsync(this, "Usuarios", "Debe seleccionar un elemento",
                    MessageDialogStyle.Affirmative);
                }
                else
                {
                    MessageDialogResult respuesta = await this.dialogCoordinator.ShowMessageAsync(this, "Eliminar usuario",
                    "Esta segurio de eliminar el registro", MessageDialogStyle.AffirmativeAndNegative);
                    if (respuesta == MessageDialogResult.Affirmative)
                    {
                        this.usuarios.Remove(Seleccionado);
                    }
                }
            }
            else if (parametro.Equals("Modificar"))
            {
                if (this.Seleccionado == null)
                {
                     await this.dialogCoordinator.ShowMessageAsync(this, "Usuarios", "Debe seleccionar un elemento",
                    MessageDialogStyle.Affirmative);
                }
                else
                {
                    UsuarioView modificarUsuario = new UsuarioView(Instancia);
                    modificarUsuario.ShowDialog();
                }
            }
        }
        //Fin Icommando
    }
}