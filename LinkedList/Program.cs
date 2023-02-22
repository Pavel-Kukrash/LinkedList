

LinkedList<string> people = new LinkedList<string>(new[] { "Tom", "Sam", "Bob" });

var currentNode = people.First;
while (currentNode != null)
{
    Console.WriteLine(currentNode.Value);
    currentNode = currentNode.Next;
}

currentNode = people.Last;
while (currentNode != null)
{
    Console.WriteLine(currentNode.Value);
    currentNode = currentNode.Previous;
}

var people1 = new LinkedList<string>();
people1.AddLast("Tom");                       
people1.AddFirst("Bob"); 


if (people1.First != null) people1.AddAfter(people1.First, "Mike");
foreach (var person in people1) Console.WriteLine(person);
