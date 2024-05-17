// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System; 
using System.Windows;  

namespace myApp 
{
    class Person 
    {
        //property
        string Name { get; set; }
        int Age { get; set; }
        
        //constructor 
        public Person(string name, int age){
            Name = name ; 
            Age = age ; 
        }
        
        //show message 
        public string GetShowMessage(){
            return $"Bonjour, {Name} ! Vous avez {Age} ans ? "; 
        }
    }
    class Tools 
    {
        
    }
    class UserKnowledge{
        //main entrance 
        static void Main(string[]args){
            
            Console.Write("Please enter your name :"); 
            string userName = Console.ReadLine(); 
            int age = 17 ;
            Person p = new Person(userName , age ); 
            
            Console.WriteLine(  p.GetShowMessage() ) ;
             
        }
    }
    
}
