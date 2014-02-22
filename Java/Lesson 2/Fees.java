import javax.swing.JOptionPane;
public class Fees
{
	public static void main(String[] args)
	{
		String creditHours, bookCost; //string for user input
		double intCreditHours, intbookCost; //convert the string inputs
 		final double creditHour = 85; //cost per credit
		final double athleticFee = 65; //cost for athletic fee
		double totalCreditCost, finalTotal; //totals for calculation
		creditHours = JOptionPane.showInputDialog(null, "How many credit hours are you enrolled in? ", "Credit Hours", JOptionPane.QUESTION_MESSAGE);//credit hours ?
		bookCost = JOptionPane.showInputDialog(null, "Enter the total amount for your books? ", "Book Prices", JOptionPane.QUESTION_MESSAGE);//Spend on books
		intCreditHours = Double.parseDouble(creditHours); //convert string to number
		intbookCost = Double.parseDouble(bookCost); //convert string to number
		totalCreditCost = (intCreditHours * creditHour); //calculate total credits
		finalTotal = (totalCreditCost + athleticFee + intbookCost); //calulate total
		System.out.println("Your total cost for classes is: " + totalCreditCost);
		System.out.println("Your total cost for books is: " + intbookCost);
		System.out.println("Athelic fee: " + athleticFee + "\n");
		System.out.println("Your total cost for this semester is:  " + finalTotal);//display total
		
	}
}