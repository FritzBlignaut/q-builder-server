using TSS.QBuilder.Contracts;
using TSS.QBuilder.Service.Contracts;

namespace TSS.QBuilder.Service
{
    internal sealed class ControlTypeService : IControlTypeService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public ControlTypeService(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }
    }
}
