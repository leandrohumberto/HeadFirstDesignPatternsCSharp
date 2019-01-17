namespace BuilderExamples.Builders
{
    public class ConcreteBuilder : Builder
    {
        private Product _product = new Product();
        private int _part = 0;

        public override void BuildPart()
        {
            _product.Parts.Add("Adding part #" + (_part++));
        }

        public override Product Construct()
        {
            return _product;
        }
    }
}
