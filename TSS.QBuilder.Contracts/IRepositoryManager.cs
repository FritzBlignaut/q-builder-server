namespace TSS.QBuilder.Contracts
{
    public interface IRepositoryManager
    {
        IQuestionSetRepository? QuestionSet { get; }
        IQuestionRepository? Question { get; }
        IControlTypeRepository? ControlType { get; }
        void Save();
    }
}
