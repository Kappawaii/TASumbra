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
            dt.TableNewRow += DataGridView1_RowsAdded;
            dt.Columns.Add("FrameNumber", Type.GetType("System.String"));
            dt.Columns.Add("Forwards");
            dt.Columns.Add("Nice");
            dt.Columns.Add("MouseX", Type.GetType("System.Int32"));
            dt.Columns.Add("MouseY", Type.GetType("System.Int32"));
            dt.Rows.Add();
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

        private void DataGridView1_RowsAdded(object sender, DataTableNewRowEventArgs e)
        {
            int lastVal = 0;
            if (e != null)
            {

                DataGridViewRow row = dataGridView1.Rows[dt.Rows.IndexOf(e.Row)];
                /*if (row.Cells["FrameNumber"].Value != null)
                {
                    lastVal = int.Parse(row.Cells["FrameNumber"].Value.ToString());
                }
                else
                {
                    row.Cells["FrameNumber"].Value = ++lastVal;
                }*/
                row.Cells["MouseX"].Value = null;
                row.Cells["MouseY"].Value = null;
                DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)row.Cells["Forwards"];
                cell.Value = cell.Items[2];
                //cell.ValueType = typeof(int);

            }
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

        private void SaveMovie_Click(object sender, EventArgs e)
        {
            dt.WriteXml("movie.xml");
        }

        private void LoadMovie_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt.ReadXml("movie.xml");
        }
    }
}
