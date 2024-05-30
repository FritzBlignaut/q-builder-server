using TSS.QBuilder.Contracts;
using TSS.QBuilder.Entities.Models;

namespace TSS.QBuilder.Repository
{
    public class ControlTypeRepository : RepositoryBase<ControlType>, IControlTypeRepository
    {
        public ControlTypeRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
            
        }
    }
}
