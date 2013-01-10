using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastro.Model;

namespace Cadastro.DAL.EntityFrameworkProvider
{
    public sealed class Persistencia
    {
        private static Persistencia _instance = null;

        private ModelContext _context = null;
        private IDAL<Fisica> _fisicaDao = null;

        Persistencia()
        {
            _context = new ModelContext("CadastroDb");

            _context.Configuration.LazyLoadingEnabled = true;
            _context.Configuration.ProxyCreationEnabled = true;

            _fisicaDao = new FisicaDao(_context);
        }

        public static Persistencia GetInstance()
        {
            if (_instance == null)
                _instance = new Persistencia();

            return _instance;
        }


        public IDAL<Fisica> FisicaDao { get { return _fisicaDao; } }
    }
}