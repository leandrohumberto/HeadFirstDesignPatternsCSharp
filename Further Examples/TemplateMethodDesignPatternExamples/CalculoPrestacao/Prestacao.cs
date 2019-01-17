namespace CalculoPrestacao
{
    public abstract class Prestacao
    {
        protected decimal ValorPrincipal { get; set; }

        protected decimal ValorDaTaxaAdministrativa { get; set; }

        protected decimal ValorDoSeguro { get; set; }

        public decimal Calcular(decimal valorTotal, int numeroDeParcelas)
        {
            CalcularValorPrincipal(valorTotal, numeroDeParcelas);
            CalcularValorDaTaxaAdministrativa();
            CalcularValorSeguro();
            return CalcularValorTotal();
        }

        private void CalcularValorPrincipal(decimal valorTotal, int numeroDeParcelas)
        {
            ValorPrincipal = valorTotal / numeroDeParcelas;
        }

        protected abstract void CalcularValorDaTaxaAdministrativa();

        protected abstract void CalcularValorSeguro();

        private decimal CalcularValorTotal()
        {
            return ValorPrincipal + ValorDaTaxaAdministrativa + ValorDoSeguro;
        }
    }
}
