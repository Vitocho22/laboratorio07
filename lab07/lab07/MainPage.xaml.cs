using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
//nico
namespace lab07

{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            List<Estudiante> estudiantes1 = new List<Estudiante>
            {
                    new Estudiante { Nombres = "Isabel", Apellidos = "Torres", Edad = 21, Ciclo = "1" },
                    new Estudiante { Nombres = "Juan", Apellidos = "López", Edad = 19, Ciclo = "2" },
                    new Estudiante { Nombres = "María", Apellidos = "Gómez", Edad = 20, Ciclo = "1" },
                    new Estudiante { Nombres = "Carlos", Apellidos = "Martínez", Edad = 22, Ciclo = "3" },
                    new Estudiante { Nombres = "Laura", Apellidos = "Sánchez", Edad = 18, Ciclo = "2" },
                    new Estudiante { Nombres = "Pedro", Apellidos = "Rodríguez", Edad = 21, Ciclo = "1" },
                    new Estudiante { Nombres = "Sofía", Apellidos = "Pérez", Edad = 19, Ciclo = "3" },
                    new Estudiante { Nombres = "Alejandro", Apellidos = "Hernández", Edad = 20, Ciclo = "2" },
                    new Estudiante { Nombres = "Valeria", Apellidos = "Díaz", Edad = 18, Ciclo = "1" },
                    new Estudiante { Nombres = "Lucas", Apellidos = "Gutiérrez", Edad = 23, Ciclo = "3" }
        };

            var groupedStudents = estudiantes1.GroupBy(e => e.Ciclo);

            lvEstudiantes1.ItemsSource = groupedStudents;
        }
    }
}
