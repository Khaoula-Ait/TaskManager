namespace TaskManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t=== Task Manager ===\n");
            TaskManager.ShowTasks();
            TaskManager.AddTask();

        }
    }
}
