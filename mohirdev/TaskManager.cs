namespace mohirdev;

public static class TaskManager
{
    public static void ShowTasks(string[] list, int[] mark)
    {
        int i = 1;
        int j = 0;
        if (list.Length != 0)
            foreach (var task in list)
            {
                if (mark.Contains(i))
                    Console.WriteLine($"{i}. {task} \t" + '+');
                else
                    Console.WriteLine($"{i}. {task} \t");
                i++;
            }
        else
            Console.WriteLine("You do not have any tasks yet!");
    }

    public static void RemoveTask(ref string[] list)
    {
        Console.Write("Which task do you want to delete? (Enter number): ");
        var deleteTask = Convert.ToInt32(Console.ReadLine());
        var iList = list.ToList();
        if (deleteTask <= list.Length && deleteTask > 0)
        {
            iList.RemoveAt(deleteTask - 1);
            list = iList.ToArray();
            Console.WriteLine("\nTask Removed");
        }
        else 
            Console.WriteLine("Enter valid number!!!\n");
    }

    public static void AddTask(ref string[] list)
    {
        Console.Write("Enter new task: ");
        string newTask = Console.ReadLine()!;
        var iList = list.ToList();
        iList.Add(newTask);
        list = iList.ToArray();
        Console.WriteLine("\nTask added");
    }

    public static void MarkTask(ref string[] list, ref int[] mark)
    {
        Console.Write("Choose task to complete: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        var markList = mark.ToList();
        if (!mark.Contains(choice)) 
            markList.Add(choice); 
        mark = markList.ToArray();
    }
}