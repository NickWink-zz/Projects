public class Shirt
{
	private int collarSize;
	private int sleeveLength;
	private int shirtPockets;
	private String material;
	
	public Shirt(int collar, int sleeve, int pockets)
	{
		collarSize = collar;
		sleeveLength = sleeve;
		shirtPockets = pockets;
		material = "cotton";
	}
	
	public void showShirt()
	{
		System.out.println("T-Shirt Size: " + collarSize + " T-Shirt length: " + sleeveLength + " T-Shirt has " + shirtPockets + " pockets, and is made of " + material + "\n"); 
	}
}