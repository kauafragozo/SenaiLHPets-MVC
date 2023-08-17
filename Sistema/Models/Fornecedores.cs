namespace LHPets.models
{
    public class Fornecedores{

        public int Id {get; set;}
        public string? Nome {get; set;}
        public string? Cnpj {get;set;}
        public string? Email {get; set;}
        
        public Fornecedores(int id, string nome, string cnpj, string email){
            this.Id=id;
            this.Nome= nome;
            this.Cnpj= cnpj;
            this.Email= email;

        }
    }
}