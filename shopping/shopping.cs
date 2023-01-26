namespace shoppinglist
{
    public class shopping
    {


       
        public int Id { get; set; }
        public string Name { get; set; }
        public int  price { get; set; }
        public int Quantity { get; set; }





        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(price)}={price},{nameof( Quantity)} = {Quantity.ToString()}}}";


        }


    }





}