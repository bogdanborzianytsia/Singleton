using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    using System;
    using System.Windows.Forms;

    public sealed class DocumentRepository
    {
        private static readonly Lazy<DocumentRepository> lazy = new Lazy<DocumentRepository>(() => new DocumentRepository());

        public static DocumentRepository Instance { get { return lazy.Value; } }

        private DocumentRepository() { }

        public void SaveDocument(Document doc, TextBox outputTextbox)
        {
            // зберігаємо документ у репозиторії
            string message = $"Збережено документ з id {doc.Id} у репозиторії.";
            outputTextbox.AppendText(message + Environment.NewLine);
        }

        public Document GetDocumentById(int id, TextBox outputTextbox)
        {
            // отримуємо документ з репозиторію за id
            string message = $"Отримано документ з id {id} з репозиторію.";
            outputTextbox.AppendText(message + Environment.NewLine);
            return new Document { Id = id, Title = $"Документ #{id}", Content = $"Це текст документа #{id}" };
        }
    }

    public class Document
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
