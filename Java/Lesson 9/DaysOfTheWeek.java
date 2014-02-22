import javax.swing.*;
public class DaysOfTheWeek
{

		enum days {MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY};

		
	public static void main(String[] args)
	{
		
		String user;
		String[][] hours = {{"MONDAY","9am to 9pm"},
		{"TUESDAY", "9am to 9pm"},
		{"WEDNESDAY", "9am to 9pm"},
		{"THURSDAY", "9am to 9pm"},
		{"FRIDAY", "9am to 9pm"},
		{"SATURDAY", "9am to 6pm"},
		{"SUNDAY", "11am to 5pm"}
		};
		int a = 0;
		int b;
		String display = "";
		user = JOptionPane.showInputDialog(null, "MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY \nPlease enter a day of the week: ");
		
		
		for(a = 0; a < 4; a++)
		{
			if(hours[a][0].equals(user))
			{
			
					display = hours[a][1] + " ";
			}
		
		}
		
		System.out.println(display);
		
				
	}


}