using Hub.Models;
using Hub.Repositorio;

namespace Hub.Views
{
    public class CadastroRepositorio : ICadastroRepositorio
    {
        private readonly ApplicationContext _applicationContext;

        public CadastroRepositorio(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public CadastroUsuario Adicionar(CadastroUsuario cadastrouUsuario)
        {
            _applicationContext.CadastroUsuario.Add(cadastrouUsuario);
            _applicationContext.SaveChanges();

            return cadastrouUsuario;
        }
    }
}
