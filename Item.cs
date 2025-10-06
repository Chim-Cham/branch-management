namespace App;

class Item
{

    public string ItemName;
    public string ItemDescription;
    public int ItemDamage;
    public User ItemOwner;

    public Item(string name, string description, int damage, User owner)
    {
        ItemName = name;
        ItemDescription = description;
        ItemDamage = damage;
        ItemOwner = owner;
    }

}