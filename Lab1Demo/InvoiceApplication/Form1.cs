using System;
using System.IO;
using System.Windows.Forms;
using InvoiceApplication.BusinessLogic;

namespace InvoiceApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            var path = pathTextBox.Text;
            var wholeText = File.ReadAllText(path);

            wholeText = wholeText.Replace(";", "\t");

            resultTextBox.Text = wholeText;
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            var path = pathTextBox.Text;
            var lines = File.ReadAllLines(path);

            var processor = new InvoiceProcessor();
            var entries = processor.GroupByCategory(lines);

            resultTextBox.Clear();
            resultTextBox.Text += "Category\tAmount\r\n";

            foreach (var item in entries)
            {
                resultTextBox.Text += $"{item.Key}\t{item.Value}{Environment.NewLine}";
            }
        }
    }
}
