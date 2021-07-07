namespace VendingMachine
{
    public class Gpio
    {
        public int Pin;

        public Gpio(int pin)
        {
            Pin = -1;
        }

        public GpioState State()
        {
            return GpioState.LOW;
        }
    }
}