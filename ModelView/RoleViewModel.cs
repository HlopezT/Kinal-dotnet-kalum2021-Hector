using System.Collections.ObjectModel; //
using System.ComponentModel; //
using kalum2021.Models; //
namespace kalum2021.ModelView
{
    public class RoleViewModel:INotifyPropertyChanged
    {
         public ObservableCollection<Role> roles{get;set;}
        public RoleViewModel()
        {
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
    }
}