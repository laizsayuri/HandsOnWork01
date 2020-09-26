using HandsOnWork01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnWork01.Controllers
{
    public class GerenciadorBulas
    {
        public List<Bula> PegarBulas()
        {
            using (Context dataBase = new Context())
            {
                List<Bula> bulas = new List<Bula>();

                bulas = dataBase.Bulas.ToList();
                return bulas;
            }
        }

        public Bula CriarBula(Bula bula)
        {
            using (Context dataBase = new Context())
            {
                Bula novaBula = dataBase.Bulas.Add(bula);

                dataBase.SaveChanges();
                return novaBula;
            }
        }

        public void RemoverBula(int id)
        {
            using (Context dataBase = new Context())
            {
                Bula bulaSeraRemovida = dataBase.Bulas.First(bula => bula.Id == id);

                dataBase.Bulas.Remove(bulaSeraRemovida);
                dataBase.SaveChanges();
            }
        }

        public Bula EditarBula(Bula bula)
        {
            using (Context dataBase = new Context())
            {
                Bula bulaSeraEditada = dataBase.Bulas.First(b => b.Id == bula.Id);

                bulaSeraEditada.Nome = bula.Nome;
                bulaSeraEditada.Uso = bula.Uso;
                bulaSeraEditada.Apresentacao = bula.Apresentacao;
                bulaSeraEditada.Indicacao = bula.Indicacao;
                bulaSeraEditada.Composicao = bula.Composicao;

                dataBase.SaveChanges();
                return bulaSeraEditada;
            }            
        }

        public bool JaExiste(string nome)
        {
            using (Context dataBase = new Context())
            {
                return dataBase.Bulas.Any(bula => bula.Nome == nome);
            }
        }
    }
}
