using TSS.QBuilder.Contracts;
using TSS.QBuilder.Entities.Models;
using TSS.QBuilder.Service.Contracts;

namespace TSS.QBuilder.Service
{
    internal sealed class QuestionSetService : IQuestionSetService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public QuestionSetService(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public IEnumerable<QuestionSet> GetAllQuestionSets(bool trackChanges)
        {
            try
            {
                var questionSets = _repository.QuestionSet?.GetAllQuestionSets(trackChanges)?.ToList() ?? [];
                return questionSets;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(QuestionSetService)} GetAllQuestionSets: {ex}");
                throw;
            }
        }
    }
}
