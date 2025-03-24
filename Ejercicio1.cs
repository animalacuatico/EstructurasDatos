namespace EstructurasDatos
{
    internal class Ejercicio1
    {
        static void Main(string[] args)
        {
            bool programWorking = true;
            Console.Clear();
            Console.WriteLine("Pila de acciones de un personaje: ");
            Stack<string> acciones = new Stack<string>();
            acciones.Push("DASH");
            acciones.Push("JUMP");
            acciones.Push("ATTACK");
            acciones.Push("DEFEND");
            Console.WriteLine("Escribe un valor para manipular la pila.");
            Console.WriteLine("1: Añadir DASH. 2: Añadir JUMP. 3: Añadir ATTACK. 4: Añadir DEFEND. 5: Eliminar última acción. 6: Terminar el programa.");
            while (programWorking)
            {
                foreach (var accion in acciones)
                {
                    Console.WriteLine(accion);
                }
                int answer = int.Parse(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        acciones.Push("DASH");
                        break;
                    case 2:
                        acciones.Push("JUMP");
                        break;
                    case 3:
                        acciones.Push("ATTACK");
                        break;
                    case 4:
                        acciones.Push("DEFEND");
                        break;
                    case 5:
                        acciones.Pop();
                        break;
                    case 6:
                        programWorking = false;
                        break;

                }
            }
        }
    }
}
