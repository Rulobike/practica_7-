using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SQLiteAsyncConnection db;
            string DB;
            DB = DependencyService.Get<ISQLite>().GetLocalFilePath("Formulario_DB");
            db = new SQLiteAsyncConnection(DB);
            db.CreateTableAsync<Formulario>().Wait();

            var dato = new Formulario
            {
                Id = "13090341",
                Nombre = "Raul",
                Apellidos = "Garcia Rios",
                Direccion = "el plan",
                Telefono = "5571677499",
                Carrera = "ISC",
                Semestre = "Noveno",
                Correo = "rulo_r.gr@hotmail.com",
                Git = "Rulobike"
            };
        db.InsertAsync(dato);
        }
    }
}

