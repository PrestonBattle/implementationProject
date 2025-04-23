namespace Haven.Models.ConcessionStuff
{
    public class FakeConcessionProduct : RotateConcessionProduct

    {
        public IEnumerable<Concession> Products => new List<Concession>
        {
            new Concession {ItemID = 0, ItemName = "PopCorn", Cost = 6.99 },
            new Concession {ItemID = 1, ItemName = "Soda", Cost = 4.58 },
            new Concession {ItemID = 2, ItemName = "Candy", Cost = 3.40 }
        };



    }
}
