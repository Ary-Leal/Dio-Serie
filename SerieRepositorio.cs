using System;
using System.Collections.Generic;
using Dio.Serie.Interfaces;


namespace Dio.Serie
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> ListaSerie = new List<Serie>

        public void Atualiza (int id, Serie objeto)

              ListaSerie[id] = objeto;
                   
    }
      {
        public void Excluir (int id, )
           
        ListaSerie[id].Excluir();
    }
      {
        public void Insere ( Serie entidade)

            ListaSerie.Add{objeto} ;
        
    }
      {
        public List<Serie> Listar ()

           return ListaSerie;
    }
      {
        public int  ProximoId ()

           return ListaSerie.count;
        
    }
      {
        public int RetornaPorId (int id)

           return ListaSerie[id];
        
    }
}