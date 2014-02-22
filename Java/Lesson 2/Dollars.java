import javax.swing.JOptionPane;
public class Dollars
{
	public static void main (String [] args)
	{
		int amountEntered = 0;
      int amountRemainder = 0;
      String userAmount;

      userAmount = JOptionPane.showInputDialog(null, "Please enter a dollar amount: ");//user entered amount
      amountEntered = Integer.parseInt(userAmount);
      System.out.println("The amount entered is $" + amountEntered); //display the amount
      
      System.out.println("Number of 20s: " + (amountEntered / 20)); //calculate the amount of 20's
		amountRemainder = amountEntered % 20;
      System.out.println("Number of 10s: " + (amountRemainder / 10)); //calculate the amount remaining to get the 10s
      amountRemainder = amountRemainder % 10;
      System.out.println("Number of 5s: " + (amountRemainder / 5)); //calculate the amount remaining to get the 5's
      amountRemainder = amountRemainder % 5;
      System.out.println("Number of 1s: " + amountRemainder ); //calculate the amount remaining to get the 1s
	}
}