using TSS.QBuilder.Contracts;
using TSS.QBuilder.Service.Contracts;

namespace TSS.QBuilder.Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IQuestionSetService?> _questionSetService;
        private readonly Lazy<IQuestionService?> _questionService;
        private readonly Lazy<IControlTypeService?> _controlTypeService;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger)
        {
            _questionSetService = new Lazy<IQuestionSetService?>(() => new QuestionSetService(repositoryManager, logger));
            _questionService = new Lazy<IQuestionService?>(() => new QuestionService(repositoryManager, logger));
            _controlTypeService = new Lazy<IControlTypeService?>(() => new ControlTypeService(repositoryManager, logger));
        }

        public IQuestionSetService QuestionSetService => _questionSetService.Value ?? throw new NullReferenceException(nameof(QuestionSetService));
        public IQuestionService QuestionService => _questionService.Value ?? throw new NullReferenceException(nameof(QuestionService));
        public IControlTypeService ControlTypeService => _controlTypeService.Value ?? throw new NullReferenceException(nameof(ControlTypeService));
    }
}
