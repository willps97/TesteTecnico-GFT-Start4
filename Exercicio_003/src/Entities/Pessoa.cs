using System;


namespace Exercicio_003.src.Entities
{
    class Pessoa
    {
        public string NomePessoa { get; set; }
        public int IdadePessoa { get; set; }
        public Cachorro Pet { get; set; }

        public Pessoa()
        {
            
        }

        public override string ToString()
        {
            return NomePessoa + ", dono do " + Pet;
        }
    }
}
