public class Household
{
	private int occupants;
	private double annualIncome;
	
	
	public Household(int householdOccupants, double householdAnnualIncome)
	{
		occupants = householdOccupants;
		annualIncome = householdAnnualIncome;
	}
	
	public void showHousehold()
	{
		System.out.println("The household has " + occupants + " occupant living inside \n" + "The household has an annual income of $" + annualIncome);
		
	}

}