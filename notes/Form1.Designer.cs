namespace notes
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
            Title = new TextBox();
            Note = new TextBox();
            label1 = new Label();
            label2 = new Label();
            previousNotes = new DataGridView();
            btnLoad = new Button();
            btnDelete = new Button();
            btnNew = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)previousNotes).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Location = new Point(386, 47);
            Title.Name = "Title";
            Title.Size = new Size(375, 23);
            Title.TabIndex = 0;
            // 
            // Note
            // 
            Note.Location = new Point(386, 103);
            Note.Multiline = true;
            Note.Name = "Note";
            Note.Size = new Size(375, 343);
            Note.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(386, 14);
            label1.Name = "label1";
            label1.Size = new Size(56, 30);
            label1.TabIndex = 2;
            label1.Text = "Title";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(386, 70);
            label2.Name = "label2";
            label2.Size = new Size(68, 30);
            label2.TabIndex = 3;
            label2.Text = "Note:";
            // 
            // previousNotes
            // 
            previousNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            previousNotes.Location = new Point(11, 12);
            previousNotes.Name = "previousNotes";
            previousNotes.Size = new Size(369, 366);
            previousNotes.TabIndex = 4;
            previousNotes.CellDoubleClick += previousNotes_CellDoubleClick;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoad.Location = new Point(11, 384);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(183, 28);
            btnLoad.TabIndex = 5;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(200, 384);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(180, 28);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(12, 418);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(183, 28);
            btnNew.TabIndex = 7;
            btnNew.Text = "New Note";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(200, 418);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(180, 28);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(btnDelete);
            Controls.Add(btnLoad);
            Controls.Add(previousNotes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Note);
            Controls.Add(Title);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)previousNotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Title;
        private TextBox Note;
        private Label label1;
        private Label label2;
        private DataGridView previousNotes;
        private Button btnLoad;
        private Button btnDelete;
        private Button btnNew;
        private Button btnSave;
    }
}
