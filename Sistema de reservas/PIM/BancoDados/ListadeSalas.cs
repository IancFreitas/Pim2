using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PIM.Locais;

namespace PIM.ListadeSalas
{
    class BasedeDadosSalas
    {
        public List<Local> SalasdaEscola = new List<Local>()
        {
            new Locais.Local{Ocupada=true, Sala="Sala de Vídeo", NumeroSala=43, Id=1},
            new Locais.Local{Ocupada=false, Sala="Sala de Teatro", NumeroSala=52, Id=2},
            new Locais.Local{Ocupada=false, Sala="Sala de Apresentação", NumeroSala=12, Id=3}
        };
        public int SalasLiberadas()
        {
            return SalasdaEscola.OfType<Local>().Where(x => x.Ocupada == false).Count();
        }
        public int SalasOcupadas()
        {
            return SalasdaEscola.OfType<Local>().Where(x => x.Ocupada == true).Count();
        }
        public int SalasTotais()
        {
            return SalasdaEscola.OfType<Local>().Count();
        }
    }
}
