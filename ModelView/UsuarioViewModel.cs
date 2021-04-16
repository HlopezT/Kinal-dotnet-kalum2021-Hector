using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using kalum2021.Models;
using MahApps.Metro.Controls.Dialogs;//

namespace kalum2021.ModelView
{
    public class UsuarioViewModel : INotifyPropertyChanged, ICommand
    {
        public UsuarioViewModel Instancia { get; set; }
        public UsuariosViewModel UsuariosViewModel { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string HeightLbPassword { get; set; } //ancho del password auto ajuste
        public string HeightTxtPassword { get; set; } //ancho del pasword auto ajuste
        public Usuarios Usuario { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler CanExecuteChanged;
        private IDialogCoordinator dialogCoordinator;//
        public UsuarioViewModel(UsuariosViewModel UsuariosViewModel, IDialogCoordinator instance)
        {
            this.Instancia = this;
            this.UsuariosViewModel = UsuariosViewModel;
            this.dialogCoordinator = instance;//
            if (this.UsuariosViewModel.Seleccionado != null) //aca recibe la instruccion al momento de modificar.
            {
                this.Usuario = new Usuarios();
                this.Usuario.Id = this.UsuariosViewModel.Seleccionado.Id;
                this.Usuario.Enabled = this.UsuariosViewModel.Seleccionado.Enabled;
                this.Apellidos = this.UsuariosViewModel.Seleccionado.Apellidos;
                this.Nombres = this.UsuariosViewModel.Seleccionado.Nombres;
                this.Email = this.UsuariosViewModel.Seleccionado.Email;
                this.Username = this.UsuariosViewModel.Seleccionado.Username;
                this.HeightLbPassword = "0"; //para ocultar
                this.HeightTxtPassword = "0"; //para ocultar
            }
        }
        public bool CanExecute(object parametros)
        {
            return true;
        }
        public async void Execute(object parametro)
        {
            if (parametro is Window)
            {
                if (this.UsuariosViewModel.Seleccionado == null)
                {//insertar
                    Usuarios nuevo = new Usuarios(100, Username, true, Nombres, Apellidos, Email);
                    nuevo.Password = ((PasswordBox)((Window)parametro).FindName("TxtPassword")).Password;
                    this.UsuariosViewModel.AgregarElemento(nuevo);
                    await dialogCoordinator.ShowMessageAsync(this,"Agregar usuario","Elemento almacenado correctamente",
                    MessageDialogStyle.Affirmative); 

                }
                else
                {//mostrar seleccion para editar
                    Usuario.Apellidos = this.Apellidos;
                    Usuario.Nombres = this.Nombres;
                    Usuario.Email = this.Email;
                    Usuario.Username = this.Username;
                    int posicion = this.UsuariosViewModel.usuarios.IndexOf(this.UsuariosViewModel.Seleccionado);
                    this.UsuariosViewModel.usuarios.RemoveAt(posicion);
                    this.UsuariosViewModel.usuarios.Insert(posicion, Usuario);
                    await dialogCoordinator.ShowMessageAsync(this,"Actualizar usuario","Elemento actualizado correctamente",
                    MessageDialogStyle.Affirmative); 
                }
                ((Window)parametro).Close();
            }
        }
    }
}