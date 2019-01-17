using System;

namespace CalculoPrestacao
{
    /// <summary>
    /// https://robsoncastilho.com.br/2012/07/10/template-method-refatorando-com-design-patterns/
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var padrao = new PrestacaoContratoPadrao();
            Console.WriteLine("Valor Prestação Contrato Padrão: {0:c}", padrao.Calcular(9546.34m, 17));

            var especial = new PrestacaoContratoEspecial();
            Console.WriteLine("Valor Prestação Contrato Especial: {0:c}", especial.Calcular(8634.61m, 17));
        }
    }
}
