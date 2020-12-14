using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using static System.Console;


namespace CreaturesOfTheSea
{
    class Program
    {
        static void Main(string[] args)
        {
            Game.Start();
        }











        //Abstraction: means hiding the unnecessary details from type consumers.

        //Encapsulation is defined 'as the process of enclosing one or more items within a physical or logical package'. Encapsulation, in object oriented programming methodology, prevents access to implementation details.
        //https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/intro-to-csharp/object-oriented-programming

        //        Encapsulation is implemented by using access specifiers.An access specifier defines the scope and visibility of a class member. C# supports the following access specifiers −
        
        //* Public Public access specifier allows a class to expose its member variables and member functions to other functions and objects.Any public member can be accessed from outside the class.
       
        //* Private Private access specifier allows a class to hide its member variables and member functions from other functions and objects.Only functions of the same class can access its private members.Even an instance of a class cannot access its private members.
      
        //* Protected Protected access specifier allows a child class to access the member variables and member functions of its base class. This way it helps in implementing inheritance.We will discuss this in more details in the inheritance chapter.

        //* Internal Internal access specifier allows a class to expose its member variables and member functions to other functions and objects in the current assembly.In other words, any member with internal access specifier can be accessed from any class or method defined within the application in which the member is defined.
        
        //* Protected internal The protected internal access specifier allows a class to hide its member variables and member functions from other class objects and functions, except a child class within the same application.This is also used while implementing inheritance.
    }
}
