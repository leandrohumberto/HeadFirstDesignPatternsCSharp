namespace Ecommerce
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product() { Name = "Xbox One", Description = "500 GB w Kinect", Price = 350.0M, };

            var processor = new PaymentProcessor();
            processor.MakePayment(PaymentMethod.BankOne, product);
            processor.MakePayment(PaymentMethod.BankTwo, product);
            processor.MakePayment(PaymentMethod.BestForMe, product);
            
            var processor2 = new PaymentProcessor2();
            processor2.MakePayment(PaymentMethod.PayPal, product);
            processor2.MakePayment(PaymentMethod.BillDesk, product);

            System.Console.ReadKey();
        }
    }
}
