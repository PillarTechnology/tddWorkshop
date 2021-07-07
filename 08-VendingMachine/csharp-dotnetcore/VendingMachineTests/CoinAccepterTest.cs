using System;
using FluentAssertions;
using VendingMachine;
using Xunit;

namespace VendingMachineTests
{
    public class CoinAccepterTest
    {
        private CoinAccepter _accepter;

        public CoinAccepterTest()
        {
            _accepter = new CoinAccepter();
        }
        
        [Fact]
        public void Setup_byDefault_InitializesCoin1GpioToPin13()
        {
            _accepter.Setup();
            
            _accepter.Coin1.Pin.Should().Be(13);
        }
    }
}