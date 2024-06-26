using Calculadora.Services;

namespace CalculadoraTestes
{
    public class CalculadoraTestesDesafio
    {
        public CalculadoraImp construirClasse()
        {
            CalculadoraImp calc = new CalculadoraImp();
            return calc;
        }

        [Theory]
        [InlineData(1,2,3)]
        [InlineData(4,5,9)]
        public void TestSomar(int val1, int val2, int resultado)
        {
            CalculadoraImp calc = construirClasse();
            int resultadoCalculadora = calc.Somar(val1,val2);
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1,2,-1)]
        [InlineData(5,4,1)]
        public void TestSubtrair(int val1, int val2, int resultado)
        {
            CalculadoraImp calc = construirClasse();
            int resultadoCalculadora = calc.subtrair(val1,val2);
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1,2,2)]
        [InlineData(4,5,20)]
        public void TestMultiplicar(int val1, int val2, int resultado)
        {
            CalculadoraImp calc = construirClasse();
            int resultadoCalculadora = calc.multiplicar(val1,val2);
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6,2,3)]
        [InlineData(5,5,1)]
        public void TestDividir(int val1, int val2, int resultado)
        {
            CalculadoraImp calc = construirClasse();
            int resultadoCalculadora = calc.dividir(val1,val2);
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestDividirPor0()
        {
            CalculadoraImp calc = construirClasse();
            Assert.Throws<DivideByZeroException>(() => calc.dividir(3,0));
        }

        [Fact]
        public void TestHistorico()
        {
            CalculadoraImp calc = construirClasse();
            calc.Somar(1,2);
            calc.Somar(1,8);
            calc.Somar(1,9);
            var lista = calc.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }

    }
}