using webapi.worldskills.Context;
using webapi.worldskills.Domains;
using webapi.worldskills.Interfaces;

namespace webapi.worldskills.Repositories
{
    public class TiposUsuarioRepository : ITiposUsuario
    {
        private readonly RankingContext  _context;

        public TiposUsuarioRepository()
        {
            _context = new RankingContext();
        }

        public void Atualizar(int id, TiposUsuario tipoUsuario)
        {
            try
            {
                TiposUsuario tipoBuscado = _context.TiposUsuario.Find(id)!;

                if (tipoBuscado != null)
                {
                    tipoBuscado.Titulo = tipoUsuario.Titulo;
                }

                _context.TiposUsuario.Update(tipoBuscado!);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(TiposUsuario tipoUsuario)
        {
            try
            {
                _context.TiposUsuario.Add(tipoUsuario);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Deletar(int id)
        {
            try
            {
                TiposUsuario tipoBuscado = _context.TiposUsuario.Find(id)!;

                if (tipoBuscado != null)
                {
                    _context.TiposUsuario.Remove(tipoBuscado);
                }

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<TiposUsuario> Listar()
        {
            try
            {
                return _context.TiposUsuario.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
