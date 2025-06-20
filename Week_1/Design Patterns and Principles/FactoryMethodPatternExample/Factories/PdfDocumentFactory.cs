using Documents;

namespace Factories
{
    public class PdfDocumentFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new PdfDocument();
        }
    }
}
