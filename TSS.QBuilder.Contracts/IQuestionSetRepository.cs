using TSS.QBuilder.Entities.Models;

namespace TSS.QBuilder.Contracts
{
    public interface IQuestionSetRepository
    {
        IEnumerable<QuestionSet> GetAllQuestionSets(bool trackChanges);
    }
}
