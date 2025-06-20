using System;

namespace Documents
{
    public class PdfDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening a PDF document.");
        }
    }
}
