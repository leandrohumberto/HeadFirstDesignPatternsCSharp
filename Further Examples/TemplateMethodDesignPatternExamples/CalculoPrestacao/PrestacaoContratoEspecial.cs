namespace CalculoPrestacao
{
    public class PrestacaoContratoEspecial : Prestacao
    {
        protected override void CalcularValorDaTaxaAdministrativa()
        {
            ValorDaTaxaAdministrativa = (ValorPrincipal * 0.01m) + 1.5m;
        }

        protected override void CalcularValorSeguro()
        {
            ValorDoSeguro = 0.015m / ValorPrincipal + 1;
        }
    }
}
