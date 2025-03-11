
namespace InvoiceApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pathLabel = new System.Windows.Forms.Label();
            pathTextBox = new System.Windows.Forms.TextBox();
            readButton = new System.Windows.Forms.Button();
            resultTextBox = new System.Windows.Forms.TextBox();
            categoryButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // pathLabel
            // 
            pathLabel.AutoSize = true;
            pathLabel.Location = new System.Drawing.Point(20, 27);
            pathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pathLabel.Name = "pathLabel";
            pathLabel.Size = new System.Drawing.Size(50, 25);
            pathLabel.TabIndex = 0;
            pathLabel.Text = "Path:";
            // 
            // pathTextBox
            // 
            pathTextBox.Location = new System.Drawing.Point(83, 22);
            pathTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pathTextBox.Name = "pathTextBox";
            pathTextBox.Size = new System.Drawing.Size(1041, 31);
            pathTextBox.TabIndex = 1;
            pathTextBox.Text = "Invoices.txt";
            // 
            // readButton
            // 
            readButton.Location = new System.Drawing.Point(20, 88);
            readButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            readButton.Name = "readButton";
            readButton.Size = new System.Drawing.Size(107, 38);
            readButton.TabIndex = 2;
            readButton.Text = "Read";
            readButton.UseVisualStyleBackColor = true;
            readButton.Click += readButton_Click;
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new System.Drawing.Point(20, 157);
            resultTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new System.Drawing.Size(1104, 571);
            resultTextBox.TabIndex = 3;
            // 
            // categoryButton
            // 
            categoryButton.Location = new System.Drawing.Point(137, 88);
            categoryButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            categoryButton.Name = "categoryButton";
            categoryButton.Size = new System.Drawing.Size(107, 38);
            categoryButton.TabIndex = 4;
            categoryButton.Text = "Category";
            categoryButton.UseVisualStyleBackColor = true;
            categoryButton.Click += categoryButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1143, 750);
            Controls.Add(categoryButton);
            Controls.Add(resultTextBox);
            Controls.Add(readButton);
            Controls.Add(pathTextBox);
            Controls.Add(pathLabel);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Invoice Application";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button categoryButton;
    }
}

