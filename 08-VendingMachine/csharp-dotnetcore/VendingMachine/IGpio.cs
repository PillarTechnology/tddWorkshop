namespace VendingMachine
{
    public enum GpioState
    {
        HIGH,
        LOW
    }
    
    public interface IGpio
    {
        GpioState State();
    }
}