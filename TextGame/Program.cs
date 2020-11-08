using System;
using System.ComponentModel;

namespace MyProgram{
	


public class Program
{
	
	



  public static void Main(string[] args)
  
	
  {						// x ,  y
	  Console.SetWindowSize(40, 25);
	  
	  
	 MainCharacter mainChar = new MainCharacter();
	 mainChar.Name = "john";
	 mainChar.ATTK = 12;
	 mainChar.HP = 150;
	 mainChar.DEF = 10;
	 
	 Enemy enemy = new Enemy();
	 
	 enemy.Name = "mob";
	 enemy.HP = 100;
	 enemy.DEF = 10;
	 enemy.ATTK = 5;
	 
	 bool fight = true;
	
	 int move;
	 while(fight){
		 Console.Clear();
		 
		 foreach(PropertyDescriptor descriptor in TypeDescriptor.GetProperties(enemy))
		{
			string name=descriptor.Name;
			object value=descriptor.GetValue(enemy);
			Console.WriteLine("{0}:  {1}",name,value);
		}
		
		 Console.WriteLine("\n\n\n\n");
		  foreach(PropertyDescriptor descriptor in TypeDescriptor.GetProperties(mainChar))
		{
			string name=descriptor.Name;
			object value=descriptor.GetValue(mainChar);
			Console.WriteLine("{0}:  {1}",name,value);
		}
		 
	
		
		
		 Console.WriteLine("\n\n\n\n");
		 Console.WriteLine("1.Attack");
		 Console.WriteLine("2.Item");
		 Console.Write(": ");
		//get users move option 
		string userMove = Console.ReadLine();
		
		//check to see if it is a number or not
		bool isNumerical = int.TryParse(userMove, out move);
		
		
		if(isNumerical){
			 switch(move)
		 {
			 
			 case 1: 
			 
					
				enemy.HP= EnemyHP(enemy.HP,enemy.DEF,mainChar.ATTK);
				AttackAnimation();
				Console.WriteLine("Enemy Attacks!");
				
				
				mainChar.HP = MainCharacterHP(mainChar.HP,mainChar.DEF,enemy.ATTK);
				
				
					break;
			 case 2: 
					Console.WriteLine("ypu pressed 2");
					break;
			 default:
					Console.WriteLine("Default case");
					break;
			 
			 
		 }
		 
			
			
		}
		
		else{
			Console.WriteLine("write a numbe rplease");
			
		}
		
		 
		
			//Console.ReadKey(); 
	
		 
		 
		//fight = false;
		 
		 
		 
	 }
	 
	 
	 
	 
	 
	 
	
	 Console.ReadLine();
	
  }
  
  	 public static int EnemyHP(int hp,int def,int attack){
			
			hp-=(attack-def);

			return hp;
		 }	
	 public static int MainCharacterHP(int hp,int def,int attack){
			
			hp-=(attack-def);

			return hp;
		 }	
  
 
 
	public static void AttackAnimation(){
		Console.Clear();
		
		int i =0;
		string space = " ";
		while(i<30){
		space+=" ";
		
		if(i==15){
			Console.WriteLine("Enemy Attacks!");
		}
		else if(i ==25){
			
			Console.WriteLine("You Attack!");
			
		}
		else{
			Console.WriteLine(space+"/");
		}
		i++;
		
		System.Threading.Thread.Sleep(20);
		}
		
		System.Threading.Thread.Sleep(500);
	}
 
}
	
	
	
	
}
	
	
	
	
	
	
