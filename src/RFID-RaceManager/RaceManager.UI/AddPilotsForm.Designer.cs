namespace RaceManager.UI
{
    partial class AddPilotsForm
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
            this.components = new System.ComponentModel.Container();
            this.gvPilots = new System.Windows.Forms.DataGridView();
            this.pilotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddPilots = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddPilot = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmationStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvPilots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvPilots
            // 
            this.gvPilots.AllowUserToAddRows = false;
            this.gvPilots.AllowUserToOrderColumns = true;
            this.gvPilots.AutoGenerateColumns = false;
            this.gvPilots.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvPilots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPilots.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.Number,
            this.teamDataGridViewTextBoxColumn,
            this.tagDataGridViewTextBoxColumn,
            this.confirmationStringDataGridViewTextBoxColumn});
            this.gvPilots.DataSource = this.pilotBindingSource;
            this.gvPilots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvPilots.GridColor = System.Drawing.SystemColors.Control;
            this.gvPilots.Location = new System.Drawing.Point(4, 4);
            this.gvPilots.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gvPilots.Name = "gvPilots";
            this.gvPilots.RowHeadersWidth = 72;
            this.gvPilots.RowTemplate.Height = 24;
            this.gvPilots.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvPilots.Size = new System.Drawing.Size(1704, 799);
            this.gvPilots.TabIndex = 1;
            // 
            // pilotBindingSource
            // 
            this.pilotBindingSource.DataSource = typeof(RaceManager.Data.Pilot);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(1274, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(281, 50);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnAddPilots
            // 
            this.btnAddPilots.Location = new System.Drawing.Point(983, 6);
            this.btnAddPilots.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAddPilots.Name = "btnAddPilots";
            this.btnAddPilots.Size = new System.Drawing.Size(281, 50);
            this.btnAddPilots.TabIndex = 3;
            this.btnAddPilots.Text = "Add Pilots to List";
            this.btnAddPilots.UseVisualStyleBackColor = true;
            this.btnAddPilots.Click += new System.EventHandler(this.btnAddPilots_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(691, 6);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(281, 50);
            this.btnSaveChanges.TabIndex = 4;
            this.btnSaveChanges.Text = "Save Changes to Database";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(400, 6);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(281, 50);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh List from Database";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gvPilots, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.6129F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.387096F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1712, 881);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddPilot);
            this.panel1.Controls.Add(this.btnSaveChanges);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnAddPilots);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(137, 813);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1569, 62);
            this.panel1.TabIndex = 7;
            // 
            // btnAddPilot
            // 
            this.btnAddPilot.Location = new System.Drawing.Point(108, 6);
            this.btnAddPilot.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAddPilot.Name = "btnAddPilot";
            this.btnAddPilot.Size = new System.Drawing.Size(281, 50);
            this.btnAddPilot.TabIndex = 6;
            this.btnAddPilot.Text = "Add New Pilot";
            this.btnAddPilot.UseVisualStyleBackColor = true;
            this.btnAddPilot.Click += new System.EventHandler(this.btnAddPilot_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "Number";
            this.Number.MinimumWidth = 9;
            this.Number.Name = "Number";
            this.Number.Width = 175;
            // 
            // teamDataGridViewTextBoxColumn
            // 
            this.teamDataGridViewTextBoxColumn.DataPropertyName = "Team";
            this.teamDataGridViewTextBoxColumn.HeaderText = "Team";
            this.teamDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            this.teamDataGridViewTextBoxColumn.Width = 175;
            // 
            // tagDataGridViewTextBoxColumn
            // 
            this.tagDataGridViewTextBoxColumn.DataPropertyName = "Tag";
            this.tagDataGridViewTextBoxColumn.HeaderText = "Tag";
            this.tagDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.tagDataGridViewTextBoxColumn.Name = "tagDataGridViewTextBoxColumn";
            this.tagDataGridViewTextBoxColumn.Width = 150;
            // 
            // confirmationStringDataGridViewTextBoxColumn
            // 
            this.confirmationStringDataGridViewTextBoxColumn.DataPropertyName = "ConfirmationString";
            this.confirmationStringDataGridViewTextBoxColumn.HeaderText = "Confirmation";
            this.confirmationStringDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.confirmationStringDataGridViewTextBoxColumn.Name = "confirmationStringDataGridViewTextBoxColumn";
            this.confirmationStringDataGridViewTextBoxColumn.Width = 175;
            // 
            // AddPilotsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1712, 881);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AddPilotsForm";
            this.Text = "Add Pilots from DB";
            this.Load += new System.EventHandler(this.AddPilotsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvPilots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvPilots;
        private System.Windows.Forms.DataGridViewTextBoxColumn nicknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pilotBindingSource;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddPilots;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddPilot;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn confirmationStringDataGridViewTextBoxColumn;
    }
}