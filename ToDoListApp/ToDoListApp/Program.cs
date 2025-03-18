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
		case "2":
		case "3":
		case "4":
		default:
	}
}


