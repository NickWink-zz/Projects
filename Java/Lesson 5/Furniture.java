import java.util.Scanner;
import javax.swing.JOptionPane;
public class Furniture
{
	public static void main(String[] args)
	{
		int woodType;
		int addChairs;
		
		String pine = "You selected the Pine table, the price of the table is $";
		int pinePrice = 100;
		
		String oak = "You selected the Oak table, the price of the table is $";
		int oakPrice = 225;
		
		String mohogany = "You selected the Oak table, the price of the table is $";
		int mohoganyPrice = 310;
		
		int chairPrice = 250;
		
		int orderTotalPine;
		int orderTotalOak;
		int orderTotalMh;
		
		orderTotalPine = chairPrice + pinePrice;
		orderTotalOak = chairPrice + oakPrice;
		orderTotalMh = chairPrice + mohoganyPrice;
		
		Scanner keyboard = new Scanner(System.in);
		System.out.print("Select the type of table for purchase. \n 1 for Pine, 2 for Oak, 3 for Mahogany: ");
		
		woodType = keyboard.nextInt();
		
		Scanner chair = new Scanner(System.in);
		
		if (woodType == 1)
			System.out.println(pine + pinePrice + "\n");
		else
			if (woodType == 2)
				System.out.println(oak + oakPrice + "\n");
			else
				if (woodType == 3)
					System.out.println(mohogany + mohoganyPrice + "\n");
				else
					System.out.println("Please enter a valid number, your total is currently $0.00");
		
		if ((woodType == 1) || (woodType == 2) || (woodType ==3))
			System.out.println("Would you like to add 4 chairs to your order? \n Enter 1 for Yes, 2 for No");
			addChairs = chair.nextInt();
			if ((woodType == 1)&& (addChairs == 1)) 
				System.out.println("Your new total is $" + orderTotalPine + " for the Pine table and 4 chairs.");
			else
				if ((woodType == 2)&& (addChairs == 1))
				System.out.println("Your new total is $" + orderTotalOak + " for the Oak table and 4 chairs.");
			else
				if ((woodType == 3)&& (addChairs == 1)) 
				System.out.println("Your new total is $" + orderTotalMh + " for the Mohogany table and 4 chairs.");
			else
				System.out.println("Chairs will not be added to your order");
			
	}
}