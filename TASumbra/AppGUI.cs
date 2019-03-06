using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace TASumbra
{
    public enum MovieKeyType
    {
        Null, Up, Down
    }
    public partial class AppGUI : Form
    {
        bool runStarted = false;

        DataTable dt;

        public AppGUI()
        {
            InitializeComponent();
        }
        private void InitializeDataTable()
        {
            dt = new DataTable("TASumbra");
            //dt.RowChanged += DataTable_TableNewRow;
            dt.RowChanged += DataTable_RowChanged;
            dt.Columns.Add("FrameNumber", Type.GetType("System.String"));
            dt.Columns.Add("Shift");
            dt.Columns.Add("Forwards");
            dt.Columns.Add("Backwards");
            dt.Columns.Add("Left");
            dt.Columns.Add("Right");
            dt.Columns.Add("LMB");
            dt.Columns.Add("RMB");
            dt.Columns.Add("MouseX", Type.GetType("System.Int32"));
            dt.Columns.Add("MouseY", Type.GetType("System.Int32"));
            for (int i = 0; i < 100; i++)
            {
                dt.Rows.Add();
            }
        }

        protected void DataTable_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            GoToRowNumeric.Maximum = dt.Rows.Count;
            if (e.Action == DataRowAction.Add)
            {
                DataTable_TableNewRow(sender, e.Row);
            }
        }

        private void ApplyDataGridViewStyle()
        {
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.DataPropertyName = col.Name;
            }
            dataGridView1.Columns["FrameNumber"].HeaderCell.Value = "Frame n°";
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void App_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;

            InitializeDataTable();
            dataGridView1.DataSource = dt;
            ApplyDataGridViewStyle();
            tabControl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left;
            dataGridView1.TopLeftHeaderCell.Value = "Frame n°";
            //dataGridView1.RowHeadersVisible = false;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            //dataGridView1.RowsAdded += DataGridView1_RowsAdded;
            //DataGridView1.DefaultValuesNeeded += dataGridView1_DefaultValuesNeeded;
            //DataGridView1_RowsAdded(null, null);
            //dataGridView1.Rows.Add();

        }

        private void DataTable_TableNewRow(object sender, DataRow row)
        {
            CheckValueOrAddDefault(row, "Shift", "/");
            CheckValueOrAddDefault(row, "Forwards", "/");
            CheckValueOrAddDefault(row, "Backwards", "/");
            CheckValueOrAddDefault(row, "Left", "/");
            CheckValueOrAddDefault(row, "Right", "/");
            /*if (row["MouseX"].GetType() == typeof(DBNull))
                row["MouseX"] = "/";
            if (row["MouseY"].GetType() == typeof(DBNull))
                row["MouseY"] = "/";*/
            if (row["LMB"].GetType() == typeof(DBNull))
                row["LMB"] = "/";

            if (row["FrameNumber"].GetType() == typeof(DBNull))
                row["FrameNumber"] = dt.Rows.IndexOf(row) + 1;

            //Console.WriteLine("Hello" + dt.Rows.IndexOf(row));
            //cell.ValueType = typeof(int);
        }

        private void CheckValueOrAddDefault<T>(DataRow row, string columnName, T defaultVal)
        {
            if (row[columnName].GetType() == typeof(DBNull))
                row[columnName] = defaultVal;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Filter = "Penumbra.exe|Penumbra.exe",
                FilterIndex = 1,
                Multiselect = false,
                Title = "Select the Penumbra executable in your 'Steam/steamapps/common/Penumbra Black Plague' folder"
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                PenumbraPathTextBox.Text = fileDialog.FileName;
            }
        }

        private void Settings_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TimeText_Click(object sender, EventArgs e)
        {

        }

        private void GetTime_Click(object sender, EventArgs e)
        {
            if (!runStarted)
            {
                RunLauncher runLauncher = new RunLauncher(PenumbraPathTextBox.Text, penumbraTimeText, framesLabel, fpsLabel, performanceText);
                if (runLauncher.Start())
                {
                    runStarted = true;
                }
                else
                {
                    MessageBox.Show("Penumbra process not found, make sure the game is launched", "FeelsBadMan");
                }

            }
            //penumbraTimeText.Text = MemoryReader.ReadPenumbraMemory().ToString();
        }

        private void GameTimeStaticLabel(object sender, EventArgs e)
        {

        }

        private void PerformanceText_Click(object sender, EventArgs e)
        {

        }


        private void NewMovie_Click(object sender, EventArgs e)
        {

        }

        private void SaveMovie_Click(object sender, EventArgs e)
        {
            dt.WriteXml("movies/movie.xml");
        }

        private void LoadMovie_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt.ReadXml("movies/movie.xml");
        }

        private void GoToRow_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = dataGridView1.Rows[(int)GoToRowNumeric.Value-1].Cells[0];
        }

        private void ChangeNumberOfFramesButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(NumberOfFramesNumeric.Value);
            Console.WriteLine(dt.Rows.Count);
            int numericValue = (int)NumberOfFramesNumeric.Value;
            if (numericValue > dt.Rows.Count)
            {
                int rowsToAdd = numericValue - dt.Rows.Count;
                for (int i = 0; i < rowsToAdd; i++)
                {
                    dt.Rows.Add();
                }
            }
            while(numericValue < dt.Rows.Count)
            {
                dt.Rows.RemoveAt(dt.Rows.Count - 1);
            }
        }
    }
}
