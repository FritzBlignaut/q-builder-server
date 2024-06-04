using TSS.QBuilder.Entities.Models;

namespace TSS.QBuilder.Service.Contracts
{
    public interface IQuestionSetService
    {
        IEnumerable<QuestionSet> GetAllQuestionSets(bool trackChanges);
    }
}
