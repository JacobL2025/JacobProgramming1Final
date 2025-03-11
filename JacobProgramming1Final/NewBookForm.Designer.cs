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
            txtBookGenre = new TextBox();
            txtBookAuthor = new TextBox();
            txtBookName = new TextBox();
            label1 = new Label();
            lblBookGenre = new Label();
            lblBookName = new Label();
            lblBookAuthor = new Label();
            btnSave = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtBookGenre
            // 
            txtBookGenre.Location = new Point(205, 52);
            txtBookGenre.Name = "txtBookGenre";
            txtBookGenre.Size = new Size(534, 39);
            txtBookGenre.TabIndex = 0;
            // 
            // txtBookAuthor
            // 
            txtBookAuthor.Location = new Point(205, 168);
            txtBookAuthor.Name = "txtBookAuthor";
            txtBookAuthor.Size = new Size(534, 39);
            txtBookAuthor.TabIndex = 1;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(205, 112);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(534, 39);
            txtBookName.TabIndex = 2;
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
            // lblBookGenre
            // 
            lblBookGenre.AutoSize = true;
            lblBookGenre.Location = new Point(12, 59);
            lblBookGenre.Name = "lblBookGenre";
            lblBookGenre.Size = new Size(184, 32);
            lblBookGenre.TabIndex = 4;
            lblBookGenre.Text = "⚔️ Book Genre:";
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Location = new Point(12, 115);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(184, 32);
            lblBookName.TabIndex = 5;
            lblBookName.Text = "📖 Book Name:";
            // 
            // lblBookAuthor
            // 
            lblBookAuthor.AutoSize = true;
            lblBookAuthor.Location = new Point(12, 171);
            lblBookAuthor.Name = "lblBookAuthor";
            lblBookAuthor.Size = new Size(193, 32);
            lblBookAuthor.TabIndex = 6;
            lblBookAuthor.Text = "✍️ Book Author:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(610, 219);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(129, 46);
            btnSave.TabIndex = 7;
            btnSave.Text = "✅ Save Book";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
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
            Controls.Add(lblBookAuthor);
            Controls.Add(lblBookName);
            Controls.Add(lblBookGenre);
            Controls.Add(label1);
            Controls.Add(txtBookName);
            Controls.Add(txtBookAuthor);
            Controls.Add(txtBookGenre);
            ForeColor = SystemColors.Highlight;
            Name = "NewBookForm";
            Text = "📖 New Book Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBookGenre;
        private TextBox txtBookAuthor;
        private TextBox txtBookName;
        private Label label1;
        private Label lblBookGenre;
        private Label lblBookName;
        private Label lblBookAuthor;
        private Button btnSave;
        private Button btnClear;
    }
}