public class TestPizza
{
		private String topping; 
		private int size; 
		private double price;
		
	public TestPizza() //set the values for the pizza
	{
		topping = "Black Olives";
		size = 16;
		price = 19.99;
	}
	
	public String getTopping() //return the topping
	{
		return topping;
	}
	
	public int getSize() //return the size
	{
		return size;
	}
	
	public double getPrice() //return the price
	{
		return price;
	}
	
	public static void main(String[] args)
	{ //display pizza order
		TestPizza newOrder = new TestPizza();
		System.out.println("Your pizza has " + newOrder.topping + " as a topping");
		System.out.println("Your pizza is " + newOrder.size + " inches large");
		System.out.println("The prize of your pizza is $" + newOrder.price + "\n");
		System.out.println("Thank you for shopping at Pizza Palace");
	}
}