using System;
using System.Collections.ObjectModel; //
using System.ComponentModel; //
using System.Windows.Input;//
using kalum2021.Models; //
using System.Windows;//
using kalum2021.Views;//

namespace kalum2021.ModelView
{
    public class UsuariosViewModel:INotifyPropertyChanged, ICommand
    {
        public ObservableCollection<Usuarios> usuarios{get;set;}
        public UsuariosViewModel Instancia{get;set;}
        public Usuarios Seleccionado{get;set;}
        public UsuariosViewModel()
        {
            this.Instancia=this; 
            this.usuarios=new ObservableCollection<Usuarios>(); 
            this.usuarios.Add(new Usuarios(1,"hlopez",true,"Hector Leonel","Lopez Temaj","leohec@hotmail.com")); 
            this.usuarios.Add(new Usuarios(2,"gsunu",true,"Gloria","Sunu","gsunu@gmail.com"));  
        }

        //inicio INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotificarCambio(string propiedad)
        {
            if(PropertyChanged!=null)
            {
                PropertyChanged(this,new PropertyChangedEventArgs(propiedad));
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

        public void Execute(object parametro)
        {
            if(parametro.Equals("Nuevo"))
            {
                UsuarioView nuevoUsuario=new UsuarioView(Instancia); 
                nuevoUsuario.Show(); 
                /*Usuarios elemento=new Usuarios(100,"bcastillo",true,"Byron","Castillo","bcastillo@gmail.com"); 
                AgregarElemento(elemento); */ 
            }
            else if(parametro.Equals("Eliminar"))
            {
                if(this.Seleccionado==null)
                {
                    MessageBox.Show("Favor de seleccionar un elemento"); 
                }
                else
                {
                    this.usuarios.Remove(Seleccionado); 
                }
            }
        }
        //Fin Icommando
    }
}