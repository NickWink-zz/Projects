public class IntArray
{
	
	
	public static void main(String[] args)
	{
		final int NUMBERS = 5;
		int[] randomNum = {4, 8, 12, 16, 20};
		int x;
		
		for(x = 0; x < NUMBERS; ++x)
		{
			System.out.println(randomNum[x]);
			
		}
		System.out.println();
		for(x = NUMBERS - 1; x >= 0; x--)
		{
			System.out.println(randomNum[x]);
		}
	}
	
	
}