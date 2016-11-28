using System.Linq;
using System.Web.Mvc;
using SetupWebApplication.Repositories.Interfaces;

namespace SetupWebApplication.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        // GET: Usuario
        public ActionResult Index()
        {
            var usuario = Mapper.RepositorieToModel.UsuarioRepositorieToViewModel(_usuarioRepository.GetById(1));
            var usuarios = Mapper.RepositorieToModel.UsuariosRepositorieToViewModels(_usuarioRepository.GetAll().ToList());
            return View(usuarios);
        }

        public ActionResult Create()
        {
            throw new System.NotImplementedException();
        }

        public ActionResult Edit(int id)
        {
            throw new System.NotImplementedException();
        }

        public ActionResult Details(int id)
        {
            throw new System.NotImplementedException();
        }

        public ActionResult Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}