using shoppinglist;

namespace RestShopping.Managers
{
    public class shoppingsMangercs
    {
        private static int _nextId = 1;
        private static readonly List<shopping> Data = new List<shopping>
        {
            new shopping {Id = _nextId++, Name = "Milk", price = 14, Quantity = 4 },
             new shopping {Id = _nextId++, Name = "Eggs", price = 12, Quantity =2  },

           new shopping {Id = _nextId++, Name = "Bread", price = 20, Quantity =1  },
            
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers
        };
        public List<shopping> GetAll()
        {
            return new List<shopping>(Data);
            // copy constructor
            // Callers should no get a reference to the Data object, but rather get a copy
        }
        public shopping Add(shopping newshopping)
        {
            newshopping.Id = _nextId++;
            Data.Add(newshopping);
            return newshopping;
        }

        public shopping Delete(int id)
        {
            shopping shopping = Data.Find(shopping1 => shopping1.Id == id);
            if (shopping == null) return null;
            Data.Remove(shopping);
            return shopping;
        }

    }
}
