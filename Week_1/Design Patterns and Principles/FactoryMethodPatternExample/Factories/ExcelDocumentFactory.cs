using Documents;

namespace Factories
{
    public class ExcelDocumentFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new ExcelDocument();
        }
    }
}
