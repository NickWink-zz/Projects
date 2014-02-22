import javax.swing.JOptionPane;
public class Time2
{
	public static void main(String[] args)
	{
		String strMinutes;
		Double minutes; //How many minutes
 		final int hour = 60; //minutes in an hour
		strMinutes = JOptionPane.showInputDialog(null, "Enter the minutes you worked today", "Minutes Worked", JOptionPane.QUESTION_MESSAGE);
		minutes = Double.parseDouble(strMinutes);
		Double totalTime = (minutes / hour); //calculate total hours
		System.out.println("You worked " + totalTime + " hours");
	}
}