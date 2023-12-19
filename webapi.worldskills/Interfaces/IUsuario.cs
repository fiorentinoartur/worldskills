using webapi.worldskills.Domains;

namespace webapi.worldskills.Interfaces
{
    public interface IUsuario
    {
        void Cadastrar(Usuario usuario);

        Usuario BuscarPorId(int id);

        Usuario BuscarPorEmailESenha(string email, string senha);
    }
}
