
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

            Stack<int> intstack = new Stack<int>();
            intstack.Push(10);
            intstack.Push(20);
            intstack.Push(30);
            Person person1=new Person();
            Person person2=new Person();
            person1.Name="Kalle";
            person2.Name="Pelle";
            Stack<Person> persstack = new Stack<Person>();
            persstack.Push(person1);
            persstack.Push(person2);



            Console.Write(intstack.Pop()+"\n");
            Console.Write(intstack.Pop()+"\n");

            Console.Write(persstack.Pop().Name+"\n");
            Console.Write(persstack.Pop().Name+"\n");


            Queue<int> intqueue = new Queue<int>(); 
            intqueue.Enqueue(10);
            intqueue.Enqueue(20);
            intqueue.Enqueue(30);
            Person person3=new Person();
            Person person4=new Person();
            person3.Name="Berit";
            person4.Name="Siv";
            Queue<Person> persqueue = new Queue<Person>();
            persqueue.Enqueue(person3);
            persqueue.Enqueue(person4);



            Console.Write(intqueue.Dequeue()+"\n");
            Console.Write(intqueue.Dequeue()+"\n");
            Console.Write(persqueue.Peek().Name+"\n");

            Console.Write(persqueue.Dequeue().Name+"\n");
             Console.Write(persqueue.Dequeue().Name+"\n");

            Console.ReadKey();
        }
    } 
}