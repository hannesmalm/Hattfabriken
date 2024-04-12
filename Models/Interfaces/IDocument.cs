using QuestPDF.Infrastructure;

namespace Hattfabriken.Models.Interfaces
{
    public interface IDocument
    {
        DocumentMetadata GetMetadata();
        DocumentSettings GetSettings();
        void Compose(IDocumentContainer container);
    }
}
