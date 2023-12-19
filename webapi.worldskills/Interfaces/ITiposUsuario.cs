using webapi.worldskills.Domains;

namespace webapi.worldskills.Interfaces
{
    public interface ITiposUsuario
    {
        void Cadastrar(TiposUsuario tipoUsuario);
        void Deletar(int id);
        List<TiposUsuario> Listar();
        void Atualizar(int id, TiposUsuario tipoUsuario);
    }
}
