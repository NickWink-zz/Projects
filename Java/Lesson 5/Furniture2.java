import java.util.Scanner;
public class Furniture2
{
	public static void main(String[] args)
	{
		int pine = 1;
		int pinePrice = 100;
		int oak = 2;
		int oakPrice = 225;
		int mohogany = 3;
		int mohoganyPrice = 310;
		int large = 25;
		int small = 0;
		
		int woodType;
		int shipping;
		int tableSize;
		int shipOut = 125;
		int shipLocal = 25;
		int total;
		
		Scanner keyboard = new Scanner(System.in);
		Scanner ship = new Scanner(System.in);
		Scanner size = new Scanner(System.in);
		
		System.out.println("Select the type of table for purchase. \n 1 for Pine, 2 for Oak, 3 for Mahogany: ");
		woodType = keyboard.nextInt();
		
		
		switch(woodType)
		{
			case 1: //main wood
			System.out.println("You selected the Pine table, the price of the table is $" + pinePrice);
			
			System.out.println("What size table would you like. Large is $35, Small is $0. \n 1 for Large, 2 for Small");
			tableSize = size.nextInt();
			//table 
			switch (tableSize)
			{
				case 1:
				
				System.out.println("You selected the large table");
				
				System.out.println("Is this order being shipped out of state? Shipping out of state is an additional $125, shipping locally is $25. \n 1 for Out of State 2 for Local:");
			
				shipping = ship.nextInt();
						
				switch (shipping)
				{
				case 1:
				total = shipOut + pinePrice + large;
				System.out.println("Your total for the table is $" + total);
				
				
				break;
				case 2:
				total = shipLocal + pinePrice + large;
				System.out.println("Your total for the table is $" + total);
				break;
				}
				break;
				//end of case 1
				
				case 2:
				System.out.println("You selected the large table");
				
				System.out.println("Is this order being shipped out of state? Shipping out of state is an additional $125, shipping locally is $25. \n 1 for Out of State 2 for Local:");
			
				shipping = ship.nextInt();
						
				switch (shipping)
				{
				case 1:
				total = shipOut + pinePrice + large;
				System.out.println("Your total for the table is $" + total);
				
				
				break;
				case 2:
				total = shipLocal + pinePrice + large;
				System.out.println("Your total for the table is $" + total);
				break;
				}
				//end of case 2
				bre
			}
				
			case 2: //main wood
			System.out.println("You selected the Pine table, the price of the table is $" + oakPrice);
			System.out.println("Is this order being shipped out of state? Shipping out of state is an additional $125, shipping locally is $25. \n 1 for Out of State 2 for Local:");
			
			shipping = ship.nextInt();
			switch (shipping)
			{
				case 1:
				total = shipOut + oakPrice;
				System.out.println("Your total for the table is $" + total);
				
				break;
				case 2:
				total = shipLocal + oakPrice;
				System.out.println("Your total for the table is $" + total);
				break;
			}
			
			case 3: //main wood
			System.out.println("You selected the Pine table, the price of the table is $" + mohoganyPrice);
			System.out.println("Is this order being shipped out of state? Shipping out of state is an additional $125, shipping locally is $25. \n 1 for Out of State 2 for Local:");
			
			shipping = ship.nextInt();
			switch (shipping)
			{
				case 1: //shipping
				total = shipOut + mohoganyPrice;
				System.out.println("Your total for the table is $" + total);
				
				break;
				case 2: //shipping
				total = shipLocal + mohoganyPrice;
				System.out.println("Your total for the table is $" + total);
				break;
			}
		}
		
		
		
	}
	
}