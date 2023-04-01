using Atividade1.Interfaces;

namespace Atividade1.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {

        public string ?cpf { get; set; }
        public  string ?dataNascimento  { get; set; }
        
        
        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        /*
         public bool validarDataNascimento(string dataNasc)
        {
            DateTime dataConvertida; //verificar se a string está em formato valido

            if (DateTime.TryParse(dataNasc, out dataConvertida)){ //try parse  tenta converter e coloca na saída
                Console.WriteLine($"{dataConvertida}");    
                 DateTime datatual = DateTime.Today;
            double anos = (datatual - dataConvertida).TotalDays / 365; // TotalDays converte para dias
            // Console.WriteLine($"{anos}");        
            {
                
            }

           
            if(anos >= 18){
                return true;
            }
            return false; // não precisa de else pq caso seja verdadeiro o primeiro return ja conclui a sentença
        }
        */

        public bool validarDataNascimento(string dataNasc)
        {
            DateTime dataConvertida; //verificar se a string está em formato valido

            if (DateTime.TryParse(dataNasc, out dataConvertida)){ //try parse  tenta converter e coloca na saída
                //Console.WriteLine($"{dataConvertida}"); 

                 DateTime datatual = DateTime.Today;
            double anos = (datatual - dataConvertida).TotalDays / 365; // TotalDays converte para dias
            // Console.WriteLine($"{anos}");   

             if(anos >= 18){
                return true;
            }
            return false; // não precisa de else pq caso seja verdadeiro o primeiro return ja conclui a sentença     
                  
            }
           return false;
        }
    }
}