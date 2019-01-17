namespace CalculoPrestacao
{
    public class PrestacaoContratoPadrao : Prestacao
    {
        protected override void CalcularValorDaTaxaAdministrativa()
        {
            ValorDaTaxaAdministrativa = ValorPrincipal * 0.01m;
        }

        protected override void CalcularValorSeguro()
        {
            ValorDoSeguro = ValorPrincipal * 0.015m;
        }
    }
}
