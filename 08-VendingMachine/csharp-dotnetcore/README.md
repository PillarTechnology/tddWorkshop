# Vending Machine Kata

In this exercise you will build the brains of a vending machine.  It will
accept money, make change, maintain inventory, and dispense products.  All the
things that you might expect a vending machine to accomplish.

The point of this kata to to provide a larger than trivial exercise that can be
used to practice TDD.  A significant portion of the effort will be in
determining what tests should be written and, more importantly, written next.

Hardware specification is as follows:

  * 4-coin coin accepter, connected via a serial interface.  It has
    bidirectional communication.  It can send and receive the following messages:

    * COIN1 - COIN4, sent when a valid coin is dropped.  *Note:* Coin acceptor
      hardware has no concept of denomination.  They can be trained on any coin
      or token.  The software is responsible for knowing the value of the different coins.
    * USERCANCEL, sent when the user hits the coin-return button.
    * MACHINECANCEL, sent by the vending machine to cancel a purchase.
    * DISPENSE1 - DISPENSE4, sent by the vending machine to make change from
      coin1 - coin4.  See previous note re: denominations.
    * COINPRESENT is sent by the vending machine.  The coin accepter responds
      with a string containing all of the coins it has available for making
      change.  Because of physical hardware limitations this never exceeds one
      coin for each coin type.

    Internally the coin accepter also has a sensor for each coin type,
    available as GPIO sensors.  For each coin type, the sensor will read HIGH if a
    coin is present, and LOW if there is no coin present.

  * 4x4 button array, used for selecting product.  Connected via serial
    interface.  When a button is pressed it sends the row and column in the
    form "A1" or "D4"

  * Stock sensor, detects if there is stock present in a given slot.  It uses
    the same indexing system as the button array.  Send a string with grid
    components, the interface returns a boolean, true if stock is present, false if
    stock is not present.
    
  * 2x20 display.  It can display 2 lines of 20 characters each.  It has a
    serial interface to receive text.  Whenever a block of text is received it
    will clear the display of any previous text.


*Each serial device has its own serial interface which must be handled separately.*


## Features

### Accept Coins
  
_As a vendor_  
_I want a vending machine that accepts coins_  
_So that I can collect money from the customer_  

The vending machine will accept valid coins (nickels, dimes, and quarters) and
reject invalid ones (pennies).  When a valid coin is inserted the amount of the
coin will be added to the current amount and the display will be updated.  When
there are no coins inserted, the machine displays INSERT COIN.  Rejected coins
are placed in the coin return.

*NOTE:* See hardware specification above. Please note that the coin acceptor
code *must* be a separate class from the vending machine logic code, because it
will be installed on separate hardware.

### Select Product

_As a vendor_  
_I want customers to select products_  
_So that I can give them an incentive to put money in the machine_  

There are three products: cola for $1.00, chips for $0.50, and candy for $0.65.
When the respective button is pressed and enough money has been inserted, the
product is dispensed and the machine displays THANK YOU.  If the display is
checked again, it will display INSERT COIN and the current amount will be set
to $0.00.  If there is not enough money inserted then the machine displays
PRICE and the price of the item and subsequent checks of the display will
display either INSERT COIN or the current amount as appropriate.

### Make Change

_As a vendor_  
_I want customers to receive correct change_  
_So that they will use the vending machine again_  

When a product is selected that costs less than the amount of money in the
machine, then the remaining amount is placed in the coin return.

### Return Coins

_As a customer_  
_I want to have my money returned_  
_So that I can change my mind about buying stuff from the vending machine_  

When the return coins button is pressed, the money the customer has placed in
the machine is returned and the display shows INSERT COIN.

### Sold Out

_As a customer_  
_I want to be told when the item I have selected is not available_  
_So that I can select another item_  

When the item selected by the customer is out of stock, the machine displays
SOLD OUT.  If the display is checked again, it will display the amount of money
remaining in the machine or INSERT COIN if there is no money in the machine.

### Exact Change Only

_As a customer_  
_I want to be told when exact change is required_  
_So that I can determine if I can buy something with the money I have before inserting it_  

When the machine is not able to make change with the money in the machine for
any of the items that it sells, it will display EXACT CHANGE ONLY instead of
INSERT COIN.
