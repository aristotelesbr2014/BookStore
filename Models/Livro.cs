using System;
using System.Collections.Generic;

namespace BookStore.Models {
    public class Livro {
        public Livro () {
            this.Autores = new List<Autor> ();
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string ISBN { get; set; }
        public DateTime DataLancamento { get; set; }

        public int CategoriaID { get; set; }
        public Categoria Categoia { get; set; }

        public ICollection<Autor> Autores { get; set; }
    }
}
