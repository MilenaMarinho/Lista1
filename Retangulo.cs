using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1LISTA1
{
    internal class Retangulo
    {
        #region Atributos
        private double altura;
        private double basee;
        private double area;
        #endregion

        #region Metodos Interface
        public void setAltura (double p)
        {
            altura = p;
        }
        public void setBase(double p)
        {
            basee = p;
        }
        public double getAltura()
        {
            return altura;
        }
        public double getBase()
        {
            return basee;
        }
        public double getArea()
        {
            return area;
        }
        #endregion
        #region MetodosFuncionais
        public void calcularArea()
        {
            area = altura * basee;
        }
        #endregion
    }
}
