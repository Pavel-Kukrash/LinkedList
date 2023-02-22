
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


// Queue


//Queue<string> people= new Queue<string>();

//people.Enqueue("Tom"); // {Tom}
//people.Enqueue("Sam"); // {Tom, Sam}
//people.Enqueue("Bob"); // {Tom, Sam, Bob}

//var firstPerson = people.Peek();
//Console.WriteLine(firstPerson); // Tom
//var personDelete = people.Dequeue(); // {Sam, Bob}

Console.WriteLine("--------------------------------");

var patients = new Queue<Person>();
patients.Enqueue(new Person("Tom"));
patients.Enqueue(new Person("Bob"));
patients.Enqueue(new Person("Sam"));

var practitioner = new Doctor();
practitioner.TakePatients(patients);


Console.WriteLine("--------------------------------");

List <string> people2 = new List<string> { "Tom", "Sam", "Bob"};
var stack = new Stack<string>(people2);

stack.Push("Mike");
stack.Push("Alice");

string headPerson = stack.Pop();
string firstPerson = stack.Peek();
Console.WriteLine(firstPerson);

var remove = stack.TryPop(out var person1);
var show = stack.TryPeek(out var person2);
Console.WriteLine(person2);

Console.WriteLine("--------------------------------");

foreach (var person in stack)
{
    Console.WriteLine(person);
}


Console.ReadKey();

class Person
{
    public string Name { get; }
    public Person(string name) => Name = name;
}

class Doctor
{
    public void TakePatients(Queue<Person> patients)
    {
        while (patients.Count > 0)
        {
            var patient = patients.Dequeue();
            Console.WriteLine($"Examination of {patient.Name}");
        }
        Console.WriteLine("Doctor finished");
    }
}







