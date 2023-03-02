string folderPath = @"C:\Users\Torusiil\Desktop\data";
string filename = "shoppinglist.txt";
string filePath = Path.Combine(folderPath, filename);
List<string> myShoppingList = new List<string>();

if (File.Exists(filePath))
{
    myShoppingList = GetItemsFromUeser();
    File.WriteAllLines(filePath, myShoppingList);
}
else
{
    File.Create(filePath).Close();
    Console.WriteLine($"File {filename} has been created.");
    myShoppingList = GetItemsFromUeser();
    File.WriteAllLines(filePath, myShoppingList);
}


static List<string> GetItemsFromUeser()
{
    List<string> userList = new List<string>();

    while (true)
    {
        Console.WriteLine("Add an item (add)/ Exit (exit):");
        string userChoice = Console.ReadLine();

        if (userChoice == "add")
        {
            Console.WriteLine("Enter an item:");
            string userItem = Console.ReadLine();
            userList.Add(userItem);
        }

        else if (userChoice == "exit")  //panin else if, sest muidu lõpetas programmi kui vajutasin 2x enter või kirjutasin valesti
        {
            Console.WriteLine("Bye!");
            break;
        }

        else
        {
            Console.WriteLine("Please choose a correct command.");  //rida 36 kommentaari täiendus
        }
    }
    return userList;
}

    static void ShowItemsFromList(List<string> someList)
    {
        Console.Clear();

        int listLength = someList.Count;
        Console.WriteLine($"You have added {listLength} items to your shopping list.");

        int i = 1;
        foreach (string item in someList)
        {
            Console.WriteLine($"{i}. {item}");
            i++;
        }
    }