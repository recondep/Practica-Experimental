class Program
{
    static void Main()
    {
        Hospital hospital = new Hospital();
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("");
            Console.WriteLine("UNIVERSIDAD ESTATAL AMAZONICA");
            Console.WriteLine("");
            Console.WriteLine("----PRACTICO EXPERIMENTAL-----");
            Console.WriteLine("--------INTEGRANTES-----------");
            Console.WriteLine("ROSA ELENA CONDE PAUCAR");
            Console.WriteLine("");
            Console.WriteLine();
            Console.WriteLine("-------------HOSPITAL----------");
            Console.WriteLine("1. Agregar turno");
            Console.WriteLine("2. Mostrar turnos");
            Console.WriteLine("3. Consultar turno por documento");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Nombre del paciente: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Apellido del paciente: ");
                    string apellido = Console.ReadLine();
                    Console.Write("Documento del paciente: ");
                    string documento = Console.ReadLine();
                    Console.Write("Fecha y hora del turno (yyyy-mm-dd hh:mm): ");
                    DateTime fechaHora = DateTime.Parse(Console.ReadLine());

                    Paciente paciente = new Paciente(nombre, apellido, documento);
                    Turno turno = new Turno(paciente, fechaHora);
                    hospital.AgregarTurno(turno);
                    Console.WriteLine("Turno agregado.");
                    break;

                case "2":
                    hospital.MostrarTurnos();
                    break;

                case "3":
                    Console.Write("Ingrese el documento del paciente: ");
                    string docConsulta = Console.ReadLine();
                    hospital.ConsultarTurno(docConsulta);
                    break;

                case "4":
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}
