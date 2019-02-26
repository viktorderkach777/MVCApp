namespace MVCApp
{
    public class Account
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public decimal Qty { get; set; }

        public virtual CustomUser CustomUser{get; set;}
    }
}