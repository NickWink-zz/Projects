public class Pizza
{
		private String topping; 
		private int size; 		
		private double price; 	
		
	public Pizza() //setting the initial values
	{
		topping = "Black Olives";
		size = 16;
		price = 19.99;
	}
	
	public String getTopping() //return topping
	{
		return topping;
	}
	
	public int getSize() //return size
	{
		return size;
	}
	
	public double getPrice() //return price
	{
		return price;
	}
	
	public static void main(String[] args)
	{
		Pizza newOrder = new Pizza();
	}
	
	 
	
}