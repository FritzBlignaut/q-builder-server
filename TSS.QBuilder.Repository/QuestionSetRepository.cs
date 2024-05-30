﻿using TSS.QBuilder.Contracts;
using TSS.QBuilder.Entities.Models;

namespace TSS.QBuilder.Repository
{
    public class QuestionSetRepository : RepositoryBase<QuestionSet>, IQuestionSetRepository
    {
        public QuestionSetRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
            
        }
    }
}
