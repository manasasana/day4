/*  generic
  public class GenericExample
{
    public void show<T>(T msg)
    {
        Console.WriteLine(msg);
    }
    public GenericExample(T msg)
    {
        Console.WriteLine(msg);
    }
}

public class TestGeneric
{
    public static void Main(string[] args)
    {
        // GenericExample<String> genericexample = new GenericExample<String>("this is string");
        //GenericExample<int> genericexample1 = new GenericExample<int>(45);
        //GenericExample<char> genericexample2 = new GenericExample<char>('k');
        GenericExample genericexample2 = new GenericExample();
        genericexample2.show("this is a message");
        genericexample2.show(67);
    }

}
*/

/*list hashset sortedset stack  queue linkedlist dictionary sorted dictionary and list 
public class TestGeneric
{
    public static void Main(string[] args)
    {
        var newList = new List<string>();
        newList.Add("apple");
        newList.Add("orange");
        newList.Add("banana");
        newList.Add("grapes");
        foreach (var i in newList)
        {
            Console.WriteLine(i);   
        }
        
        var newHashSet = new HashSet<int>();
        newHashSet.Add(89);
        newHashSet.Add(76);
        newHashSet.Add(54);
        newHashSet.Add(12);
        foreach (var i in newHashSet)
        {
            Console.WriteLine(i);
        }*/
/*var SortedSet = new SortedSet<int>();
SortedSet.Add(1);
SortedSet.Add(4);
SortedSet.Add(9);
SortedSet.Add(4);
SortedSet.Add(1);
foreach (var i in SortedSet)
{
    Console.WriteLine(i);
}

var mystack = new Stack<int>();
mystack.Push(1);
mystack.Push(2);
mystack.Push(3);
foreach (var i in mystack)
{
    Console.WriteLine(i);
}
Console.WriteLine("next");
Console.WriteLine(mystack.Peek());
Console.WriteLine(mystack.Pop());
Console.WriteLine(mystack.Peek());
Console.WriteLine("next");
foreach (var i in mystack)
{
    Console.WriteLine(i);
}
var queue = new Queue<int>();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);
foreach (var i in queue)
{
    Console.WriteLine(i);
}
Console.WriteLine("next");
Console.WriteLine(queue.Peek());
Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Peek());
var linked = new LinkedList<String>();
linked.AddLast("q");
linked.AddLast("v");
linked.AddLast("i");
linked.AddFirst("o");
foreach (var i in linked)
{
    Console.WriteLine(i);
}
LinkedListNode<String > linknode = linked.Find("q");
linked.AddBefore(linknode, "y");
Console.WriteLine("next");
linked.AddAfter(linknode, "t");
Console.WriteLine("next");
foreach (var i in linked)
{
    Console.WriteLine(i);
}
Dictionary < int, string> dict= new Dictionary<int, string>();
dict.Add(1, "a");
dict.Add(2, "b");
dict.Add(3, "c");   
dict.Add(4, "d");
foreach (KeyValuePair<int, string> kvp in dict)
    Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
dict.Remove(1);
foreach (KeyValuePair<int, string> kvp in dict)
    Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
SortedDictionary<int, string> dict = new SortedDictionary<int, string>();
dict.Add(1, "a");
dict.Add(5, "b");
dict.Add(9, "c");
dict.Add(4, "d");
foreach (KeyValuePair<int, string> kvp in dict)
    Console.WriteLine(kvp);
SortedList<int, string> dict = new SortedList<int, string>();
dict.Add(1, "aguy");
dict.Add(5, "btyk");
dict.Add(9, "colkiop");
dict.Add(4, "ddjtki");
foreach (KeyValuePair<int, string> kvp in dict)
    Console.WriteLine(kvp);

}

}*/
/*public class TestGeneric
{
    public static void Main(string[] args)
    {
        using (TextWriter tw = File.CreateText("C:\\testing\\example.txt"))
        {
            tw.WriteLine("hello");
        }


        FileStream fileStream = new FileStream("C:\\testing\\example.txt", FileMode.OpenOrCreate);
        StreamWriter sw = new StreamWriter(fileStream);
        sw.WriteLine("hello");
        //fileStream.WriteByte(66) ;
        sw.Close();
        fileStream.Close();
        Console.WriteLine("we created a file");
        StreamReader sr = new StreamReader(fileStream);
        string str = sr.ReadLine();
        Console.WriteLine(str);
        TextWriter writer = new TextWriter(fileStream);
        sr.Close();
        fileStream.Close();*/
/*using System.Text;
public class TestGeneric
    {
        public static void Main(string[] args)
    {
        /*using (TextReader reader = File.OpenText("C:\\testing\\example.txt"))
        {
            Console.WriteLine(reader.Read());
            Console.WriteLine(reader.ReadLine());

            Console.WriteLine(reader.ReadToEnd());
        }*/

// String filename = "C:\\testing\\example.txt";
/*using (BinaryWriter bw = new BinaryWriter(File.Open(filename, FileMode.Open)))
{
    bw.Write(90);
    bw.Write("hello");
}
using (BinaryReader bw = new BinaryReader(File.Open(filename, FileMode.Open)))
{
    Console.WriteLine(bw.ReadString());
}

string text = "example of string builder";
StringBuilder stringBuilder = new StringBuilder();
StringWriter stringWriter = new StringWriter(stringBuilder);
stringWriter.WriteLine(text);
stringWriter.Close();
StringReader stringReader = new StringReader(stringBuilder.ToString());  
while (stringReader.Peek()! = -1)
{
    Console.WriteLine(stringReader.ReadLine());
}
// FileInfo fi = new FileInfo("C:\\testing\\example.txt");
//fi.Delete();
DirectoryInfo  di= new DirectoryInfo("C:\\testing\\example1.txt");
di.Create();
}
}*/

class Multithread
{
    public static void thread1()
    {
        for (int i = 0; i < 10; i++) 
        {
            Console.WriteLine(i);
            Thread t=Thread.CurrentThread;
            Console.WriteLine(t.Name);
            //Thread.Sleep(100);
        }
    }
    static void Main()
    {
        /*Thread mythread = Thread.CurrentThread;
        mythread.Name="mainthread";
        Console.WriteLine(mythread.Name);*/
        Thread t1 = new Thread(new ThreadStart(Multithread.thread1));
        t1.Name = "threadone";
        Thread t2 = new Thread(new ThreadStart(Multithread.thread1));
        t2.Name = "threadtwo";
        Thread t3 = new Thread(new ThreadStart(Multithread.thread1));
        t3.Name = "threadthree";
        t1.Priority = ThreadPriority.Lowest;
        t3.Priority = ThreadPriority.Highest;
        t2.Priority = ThreadPriority.Normal;
        t1.Start();
        t2.Start();
        t3.Start();
        
    }
}
