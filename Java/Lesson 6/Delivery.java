public class Delivery
{
	int deliveryLocal = 1;
	int deliveryLong = 2;
        
	
	int deliveryYear;
	int deliveryNum;
	int deliveryDistance;
        int overnightFee;
	int total;
	
	double deliveryWeight;
	double deliveryFee;
        
	boolean deliveryOvernight;
	
	
	public Delivery(int year, int deliveryNumber, int distance, double weight, boolean overnight)
	{
		deliveryYear = year;
		deliveryNum = deliveryYear * 10000 + deliveryNumber;
		deliveryDistance = distance;
		deliveryWeight = weight;
                deliveryOvernight = overnight;
		
		deliveryFee = calculateFee() + totalOvernight();
                
	}
	
	private double calculateFee()
	{
		double fee = 0;
		
		if(deliveryDistance == deliveryLocal)
		{
		if(deliveryWeight < 5)
			fee = 12;
		if((deliveryWeight >= 5) && (deliveryWeight <= 20))
			fee = 16.5;
		if(deliveryWeight > 20)
			fee = 22;
		}
		
		if(deliveryDistance == deliveryLong)
		{
			if(deliveryWeight < 5)
				fee = 35;
			if(deliveryWeight >= 5)
				fee = 47.95;
		}
		return fee;
	}
        
        private double totalOvernight()
        {
            int overnightTotal = 0;
            if(deliveryOvernight)
                overnightTotal = 35;
            else
                overnightTotal = 0;
              
            return overnightTotal;
        }
	
	
}