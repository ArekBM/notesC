using System.Data;

namespace notes
{
    public partial class Form1 : Form
    {
        DataTable notes = new DataTable();

        bool editing = false;

        public Form1()
        {
            InitializeComponent();
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");

            previousNotes.DataSource = notes;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Title.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            Note.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[previousNotes.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Title.Text = "";
            Note.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                notes.Rows[previousNotes.CurrentCell.RowIndex]["Title"] = Title.Text;
                notes.Rows[previousNotes.CurrentCell.RowIndex]["Note"] = Note.Text;
            }
            else
            {
                notes.Rows.Add(Title.Text, Note.Text);
            }
            Title.Text = "";
            Note.Text = "";
            editing = false;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");

            previousNotes.DataSource = notes;
        }

        private void previousNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Title.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            Note.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }
    }
}
