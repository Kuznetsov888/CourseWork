using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PersonnelManager
{
    public partial class
        PersonnelManager : Form
    {
        // Number of rows in Table
        const int DataColumnsCount = 4;

        private bool EditEnabled = false;

        public PersonnelManager()
        {
            InitializeComponent();
            ChangeDocumentEditEnabled(false);
        }
        private void ToolStripButtonNew_Click(object sender, EventArgs e)
        {
            // Clearing dataGridViewData for new data
            dataGridViewData.Rows.Clear();
            ChangeDocumentEditEnabled(true);
        }

        private void ToolStripButtonOpen_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            // Showing FileOpenDialog
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of specified file
                    filePath = openFileDialog.FileName;

                    // Clearing DataGridView
                    dataGridViewData.Rows.Clear();

                    // Read the contents of the file into a stream
                    Stream fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        // Filling DataGridView string by string
                        while (!reader.EndOfStream)
                        {

                            // Exception handling
                            try
                            {
                                CreateRowFromString(reader.ReadLine());
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                        }

                        // Removing StreamReader
                        reader.Close();
                    }
                }
            }

            // Making DataGridView Accessible for Edit.
            dataGridViewData.Enabled = true;
            // Set  dataGridWieData as ReadOnly
            ChangeDocumentEditEnabled(false);
        }

        private void ToolStripButtonSave_Click(object sender, EventArgs e)
        {
            // Showing SaveFileDialog
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Read the contents of the file into a stream
                    Stream fileStream;

                    if ((fileStream = saveFileDialog.OpenFile()) != null)
                    {
                        // StreamWriter writing
                        using (StreamWriter writer = new StreamWriter(fileStream))
                        {
                            foreach (DataGridViewRow row in dataGridViewData.Rows)
                            {
                                // If there is no data in the first column - then don't use this line
                                if (row.Cells[0].Value == null)
                                    continue;
                                string tmp_str = "";

                                // Fill line cell by cell to one string.
                                for (int i = 0; i < row.Cells.Count; ++i)
                                {
                                    tmp_str += row.Cells[i].Value;
                                    if (i != row.Cells.Count - 1)
                                        tmp_str += ",";
                                }
                                // Write string to file.
                                writer.WriteLine(tmp_str);
                            }
                            // Removing StreamWriter
                            writer.Close();
                        }

                        fileStream.Close();
                    }
                }
            }
        }
        // Search by input word
        private void ToolStripButtonSearch_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewData.Rows)
            {
                bool found = false;
                foreach (DataGridViewTextBoxCell cell in row.Cells)
                {
                    // If cell is empty - skip search in it.
                    if (cell.Value == null)
                        continue;
                    // If cell has searched text - set flag that this row has needed data.
                    if (cell.Value.ToString().Contains(ToolStripTextBox1.Text))
                        found = true;
                }
                // If row doesn't have needed data - hide it.
                if (row.Cells[0].Value != null)
                    row.Visible = found;
            }
        }
        // Reading data from file to DataGridView
        private void CreateRowFromString(string data)
        {
            // Creating new row based on first row of the DataGridView.
            DataGridViewRow row = (DataGridViewRow)dataGridViewData.Rows[0].Clone();
            row.DefaultCellStyle.BackColor = Color.White;

            // Split parsed string into words.
            string[] words = data.Split(new Char[] { ',' });

            if (words == null)
            {
                throw new ArgumentNullException("No correct data for Table");
            }
            if (DataColumnsCount < words.Count())
            {
                throw new ArgumentOutOfRangeException("More fields than supported by table");
            }
            // First two words are used as Department and Position fields.
            row.Cells[0].Value = words[0];
            row.Cells[1].Value = words[1];
            
            // Making Director rows LightGreen for easier search.
            if (words[1] == "Director")
            {
                row.DefaultCellStyle.BackColor = Color.LightGreen;
            }
            // If Position is epty - set Name <Vacansy>.
            // Making Vacancy rows LightPink for easier search.
            if ((words[2].Length != 0) && (words[2] != "<Vacancy>"))
            {
                row.Cells[2].Value = words[2];
                row.Cells[3].Value = words[3];
            }
            else
            {
                row.Cells[2].Value = "<Vacancy>";
                row.Cells[3].Value = "";
                row.DefaultCellStyle.BackColor = Color.LightPink;
            }
            // Add parsed row to the DataGridView.
            dataGridViewData.Rows.Add(row);
           
        }

        private void ToolStripButtonBack_Click(object sender, EventArgs e)
        {
            // Making all rows visible again after search.
            foreach (DataGridViewRow row in dataGridViewData.Rows)
            {
                row.Visible = true;
            }
        }

        private void ToolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (EditEnabled == false)
                return;
            // Deleting selected row.
            if (dataGridViewData.SelectedRows.Count != 0)
            {
                dataGridViewData.Rows.RemoveAt(dataGridViewData.SelectedRows[0].Index);
            }
            else
            {// Deleting selected cell.
                if (dataGridViewData.SelectedCells.Count != 0)
                {
                    foreach (DataGridViewTextBoxCell cell in dataGridViewData.SelectedCells)
                        cell.Value = "";
                }
            }
        }
        // Set Data as ReadOnly or ReadAndWrite
        private void ToolStripButtonEdit_Click(object sender, EventArgs e)
        {
            ChangeDocumentEditEnabled(!EditEnabled);
        }

        private void ChangeDocumentEditEnabled(bool enable)
        {
            if (enable)
            {
                dataGridViewData.ReadOnly = false;
                ToolStripButtonEdit.BackColor = Color.Green;
                EditEnabled = true;
                ToolStripButtonDelete.Enabled = true;
            } else
            {
                dataGridViewData.ReadOnly = true;
                ToolStripButtonEdit.BackColor = Color.Red;
                EditEnabled = false;
                ToolStripButtonDelete.Enabled = false;
            }
        }
    }
}

