using RestWithASPNET.Model;

namespace RestWithASPNET.Services.Implementations
{
    public interface IPessoaService
    {
        Pessoa Create(Pessoa pessoa);
        Pessoa FindByID(long id);
        List<Pessoa> FindAll();
        Pessoa Delete(long id);
        Pessoa Update (Pessoa pessoa);


    }
}
