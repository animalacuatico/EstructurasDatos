using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDatos
{
    internal class Ejercicio2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe estos números para añadir tareas al NPC.");

            List<string> NPCActions = new List<string>();
            bool programRunning = true;
            while (programRunning)
            {
                Console.WriteLine("1: Añadir una tarea al NPC. 2: Quitar una tarea al NPC. 3: Intercambiar dos tareas del NPC. 4: Terminar el programa.");
                Console.WriteLine("Lista de acciones: ");
                foreach (string action in NPCActions)
                {
                    Console.WriteLine(action);
                }
                int answer = int.Parse(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                    AddNPCTask(NPCActions);
                        Console.WriteLine("Acción añadida.");
                    break;
                    case 2:
                    RemoveNPCTask(NPCActions);
                        Console.WriteLine("Acción quitada.");
                    break;
                    case 3:
                    SwapNPCTask(NPCActions);
                        Console.WriteLine("Acciones intercambiadas.");
                    break;
                    case 4:
                    programRunning = false;
                        Console.WriteLine("Programa terminado.");
                    break;
                }
            }

        }
        static void AddNPCTask(List <string> NPCActions)
        {
            Console.WriteLine("Escribe una acción que el NPC debe cumplir.");
            string TaskToAdd = Console.ReadLine();
            NPCActions.Add(TaskToAdd);
        }
        static void RemoveNPCTask(List <string> NPCActions)
        {
            Console.WriteLine("Escribe el índice de la acción del NPC que quieras remover.");
            int IndexToSubtract = int.Parse(Console.ReadLine());
            NPCActions.RemoveAt(IndexToSubtract);
        }
        static void SwapNPCTask(List <string> NPCActions)
        {
            Console.WriteLine("Escribe dos índices para intercambiar en las acciones del NPC.");
            int firstSwap = int.Parse(Console.ReadLine());
            int secondSwap = int.Parse(Console.ReadLine());
            string temp = NPCActions[firstSwap];
            NPCActions[firstSwap] = NPCActions[secondSwap];
            NPCActions[secondSwap] = temp;

        }
    }
}
