namespace Structural
{
    /// <summary>
    /// The 'ConcreteBulder' class
    /// </summary>
    public class ConcreteBuilder1 : Builder
    {
        private Product _product = new Product();

        public override void BuildPartA()
        {
            _product.Add("A");
        }

        public override void BuildPartB()
        {
            _product.Add("B");
        }

        public override Product GetResult() => _product;
    }
}
