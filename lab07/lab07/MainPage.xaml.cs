using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace lab07
    //Sinche
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            List<Estudiante> estudiantes1 = new List<Estudiante>
            {
                new Estudiante { Nombres = "Alejandro", Apellidos = "Gutiérrez", Edad = 20, Seccion = "Seccion A" },
                new Estudiante { Nombres = "Lorena", Apellidos = "Sánchez", Edad = 19, Seccion = "Seccion A" },
                new Estudiante { Nombres = "Ricardo", Apellidos = "López", Edad = 22, Seccion = "Seccion A" },
                new Estudiante { Nombres = "Isabel", Apellidos = "Torres", Edad = 21, Seccion = "Seccion B" },
                new Estudiante { Nombres = "Gustavo", Apellidos = "Mendoza", Edad = 18, Seccion = "Seccion B" },
                new Estudiante { Nombres = "Paula", Apellidos = "Pérez", Edad = 23, Seccion = "Seccion B" },
                new Estudiante { Nombres = "Roberto", Apellidos = "Fernández", Edad = 20, Seccion = "Seccion C" },
                new Estudiante { Nombres = "Natalia", Apellidos = "Gómez", Edad = 22, Seccion = "Seccion C" },
                new Estudiante { Nombres = "Luisa", Apellidos = "Hernández", Edad = 24, Seccion = "Seccion C" },
            };

            var groupedStudents = estudiantes1.GroupBy(e => e.Seccion);

            lvEstudiantes1.ItemsSource = groupedStudents;
        }
    }
}
