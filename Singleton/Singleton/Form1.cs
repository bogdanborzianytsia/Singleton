using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singleton
{
    public partial class Form1 : Form
    {
        private DocumentRepository _documentRepository;
        public Form1()
        {
            InitializeComponent();
            _documentRepository = DocumentRepository.Instance;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var repo = DocumentRepository.Instance;
            var outputTextbox = new TextBox();

            var doc1 = new Document { Id = 1, Title = textBox1.Text, Content = textBox2.Text };
            repo.SaveDocument(doc1, outputTextbox);
            var savedDoc1 = repo.GetDocumentById(1, outputTextbox);
            MessageBox.Show(outputTextbox.Text);
        }
    }
}
