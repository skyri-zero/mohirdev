using mohirdev;

/*string[] taskList = {"Do the dishes", "Do the chores", "Deadline on 13th of October"};
int[] isMarked = {};
    
TaskManager manager = new TaskManager(ref taskList, ref isMarked);
manager.Start();*/

Book fiction = new Book();
Book custom = new Book("Harry Potter", "J. K. Rowling", 55);

custom.name = "Alchemist";
custom.Print();

fiction.ChangeName("Ikigai");
fiction.Print();