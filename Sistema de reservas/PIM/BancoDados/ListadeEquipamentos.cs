using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PIM.Equipamentos;
using PIM.Notebooks;
using PIM.Projetores;
using PIM.Tablets;

namespace PIM.ListadeEquipamentos
{
    public class BasedeDadosEquips
    {
        public List<Equipamento> EstoqueDeEquipamentos = new List<Equipamento>()
        {
            new Notebook(){ Alugado = true, CodigoSerie = 01325546, Id = 1, Modelo = "Sony Vaio i456", Voltagem = 110 },
            new Notebook { Alugado = false, CodigoSerie = 032465, Id = 2, Modelo = "Positivo dual", Voltagem = 110 },
            new Notebook { Alugado = false, CodigoSerie = 456121, Id = 3, Modelo = "Dell boladao i9", Voltagem = 220 },
            new Tablet { Id = 1, Modelo = "Samsung A16", CodigoSerie = 123564, Voltagem = 5, Alugado = true },
            new Tablet { Id = 2, Modelo = "Postivo fd5", CodigoSerie = 498498, Voltagem = 5, Alugado = false },
            new Tablet { Id = 3, Modelo = "Ipad 10", CodigoSerie = 465186, Voltagem = 5, Alugado = false },
            new Projetor { Id = 1, Modelo = "Epson 410", CodigoSerie = 01325546, Voltagem = 220, Alugado = true },
            new Projetor { Id = 2, Modelo = "Sony light 12", CodigoSerie = 032465, Voltagem = 220, Alugado = false },
            new Projetor { Id = 3, Modelo = "HP fullcinema", CodigoSerie = 2362198, Voltagem = 220, Alugado = false }
        };

        public int EstoqueNotebooksLiberados()
        {
            return EstoqueDeEquipamentos.OfType<Notebook>().Where(x => x.Alugado == false).Count();
        }
        public int EstoqueNotebooksAlugados()
        {
            return EstoqueDeEquipamentos.OfType<Notebook>().Where(x => x.Alugado == true).Count();
        }
        public int EstoqueTabletsLiberados()
        {
            return EstoqueDeEquipamentos.OfType<Tablet>().Where(x => x.Alugado == false).Count();
        }
        public int EstoqueTabletsAlugados()
        {
            return EstoqueDeEquipamentos.OfType<Tablet>().Where(x => x.Alugado == true).Count();
        }
        public int EstoqueProjetoresLiberados()
        {
            return EstoqueDeEquipamentos.OfType<Projetor>().Where(x => x.Alugado == false).Count();
        }
        public int EstoqueProjetoresAlugados()
        {
            return EstoqueDeEquipamentos.OfType<Projetor>().Where(x => x.Alugado == true).Count();
        }

        public int EstoqueTotal()
        {
            return EstoqueDeEquipamentos.Count();
        }

    }
}
