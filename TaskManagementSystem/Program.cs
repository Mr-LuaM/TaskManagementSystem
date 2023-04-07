using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem;

namespace TaskManagementSystem
{
    class Task//THIS CLASS AY GINAMIT TO HOLD THE INPUTS
    {
        public int Priority { get; set; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; }
        public bool IsCompleted { get; set; }
    }
    class Program//THIS CLASS IS FOR ALL THE METHODS USED TO MAKE THE SYSTEM WORK
    {
        static DesignForm ds = new DesignForm();
        static void Main(string[] args)
        {
            List<Task> taskList = new List<Task>();
            Queue<Task> taskQueue = new Queue<Task>();
            int choice;
            ds.TITLESCREEN();
            do
            {
                ds.Header();
                ds.Menu();
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddTask(taskList, taskQueue);
                        break;
                    case 2:
                        DeleteTask(taskList, taskQueue);
                        break;
                    case 3:
                        DisplayTasks(taskList, taskQueue);
                        break;
                }
            } while (choice != 4);
        }
        static void AddTask(List<Task> taskList, Queue<Task> taskQueue)//method for adding task in list
        {
            ds.Header();
            ds.AddDesign();
            Console.WriteLine("\n+===============================================================================================+");
            Console.Write("|Enter task name: ");
            string name = Console.ReadLine();
            Console.Write("|Enter task priority: ");
            int priority = Convert.ToInt32(Console.ReadLine());
            Console.Write("|Enter task deadline (dd/MM/yyyy HH:mm): ");
            DateTime dateTime = Convert.ToDateTime(Console.ReadLine());

            Task task = new Task
            {
                Name = name,
                Priority = priority,
                DateTime = dateTime,
                IsCompleted = false
            };

            taskList.Add(task);
            Console.WriteLine("+===============================================================================================+");
            Console.WriteLine("                                       Task Added Successfully                                   ");
            Console.ReadKey();
        }
        static void DeleteTask(List<Task> taskList, Queue<Task> taskQueue)//method for deleting task in list
        {
            ds.Header();
            ds.DelDesign();
            Console.WriteLine("\n+===============================================================================================+");
            Console.Write("|Enter task name to delete: ");
            string name = Console.ReadLine();

            Task taskToDelete = taskList.Find(t => t.Name == name);
            if (taskToDelete != null)
            {
                taskList.Remove(taskToDelete);
                taskQueue = new Queue<Task>(taskList);

                Console.WriteLine("+===============================================================================================+");
                Console.WriteLine("                                    Task Deleted Successfully                                    ");
            }
            else
            {
                Console.WriteLine("+===============================================================================================+");
                Console.WriteLine("                                        Task Not Found                                           ");
            }
            Console.ReadKey();
        }
        static void DisplayTasks(List<Task> taskList, Queue<Task> taskQueue)//to display task in list and in queue
        {
            int choice;
            do
            {
                ds.Header();
                ds.TILH();
                ds.ColumnHeader();
                foreach (Task task in taskList)
                {
                    Console.WriteLine("| {0,-29} | {1,-13} | {2,-29} | {3,-22} |", task.Name, task.Priority, task.DateTime, task.IsCompleted ? "\u001b[32mDone\u001b[0m" : "\u001b[31mNot Done\u001b[0m");
                }
                Console.WriteLine("+===============================================================================================+");
                ds.TIQH();
                ds.ColumnHeader();
                foreach (Task task in taskQueue)
                {
                    Console.WriteLine("| {0,-29} | {1,-13} | {2,-29} | {3,-22} |", task.Name, task.Priority, task.DateTime, task.IsCompleted ? "\u001b[32mDone\u001b[0m" : "\u001b[31mNot Done\u001b[0m");
                }
                Console.WriteLine("+===============================================================================================+");

                ds.TaskManager();
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        SearchTask(taskList, taskQueue);
                        break;
                    case 2:
                        SortTasks(taskList);
                        break;
                    case 3:
                        EnqueueTask(taskList, taskQueue);

                        break;
                    case 4:
                        DequeueTask(taskQueue, taskList);
                        break;
                    case 5:
                        return;
                }
            } while (choice != 5);

        }

        static void SearchTask(List<Task> taskList, Queue<Task> taskQueue)//search task in list and in queue
        {
            ds.Header();
            ds.SearchDesign();
            Console.WriteLine("\n+===============================================================================================+");
            Console.Write("|Enter task name to search: ");
            string searchName = Console.ReadLine();
            Console.WriteLine("+===============================================================================================+");

            bool taskFound = false;

            if (taskList.Count() > 0)
            {
                ds.TILH();
                ds.ColumnHeader();
                foreach (Task task in taskList)
                {
                    if (task.Name.Contains(searchName))
                    {
                        Console.WriteLine("| {0,-29} | {1,-13} | {2,-29} | {3,-22} |", task.Name, task.Priority, task.DateTime, task.IsCompleted ? "\u001b[32mDone\u001b[0m" : "\u001b[31mNot Done\u001b[0m");
                        Console.WriteLine("+-----------------------------------------------------------------------------------------------+");
                        taskFound = true;
                    }
                }
                if (!taskFound)
                {
                    Console.WriteLine("\n                       No task found with the given name in the Task List                   ");
                }
            }
            else
            {
                Console.WriteLine("\n                                      List is Empty");
            }
            taskFound = false;
            if (taskQueue.Count() > 0)
            {
                ds.TIQH();
                ds.ColumnHeader();
                foreach (Task task in taskQueue)
                {
                    if (task.Name.Contains(searchName))
                    {
                        Console.WriteLine("| {0,-29} | {1,-13} | {2,-29} | {3,-22} |", task.Name, task.Priority, task.DateTime, task.IsCompleted ? "\u001b[32mDone\u001b[0m" : "\u001b[31mNot Done\u001b[0m");
                        Console.WriteLine("+-----------------------------------------------------------------------------------------------+");
                        taskFound = true;
                    }
                }
                if (!taskFound)
                {
                    Console.WriteLine("\n                       No task found with the given name in the Task Queue                   ");
                }
            }
            else
            {
                Console.WriteLine("\n                                      Queue is Empty");
            }
            Console.ReadKey();
        }
        static void SortTasks(List<Task> taskList)//sort task in list so it can be enqueued better, we used selection sort
        {
            int n = taskList.Count;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (taskList[j].Priority < taskList[minIndex].Priority)
                    {
                        minIndex = j;
                    }
                }
                Task temp = taskList[minIndex];
                taskList[minIndex] = taskList[i];
                taskList[i] = temp;
            }
            Console.WriteLine("\n                           Task in List is Sorted by Priority");
            Console.WriteLine("                                   See Task Display... ");
            Console.ReadKey();
        }
        static void EnqueueTask(List<Task> taskList, Queue<Task> taskQueue)//main menu to enqueue
        {
            int choice;
            ds.Header();
            ds.EnqueueHeader();
            ds.Enqueue();
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    EnqueueAllTasks(taskList, taskQueue);
                    break;
                case 2:
                    EnqueueOne(taskList, taskQueue);
                    break;
                case 3:
                    return;
            }
        }
        static void EnqueueAllTasks(List<Task> taskList, Queue<Task> taskQueue)//enqueue all task in list
        {
            Console.WriteLine("                               Enqueueing all tasks in list...");
            foreach (Task task in taskList.ToList())
            {
                if (!task.IsCompleted)
                {
                    taskQueue.Enqueue(task);
                    taskList.Remove(task);
                }                
            }            
            Console.WriteLine("                                Enqueued all tasks in list ");
            Console.WriteLine("                                   See Task Display... ");
            Console.ReadKey();
        }

        static void EnqueueOne(List<Task> taskList, Queue<Task> taskQueue)//enqueue only one 
        {
            Console.Write("Enter task name to enqueue: ");
            string taskName = Console.ReadLine();

            Task taskToEnqueue = taskList.Find(task => task.Name == taskName);
            if (taskToEnqueue == null || taskToEnqueue.IsCompleted)
            {
                Console.WriteLine("Task not found in list or is completed.");
                Console.ReadKey();
                return;
            }
            taskList.Remove(taskToEnqueue);
            taskQueue.Enqueue(taskToEnqueue);
            Console.WriteLine($"{taskToEnqueue.Name} task enqueued");
            Console.WriteLine("\n                                   See Task Display... ");
            Console.ReadKey();
        }
        static void DequeueTask(Queue<Task> taskQueue, List<Task> taskList)//dequeue task when finished
        {
            if (taskQueue.Count == 0)
            {
                Console.WriteLine("\n                                 No tasks in the queue...");
                Console.ReadKey();
                return;
            }
            Task task = taskQueue.Dequeue();
            task.IsCompleted = true;
            Console.WriteLine($"                                   Task {task.Name} Dequeued");
            taskList.Add(task);
            Console.ReadKey();
        }

    }
}


