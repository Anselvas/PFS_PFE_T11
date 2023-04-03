using Atividade1.Interfaces;

namespace Atividade1.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public string ?nome { get; set; }
        public Endereco ?endereco { get; set; }
        public int ?rendimento { get; set; }
        
        
        
        public abstract float PagarImposto(float rendimento);
       
    }
}