using System.Collections.ObjectModel; //
using System.ComponentModel; //
using kalum2021.Models; //

namespace kalum2021.ModelView
{
    public class UsuarioViewModel:INotifyPropertyChanged
    {
        public ObservableCollection<Usuarios> usuarios{get;set;}
        public UsuarioViewModel()
        {
            this.usuarios=new ObservableCollection<Usuarios>(); 
            this.usuarios.Add(new Usuarios(1,"hlopez",true,"Hector Leonel","Lopez Temaj","leohec@hotmail.com")); 
            this.usuarios.Add(new Usuarios(2,"gsunu",true,"Gloria","Sunu","gsunu@gmail.com"));  
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