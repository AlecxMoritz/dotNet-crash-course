namespace _09_interfaces
{
    internal interface IItem
    {
        string Name { get; set; }
        int GoldValue { get; set; }
        string ItemType { get; set; }



        void Equip();
        void Sell();
    }
}