using System.Collections.Generic;
namespace Dio.Series.Inteface
{
    public interface IRepositorio<T>
    {
        List<T> List();

        T RetornarPorIdd(int id);

        void Inserir(T entidade);
        void Excluir(int id);
        void Atualizar(int id, T entidade);
        int ProximoId();
    }
}