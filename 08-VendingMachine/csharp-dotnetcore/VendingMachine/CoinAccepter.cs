namespace VendingMachine
{
    public class CoinAccepter
    {
        public Gpio Coin1; 
        
        public void Setup()
        {
            Coin1 = new Gpio(-1);
        }
        
        public void Loop()
        {
            
        }
    }
}