import javax.swing.*;
public class StudentIDArray
{
	public static void main(String[] args)
	{
		int[] studentID = {3423, 3983, 2333, 2123, 8858, 3239, 2193, 9583, 4832, 1038};
		String[] firstName = {"John", "Joseph", "Angel", "Samantha", "Robin", "Wayne", "Leo", "Van", "Jordi", "Ciara"};
		double[] gpa = {3.24, 4.00, 2.34, 2.00, 3.12, 1.23, 3.44, 3.89, 2.89, 2.75};
		
		String user = "";
		int id;
		int index = -1;
		boolean found = false;
		while(!found)
		{
		user = JOptionPane.showInputDialog(null, "Please enter your Student ID: ");
		id = Integer.parseInt(user);
		
		for (int i=0; i < studentID.length; i++)
		{
			if (studentID[i] == id)
			{
				found = true;
				index = i;
			}
			
			
		}
		
		if(!found)
		{
			JOptionPane.showMessageDialog(null, "Invalid ID number please try again");
		}
		else
		{
			System.out.println("Your First Name is: " + firstName[index] + "\nYour Student ID is: " + studentID[index] + " \nYour Grade Point Average is: " + gpa[index]);
		}
		}
	}
}