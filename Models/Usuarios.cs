namespace kalum2021.Models
{
    public class Usuarios
    {
        public int Id {get;set;}
        public string Username {get;set;}
        public bool Enabled {get;set;}
        public string Nombres {get;set;}
        public string Apellidos{get;set;}
        public string Email{get;set;}
        public string Password{get;set;}

        //inicio constructores
        public Usuarios()
        {
            //constructor vacio
        }
        public Usuarios(int Id, string Username, bool Enabled, string Nombres,
        string Apellidos, string Email)
        {
            this.Id=Id; 
            this.Username=Username; 
            this.Enabled=Enabled; 
            this.Nombres=Nombres; 
            this.Apellidos=Apellidos; 
            this.Email=Email; 
        }
        public Usuarios(int Id, string Username, bool Enabled, string Nombres,
        string Apellidos, string Email, string Pasword)
        {
            this.Id=Id; 
            this.Username=Username; 
            this.Enabled=Enabled; 
            this.Nombres=Nombres; 
            this.Apellidos=Apellidos; 
            this.Email=Email; 
            this.Password=Password; 
        }//se agrega otro constructo, solo que agregando el password para no afectar a la otra. 
        //fin constructores

    }
}