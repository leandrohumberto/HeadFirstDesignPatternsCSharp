namespace Structural
{
    /// <summary>
    /// The 'ConcreteBulder' class
    /// </summary>
    public class ConcreteBuilder2 : Builder
    {
        private Product _product = new Product();

        public override void BuildPartA()
        {
            _product.Add("X");
        }

        public override void BuildPartB()
        {
            _product.Add("Y");
        }

        public override Product GetResult() => _product;
    }
}
