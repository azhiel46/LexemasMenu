using System;

namespace MenuLexemas
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("Menu de Opciones");
                Console.WriteLine("\n" +
                    "\n 1.-Lista de Palabras" +
                    "\n 2.-Salir \n");

                Console.WriteLine("Digite una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                

                switch(opcion)
                {
                    case 1:
                        Console.WriteLine("Elija una Palabra");
                        Console.WriteLine("\n 1.Precerámica");
                        Console.WriteLine("\n 2.Precolombino");
                        Console.WriteLine("\n 3.Predeporte");
                        Console.WriteLine("\n 4.Predeterminar");
                        Console.WriteLine("\n 5.Predominar");
                        Console.WriteLine("\n 6.Predominio");
                        Console.WriteLine("\n 7.Preeminencia");
                        Console.WriteLine("\n 8.Preescolar");
                        Console.WriteLine("\n 9.Prehistoria");
                        Console.WriteLine("\n 10.Prejubilar");
                        
                        opcion = Convert.ToInt32(Console.ReadLine());
                        switch (opcion)
                        {
                            case 1:
                               Console.WriteLine("\n Lexema: -PRE-" +
                                   "\n Palabra: Precerámica" +
                                   "\n PRE-CE-RA-MI-CA");
                            break;
                            case 2:
                                Console.WriteLine("\n Lexema: -PRE-" +
                                    "\n Palabra: Precolombino" +
                                    "\n PRE-CO-LOM-BI-NO");
                                break;
                            case 3:
                                Console.WriteLine("\n Lexema: -PRE-" +
                                    "\n Palabra: Predeporte" +
                                    "\n PRE-DE-POR-TE");
                                break;
                            case 4:
                                Console.WriteLine("\n Lexema: -PRE-" +
                                    "\n Palabra: Predeterminar" +
                                    "\n PRE-DE-TER-MI-NAR");
                                break;
                            case 5:
                                Console.WriteLine("\n Lexema: -PRE-" +
                                    "\n Palabra: Predominar" +
                                    "\n PRE-DO-MI-NAR");
                                break;
                            case 6:
                                Console.WriteLine("\n Lexema: -PRE-" +
                                    "\n Palabra: Predominio" +
                                    "\n PRE-DO-MI-NIO");
                                break;
                            case 7:
                                Console.WriteLine("\n Lexema: -PRE-" +
                                    "\n Palabra: Preeminencia" +
                                    "\n PRE-MI-NEN-CIA");
                                break;
                            case 8:
                                Console.WriteLine("\n Lexema: -PRE-" +
                                    "\n Palabra: Preescolar" +
                                    "\n PRE-ES-CO-LAR");
                                break;
                            case 9:
                                Console.WriteLine("\n Lexema: -PRE-" +
                                    "\n Palabra: Prehistoria" +
                                    "\n PRE-HIS-TO-RIA");
                                break;
                            case 10:
                                Console.WriteLine("\n Lexema: -PRE-" +
                                    "\n Palabra: Prejubilar" +
                                    "\n PRE-JU-BI-LAR");
                                break;

                            default:
                                Console.WriteLine("Digite Una Opcion Valida");
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Salinedo de la aplicacion");
                        break;

                    default:
                        Console.WriteLine("Digite Una Opcion Valida");
                        break;
                }
                Console.ReadKey();
            } while (opcion != 2);
        }
    }
}
