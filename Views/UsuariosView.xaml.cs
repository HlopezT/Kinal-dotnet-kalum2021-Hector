using kalum2021.ModelView; 
using System.Windows; 

namespace kalum2021.Views
{
    public partial class UsuariosView:Window
    {
        //inicio constructor nulo 
        public UsuariosView()
        {
            InitializeComponent();
            UsuarioViewModel ModeloDatos=new UsuarioViewModel(); 
            this.DataContext=ModeloDatos; 
        }
        
    }
}