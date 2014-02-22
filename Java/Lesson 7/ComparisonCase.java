public class ComparisonCase
{
 
    public static void main(String[] args) 
	 {
        java.util.Scanner input = new java.util.Scanner(System.in);
        String word1 = "Java";
        String word2;
       
        	System.out.println("Type the word: " + word1);
        	word2 = input.next();
         
			
			 	if (word1.equals(word2)) 
				{
                System.out.println("Correct, you typed the word exactly as shown. \n");
					 System.exit(0);
            } 
				else 
				{
                System.out.println("Your entry is incorrect. \n");
            }
           
            if (word1.equalsIgnoreCase(word2)) 
				{
                System.out.println("If we ignore the letter casing your entry was correct. \n" + word1 + " is equal to " + word2 + "\n");
            } 
				else 
				{
                System.out.println("Please enter above given word correctly. \n");
            }
    }
}