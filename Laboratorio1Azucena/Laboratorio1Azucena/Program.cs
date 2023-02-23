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
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("--------------------------------BIENVEDIDO/A--------------------------------\n");
                Console.WriteLine("------------------------Elija su departamento-------------------------");

                Console.WriteLine("\n1 - Chalatenango");
                Console.WriteLine("\n2 - Santa Ana");
                Console.WriteLine("\n3 - Ahuachapán");
                Console.WriteLine("\n4 - Sonsonate");
                Console.WriteLine("\n5 - La libertad");
                Console.WriteLine("\n6 - San Salvador");
                Console.WriteLine("\n7 - La Paz ");
                Console.WriteLine("\n8 - San Vicente");
                Console.WriteLine("\n9 - Usulután");
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("\n10 - Salir");
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("\nIngrese el numero de su consulta");
                id = Console.ReadLine();
                switch (id)
                {
                    case "1":
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("___________________________CHALATENANGO____________________________");  
                            Console.WriteLine("\n1 - Agua Caliente");
                            Console.WriteLine("\n2 - Arcatao");
                            Console.WriteLine("\n3 - Azacualpa");
                            Console.WriteLine("\n4 - Chalatenago");
                            Console.WriteLine("\n5 - Cancasque");
                            Console.WriteLine("\n6 - Citalá");
                            Console.WriteLine("\n7 - Comalapa");
                            Console.WriteLine("\n8 - Concepción Quezaltepeque");
                            Console.WriteLine("---------------------------------------------\n");
                            Console.WriteLine("\n9 - Salir");
                            Console.WriteLine("\nIngrese el numero de su consulta");
                            id = Console.ReadLine();
                            switch (id)
                            {
                                case "1":
                                    Console.WriteLine("Departamento: Chalatenago");
                                    Console.WriteLine("Municipio: Agua caliente");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;

                                case "2":
                                    Console.WriteLine("Departamento: Chalatenago");
                                    Console.WriteLine("Municipio: Arcatao");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "3":
                                    Console.WriteLine("Departamento: Chalatenago");
                                    Console.WriteLine("Municipio: Azacualpa");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "4":
                                    Console.WriteLine("Departamento: Chalatenago");
                                    Console.WriteLine("Municipio: Chalatenango");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "5":
                                    Console.WriteLine("Departamento: Chalatenago");
                                    Console.WriteLine("Municipio: Cancasque");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "6":
                                    Console.WriteLine("Departamento: Chalatenago");
                                    Console.WriteLine("Municipio: Citalá");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "7":
                                    Console.WriteLine("Departamento: Chalatenago");
                                    Console.WriteLine("Municipio: Comalapa");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "8":
                                    Console.WriteLine("Departamento: Chalatenago");
                                    Console.WriteLine("Municipio: Concepción Quezaltepeque");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "9":
                                    Console.WriteLine("Fin de las consultas");
                                    Console.ReadLine();
                                    break;
                                default:
                                    Console.WriteLine("La opcion ingresada no es correcta");
                                    break;
                            }
                            Console.ReadLine();
                        }
                        while (id != "9");
                      break;
                    case "2":
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("___________________________SANTA ANA____________________________");
                            Console.WriteLine("\n1 - Chalchuapa");
                            Console.WriteLine("\n2 - Coatepeque");
                            Console.WriteLine("\n3 - El congo");
                            Console.WriteLine("\n4 - San Antonio Pajonal");
                            Console.WriteLine("\n5 - El Porvenir");
                            Console.WriteLine("\n6 - Metapán");
                            Console.WriteLine("\n7 - Santa Ana");
                            Console.WriteLine("\n8 - Masahuat");
                            Console.WriteLine("________________________________________\n");
                            Console.WriteLine("\n9-Salir");
                            Console.WriteLine("\nIngrese el numero de su consulta");
                            id = Console.ReadLine();
                            switch (id)
                            {
                                case "1":
                                    Console.WriteLine("Departamento: Santa Ana");
                                    Console.WriteLine("Municipio: Chalchuapa");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;

                                case "2":
                                    Console.WriteLine("Departamento: Santa Ana");
                                    Console.WriteLine("Municipio: Cuatepeque");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "3":
                                    Console.WriteLine("Departamento: Santa Ana");
                                    Console.WriteLine("Municipio: El Congo");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "4":
                                    Console.WriteLine("Departamento: Santa Ana");
                                    Console.WriteLine("Municipio: San Antonio Pajonal");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "5":
                                    Console.WriteLine("Departamento: Santa Ana");
                                    Console.WriteLine("Municipio: El Porvenir");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "6":
                                    Console.WriteLine("Departamento: Santa Ana");
                                    Console.WriteLine("Municipio: Metapan");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "7":
                                    Console.WriteLine("Departamento: Santa Ana");
                                    Console.WriteLine("Municipio: Santa Ana");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "8":
                                    Console.WriteLine("Departamento: Santa Ana");
                                    Console.WriteLine("Municipio: Masauat");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "9":
                                    Console.WriteLine("Fin de las consultas");
                                    Console.ReadLine();
                                    break;
                                    default:
                                    Console.WriteLine("La opcion ingresada no es correcta");
                                    break;
                            }

                        }
                        while (id != "9");
                     break;

                    case "3":
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("___________________________AHUACHAPAN____________________________");
                            Console.WriteLine("\n1 - Ahuachapán");
                            Console.WriteLine("\n2 - Apaneca");
                            Console.WriteLine("\n3 - Atiquizaya");
                            Console.WriteLine("\n4 - El Refugio");
                            Console.WriteLine("\n5 - Jujutla");
                            Console.WriteLine("\n6 - Tacuba");
                            Console.WriteLine("\n7 - Turín");
                            Console.WriteLine("\n8 - San Lorenzo");
                            Console.WriteLine("__________________________________\n");
                            Console.WriteLine("\n9-Salir");
                            Console.WriteLine("\nIngrese el numero de su consulta");
                            id = Console.ReadLine();
                            switch (id)
                            {
                                case "1":
                                    Console.WriteLine("Departamento: Ahuachapán");
                                    Console.WriteLine("Municipio: Ahuachapán");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;

                                case "2":
                                    Console.WriteLine("Departamento: Ahuachapán");
                                    Console.WriteLine("Municipio: Apaneca");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "3":
                                    Console.WriteLine("Departamento: Ahuachapán");
                                    Console.WriteLine("Municipio: Atiquizaya");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "4":
                                    Console.WriteLine("Departamento: Ahuachapán");
                                    Console.WriteLine("Municipio: El Refugio");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "5":
                                    Console.WriteLine("Departamento: Ahuachapán");
                                    Console.WriteLine("Municipio: Jujutla");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "6":
                                    Console.WriteLine("Departamento: Ahuachapán");
                                    Console.WriteLine("Municipio: Tacuba");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "7":
                                    Console.WriteLine("Departamento: Ahuachapán");
                                    Console.WriteLine("Municipio: Turín");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "8":
                                    Console.WriteLine("Departamento: Ahuachapán");
                                    Console.WriteLine("Municipio: San Lorenzo");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "9":
                                    Console.WriteLine("Fin de las consultas");
                                    Console.ReadLine();
                                    break;
                                default:
                                    Console.WriteLine("La opcion ingresada no es correcta");
                                    break;
                            }

                        }
                        while (id != "9");
                        break;
                    case "4":
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("___________________________SONSONATE____________________________");
                            Console.WriteLine("\n1 - Acajutla");
                            Console.WriteLine("\n2 - Armenia");
                            Console.WriteLine("\n3 - Caluco");
                            Console.WriteLine("\n4 - Izalco");
                            Console.WriteLine("\n5 - San Julián");
                            Console.WriteLine("\n6 - Juayúa");
                            Console.WriteLine("\n7 - Nahuizalco");
                            Console.WriteLine("\n8 - Salcoatitán");
                            Console.WriteLine("__________________________________\n");
                            Console.WriteLine("\n9-Salir");
                            Console.WriteLine("\nIngrese el numero de su consulta");
                            id = Console.ReadLine();
                            switch (id)
                            {
                                case "1":
                                    Console.WriteLine("Departamento: Sonsonate");
                                    Console.WriteLine("Municipio: Acajutla");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;

                                case "2":
                                    Console.WriteLine("Departamento: Sonsonate");
                                    Console.WriteLine("Municipio: Armenia");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "3":
                                    Console.WriteLine("Departamento: Sonsonate");
                                    Console.WriteLine("Municipio: Caluco");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "4":
                                    Console.WriteLine("Departamento: Sonsonate");
                                    Console.WriteLine("Municipio: Izalco");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "5":
                                    Console.WriteLine("Departamento: Sonsonate");
                                    Console.WriteLine("Municipio: San Julián");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "6":
                                    Console.WriteLine("Departamento: Sonsonate");
                                    Console.WriteLine("Municipio: Juayúa");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "7":
                                    Console.WriteLine("Departamento: Sonsonate");
                                    Console.WriteLine("Municipio: Nahuizalco");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "8":
                                    Console.WriteLine("Departamento: Sonsonate");
                                    Console.WriteLine("Municipio: Salcoatitán");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "9":
                                    Console.WriteLine("Fin de las consultas");
                                    Console.ReadLine();
                                    break;
                                default:
                                    Console.WriteLine("La opcion ingresada no es correcta");
                                    break;
                            }

                        }
                        while (id != "9");
                        break;
                    case "5":
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("___________________________LA LIBERTAD____________________________");
                            Console.WriteLine("\n1 - Colón");
                            Console.WriteLine("\n2 - Comasagua");
                            Console.WriteLine("\n3 - Ciudad Arce");
                            Console.WriteLine("\n4 - Jayaque");
                            Console.WriteLine("\n5 - La Libertad");
                            Console.WriteLine("\n6 - Santa Tecla");
                            Console.WriteLine("\n7 - Sacacoyo");
                            Console.WriteLine("\n8 - San Matías");
                            Console.WriteLine("__________________________________\n");
                            Console.WriteLine("\n9-Salir");
                            Console.WriteLine("\nIngrese el numero de su consulta");
                            id = Console.ReadLine();
                            switch (id)
                            {
                                case "1":
                                    Console.WriteLine("Departamento: La libertad");
                                    Console.WriteLine("Municipio: Colón");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;

                                case "2":
                                    Console.WriteLine("Departamento: La libertad");
                                    Console.WriteLine("Municipio: Comasagua");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "3":
                                    Console.WriteLine("Departamento: La libertad");
                                    Console.WriteLine("Municipio: Ciudad Arce");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "4":
                                    Console.WriteLine("Departamento: La libertad");
                                    Console.WriteLine("Municipio: Jayaque");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "5":
                                    Console.WriteLine("Departamento: La libertad");
                                    Console.WriteLine("Municipio: La Libertad");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "6":
                                    Console.WriteLine("Departamento: La libertad");
                                    Console.WriteLine("Municipio: Santa Tecla");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "7":
                                    Console.WriteLine("Departamento: La libertad");
                                    Console.WriteLine("Municipio: Sacacoyo");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "8":
                                    Console.WriteLine("Departamento: La libertad");
                                    Console.WriteLine("Municipio: San Matías");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "9":
                                    Console.WriteLine("Fin de las consultas");
                                    Console.ReadLine();
                                    break;
                                default:
                                    Console.WriteLine("La opcion ingresada no es correcta");
                                    break;
                            }

                        }
                        while (id != "9");
                        break;
                    case "6":
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("___________________________SAN SALVADOR____________________________");
                            Console.WriteLine("\n1 - Aguilares");
                            Console.WriteLine("\n2 - Apopa");
                            Console.WriteLine("\n3 - Ciudad Delgado");
                            Console.WriteLine("\n4 - El Paisnal");
                            Console.WriteLine("\n5 - Guazapa");
                            Console.WriteLine("\n6 - Ilopango");
                            Console.WriteLine("\n7 - Mejicanos");
                            Console.WriteLine("\n8 - Nejapa");
                            Console.WriteLine("__________________________________\n");
                            Console.WriteLine("\n9-Salir");
                            Console.WriteLine("\nIngrese el numero de su consulta");
                            id = Console.ReadLine();
                            switch (id)
                            {
                                case "1":
                                    Console.WriteLine("Departamento: San Salvador");
                                    Console.WriteLine("Municipio: Aguilares");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;

                                case "2":
                                    Console.WriteLine("Departamento: San Salvador");
                                    Console.WriteLine("Municipio: Apopa");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "3":
                                    Console.WriteLine("Departamento: San Salvador");
                                    Console.WriteLine("Municipio: Ciudad Delgado");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "4":
                                    Console.WriteLine("Departamento: San Salvador");
                                    Console.WriteLine("Municipio: El Paisnal");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "5":
                                    Console.WriteLine("Departamento: San Salvador");
                                    Console.WriteLine("Municipio: Guazapa");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "6":
                                    Console.WriteLine("Departamento: San Salvador");
                                    Console.WriteLine("Municipio: Ilopango");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "7":
                                    Console.WriteLine("Departamento: San Salvador");
                                    Console.WriteLine("Municipio: Mejicanos");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "8":
                                    Console.WriteLine("Departamento: San Salvador");
                                    Console.WriteLine("Municipio: Nejapa");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "9":
                                    Console.WriteLine("Fin de las consultas");
                                    Console.ReadLine();
                                    break;
                                default:
                                    Console.WriteLine("La opcion ingresada no es correcta");
                                    break;
                            }

                        }
                        while (id != "9");
                        break;
                    case "7":
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("___________________________LA PAZ____________________________");
                            Console.WriteLine("\n1 - El Rosario");
                            Console.WriteLine("\n2 - Jesusalén");
                            Console.WriteLine("\n3 - Zacatecoluca");
                            Console.WriteLine("\n4 - Olocuilta");
                            Console.WriteLine("\n5 - Paraíso de Osorio");
                            Console.WriteLine("\n6 - San Juan Talpa");
                            Console.WriteLine("\n7 - San Juan Nonualco");
                            Console.WriteLine("\n8 - San Luis Talpa");
                            Console.WriteLine("__________________________________\n");
                            Console.WriteLine("\n9-Salir");
                            Console.WriteLine("\nIngrese el numero de su consulta");
                            id = Console.ReadLine();
                            switch (id)
                            {
                                case "1":
                                    Console.WriteLine("Departamento: La Paz");
                                    Console.WriteLine("Municipio: El Rosario");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;

                                case "2":
                                    Console.WriteLine("Departamento: La Paz");
                                    Console.WriteLine("Municipio: Jesuralén");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "3":
                                    Console.WriteLine("Departamento: La Paz");
                                    Console.WriteLine("Municipio: Zacatecoluca");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "4":
                                    Console.WriteLine("Departamento: La Paz");
                                    Console.WriteLine("Municipio: Olocuilta");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "5":
                                    Console.WriteLine("Departamento: La Paz");
                                    Console.WriteLine("Municipio: Pasaíso de Osorio");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "6":
                                    Console.WriteLine("Departamento: La Paz");
                                    Console.WriteLine("Municipio: San Juan Talpa");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "7":
                                    Console.WriteLine("Departamento: La Paz");
                                    Console.WriteLine("Municipio: San Juan Nonualco");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "8":
                                    Console.WriteLine("Departamento: La Paz");
                                    Console.WriteLine("Municipio: San Luis Talpa");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "9":
                                    Console.WriteLine("Fin de las consultas");
                                    Console.ReadLine();
                                    break;
                                default:
                                    Console.WriteLine("La opcion ingresada no es correcta");
                                    break;
                            }

                        }
                        while (id != "9");
                        break;
                    case "8":
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("___________________________SAN VICENTE____________________________");
                            Console.WriteLine("\n1 - Apastepeque");
                            Console.WriteLine("\n2 - Guadalupe");
                            Console.WriteLine("\n3 - San Lorenzo");
                            Console.WriteLine("\n4 - San Sebastián");
                            Console.WriteLine("\n5 - San Vicente");
                            Console.WriteLine("\n6 - Santa Clara");
                            Console.WriteLine("\n7 - Santo Domingo");
                            Console.WriteLine("\n8 - Tecoluca");
                            Console.WriteLine("__________________________________\n");
                            Console.WriteLine("\n9-Salir");
                            Console.WriteLine("\nIngrese el numero de su consulta");
                            id = Console.ReadLine();
                            switch (id)
                            {
                                case "1":
                                    Console.WriteLine("Departamento: San Vicente");
                                    Console.WriteLine("Municipio: Apastepeque");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;

                                case "2":
                                    Console.WriteLine("Departamento: San Vicente");
                                    Console.WriteLine("Municipio: Guadalupe");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "3":
                                    Console.WriteLine("Departamento: San Vicente");
                                    Console.WriteLine("Municipio: San Lorenzo");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "4":
                                    Console.WriteLine("Departamento: San Vicente");
                                    Console.WriteLine("Municipio: San Sebastián");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "5":
                                    Console.WriteLine("Departamento: San Vicente");
                                    Console.WriteLine("Municipio: San Vicente");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "6":
                                    Console.WriteLine("Departamento: San Vicente");
                                    Console.WriteLine("Municipio: Santa Clara");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "7":
                                    Console.WriteLine("Departamento: San Vicente");
                                    Console.WriteLine("Municipio: Santo Domingo");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "8":
                                    Console.WriteLine("Departamento: San Vicente");
                                    Console.WriteLine("Municipio: Tecoluca");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "9":
                                    Console.WriteLine("Fin de las consultas");
                                    Console.ReadLine();
                                    break;
                                default:
                                    Console.WriteLine("La opcion ingresada no es correcta");
                                    break;
                            }

                        }
                        while (id != "9");
                        break;
                    case "9":
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("___________________________USULUTAN____________________________");
                            Console.WriteLine("\n1 - Alegría");
                            Console.WriteLine("\n2 - Berlín");
                            Console.WriteLine("\n3 - California");
                            Console.WriteLine("\n4 - El Triunfo");
                            Console.WriteLine("\n5 - Jucuapa");
                            Console.WriteLine("\n6 - Jucuarán");
                            Console.WriteLine("\n7 - Nueva Granada");
                            Console.WriteLine("\n8 - Usulután");
                            Console.WriteLine("__________________________________\n");
                            Console.WriteLine("\n9-Salir");
                            Console.WriteLine("\nIngrese el numero de su consulta");
                            id = Console.ReadLine();
                            switch (id)
                            {
                                case "1":
                                    Console.WriteLine("Departamento: Usulután");
                                    Console.WriteLine("Municipio: Alegría");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;

                                case "2":
                                    Console.WriteLine("Departamento: Usulután");
                                    Console.WriteLine("Municipio: Berlín");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "3":
                                    Console.WriteLine("Departamento: Usulután");
                                    Console.WriteLine("Municipio: California");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "4":
                                    Console.WriteLine("Departamento: Usulután");
                                    Console.WriteLine("Municipio: El Triunfo");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "5":
                                    Console.WriteLine("Departamento: Usulután");
                                    Console.WriteLine("Municipio: Jucuapa");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "6":
                                    Console.WriteLine("Departamento: Usulután");
                                    Console.WriteLine("Municipio: Jucuarán");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "7":
                                    Console.WriteLine("Departamento: Usulután");
                                    Console.WriteLine("Municipio: Nueva Granada");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "8":
                                    Console.WriteLine("Departamento: Usulután");
                                    Console.WriteLine("Municipio: Usulután");
                                    departamento.datos();
                                    Console.ReadLine();
                                    break;
                                case "9":
                                    Console.WriteLine("Fin de las consultas");
                                    Console.ReadLine();
                                    break;
                                default:
                                    Console.WriteLine("La opcion ingresada no es correcta");
                                    break;
                            }

                        }
                        while (id != "9");
                        break;
                    case "10":
                        Console.WriteLine("Fin de las consultas");
                        
                        break;
                    default:
                        Console.WriteLine("La opcion ingresada no es correcta");
                        break;



                }
                
            }
            while (id != "10");
            
        }

        class departamento
        {
            
            public void datos()
            {

                List<string> nombre = new List<string>();
                
                List<string> edad = new List<string>();
                
                Console.WriteLine("Ingrese su nombre:");
                nombre.Add(Console.ReadLine());

                Console.WriteLine("Ingrese Su edad:");
                edad.Add(Console.ReadLine());
                Console.WriteLine("Nombre: "+nombre[0]);
                Console.WriteLine("Edad: " + edad[0]);
                
            }
            
        }
    }
}
