namespace TSS.QBuilder.Service.Contracts
{
    public interface IServiceManager
    {
        IQuestionSetService QuestionSetService { get; }
        IQuestionService QuestionService { get; }
        IControlTypeService ControlTypeService { get; }
    }
}
