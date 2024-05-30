using TSS.QBuilder.Contracts;
using TSS.QBuilder.Entities.Models;

namespace TSS.QBuilder.Repository
{
    public class QuestionRepository : RepositoryBase<Question>, IQuestionRepository
    {
        public QuestionRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
            
        }
    }
}
