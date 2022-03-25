using CollectionsDemo;


Linked_List<int> myList = new Linked_List<int>();
myList.Add(20);
myList.Add(30);
myList.Add(40);
myList.Add(50);
myList.Add(60);
myList.Add(70);
myList.Add(80);

Console.WriteLine("Before Adding");
myList.Display();
myList.Add(100, 3);
Console.WriteLine("After Adding");
myList.Display();

myList.Remove(4);
Console.WriteLine("After Removing");
myList.Display();

Console.WriteLine("****************************************");

Linked_List<string> myListStr = new Linked_List<string>();
myListStr.Add("Kiran");
myListStr.Add("Kumar");
myListStr.Add("Karan");
myListStr.Add("Kavan");
myListStr.Add("Kavith");
myListStr.Add("Keren");

myListStr.Display();
Console.WriteLine("****************************************");