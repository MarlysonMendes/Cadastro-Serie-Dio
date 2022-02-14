using Dio.Series.Inteface;

namespace Dio.Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSeries = new List<Serie>();
        public void Atualizar(int id, Serie objeto)
        {
            listaSeries[id] = objeto;
        }

        public void Excluir(int id)
        {
            listaSeries.RemoveAt(id);
        }

        public void Inserir(Serie objeto)
        {
            listaSeries.Add(objeto);
        }

        public List<Serie> List()
        {
            return listaSeries;
        }

        public int ProximoId()
        {
            return listaSeries.Count;
        }

        public Serie RetornarPorIdd(int id)
        {
            return listaSeries[id];
        }
    }

}