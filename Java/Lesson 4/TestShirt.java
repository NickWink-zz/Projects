public class TestShirt
{
	public static void main(String[] args)
	{
		Shirt lrg = new Shirt(17, 36, 2);
		Shirt polo = new Shirt(15, 32, 1);
		Shirt tommy = new Shirt(22, 45, 0);
		
		lrg.showShirt();
		polo.showShirt();
		tommy.showShirt();
	}
}