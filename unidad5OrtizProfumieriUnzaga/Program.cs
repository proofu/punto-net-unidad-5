using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace unidad5OrtizProfumieriUnzaga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Crear un proyecto con nombre Unidad5 más los apellidos de los alumnos que forman el grupo.
            //Ejemplo: Unidad5Apellido1Apellido2Apellido3Apellido4Apellido5
            //2.Crear una clase Direccion que contenga(Calle, Numero, Piso, Departamento).
            //3.Crear una clase para llevar la información(identificador, nombre, apellido, edad, grado)
            //de los alumnos de una escuela primaria.
            //4.Para ambas clases, crear un constructor usando todas de las propiedades y sobreescribir
            //el método ToString() para mostrar todas las propiedades.
            //5.En la clase Alumno:
            //  1.Crear un método que devuelva el nombre y el apellido.
            //  2.Crear un método para validar que la edad no acepte valores negativos.
            //  3.Crear un método para validar que el grado este entre 1 y 7.
            //6.Crear un programa en donde el usuario ingrese 3 alumnos validando que la edad y el grado contengan
            //valores correctos y luego muestre todos los datos usando el método ToString().
                       
            List<Alumno> listaAlumno = new List<Alumno>();

            int cantidadAlumno = 3;
            for(int i = 0; i < cantidadAlumno; i++)
            {
               
                //Alumno
                Console.WriteLine($"Ingreso del alumno N° {i + 1}   ");

                Console.WriteLine($"identificador: { i+1 }");
                int identificador = i + 1;

                Console.WriteLine("Nombre: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("Apellido: ");
                string apellido = Console.ReadLine();


                Console.WriteLine("Edad: ");
                int edad = int.Parse(Console.ReadLine());

                Console.WriteLine("grado : ");
                int grado = int.Parse(Console.ReadLine());

                //Dirrección
                Direccion direccion = new Direccion("Av.Siempre viva", "1234", "7", "B");


                Alumno alumno = new Alumno(identificador, nombre, apellido, grado , edad, direccion);

                listaAlumno.Add( alumno );
            }



            Console.WriteLine("--------------- Lista de Alumnos ---------------");
            foreach(var alumno in listaAlumno)
            {
                Console.WriteLine(alumno.ToString());

            }
            Console.ReadKey();
                 
        }
    }
}
