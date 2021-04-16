using System.Windows;
using kalum2021.ModelView; 
using MahApps.Metro.Controls;

namespace kalum2021.Views
{
    public partial class RoleView : MetroWindow
    {
        public RoleView(RolesViewModel RoleViewModel)
        {
            InitializeComponent();
            RoleViewModel Modelo=new RoleViewModel(RoleViewModel); 
            this.DataContext=Modelo; 
        }
    }
}