
namespace SemplForReflection
{
   public class Client
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Sum { get; private set; }


        public Client(string Name, string Phone, int Sum)
        {
            this.Name = Name;
            this.Phone = Phone;
            this.Sum = Sum;
        }

        public void AddSum(int sum)
        {
            if (sum > 0)
            {
                Sum = Sum + sum;
            }
        }
    }
}
