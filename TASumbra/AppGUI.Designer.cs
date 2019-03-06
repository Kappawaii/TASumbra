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
            this.ChangeNumberOfFramesButton = new System.Windows.Forms.Button();
            this.NumberOfFramesNumeric = new System.Windows.Forms.NumericUpDown();
            this.NumberOfFramesLabel = new System.Windows.Forms.Label();
            this.NewMovieButton = new System.Windows.Forms.Button();
            this.GoToRow = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.GoToRowNumeric = new System.Windows.Forms.NumericUpDown();
            this.LoadMovieButton = new System.Windows.Forms.Button();
            this.SaveMovieButton = new System.Windows.Forms.Button();
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
            this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MouseY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MouseX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inventory = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Crouch = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.RMB = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.LMB = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Right = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Left = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Backwards = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Forwards = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Run = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.FrameNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.Settings.SuspendLayout();
            this.MovieEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfFramesNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoToRowNumeric)).BeginInit();
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
            this.MovieEditor.Controls.Add(this.LoadingLabel);
            this.MovieEditor.Controls.Add(this.ChangeNumberOfFramesButton);
            this.MovieEditor.Controls.Add(this.NumberOfFramesNumeric);
            this.MovieEditor.Controls.Add(this.NumberOfFramesLabel);
            this.MovieEditor.Controls.Add(this.NewMovieButton);
            this.MovieEditor.Controls.Add(this.GoToRow);
            this.MovieEditor.Controls.Add(this.label5);
            this.MovieEditor.Controls.Add(this.GoToRowNumeric);
            this.MovieEditor.Controls.Add(this.LoadMovieButton);
            this.MovieEditor.Controls.Add(this.SaveMovieButton);
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
            // ChangeNumberOfFramesButton
            // 
            this.ChangeNumberOfFramesButton.Location = new System.Drawing.Point(832, 196);
            this.ChangeNumberOfFramesButton.Name = "ChangeNumberOfFramesButton";
            this.ChangeNumberOfFramesButton.Size = new System.Drawing.Size(87, 50);
            this.ChangeNumberOfFramesButton.TabIndex = 11;
            this.ChangeNumberOfFramesButton.Text = "Change number of lines";
            this.ChangeNumberOfFramesButton.UseVisualStyleBackColor = true;
            this.ChangeNumberOfFramesButton.Click += new System.EventHandler(this.ChangeNumberOfFramesButton_Click);
            // 
            // NumberOfFramesNumeric
            // 
            this.NumberOfFramesNumeric.Location = new System.Drawing.Point(843, 170);
            this.NumberOfFramesNumeric.Maximum = new decimal(new int[] {
            128000,
            0,
            0,
            0});
            this.NumberOfFramesNumeric.Name = "NumberOfFramesNumeric";
            this.NumberOfFramesNumeric.Size = new System.Drawing.Size(61, 20);
            this.NumberOfFramesNumeric.TabIndex = 10;
            // 
            // NumberOfFramesLabel
            // 
            this.NumberOfFramesLabel.AutoSize = true;
            this.NumberOfFramesLabel.Location = new System.Drawing.Point(832, 154);
            this.NumberOfFramesLabel.Name = "NumberOfFramesLabel";
            this.NumberOfFramesLabel.Size = new System.Drawing.Size(80, 13);
            this.NumberOfFramesLabel.TabIndex = 9;
            this.NumberOfFramesLabel.Text = "Movie number :";
            this.NumberOfFramesLabel.Visible = false;
            // 
            // NewMovieButton
            // 
            this.NewMovieButton.Location = new System.Drawing.Point(6, 16);
            this.NewMovieButton.Name = "NewMovieButton";
            this.NewMovieButton.Size = new System.Drawing.Size(75, 23);
            this.NewMovieButton.TabIndex = 8;
            this.NewMovieButton.Text = "New Movie";
            this.NewMovieButton.UseVisualStyleBackColor = true;
            this.NewMovieButton.Visible = false;
            this.NewMovieButton.Click += new System.EventHandler(this.NewMovie_Click);
            // 
            // GoToRow
            // 
            this.GoToRow.Location = new System.Drawing.Point(832, 98);
            this.GoToRow.Name = "GoToRow";
            this.GoToRow.Size = new System.Drawing.Size(87, 23);
            this.GoToRow.TabIndex = 7;
            this.GoToRow.Text = "Go";
            this.GoToRow.UseVisualStyleBackColor = true;
            this.GoToRow.Click += new System.EventHandler(this.GoToRow_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(840, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Go to frame :";
            // 
            // GoToRowNumeric
            // 
            this.GoToRowNumeric.Location = new System.Drawing.Point(843, 72);
            this.GoToRowNumeric.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.GoToRowNumeric.Name = "GoToRowNumeric";
            this.GoToRowNumeric.Size = new System.Drawing.Size(61, 20);
            this.GoToRowNumeric.TabIndex = 5;
            // 
            // LoadMovieButton
            // 
            this.LoadMovieButton.Location = new System.Drawing.Point(87, 16);
            this.LoadMovieButton.Name = "LoadMovieButton";
            this.LoadMovieButton.Size = new System.Drawing.Size(75, 23);
            this.LoadMovieButton.TabIndex = 4;
            this.LoadMovieButton.Text = "Load Movie";
            this.LoadMovieButton.UseVisualStyleBackColor = true;
            this.LoadMovieButton.Click += new System.EventHandler(this.LoadMovie_Click);
            // 
            // SaveMovieButton
            // 
            this.SaveMovieButton.Location = new System.Drawing.Point(168, 16);
            this.SaveMovieButton.Name = "SaveMovieButton";
            this.SaveMovieButton.Size = new System.Drawing.Size(75, 23);
            this.SaveMovieButton.TabIndex = 3;
            this.SaveMovieButton.Text = "Save Movie";
            this.SaveMovieButton.UseVisualStyleBackColor = true;
            this.SaveMovieButton.Click += new System.EventHandler(this.SaveMovie_Click);
            // 
            // MovieNumberLabel
            // 
            this.MovieNumberLabel.AutoSize = true;
            this.MovieNumberLabel.Location = new System.Drawing.Point(370, 21);
            this.MovieNumberLabel.Name = "MovieNumberLabel";
            this.MovieNumberLabel.Size = new System.Drawing.Size(80, 13);
            this.MovieNumberLabel.TabIndex = 2;
            this.MovieNumberLabel.Text = "Movie number :";
            this.MovieNumberLabel.Visible = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(456, 19);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Visible = false;
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
            this.Run,
            this.Forwards,
            this.Backwards,
            this.Left,
            this.Right,
            this.LMB,
            this.RMB,
            this.Crouch,
            this.Inventory,
            this.MouseX,
            this.MouseY,
            this.Comments});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(2, 49);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(826, 427);
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
            // Comments
            // 
            this.Comments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Comments.Frozen = true;
            this.Comments.HeaderText = "Comments";
            this.Comments.MinimumWidth = 130;
            this.Comments.Name = "Comments";
            this.Comments.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Comments.Width = 130;
            // 
            // MouseY
            // 
            this.MouseY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MouseY.Frozen = true;
            this.MouseY.HeaderText = "MouseY";
            this.MouseY.Name = "MouseY";
            this.MouseY.Width = 71;
            // 
            // MouseX
            // 
            this.MouseX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MouseX.Frozen = true;
            this.MouseX.HeaderText = "MouseX";
            this.MouseX.Name = "MouseX";
            this.MouseX.Width = 71;
            // 
            // Inventory
            // 
            this.Inventory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Inventory.Frozen = true;
            this.Inventory.HeaderText = "Inventory";
            this.Inventory.Items.AddRange(new object[] {
            "Up",
            "Down",
            "/"});
            this.Inventory.MinimumWidth = 55;
            this.Inventory.Name = "Inventory";
            this.Inventory.Width = 57;
            // 
            // Crouch
            // 
            this.Crouch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Crouch.Frozen = true;
            this.Crouch.HeaderText = "Crouch";
            this.Crouch.Items.AddRange(new object[] {
            "Up",
            "Down",
            "/"});
            this.Crouch.MinimumWidth = 55;
            this.Crouch.Name = "Crouch";
            this.Crouch.Width = 55;
            // 
            // RMB
            // 
            this.RMB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.RMB.Frozen = true;
            this.RMB.HeaderText = "RMB";
            this.RMB.Items.AddRange(new object[] {
            "Up",
            "Down",
            "/"});
            this.RMB.MinimumWidth = 55;
            this.RMB.Name = "RMB";
            this.RMB.Width = 55;
            // 
            // LMB
            // 
            this.LMB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.LMB.Frozen = true;
            this.LMB.HeaderText = "LMB";
            this.LMB.Items.AddRange(new object[] {
            "Up",
            "Down",
            "/"});
            this.LMB.MinimumWidth = 55;
            this.LMB.Name = "LMB";
            this.LMB.Width = 55;
            // 
            // Right
            // 
            this.Right.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Right.Frozen = true;
            this.Right.HeaderText = "Right";
            this.Right.Items.AddRange(new object[] {
            "Up",
            "Down",
            "/"});
            this.Right.MinimumWidth = 55;
            this.Right.Name = "Right";
            this.Right.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Right.Width = 55;
            // 
            // Left
            // 
            this.Left.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Left.FillWeight = 50F;
            this.Left.Frozen = true;
            this.Left.HeaderText = "Left";
            this.Left.Items.AddRange(new object[] {
            "Up",
            "Down",
            "/"});
            this.Left.MinimumWidth = 55;
            this.Left.Name = "Left";
            this.Left.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Left.Width = 55;
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
            // Run
            // 
            this.Run.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Run.Frozen = true;
            this.Run.HeaderText = "Run";
            this.Run.Items.AddRange(new object[] {
            "Up",
            "Down",
            "/"});
            this.Run.MinimumWidth = 55;
            this.Run.Name = "Run";
            this.Run.Width = 55;
            // 
            // FrameNumber
            // 
            this.FrameNumber.FillWeight = 55F;
            this.FrameNumber.Frozen = true;
            this.FrameNumber.HeaderText = "Frame n°";
            this.FrameNumber.Name = "FrameNumber";
            this.FrameNumber.ReadOnly = true;
            this.FrameNumber.Width = 55;
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.AutoSize = true;
            this.LoadingLabel.Location = new System.Drawing.Point(249, 21);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(54, 13);
            this.LoadingLabel.TabIndex = 12;
            this.LoadingLabel.Text = "Loading...";
            this.LoadingLabel.Visible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfFramesNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoToRowNumeric)).EndInit();
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
        private System.Windows.Forms.Button SaveMovieButton;
        private System.Windows.Forms.Button LoadMovieButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown GoToRowNumeric;
        private System.Windows.Forms.Button GoToRow;
        private System.Windows.Forms.Button NewMovieButton;
        private System.Windows.Forms.Button ChangeNumberOfFramesButton;
        private System.Windows.Forms.NumericUpDown NumberOfFramesNumeric;
        private System.Windows.Forms.Label NumberOfFramesLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrameNumber;
        private System.Windows.Forms.DataGridViewComboBoxColumn Run;
        private System.Windows.Forms.DataGridViewComboBoxColumn Forwards;
        private System.Windows.Forms.DataGridViewComboBoxColumn Backwards;
        private System.Windows.Forms.DataGridViewComboBoxColumn Left;
        private System.Windows.Forms.DataGridViewComboBoxColumn Right;
        private System.Windows.Forms.DataGridViewComboBoxColumn LMB;
        private System.Windows.Forms.DataGridViewComboBoxColumn RMB;
        private System.Windows.Forms.DataGridViewComboBoxColumn Crouch;
        private System.Windows.Forms.DataGridViewComboBoxColumn Inventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn MouseX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MouseY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
        private System.Windows.Forms.Label LoadingLabel;
    }
}