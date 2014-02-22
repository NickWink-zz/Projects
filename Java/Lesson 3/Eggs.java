import javax.swing.JOptionPane;
public class Eggs
{
	public static void main (String[] args)
	{
		numberOfEggs();
	}
	
	public static void numberOfEggs()
	{
		String eggsAmount; 
		int eggsEntered;
		int eggsRemainder;
		int eggsTotal;
		final int oneDozen = 12;
		eggsAmount = JOptionPane.showInputDialog(null, "How many eggs do you have? "); //
		eggsEntered = Integer.parseInt(eggsAmount);
		
		eggsTotal = (eggsEntered / oneDozen); //total
		eggsRemainder = (eggsEntered % oneDozen); //remainder
		
		if (eggsRemainder == 0) //I added this because I don't like that it would show 0. :-)
		System.out.println("You have " + eggsTotal + " Dozen with no eggs remaining");
		else
		if (eggsRemainder > 0)
		System.out.println("You have " + eggsTotal + " Dozen and " + eggsRemainder + " eggs remaining");
		
		
	}
}