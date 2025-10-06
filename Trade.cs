namespace App;

class Trade
{

    public Item ItemSent;
    public User TradeSender;
    public Item ItemRecieved;
    public User TradeReciever;

    public Item(Item sent, Item recieved, User sender, User reciver)
    {
        ItemSent = sent;
        TradeSender = sender;
        ItemRecieved = recieved;
        TradeReciever = reciver;
    }
}