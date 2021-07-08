namespace VendingMachine
{
    public class SerialBus
    {
        private string _msg = string.Empty;

        public void Send(string msg)
        {
            _msg = msg;
        }

        public string Recv()
        {
            var tmp = _msg;
            _msg = string.Empty;
            return tmp;
        }
        
    }
}