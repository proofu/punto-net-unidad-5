using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace unidad5OrtizProfumieriUnzaga
{
    public class Alumno
    {
        //3.Crear una clase para llevar la información(identificador, nombre, apellido, edad, grado)
        //de los alumnos de una escuela primaria.
        //4.Para ambas clases, crear un constructor usando todas de las propiedades y sobreescribir
        //el método ToString() para mostrar todas las propiedades.
        private int id, grado;
        private string nombre, apellido;
        private int edad;
        private Direccion direccion;

        public int Grado
        {
            get { return grado; }
            set 
            {
                grado = value; 
                while (!validarGrado())
                {
                    Console.WriteLine("el grado no es valido debe ser entre 1 y 6");
                    Grado = int.Parse(Console.ReadLine());
                }
            }
        }
        public int Edad
        {
            get { return edad; }
            set {
                edad = value; 
                while (!validarEdad())
                {
                    Console.WriteLine("La edad no es valida, ingrese una edad:");
                    Edad = int.Parse(Console.ReadLine());
                }
            }
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Id { get => id; set => id = value; }
        public Direccion Direccion { get => direccion; set => direccion = value; }

        public Alumno(int id,string nombre,string apellido,int grado,int edad,Direccion direccion)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.grado = grado;
            this.edad = edad;
            this.direccion = direccion;
            while(!validarEdad())
            {
                Console.WriteLine("La edad no es valida, ingrese una edad:");
                Edad = int.Parse(Console.ReadLine());
            }
            while (!validarGrado())
            {
                Console.WriteLine("el grado no es valido debe ser entre 1 y 6");
                Grado = int.Parse(Console.ReadLine());
            }
        }


        public string nombreApellido()
        {
            return $"Nombre:{Nombre} Apellido:{Apellido}"; 
        }
        private bool validarEdad()
        {
            return Edad > 0;
        }
        private bool validarGrado()
        {
            return Grado >= 1 && Grado <= 7;
        }
        public override string ToString()
        {
            return $"id:{Id} nombre:{Nombre} apellido:{Apellido} edad:{Edad} grado:{Grado} {Direccion}";
        }
    }
}
