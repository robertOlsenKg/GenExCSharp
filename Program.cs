
using System;
using System.Collections.Generic;
namespace GenExCSharp
{
    public class Person //en enkel klass
{
    public string Name;
    public Person() //Konstruktor
    {
        Name = "unknown";
    }

   
}
    public class Program
    {
   
        public static void Main()
        {

            Stack<int> intstack = new Stack<int>(); //Deklarerar en stack för heltal <typparameter>
            intstack.Push(10);  //Lägger till tre tal i stacken
            intstack.Push(20);
            intstack.Push(30);
            Person person1=new Person();    //skapar två personobjekt
            Person person2=new Person();
            person1.Name="Kalle";   //Tilldelar namn till personerna
            person2.Name="Pelle";
            Stack<Person> persstack = new Stack<Person>();  //Deklarerar en stack för personobjekt
            persstack.Push(person1);    //Lägger till de två personerna i stacken
            persstack.Push(person2);



            Console.Write(intstack.Pop()+"\n"); //Tar bort och skriver ut två tal ur stacken
            Console.Write(intstack.Pop()+"\n"); //Sist in i stacken kommer först ut LIFO

            Console.Write(persstack.Pop().Name+"\n");   //Tar bort och skriver ut namnen på personerna i stacken
            Console.Write(persstack.Pop().Name+"\n");


            Queue<int> intqueue = new Queue<int>();     //Deklarerar en kö för heltal
            intqueue.Enqueue(10);   //Lägger in tre tal i kön
            intqueue.Enqueue(20);   //kommentar
            intqueue.Enqueue(30);

            Person person3=new Person();
            Person person4=new Person();
            person3.Name="Berit";
            person4.Name="Siv";
            Queue<Person> persqueue = new Queue<Person>();  //Deklarerar en kö för personobjekt
            persqueue.Enqueue(person3); //Lägger in objekten i kön
            persqueue.Enqueue(person4);

            Console.Write(intqueue.Count()+"\n");   //Skriver ut antal tal i kön
            Console.Write(intqueue.Dequeue()+"\n"); //Tar bort och skriver ut de två första talen i kön. Först in, först ut. FIFO
            Console.Write(intqueue.Dequeue()+"\n");
            Console.Write(intqueue.Count()+"\n");
            
            Console.Write(persqueue.Peek().Name+"\n");  //Skriver ut namnet på det första objektet i personkön, utanm att ta bort det
            Console.Write(persqueue.Dequeue().Name+"\n");   //Tar bort och skriver ut namnen på det första objekten i kön
            Console.Write(persqueue.Dequeue().Name+"\n");

            List<Person> perslist = new List<Person>();//Deklarerar en lista för personobjekt
            perslist.Add(person1);//Lägger till tre objekt sist i listan
            perslist.Add(person2);
            perslist.Add(person3);
            Console.Write("__________\n");  //För att sära på utskrifterna
            foreach(var item in perslist)   //Skriver ut namnen på objekten i listan
                Console.Write(item.Name+"\n");
            Console.Write("__________\n");

            perslist.Insert(1,person4); //Lägger till ett objekt på position 1

            foreach(var item in perslist)
                Console.Write(item.Name+"\n");
            Console.Write("__________\n");

            perslist.RemoveAt(2);   //Tar bort objektet på position 2

              foreach(var item in perslist)
                Console.Write(item.Name+"\n");
            Console.Write("__________\n");


            Console.ReadKey();  //Väntar på att en tangent ska tryckas ned
        }
    } 
}