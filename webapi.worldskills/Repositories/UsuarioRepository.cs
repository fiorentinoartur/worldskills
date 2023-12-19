using webapi.worldskills.Context;
using webapi.worldskills.Domains;
using webapi.worldskills.Interfaces;
using webapi.worldskills.Utils;

namespace webapi.worldskills.Repositories
{
    public class UsuarioRepository : IUsuario
    {
        private readonly RankingContext _context;

        public UsuarioRepository()
        {
            _context = new RankingContext();
        }

        public Usuario BuscarPorId(int id)
        {
            try
            {
                Usuario usuarioBuscado = _context.Usuario
                    .Select(u => new Usuario
                    {
                        IdUsuario = u.IdUsuario,
                        Nome = u.Nome,
                        Email = u.Email,
                        Senha = u.Senha,

                        TipoUsuario = new TiposUsuario
                        {
                            Titulo = u.TipoUsuario!.Titulo
                        }

                    }).FirstOrDefault(u => u.IdUsuario == id)!;

                if (usuarioBuscado != null)
                {
                    return usuarioBuscado;

                }
                return null!;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(Usuario usuario)
        {
            try
            {

                usuario.Senha = Criptografia.GerarHash(usuario.Senha!);


                _context.Usuario.Add(usuario);


                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }


        public Usuario BuscarPorEmailESenha(string email, string senha)
        {
            try
            {
                Usuario usuarioBuscado = _context.Usuario
                    .Select(u => new Usuario
                    {
                        IdUsuario = u.IdUsuario,
                        Nome = u.Nome,
                        Email = u.Email,
                        Senha = u.Senha,

                        TipoUsuario = new TiposUsuario
                        {
                            IdTipoUsuario = u.IdTipoUsuario,
                            Titulo = u.TipoUsuario!.Titulo
                        }
                    }).FirstOrDefault(u => u.Email == email)!;

                if (usuarioBuscado != null)
                {
                    bool confere = Criptografia.CompararHash(senha, usuarioBuscado.Senha!);

                    if (confere)
                    {
                        return usuarioBuscado;
                    }
                }
                return null!;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
