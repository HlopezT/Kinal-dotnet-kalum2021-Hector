using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using kalum2021.Models;

namespace kalum2021.ModelView
{
    public class RoleViewModel : INotifyPropertyChanged, ICommand
    {
        public RoleViewModel Instancia{get;set;}
        public RolesViewModel RolesViewModel{get;set;}
        public string Nombre{get;set;}
        public Role Role{get;set;} //referencia
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler CanExecuteChanged;

        public RoleViewModel(RolesViewModel RolesViewModel)
        {
            this.Instancia=this; 
            this.RolesViewModel=RolesViewModel; 
            if(this.RolesViewModel.Seleccionado!=null)
            {
                this.Role=new Role(); 
                this.Role.Id=this.RolesViewModel.Seleccionado.Id; 
                this.Nombre=this.RolesViewModel.Seleccionado.Nombre; 
            }
        }
        public bool CanExecute(object parametro)
        {
            return true; 
        }

        public void Execute(object parametro)
        {
            if(parametro is Window)
            {
                if(this.RolesViewModel.Seleccionado==null)
                {
                    Role nuevo=new Role(200,Nombre);
                    this.RolesViewModel.AgregarElemento(nuevo); 
                }
                else
                {
                    Role.Nombre=this.Nombre; 
                    int posicion=this.RolesViewModel.roles.IndexOf(this.RolesViewModel.Seleccionado); 
                    this.RolesViewModel.roles.RemoveAt(posicion); 
                    this.RolesViewModel.roles.Insert(posicion,Role); 
                }
                ((Window)parametro).Close(); 
            }
        }
    }
}