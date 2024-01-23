// In C#, there isn't a direct equivalent to friend functions, 
// but you can achieve similar behavior using the internal access modifier. 
// The internal modifier allows members of the same assembly 
// (a .NET assembly is a compiled unit of code) to 
// access a class's private members.

using System;

// Assembly A
public class MyClass {
    private int privateData;

    public MyClass(int data) {
        privateData = data;
    }

    internal void InternalMethod() {
        Console.WriteLine("Internal method can access private data: " + privateData);
    }
}

// Assembly B (Another class in a different assembly)
class Program {
    static void Main() {
        MyClass myObj = new MyClass(42);
        
        // Access the internal method from a different assembly
        myObj.InternalMethod();
    }
}

// We have a class MyClass with a private member privateData. 
// We use the internal modifier on the InternalMethod, which allows
// it to be accessed from a different assembly (assuming both classes are 
// in different assemblies). 
// This is somewhat similar to the friend function concept in C++
