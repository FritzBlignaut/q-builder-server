using TSS.QBuilder.Contracts;
using TSS.QBuilder.Service.Contracts;

namespace TSS.QBuilder.Service
{
    internal sealed class QuestionService : IQuestionService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public QuestionService(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }
    }
}
