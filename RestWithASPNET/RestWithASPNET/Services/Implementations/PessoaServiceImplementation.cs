using RestWithASPNET.Model;

namespace RestWithASPNET.Services.Implementations
{
    public class PessoaServiceImplementation : IPessoaService
    {
        private volatile int count;

        public Pessoa Create(Pessoa pessoa)
        {
            return pessoa;
        }

        public Pessoa Delete(long id)
        {
            throw new NotImplementedException();
        }

        public List<Pessoa> FindAll()
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            
            for (int i = 0; i < 8; i++)
            {
                Pessoa pessoa = MockPerson(i);
                pessoas.Add(pessoa);
            }
            return pessoas;
        }

    

        public Pessoa FindByID(long id)
        {
            return new Pessoa
            {

                Id = 1,
                FirstName = "Gabriel",
                LastName = "Natali",
                Address = "Rua Carlos Mazer",
                Gender = "Male"


            };
        }

        public Pessoa Update(Pessoa pessoa)
        {
            return pessoa;
        }




        private Pessoa MockPerson(int i)
        {
            return new Pessoa
            {

                Id = IncrementAndGet(),
                FirstName = "Nome Inicial" + i,
                LastName = "Nome Final" + i,
                Address = "Algum Endereço" + i,
                Gender = "Male" + i


            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
