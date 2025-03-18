// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//creation of a list named task for tasks to be stored in
List<string> task = new List<string>();
bool running = true; //ensures that the code is running

//user prompt for app instruction
while (running) {
	Console.WriteLine("To-Do List: ");
	System.Console.WriteLine("Enter 1-4 to interact with the list.");
	Console.WriteLine("Enter 1 to check the list.");
	Console.WriteLine("Enter 2 to add to the list.");
	Console.WriteLine("Enter 3 to remove a task from the list.");
	Console.WriteLine("Enter 4 to exit the program.");
	Console.WriteLine("Choose an option: ");

	string choice = Console.ReadLine(); //reads inputs by the user

	//switch statement for the main menu options
	switch (choice) {
		case "1":
			viewTask(task);
			break;
		case "2":
			addTask(task);
			break;
		case "3":
			deleteTask(task);
			break;
		case "4":
			running = false;
			Console.WriteLine("Goodbye!");
			break;
		default:
			Console.WriteLine("Invalid input!");
			break;
	}
}

//add task method
static void addTask(List<string> tasks) {
	Console.WriteLine("Enter a new task: ");
	string task = Console.ReadLine();
	if (!string.IsNullOrWhiteSpace(task)) {
		tasks.Add(task);
		Console.WriteLine("Task added!");
	} else {
		Console.WriteLine("The task cannot be empty.");
	}
}




