import javax.swing.*;
public class Schedule
{
	public static void main(String[] args)
	{
		
		String[][] studentClass = {
		{"CIS105","Mo 8:00PM", "TU 8:00PM", "We 6:50PM", "Th 8:00PM"},
		{"ENG102","Tu 8:30PM", "We 9:00PM", "Th 4:50PM", "Fr 7:00PM"},
		{"CIS117","Mo 4:00PM", "We 8:00PM", "Th 6:50PM", "Fr 6:00PM"},
		{"CIS114","Tu 8:00PM", "We 6:00PM", "Th 2:50PM", "Fr 5:00PM"}
		};
		
		String user;
		String times = "";
		int a = 0;
		int b;
		user = JOptionPane.showInputDialog(null,"Please enter a class in all caps");
		
		for(a = 0; a < 4; a++)
		{
			
			if(studentClass[a][0].equals(user))
			{
				
				for(b = 1; b < 5; ++b)
				{
					times = times + studentClass[a][b] + " ";
					
				}
			}
		}
			if(times.length() > 0)
			{
				System.out.println("Your class schedule is: " + times);
			}
			else
			{
				System.out.println("Class does not exist");
				
			}
			System.exit(0);
		
		
		
		
		
	
	}
}