using CargaDescarga;

namespace Scm.Data.Repositories
{
    public class RetencionRepository : BaseRepository<Retencion>
    {
        public RetencionRepository(ScmContext context) : base(context)
        {
            
        }
    }
}