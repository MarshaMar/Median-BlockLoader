using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BlockLoader.DataLayer
{
    public class RespondentRepository : IRespondentRepository
    {
        private const string RespondentElementName = "respondent";
        private const string ReachedBlockElementName = "reachedblock";
        private readonly XmlLoader _loader;
        private readonly string _filePath;

        public RespondentRepository(XmlLoader loader, string filePath)
        {
            _loader = loader;
            _filePath = filePath;
        }

        public IEnumerable<Respondent> LoadRespondents()
        {
            if (!File.Exists(_filePath))
            {
                throw new FileNotFoundException(_filePath);
            }

            var doc = LoadDocument(_filePath);
            if (doc?.Root == null)
            {
                throw new InvalidOperationException("Xml file is empty, or invalid.");
            }

            var respondentElements = doc.Root.Elements(RespondentElementName);

            foreach (var respondentElement in respondentElements)
            {
                var respondent = new Respondent
                {
                    Id = respondentElement.Attribute("id").Value,
                    ReachedBlocks = new List<string>()
                };

                foreach (var blockElement in respondentElement.Elements("reachedblocks").Elements(ReachedBlockElementName))
                {
                    respondent.ReachedBlocks.Add(blockElement.Attribute("code").Value);
                }

                yield return respondent;
            }
        }
        private XDocument LoadDocument(string filePath)
        {
            return _loader.Load(filePath);
        }
    }
}
