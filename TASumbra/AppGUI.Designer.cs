namespace TASumbra
{
    partial class AppGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppGUI));
            this.Label1 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Settings = new System.Windows.Forms.TabPage();
            this.PenumbraPathSelect = new System.Windows.Forms.Button();
            this.PenumbraPathTextBox = new System.Windows.Forms.MaskedTextBox();
            this.MovieEditor = new System.Windows.Forms.TabPage();
            this.Load_Movie = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MovieNumberLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tests = new System.Windows.Forms.TabPage();
            this.performanceText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fpsLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.framesLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GameTime = new System.Windows.Forms.Label();
            this.LaunchRunLabel = new System.Windows.Forms.Label();
            this.penumbraTimeText = new System.Windows.Forms.Label();
            this.LaunchRun = new System.Windows.Forms.Button();
            this.FrameNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Forwards = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Backwards = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Left = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Right = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MouseX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MouseY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.Settings.SuspendLayout();
            this.MovieEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tests.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(3, 3);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(66, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Game Path :";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Settings);
            this.tabControl.Controls.Add(this.MovieEditor);
            this.tabControl.Controls.Add(this.tests);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(944, 502);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl.TabIndex = 1;
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.PenumbraPathSelect);
            this.Settings.Controls.Add(this.PenumbraPathTextBox);
            this.Settings.Controls.Add(this.Label1);
            this.Settings.Location = new System.Drawing.Point(4, 22);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(936, 476);
            this.Settings.TabIndex = 0;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // PenumbraPathSelect
            // 
            this.PenumbraPathSelect.Location = new System.Drawing.Point(456, 18);
            this.PenumbraPathSelect.Name = "PenumbraPathSelect";
            this.PenumbraPathSelect.Size = new System.Drawing.Size(26, 22);
            this.PenumbraPathSelect.TabIndex = 2;
            this.PenumbraPathSelect.Text = "...";
            this.PenumbraPathSelect.UseVisualStyleBackColor = true;
            this.PenumbraPathSelect.Click += new System.EventHandler(this.Button1_Click);
            // 
            // PenumbraPathTextBox
            // 
            this.PenumbraPathTextBox.Location = new System.Drawing.Point(8, 19);
            this.PenumbraPathTextBox.Name = "PenumbraPathTextBox";
            this.PenumbraPathTextBox.Size = new System.Drawing.Size(442, 20);
            this.PenumbraPathTextBox.TabIndex = 1;
            // 
            // MovieEditor
            // 
            this.MovieEditor.Controls.Add(this.Load_Movie);
            this.MovieEditor.Controls.Add(this.button1);
            this.MovieEditor.Controls.Add(this.MovieNumberLabel);
            this.MovieEditor.Controls.Add(this.numericUpDown1);
            this.MovieEditor.Controls.Add(this.dataGridView1);
            this.MovieEditor.Location = new System.Drawing.Point(4, 22);
            this.MovieEditor.Name = "MovieEditor";
            this.MovieEditor.Padding = new System.Windows.Forms.Padding(3);
            this.MovieEditor.Size = new System.Drawing.Size(936, 476);
            this.MovieEditor.TabIndex = 1;
            this.MovieEditor.Text = "Movie Editor";
            this.MovieEditor.UseVisualStyleBackColor = true;
            // 
            // Load_Movie
            // 
            this.Load_Movie.Location = new System.Drawing.Point(215, 20);
            this.Load_Movie.Name = "Load_Movie";
            this.Load_Movie.Size = new System.Drawing.Size(75, 23);
            this.Load_Movie.TabIndex = 4;
            this.Load_Movie.Text = "Load Movie";
            this.Load_Movie.UseVisualStyleBackColor = true;
            this.Load_Movie.Click += new System.EventHandler(this.LoadMovie_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save Movie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SaveMovie_Click);
            // 
            // MovieNumberLabel
            // 
            this.MovieNumberLabel.AutoSize = true;
            this.MovieNumberLabel.Location = new System.Drawing.Point(400, 26);
            this.MovieNumberLabel.Name = "MovieNumberLabel";
            this.MovieNumberLabel.Size = new System.Drawing.Size(80, 13);
            this.MovieNumberLabel.TabIndex = 2;
            this.MovieNumberLabel.Text = "Movie number :";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(483, 23);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FrameNumber,
            this.Forwards,
            this.Backwards,
            this.Left,
            this.Right,
            this.MouseX,
            this.MouseY});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(0, 49);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(544, 427);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // tests
            // 
            this.tests.Controls.Add(this.performanceText);
            this.tests.Controls.Add(this.label3);
            this.tests.Controls.Add(this.fpsLabel);
            this.tests.Controls.Add(this.label4);
            this.tests.Controls.Add(this.framesLabel);
            this.tests.Controls.Add(this.label2);
            this.tests.Controls.Add(this.GameTime);
            this.tests.Controls.Add(this.LaunchRunLabel);
            this.tests.Controls.Add(this.penumbraTimeText);
            this.tests.Controls.Add(this.LaunchRun);
            this.tests.Location = new System.Drawing.Point(4, 22);
            this.tests.Name = "tests";
            this.tests.Padding = new System.Windows.Forms.Padding(3);
            this.tests.Size = new System.Drawing.Size(936, 476);
            this.tests.TabIndex = 2;
            this.tests.Text = "tests";
            this.tests.UseVisualStyleBackColor = true;
            // 
            // performanceText
            // 
            this.performanceText.AutoSize = true;
            this.performanceText.Location = new System.Drawing.Point(82, 137);
            this.performanceText.MinimumSize = new System.Drawing.Size(50, 0);
            this.performanceText.Name = "performanceText";
            this.performanceText.Size = new System.Drawing.Size(50, 13);
            this.performanceText.TabIndex = 9;
            this.performanceText.Text = "-1 µs";
            this.performanceText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.performanceText.Click += new System.EventHandler(this.PerformanceText_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Performance";
            // 
            // fpsLabel
            // 
            this.fpsLabel.AutoSize = true;
            this.fpsLabel.Location = new System.Drawing.Point(59, 111);
            this.fpsLabel.Name = "fpsLabel";
            this.fpsLabel.Size = new System.Drawing.Size(16, 13);
            this.fpsLabel.TabIndex = 7;
            this.fpsLabel.Text = "-1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fps:";
            // 
            // framesLabel
            // 
            this.framesLabel.AutoSize = true;
            this.framesLabel.Location = new System.Drawing.Point(59, 73);
            this.framesLabel.Name = "framesLabel";
            this.framesLabel.Size = new System.Drawing.Size(16, 13);
            this.framesLabel.TabIndex = 5;
            this.framesLabel.Text = "-1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Frames:";
            // 
            // GameTime
            // 
            this.GameTime.AutoSize = true;
            this.GameTime.Location = new System.Drawing.Point(123, 35);
            this.GameTime.Name = "GameTime";
            this.GameTime.Size = new System.Drawing.Size(61, 13);
            this.GameTime.TabIndex = 3;
            this.GameTime.Text = "GameTime:";
            // 
            // LaunchRunLabel
            // 
            this.LaunchRunLabel.AutoSize = true;
            this.LaunchRunLabel.Location = new System.Drawing.Point(9, 60);
            this.LaunchRunLabel.MinimumSize = new System.Drawing.Size(150, 0);
            this.LaunchRunLabel.Name = "LaunchRunLabel";
            this.LaunchRunLabel.Size = new System.Drawing.Size(150, 13);
            this.LaunchRunLabel.TabIndex = 2;
            this.LaunchRunLabel.Click += new System.EventHandler(this.GameTimeStaticLabel);
            // 
            // penumbraTimeText
            // 
            this.penumbraTimeText.AutoSize = true;
            this.penumbraTimeText.Location = new System.Drawing.Point(190, 35);
            this.penumbraTimeText.Name = "penumbraTimeText";
            this.penumbraTimeText.Size = new System.Drawing.Size(67, 13);
            this.penumbraTimeText.TabIndex = 1;
            this.penumbraTimeText.Text = "not detected";
            this.penumbraTimeText.Click += new System.EventHandler(this.TimeText_Click);
            // 
            // LaunchRun
            // 
            this.LaunchRun.Location = new System.Drawing.Point(3, 30);
            this.LaunchRun.Name = "LaunchRun";
            this.LaunchRun.Size = new System.Drawing.Size(114, 23);
            this.LaunchRun.TabIndex = 0;
            this.LaunchRun.Text = "Launch Run";
            this.LaunchRun.UseVisualStyleBackColor = true;
            this.LaunchRun.Click += new System.EventHandler(this.GetTime_Click);
            // 
            // FrameNumber
            // 
            this.FrameNumber.FillWeight = 55F;
            this.FrameNumber.Frozen = true;
            this.FrameNumber.HeaderText = "Frame n°";
            this.FrameNumber.Name = "FrameNumber";
            this.FrameNumber.Width = 55;
            // 
            // Forwards
            // 
            this.Forwards.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Forwards.FillWeight = 65F;
            this.Forwards.Frozen = true;
            this.Forwards.HeaderText = "Forwards";
            this.Forwards.Items.AddRange(new object[] {
            "Up",
            "Down",
            "/"});
            this.Forwards.Name = "Forwards";
            this.Forwards.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Forwards.Width = 56;
            // 
            // Backwards
            // 
            this.Backwards.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Backwards.FillWeight = 75F;
            this.Backwards.Frozen = true;
            this.Backwards.HeaderText = "Backwards";
            this.Backwards.Items.AddRange(new object[] {
            "Up",
            "Down",
            "/"});
            this.Backwards.Name = "Backwards";
            this.Backwards.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Backwards.Width = 66;
            // 
            // Left
            // 
            this.Left.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Left.FillWeight = 50F;
            this.Left.Frozen = true;
            this.Left.HeaderText = "Left";
            this.Left.Name = "Left";
            this.Left.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Left.Width = 31;
            // 
            // Right
            // 
            this.Right.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Right.Frozen = true;
            this.Right.HeaderText = "Right";
            this.Right.Name = "Right";
            this.Right.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Right.Width = 38;
            // 
            // MouseX
            // 
            this.MouseX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MouseX.Frozen = true;
            this.MouseX.HeaderText = "MouseX";
            this.MouseX.Name = "MouseX";
            this.MouseX.Width = 71;
            // 
            // MouseY
            // 
            this.MouseY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MouseY.Frozen = true;
            this.MouseY.HeaderText = "MouseY";
            this.MouseY.Name = "MouseY";
            this.MouseY.Width = 71;
            // 
            // AppGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppGUI";
            this.Text = "TASumbra";
            this.Load += new System.EventHandler(this.App_Load);
            this.tabControl.ResumeLayout(false);
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.MovieEditor.ResumeLayout(false);
            this.MovieEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tests.ResumeLayout(false);
            this.tests.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.TabPage MovieEditor;
        private System.Windows.Forms.MaskedTextBox PenumbraPathTextBox;
        private System.Windows.Forms.Button PenumbraPathSelect;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label MovieNumberLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TabPage tests;
        private System.Windows.Forms.Label penumbraTimeText;
        private System.Windows.Forms.Button LaunchRun;
        private System.Windows.Forms.Label LaunchRunLabel;
        private System.Windows.Forms.Label GameTime;
        private System.Windows.Forms.Label fpsLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label framesLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label performanceText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Load_Movie;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrameNumber;
        private System.Windows.Forms.DataGridViewComboBoxColumn Forwards;
        private System.Windows.Forms.DataGridViewComboBoxColumn Backwards;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Left;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Right;
        private System.Windows.Forms.DataGridViewTextBoxColumn MouseX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MouseY;
    }
}