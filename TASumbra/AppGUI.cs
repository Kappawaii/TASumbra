using System;
using System.Data;
using System.Drawing;
using System.IO;
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
            dt.Columns.Add("Run");
            dt.Columns.Add("Forwards");
            dt.Columns.Add("Backwards");
            dt.Columns.Add("Left");
            dt.Columns.Add("Right");
            dt.Columns.Add("LMB");
            dt.Columns.Add("RMB");
            dt.Columns.Add("Crouch");
            dt.Columns.Add("Inventory");
            dt.Columns.Add("MouseX", Type.GetType("System.Int32"));
            dt.Columns.Add("MouseY", Type.GetType("System.Int32"));
            try
            {
                LoadMovie_Click(null, null);
            }
            catch (FileNotFoundException)
            {
                for (int i = 0; i < 600; i++)
                {
                    dt.Rows.Add();
                }
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
            dataGridView1.CellEndEdit += OnCellEndEdit;
            dataGridView1.CellFormatting += CellFormatting;
            dataGridView1.CellBeginEdit += OnCellEnterEdit;
            //TODO: add color between Down -> Up and for mouse input
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column is DataGridViewComboBoxColumn)
                {
                    ((DataGridViewComboBoxColumn)column).DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
                }
            }
        }
        private void CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            OnCellEndEdit(sender, new DataGridViewCellEventArgs(e.ColumnIndex, e.RowIndex));
        }
        private void OnCellEnterEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            DataGridViewCellStyle cellColor = cell.Style;
            if (cell.Value is string)
            {
                cellColor.ForeColor = Color.Black;
            }
        }

        private void OnCellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // = DataGridViewComboBoxDisplayStyle.Nothing
            DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            Console.WriteLine(cell.Value.ToString());
            DataGridViewCellStyle cellColor = cell.Style;
            if (cell.Value == DBNull.Value)
            {
                //cellColor.ForeColor = Color.White;
            }
            else if (cell.Value is string strValue)
            {
                //string value = cell.Value.ToString();
                if (strValue == "/")
                {
                    cellColor.ForeColor = Color.White;
                }
                else if (strValue == "Up")
                {
                    cellColor.ForeColor = Color.Red;
                }
                else if (strValue == "Down")
                {
                    cellColor.ForeColor = Color.Blue;
                }
            }
            else if (cell.Value is int value)
            {
                if (value == 0)
                {
                    cellColor.ForeColor = Color.Red;
                }
                else if (value > 0)
                {
                    cellColor.ForeColor = Color.Blue;
                }
                else if (value < 0)
                {
                    cellColor.ForeColor = Color.Green;
                }
            }
            else
            {
                Console.WriteLine("Warning :Cell value unknown :" + cell.Value.ToString());
            }

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
            CheckValueOrAddDefault(row, "Run", "/");
            CheckValueOrAddDefault(row, "Forwards", "/");
            CheckValueOrAddDefault(row, "Backwards", "/");
            CheckValueOrAddDefault(row, "Left", "/");
            CheckValueOrAddDefault(row, "Right", "/");
            CheckValueOrAddDefault(row, "LMB", "/");
            CheckValueOrAddDefault(row, "RMB", "/");
            CheckValueOrAddDefault(row, "Crouch", "/");
            CheckValueOrAddDefault(row, "Inventory", "/");
            CheckValueOrAddDefault(row, "FrameNumber", dt.Rows.IndexOf(row) + 1);


            /* DBNull.Value is already the default value
            CheckValueOrAddDefault(row, "MouseX", DBNull.Value);
            CheckValueOrAddDefault(row, "MouseY", DBNull.Value);

            Legacy ValueDefault checker :
            if (row["MouseX"].GetType() == typeof(DBNull))
                row["MouseX"] = "/";
            */
        }

        private void CheckValueOrAddDefault<T>(DataRow row, string columnName, T defaultVal)
        {
            if (row[columnName].GetType() == typeof(DBNull))
                row[columnName] = defaultVal;
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

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ComboBox ctrl = e.Control as ComboBox;
            if (ctrl != null)
            {
                ctrl.Enter -= new EventHandler(ctrl_Enter);
                ctrl.Enter += new EventHandler(ctrl_Enter);
            }
        }
        void ctrl_Enter(object sender, EventArgs e)
        {
            (sender as ComboBox).DroppedDown = true;
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
            dataGridView1.CurrentCell = dataGridView1.Rows[(int)GoToRowNumeric.Value - 1].Cells[0];
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
            while (numericValue < dt.Rows.Count)
            {
                dt.Rows.RemoveAt(dt.Rows.Count - 1);
            }
        }
    }
}
