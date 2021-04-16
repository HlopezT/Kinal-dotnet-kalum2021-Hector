using System;
using System.Collections.ObjectModel; //
using System.ComponentModel; //
using System.Windows.Input;//
using kalum2021.Models; //
using System.Windows;//
using kalum2021.Views;//

namespace kalum2021.ModelView
{
    public class RolesViewModel:INotifyPropertyChanged, ICommand
    {
        public ObservableCollection<Role> roles{get;set;}
         public RolesViewModel Instancia{get;set;}
        public Role Seleccionado{get;set;}
        public RolesViewModel()
        {
            this.Instancia=this; 
            this.roles=new ObservableCollection<Role>(); 
            this.roles.Add(new Role(1,"Administrador")); 
            this.roles.Add(new Role(2,"Operador")); 
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotificarCambio(string propiedad)
        {
            if(PropertyChanged!=null)
            {
                PropertyChanged(this,new PropertyChangedEventArgs(propiedad));
            }
        }
        public void AgregarElemento(Role nuevo)
        {
            this.roles.Add(nuevo); 
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parametro)
        {
            return true; 
        }
        public void Execute(object parametro)
        {
            if(parametro.Equals("Nuevo"))
            {
                this.Seleccionado=null;//se define que seleccionado es igual a nulo 
                RoleView nuevoRol=new RoleView(Instancia); 
                nuevoRol.Show(); 
            }
            else if(parametro.Equals("Eliminar"))
            {
                if(this.Seleccionado==null)
                {
                    MessageBox.Show("Favor de seleccionar un elemento"); 
                }
                else
                {
                    this.roles.Remove(Seleccionado); 
                }
            }
            else if(parametro.Equals("Modificar"))
            {
                if(this.Seleccionado==null)
                {
                    MessageBox.Show("Favor de seleccionar un elemento"); 
                }
                else
                {
                    RoleView modificarRol=new RoleView(Instancia); 
                    modificarRol.ShowDialog(); 
                }
            }
        }
    }
}