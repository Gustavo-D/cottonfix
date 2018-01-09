using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerCottonFix
{
    public class CtrlAgilDesagilBBM
    {
        private double tipofolha;
        private double cor;
        private double preco;
        private double agiodesagiototal;
        private double novopreco;
        private double[,] mtipofolha = new double[,] { { 22, 550 }, { 23, 450 }, { 32, 450 }, { 33, 400 }, { 34, 350 }, { 43, 150 }, { 44, 0 }, { 45, -100 }, { 54, -400 }, { 55, -450 }, { 56, -500 }, { 65, -750 }, { 66, 800 }, { 67, -1000 }, { 76, -1400 }, { 77, -1500 } };
        private double[,] mcor = new double[,] { { 1, 0 }, { 2, -300 }, { 3, -600 }, { 4, -1200 }, { 5, -1200 } };

        public CtrlAgilDesagilBBM(double tipofolha, double cor, double preco)
        {
            this.tipofolha = tipofolha;
            this.cor = cor;
            this.preco = preco;
            Calcularagiodesagio();
        }

        private void Calcularagiodesagio()
        {

            double agiodesagiotipofilha = 0;
            double agiodesagiocor = 0;

            for (int i = 0; i < 16; i++)
            {

                if (mtipofolha[i, 0] == tipofolha)
                {
                    agiodesagiotipofilha = mtipofolha[i, 1];
                }
            }

            for (int i = 0; i < 5; i++)
            {

                if (mcor[i, 0] == cor)
                {
                    agiodesagiocor = mcor[i, 1];
                }
            }

            agiodesagiototal = agiodesagiotipofilha + agiodesagiocor;

            if (agiodesagiototal == 0)
            {
                novopreco = preco;
            }
            else
            {
                novopreco = preco + (agiodesagiototal / 10000);
            }
        }

        public double GetNovoPreco()
        {
            return novopreco;
        }

    }
}
