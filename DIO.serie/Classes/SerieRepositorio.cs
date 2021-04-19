using System;
using System.Collections.Generic;
using DIO.serie.Interfaces;



namespace DIO.serie
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
          private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id]=objeto;
        }

        public void Exclui(int id)
        {
            //mudança de indice
            listaSerie[id].Excluir();
            // implementar e-mail
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}