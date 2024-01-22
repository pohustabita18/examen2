namespace Examen2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numele clientului: ");
            string customerName = Console.ReadLine();

            Console.Write("Introduceti data comenzii :");
            DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), null);

            Console.Write("Introduceti valoarea totala a comenzii: ");
            decimal orderTotal = decimal.Parse(Console.ReadLine());

            // Crearea obiectului de tip Order
            Order order = new Order
            {
                Customer = customerName,
                Date = orderDate,
                Total = orderTotal;
            }
    }
}