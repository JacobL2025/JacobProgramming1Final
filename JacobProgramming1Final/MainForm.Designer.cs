namespace JacobProgramming1Final
{
    partial class MainForm
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
            dgvLibrary = new DataGridView();
            BookId = new DataGridViewTextBoxColumn();
            BookName = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            btnAddBook = new Button();
            label1 = new Label();
            btnToast = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLibrary).BeginInit();
            SuspendLayout();
            // 
            // dgvLibrary
            // 
            dgvLibrary.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvLibrary.BackgroundColor = SystemColors.Info;
            dgvLibrary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibrary.Columns.AddRange(new DataGridViewColumn[] { BookId, BookName, Column1 });
            dgvLibrary.GridColor = Color.FromArgb(255, 128, 0);
            dgvLibrary.Location = new Point(12, 82);
            dgvLibrary.Name = "dgvLibrary";
            dgvLibrary.RowHeadersWidth = 82;
            dgvLibrary.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLibrary.Size = new Size(698, 628);
            dgvLibrary.TabIndex = 0;
            // 
            // BookId
            // 
            BookId.HeaderText = "BookId";
            BookId.MinimumWidth = 10;
            BookId.Name = "BookId";
            BookId.Width = 200;
            // 
            // BookName
            // 
            BookName.HeaderText = "BookName";
            BookName.MinimumWidth = 10;
            BookName.Name = "BookName";
            BookName.Width = 200;
            // 
            // Column1
            // 
            Column1.HeaderText = "BookAuthor";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // btnAddBook
            // 
            btnAddBook.BackColor = SystemColors.Info;
            btnAddBook.ForeColor = SystemColors.MenuHighlight;
            btnAddBook.Location = new Point(723, 82);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(154, 63);
            btnAddBook.TabIndex = 1;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 19.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(687, 71);
            label1.TabIndex = 2;
            label1.Text = "Jacob's Very Cool Library";
            // 
            // btnToast
            // 
            btnToast.BackColor = SystemColors.Info;
            btnToast.ForeColor = SystemColors.MenuHighlight;
            btnToast.Location = new Point(727, 151);
            btnToast.Name = "btnToast";
            btnToast.Size = new Size(150, 46);
            btnToast.TabIndex = 3;
            btnToast.Text = "Toast";
            btnToast.UseVisualStyleBackColor = false;
            btnToast.Click += btnToast_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(888, 724);
            Controls.Add(btnToast);
            Controls.Add(label1);
            Controls.Add(btnAddBook);
            Controls.Add(dgvLibrary);
            Name = "MainForm";
            Text = "The Very Cool Library";
            ((System.ComponentModel.ISupportInitialize)dgvLibrary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLibrary;
        private DataGridViewTextBoxColumn BookId;
        private DataGridViewTextBoxColumn BookName;
        private DataGridViewTextBoxColumn Column1;
        private Button btnAddBook;
        private Label label1;
        private Button btnToast;
    }
}
