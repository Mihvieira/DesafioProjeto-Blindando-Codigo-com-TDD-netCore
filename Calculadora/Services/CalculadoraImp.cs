using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        private List<string> listaHistorico;
        private DateTime DataAtual = DateTime.Now;
        private int indexLista = 0;

        public CalculadoraImp()
        {
            listaHistorico = new List<string>();
        }

        public int Somar(int num1, int num2)
        {
            int res = num1 + num2;
            AdicionarHistorico(res);
            return res;
        }

        public int subtrair(int num1, int num2)
        {
            int res = num1-num2;
            AdicionarHistorico(res);
            return res;
        }

        public int multiplicar(int num1, int num2)
        {
            int res = num1*num2;
            AdicionarHistorico(res);
            return res;
        }

        public int dividir(int num1, int num2)
        {
            int res = num1/num2;
            AdicionarHistorico(res);
            return res;
        }

        public List<string> historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count -3);
            return listaHistorico;
        }

         public void AdicionarHistorico(int res)
        {
            listaHistorico.Insert(indexLista, "Res: "+ res + "-data" + DataAtual);
            indexLista+=1;
        }
    }
}