class Notebook : IComparable<Notebook>
{
    public double price = 0;
    public int ram = 0;
    public string brand = string.Empty;

    public int CompareTo(Notebook? obj)
    {
        if (this.price > obj.price)
            return 1;
        if (this.price < obj.price)
            return -1;
        else
        {
            if (this.ram > obj.ram)
                return 1;
            if (this.ram < obj.ram)
                return -1;
            else
                return 0;
        }
    }
}

