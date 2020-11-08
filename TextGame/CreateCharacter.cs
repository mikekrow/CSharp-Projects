using System;
using System.ComponentModel;

namespace MyProgram{
	


class CreateCharacter
{
  public static void Starting()
  
  {
	  Character mainChar = new Character();
	  
	  Console.WriteLine("Welcome to txtPG!");
	  Console.Write("Please enter you name: ");
	  mainChar.Name = (string)Console.ReadLine();
	  
	  //Console.WriteLine("great! "+charName);
	  Console.Write("Please enter you age: ");
	  mainChar.Age = Convert.ToInt32(Console.ReadLine());
	  
	  
	  Random rnd = new Random();
	  int startingHP = rnd.Next(60, 100);
	  Console.WriteLine(startingHP.GetType());
	  Console.ReadLine();
	  mainChar.HP = startingHP;

	  mainChar.DEF = rnd.Next(10,30);
	  mainChar.ATTK = rnd.Next(20,40);
	  mainChar.LUCK = rnd.Next(0,5);
	  

	
	
	  
	  
	 
	 
	 //displays all properties in an object and their values
	  foreach(PropertyDescriptor descriptor in TypeDescriptor.GetProperties(mainChar))
		{
			string name=descriptor.Name;
			object value=descriptor.GetValue(mainChar);
			Console.WriteLine("{0}={1}",name,value);
		}
	  
	  
	  
    //Person myObj = new Person();
    //myObj.Name = "Liam";
    //Console.WriteLine(myObj.Name);
	Console.ReadLine();
	
	//Person myObj2  = new Person();
	//myObj2.Age = 2;
	//Console.WriteLine(myObj2.Age);
	//Console.ReadLine();
	
	
  }
}
	
	
	
	
}