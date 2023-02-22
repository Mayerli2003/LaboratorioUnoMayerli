using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1Azucena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string id;
            departamento departamento = new departamento();
            
            
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("----------  BIENVEDIDO/A  ----------");
                Console.WriteLine("------------------------Elija su departamento-------------------------");

                Console.WriteLine("\n1 - Chalatenango");
                Console.WriteLine("\n2 - Santa Ana");
                Console.WriteLine("\n3 - Ahuachapán");
                Console.WriteLine("\n4 - Sonsonate");
                Console.WriteLine("\n5 - La libertad");
                Console.WriteLine("\n6 - San Salvador");
               
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("\n7 - Salir");
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("\nIngrese el numero de su consulta");
                id = Console.ReadLine();
                switch (id)
                {
                    case "1":
                        Console.WriteLine("\n1 - Agua Caliente");
                        Console.WriteLine("\n2 - Arcatao");
                        Console.WriteLine("\n3 - Azacualpa");
                        Console.WriteLine("\n4 - Sonsonate");
                        Console.WriteLine("\n5 - Cancasque");
                        Console.WriteLine("\n6 - Citalá");
                        Console.WriteLine("\nIngrese el numero de su consulta");
                        id = Console.ReadLine();
                        switch (id)
                        {
                            case "1":
                                departamento.datos();
                                break;

                            case "2":
                                break;
                            case "3":
                                break;
                            case "4":
                                break;
                            case "5":
                                break;
                        }
                        Console.ReadLine();
                      break;
                    case "2":
                        do
                        {
                            Console.WriteLine("\n1 - Chalchuapa");
                            Console.WriteLine("\n2 - Coatepeque");
                            Console.WriteLine("\n3 - El congo");
                            Console.WriteLine("\n4 - San Antonio");
                            Console.WriteLine("\n5 - Pajonal");
                            Console.WriteLine("\n6 - Metapan");
                            Console.WriteLine("\nIngrese el numero de su consulta");
                            id = Console.ReadLine();
                            switch (id)
                            {
                                case "1":
                                    break;

                                case "2":   
                                    break; 
                                case "3":
                                    break; 
                                case "4":
                                    break; 
                                case "5":
                                    break;
                            }

                        }
                        while (id != "5");
                        break;
                    case "3":
                        Console.WriteLine("\n1 - ");
                        Console.WriteLine("\n2 - Arcatao");
                        Console.WriteLine("\n3 - Azacualpa");
                        Console.WriteLine("\n4 - Sonsonate");
                        Console.WriteLine("\n5 - Cancasque");
                        Console.WriteLine("\n6 - Citalá");
                        Console.WriteLine("\nIngrese el numero de su consulta");
                        id = Console.ReadLine();
                        switch (id)
                        {
                            case "1":
                                break;

                            case "2":
                                break;
                            case "3":
                                break;
                            case "4":
                                break;
                            case "5":
                                break;
                        }
                        break;
                    case "4":
                        Console.WriteLine("\n1 - Agua Caliente");
                        Console.WriteLine("\n2 - Arcatao");
                        Console.WriteLine("\n3 - Azacualpa");
                        Console.WriteLine("\n4 - Sonsonate");
                        Console.WriteLine("\n5 - Cancasque");
                        Console.WriteLine("\n6 - Citalá");
                        Console.WriteLine("\nIngrese el numero de su consulta");
                        id = Console.ReadLine();
                        switch (id)
                        {
                            case "1":
                                break;

                            case "2":
                                break;
                            case "3":
                                break;
                            case "4":
                                break;
                            case "5":
                                break;
                        }
                        break;
                    case "5":
                        Console.WriteLine("\n1 - Agua Caliente");
                        Console.WriteLine("\n2 - Arcatao");
                        Console.WriteLine("\n3 - Azacualpa");
                        Console.WriteLine("\n4 - Sonsonate");
                        Console.WriteLine("\n5 - Cancasque");
                        Console.WriteLine("\n6 - Citalá");
                        Console.WriteLine("\nIngrese el numero de su consulta");
                        id = Console.ReadLine();
                        switch (id)
                        {
                            case "1":
                                break;

                            case "2":
                                break;
                            case "3":
                                break;
                            case "4":
                                break;
                            case "5":
                                break;
                        }
                        break;
                    case "6":
                        Console.WriteLine("\n1 - Agua Caliente");
                        Console.WriteLine("\n2 - Arcatao");
                        Console.WriteLine("\n3 - Azacualpa");
                        Console.WriteLine("\n4 - Sonsonate");
                        Console.WriteLine("\n5 - Cancasque");
                        Console.WriteLine("\n6 - Citalá");
                        Console.WriteLine("\nIngrese el numero de su consulta");
                        id = Console.ReadLine();
                        switch (id)
                        {
                            case "1":
                                break;

                            case "2":
                                break;
                            case "3":
                                break;
                            case "4":
                                break;
                            case "5":
                                break;
                        }
                        break;
                    case "7":
                        Console.WriteLine("\n1 - Agua Caliente");
                        Console.WriteLine("\n2 - Arcatao");
                        Console.WriteLine("\n3 - Azacualpa");
                        Console.WriteLine("\n4 - Sonsonate");
                        Console.WriteLine("\n5 - Cancasque");
                        Console.WriteLine("\n6 - Citalá");
                        Console.WriteLine("\nIngrese el numero de su consulta");
                        id = Console.ReadLine();
                        switch (id)
                        {
                            case "1":
                                break;

                            case "2":
                                break;
                            case "3":
                                break;
                            case "4":
                                break;
                            case "5":
                                break;
                        }
                        break;
                    

                    
                }
                
            }
            while (id != "7");
            
        }

        class departamento
        {
            public void listaDepartamento()
            {
                string[] departamento = new string[6];
                departamento[0] = "Chalatenango";
                departamento[1] = "Santa Ana";
                departamento[2] = "Ahuachapan";
                departamento[3] = "Sonsonate";
                departamento[4] = "La libertad";
                departamento[5] = "San salavador";

            }

            public void datos()
            {

                List<string> nombre = new List<string>();
                nombre.Add("mayerli");
                List<string> edad = new List<string>();
                Console.WriteLine("Ingrese su nombre:");
                nombre.Add("Console.ReadLine()");

                Console.WriteLine("Ingrese Su edad:");
                edad.Add(Console.ReadLine());
                Console.WriteLine("Nombres: "  + nombre +  " \n edades: " + edad);
            }
            
        }
    }
}
