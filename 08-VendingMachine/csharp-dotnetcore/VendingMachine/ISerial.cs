namespace VendingMachine
{
    public interface ISerial
    {
        void SendMsg(string msg); // Dispatches sending to a hardware driver, which handles error correction and resends. 
        string ReceiveMessage();  // Will return an empty string if there are no messages present.
    }
}