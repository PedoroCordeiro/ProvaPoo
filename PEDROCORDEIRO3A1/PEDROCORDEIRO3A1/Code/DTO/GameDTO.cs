using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEDROCORDEIRO3A1.Code.DTO
{
    class GameDTO
    {
        private int _codigo;
        private string _nome;
        private string _genero;
        private double _valor;
        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Genero { get => _genero; set => _genero = value; }
        public double Valor { get => _valor; set => _valor = value; }
    }
}
