using mohirdev;

string[] taskList = {"Do the dishes", "Do the chores", "Deadline on 13th of October"};
int[] isMarked = {};
    
while (true)
{
    TaskManager.ShowTasks(taskList, isMarked);
    Console.WriteLine("\n1 - Add task \t 2 - Remove task \t 3 - Mark task \t 0 - Exit\n");
    Console.Write("Choose action: ");
    var choice = Convert.ToInt32(Console.ReadLine());
    if (choice != 0)
        switch (choice)
        {
            case 1:
                TaskManager.AddTask(ref taskList);
                break;
            case 2:
                TaskManager.RemoveTask(ref taskList);
                break;
            case 3:
                TaskManager.MarkTask(ref taskList, ref isMarked);
                break;
            default:
                Console.WriteLine("Enter 1 or 2!!!\n");
                break;
        }
    else
        break;
}