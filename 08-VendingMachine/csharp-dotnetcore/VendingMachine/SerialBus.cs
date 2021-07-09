using System;
using System.Collections.Generic;

namespace VendingMachine
{
    public class SerialBus
    {
        private string _msg = string.Empty;
        private readonly List<Action<string>> _subscribers = new List<Action<string>>();

        public void Send(string msg)
        {
            _msg = msg;
            foreach (var subscriber in _subscribers)
            {
                subscriber(msg);
            }
        }

        public void Subscribe(Action<string> action)
        {
            _subscribers.Add(action);
        }

        public string Recv()
        {
            var tmp = _msg;
            _msg = string.Empty;
            return tmp;
        }
        
    }
}