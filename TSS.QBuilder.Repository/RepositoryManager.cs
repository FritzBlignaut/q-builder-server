using TSS.QBuilder.Contracts;

namespace TSS.QBuilder.Repository
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<IQuestionSetRepository?> _questionSetRepository;

        private readonly Lazy<IQuestionRepository?> _questionRepository;

        private readonly Lazy<IControlTypeRepository?> _qontrolTypeRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _questionSetRepository = new Lazy<IQuestionSetRepository?>(() => new QuestionSetRepository(_repositoryContext));
            _questionRepository = new Lazy<IQuestionRepository?>(() => new QuestionRepository(_repositoryContext));
            _qontrolTypeRepository = new Lazy<IControlTypeRepository?>(() => new ControlTypeRepository(_repositoryContext));
        }

        public IQuestionSetRepository? QuestionSet => _questionSetRepository.Value;
        public IQuestionRepository? Question => _questionRepository.Value;
        public IControlTypeRepository? ControlType => _qontrolTypeRepository.Value;

        public void Save() => _repositoryContext.SaveChanges();
    }
}
