using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persona_herencia

    //LEONARDO LOPEZ VILLEGAS DI22138
    //UNIVERSIDAD DASC
    //INTENTO 1  //hola
    // FECHA : 08/05/2024
{
    class Persona //CLASE PADRE
    { // Declaración de los atributos de la clase Persona
        protected string NombreCompleto;
        protected string FechaN;                   //PROTECTED
        protected int Edad;                     //Se  utiliza para restringir el acceso a miembros de una clase.
        protected int DNI_Matricula;
        protected string Carrera_Puesto;

        public string nombrecompleto //Caja de memoria
        
            
         //Get: Se utiliza para obtener (o "leer") el valor de una propiedad.
         //Set: Se utiliza para establecer (o "escribir") el valor de una propiedad.


        {
            get { return NombreCompleto; } // Retorna el nombre completo.
            set { NombreCompleto = value; } // Establece el nombre completo.
        }
        public string fechan  // Propiedad para acceder y modificar la fecha de nacimiento.
        {
            get { return FechaN; }
            set { FechaN = value; }
        }
        public int edad  // Propiedad para acceder y modificar la edad.
        {
            get { return Edad; }
            set { Edad = value; }
        }
        public int dni_matricula  // Propiedad para acceder y modificar el número de identificación o matrícula.
        {
            get { return DNI_Matricula; }
            set { DNI_Matricula = value; }
        }
        public string carrera_Puesto
        {
            get { return Carrera_Puesto; }
            set { Carrera_Puesto = value; }
        }
        
    }
       

    class Alumno :Persona //clase hija alumno
    {
        // Propiedad para acceder y modificar la matrícula del alumno.
        public string Matricula
        {
            get { return Matricula; } // Retorna la matrícula.
            set { Matricula = value; } // Establece la matrícula.
        }

        // Propiedad para acceder y modificar la carrera del alumno.
        public string Carrera
        {
            get { return Carrera; } // Retorna la carrera.
            set { Carrera = value; } // Establece la carrera.
        }


    }
    class Empleado : Persona //clase hija
        // Definición de la clase Empleado, que hereda de la clase Persona
    {
        protected int Sueldo; // Variable protegida para almacenar el sueldo.

        // Propiedad para acceder y modificar el sueldo.
        public int sueldo
        {
            get { return Sueldo; } // Retorna el sueldo.
            set { Sueldo = value; } // Establece el sueldo.
        }

        // Propiedad para el DNI.
        public string DNI
        {
            get { return DNI; } // Retorna el DNI.
            set { DNI = value; } // Establece el DNI.
        }

        // Propiedad para el puesto.
        public string Puesto
        {
            get { return Puesto; } // Retorna el puesto.
            set { Puesto = value; } // Establece el puesto.
        }
    }
    class Docente : Persona //clase Hija
    {
        protected int Sueldo; // Campo protegido para almacenar el sueldo.

        // Propiedad para acceder y modificar el sueldo.
        public int sueldo
        {
            get { return Sueldo; } // Retorna el sueldo.
            set { Sueldo = value; } // Establece el sueldo.
        }

        // Campo protegido para almacenar el número de identificación (DNI).
        public string DNI
        {
            get { return DNI; } // Retorna el DNI.
            set { DNI = value; } // Establece el DNI.
        }

        // Campo protegido para almacenar el puesto.
        public string Puesto
        {
            get { return Puesto; } // Retorna el puesto.
            set { Puesto = value; } // Establece el puesto.
        }
    }
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }//holaaa pp
} 
