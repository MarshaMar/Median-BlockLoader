using BlockLoader.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockLoader.Tests
{
    internal class RespondentRepositoryFake : IRespondentRepository
    {
        private readonly IList<Respondent> _respondents;

        public RespondentRepositoryFake(IList<Respondent> respondents)
        {
            _respondents = respondents;
        }

        public IEnumerable<Respondent> LoadRespondents()
        {
            return _respondents;
        }
    }
}