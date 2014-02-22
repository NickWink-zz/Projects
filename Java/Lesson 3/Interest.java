import javax.swing.JOptionPane;
public class Interest
{
	
	
	public static void main (String[] args) //display the data.
	{
		String moneyInvested;
		double investedMoney;
		moneyInvested = JOptionPane.showInputDialog(null, "How much money would you like to invest? ");
		investedMoney = Double.parseDouble(moneyInvested);
		newAmount(investedMoney);
	}
	
	public static void newAmount(double investedMoney) 
	{
		
		double newBalance;
		double interestBalance;
		final double interestRate = 0.05;
		
		interestBalance = (investedMoney * interestRate);
		newBalance = (double)(investedMoney + interestBalance);
		
		System.out.println("Your balance after 1 year will be $" + newBalance);
	}
	
	
	
	
}
