using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnWork01.Models
{
    public class Bula
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Apresentacao { get; set; }

        public string Uso { get; set; }

        public string Composicao { get; set; }

        public string Indicacao { get; set; }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(Nome) || string.IsNullOrWhiteSpace(Nome))
            {
                return false;
            }

            if (string.IsNullOrEmpty(Apresentacao) || string.IsNullOrWhiteSpace(Apresentacao))
            {
                return false;
            }

            if (string.IsNullOrEmpty(Uso) || string.IsNullOrWhiteSpace(Uso))
            {
                return false;
            }

            if (string.IsNullOrEmpty(Composicao) || string.IsNullOrWhiteSpace(Composicao))
            {
                return false;
            }

            if (string.IsNullOrEmpty(Indicacao) || string.IsNullOrWhiteSpace(Indicacao))
            {
                return false;
            }           

            return true;
        }
    }
}
