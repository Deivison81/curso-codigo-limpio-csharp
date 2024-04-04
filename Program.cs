
 List<string> TaskList  = new List<string>();

            int menuSelected = 0;
            do
            {
                menuSelected = ShowMainMenu();
                if ((Menu)menuSelected == Menu.Add)
                {
                    ShowMenuAdd();
                }
                else if ((Menu)menuSelected == Menu.Remove)
                {
                    ShowMenuRemove();
                }
                else if ((Menu)menuSelected == Menu.List)
                {
                    ShowMenuTaskList();
                }
            } while ((Menu)menuSelected != Menu.Exit);

/// <summary>
/// Show the options for Task, 1. Nueva tarea, 2. Remover tarea, 3. Tareas pendientes, 4. Salir
/// </summary>
/// <returns>Returns option selected by user</returns>
int ShowMainMenu()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Ingrese la opción a realizar: ");
            Console.WriteLine("1. Nueva tarea");
            Console.WriteLine("2. Remover tarea");
            Console.WriteLine("3. Tareas pendientes");
            Console.WriteLine("4. Salir");

            string Result = Console.ReadLine();
                    

            return Convert.ToInt32(Result);
        }

        void ShowMenuRemove()
        {
            try
            {
                Console.WriteLine("Ingrese el número de la tarea a remover: ");

                ShowTaskList();

                string TaskRemove = Console.ReadLine();
                // Remove one position because the array start in 0
                int indexToRemove = Convert.ToInt32(TaskRemove) - 1;
                
                if (indexToRemove > (TaskList.Count - 1) || indexToRemove < 0) { 
                    Console.WriteLine("El Numero de tarea Seleccionado no es valida");
                }
                else
                {
                    if (indexToRemove > -1 && TaskList.Count > 0)
                    {
                        string TaskliskIndex = TaskList[indexToRemove];
                        TaskList.RemoveAt(indexToRemove);
                        Console.WriteLine($"Tarea {TaskliskIndex} eliminada");
                  
                    }

                }

            }
            catch (Exception)
            {
                Console.WriteLine("Ha ocurrido un error al eliminar la tarea");
            }
        }

        void ShowMenuAdd()
        {
            try
            {
                Console.WriteLine("Ingrese el nombre de la tarea: ");
                string TaskAdd = Console.ReadLine();
                TaskList.Add(TaskAdd);
                Console.WriteLine("Tarea registrada");
            }
            catch (Exception)
            {
                Console.WriteLine("Ha ocurrido un error al ingresar la tarea");
            }
        }

        

        void ShowMenuTaskList()
        {
            if (TaskList?.Count > 0 )
            {
                ShowTaskList();
            } 
            else
            {
                Console.WriteLine("No hay tareas por realizar");
            }
        }

        void ShowTaskList() 
        {
            Console.WriteLine("----------------------------------------");
            var indexTask = 1;
            
            TaskList.ForEach(p =>   Console.WriteLine($"{indexTask++} . {p}"));
            
            Console.WriteLine("----------------------------------------");
        }
 
        public enum Menu 
        { 
            Add= 1,

            Remove= 2,
        
            List= 3,
        
            Exit= 4
        }


