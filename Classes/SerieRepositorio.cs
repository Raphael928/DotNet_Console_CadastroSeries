using DIO.Series.Interfaces;

namespace DIO.Series.Classes
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> lListaSerie = new List<Serie>();
        public void Atualiza(int pId, Serie pSerie)
        {
            lListaSerie[pId] = pSerie;
        }

        public void Exclui(int pId)
        {
            lListaSerie[pId].Excluir();
        }

        public void Insere(Serie pSerie)
        {
            lListaSerie.Add(pSerie);
        }

        public List<Serie> Lista()
        {
            return lListaSerie;
        }

        public int ProximoId()
        {
            return lListaSerie.Count;
        }

        public Serie RetornaPorId(int pId)
        {
            return lListaSerie[pId];
        }
    }
}