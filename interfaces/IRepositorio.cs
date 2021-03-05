using System.Collections.Generic;

namespace Dio.Serie.Interfaces


{
    public interface IRepositorio<T>
    {
        List<T> Lista();

        T RetornaPorId(int id);

        void  Insert (T entidade);

        void  Excluir (int id);

        void 
         (int id, T entidade);

        int ProximoId();  
    }
}