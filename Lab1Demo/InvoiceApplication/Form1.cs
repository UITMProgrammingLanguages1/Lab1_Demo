using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

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

            var entries = new Dictionary<string, decimal>();

            for (int i = 1; i < lines.Length; i++)
            {
                var line = lines[i];

                var split = line.Split(";");

                var category = split[2];
                var price = decimal.Parse(split[1]);

                if (entries.ContainsKey(category))
                {
                    entries[category] += price;
                }
                else
                {
                    entries[category] = price;
                }
            }

            resultTextBox.Clear();
            resultTextBox.Text += "Category\tAmount\r\n";

            foreach (var item in entries)
            {
                resultTextBox.Text += $"{item.Key}\t{item.Value}{Environment.NewLine}";
            }

        }
    }
}
