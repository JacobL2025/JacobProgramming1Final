namespace JacobProgramming1Final
{
    partial class NewBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            txtBookId = new Label();
            txtBookName = new Label();
            txtBookAuthor = new Label();
            btnSave = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(205, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(534, 39);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(205, 168);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(534, 39);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(205, 112);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(534, 39);
            textBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(268, 32);
            label1.TabIndex = 3;
            label1.Text = "Add an Awesome Book!";
            // 
            // txtBookId
            // 
            txtBookId.AutoSize = true;
            txtBookId.Location = new Point(12, 59);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(140, 32);
            txtBookId.TabIndex = 4;
            txtBookId.Text = "📕 Book Id:";
            // 
            // txtBookName
            // 
            txtBookName.AutoSize = true;
            txtBookName.Location = new Point(12, 115);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(184, 32);
            txtBookName.TabIndex = 5;
            txtBookName.Text = "📖 Book Name:";
            // 
            // txtBookAuthor
            // 
            txtBookAuthor.AutoSize = true;
            txtBookAuthor.Location = new Point(12, 171);
            txtBookAuthor.Name = "txtBookAuthor";
            txtBookAuthor.Size = new Size(193, 32);
            txtBookAuthor.TabIndex = 6;
            txtBookAuthor.Text = "✍️ Book Author:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(610, 219);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(129, 46);
            btnSave.TabIndex = 7;
            btnSave.Text = "✅ Save Book";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(20, 219);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(119, 46);
            btnClear.TabIndex = 8;
            btnClear.Text = "\U0001f9f9 Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // NewBookForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(751, 277);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(txtBookAuthor);
            Controls.Add(txtBookName);
            Controls.Add(txtBookId);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            ForeColor = SystemColors.Highlight;
            Name = "NewBookForm";
            Text = "📖 New Book Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label txtBookId;
        private Label txtBookName;
        private Label txtBookAuthor;
        private Button btnSave;
        private Button btnClear;
    }
}