using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using kalum2021.Models; //
using kalum2021.Views; //
namespace kalum2021
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        /*public void Saludar(object sender, RoutedEventArgs e)
        {
            Student estudiante=new Student("2021888","Hector Leonel","Lopez Temaj","leo-hec@hotmail.com",new DateTime(1992,04,08),"Masculino","41755673"); 
            Teacher profesor=new Teacher("TCH-20215","Edwin","Tumax","edwintumax@gmail.com",new DateTime(1990,05,05),"Masculino","78788989"); 
            MessageBox.Show(estudiante.ToString(),"Estudiante");
            MessageBox.Show(profesor.ToString(),"Profesor");
        }*/
        public void VentanaUsuarios(object sender, RoutedEventArgs e)
        {
           UsuariosView VentanaUsuarios=new UsuariosView(); 
           VentanaUsuarios.ShowDialog(); 
        }
        public void VentanaRoles(object sender, RoutedEventArgs e)
        {
           RoleView VentanaRoles=new RoleView(); 
           VentanaRoles.ShowDialog(); 
        }
    }
}
