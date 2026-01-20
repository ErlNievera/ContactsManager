namespace ContactsManager
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
            components = new System.ComponentModel.Container();
            btnAddContact = new Button();
            txtFullName = new TextBox();
            lblFullName = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            mtbPhone = new TextBox();
            lblPhone = new Label();
            cmbGender = new ComboBox();
            lblGender = new Label();
            dtpBirthDate = new DateTimePicker();
            lblBirthDate = new Label();
            btnUpdateContact = new Button();
            dgContacts = new DataGridView();
            colFullName = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colGender = new DataGridViewTextBoxColumn();
            colBirthDate = new DataGridViewTextBoxColumn();
            colCreatedAt = new DataGridViewTextBoxColumn();
            gbActionManagement = new GroupBox();
            btnExportCsv = new Button();
            chkConfirmDelete = new CheckBox();
            btnClearAll = new Button();
            btnRemoveSelected = new Button();
            toolStrip1 = new ToolStrip();
            lblStatus = new ToolStripLabel();
            lblCounts = new ToolStripLabel();
            gbFilteringSearching = new GroupBox();
            btnResetFilter = new Button();
            btnApplyFilter = new Button();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblFilterGender = new Label();
            cmbFilterGender = new ComboBox();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgContacts).BeginInit();
            gbActionManagement.SuspendLayout();
            toolStrip1.SuspendLayout();
            gbFilteringSearching.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // btnAddContact
            // 
            btnAddContact.Location = new Point(116, 255);
            btnAddContact.Name = "btnAddContact";
            btnAddContact.Size = new Size(75, 23);
            btnAddContact.TabIndex = 0;
            btnAddContact.Text = "Add";
            btnAddContact.UseVisualStyleBackColor = true;
            btnAddContact.Click += btnAddContact_Click;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(116, 29);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(234, 22);
            txtFullName.TabIndex = 1;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(23, 32);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(74, 16);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "Full Name:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(23, 77);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 16);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(116, 74);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(234, 22);
            txtEmail.TabIndex = 4;
            // 
            // mtbPhone
            // 
            mtbPhone.Location = new Point(116, 122);
            mtbPhone.Name = "mtbPhone";
            mtbPhone.Size = new Size(234, 22);
            mtbPhone.TabIndex = 5;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(23, 125);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(50, 16);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Phone:";
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Non-binary", "Prefer not to say" });
            cmbGender.Location = new Point(116, 171);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(234, 24);
            cmbGender.TabIndex = 7;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(23, 174);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(56, 16);
            lblGender.TabIndex = 8;
            lblGender.Text = "Gender:";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(116, 217);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(234, 22);
            dtpBirthDate.TabIndex = 9;
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(23, 223);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(73, 16);
            lblBirthDate.TabIndex = 10;
            lblBirthDate.Text = "Birth Date:";
            // 
            // btnUpdateContact
            // 
            btnUpdateContact.Location = new Point(275, 255);
            btnUpdateContact.Name = "btnUpdateContact";
            btnUpdateContact.Size = new Size(75, 23);
            btnUpdateContact.TabIndex = 11;
            btnUpdateContact.Text = "Update";
            btnUpdateContact.UseVisualStyleBackColor = true;
            btnUpdateContact.Click += btnUpdateContact_Click;
            // 
            // dgContacts
            // 
            dgContacts.AllowUserToAddRows = false;
            dgContacts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgContacts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgContacts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgContacts.Columns.AddRange(new DataGridViewColumn[] { colFullName, colEmail, colPhone, colGender, colBirthDate, colCreatedAt });
            dgContacts.Location = new Point(414, 98);
            dgContacts.Name = "dgContacts";
            dgContacts.ReadOnly = true;
            dgContacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgContacts.Size = new Size(669, 450);
            dgContacts.TabIndex = 13;
            // 
            // colFullName
            // 
            colFullName.HeaderText = "Full Name";
            colFullName.Name = "colFullName";
            colFullName.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email";
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // colPhone
            // 
            colPhone.HeaderText = "Phone";
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            // 
            // colGender
            // 
            colGender.HeaderText = "Gender";
            colGender.Name = "colGender";
            colGender.ReadOnly = true;
            // 
            // colBirthDate
            // 
            colBirthDate.HeaderText = "Birth Date";
            colBirthDate.Name = "colBirthDate";
            colBirthDate.ReadOnly = true;
            // 
            // colCreatedAt
            // 
            colCreatedAt.HeaderText = "CreatedAt";
            colCreatedAt.Name = "colCreatedAt";
            colCreatedAt.ReadOnly = true;
            // 
            // gbActionManagement
            // 
            gbActionManagement.Controls.Add(btnExportCsv);
            gbActionManagement.Controls.Add(chkConfirmDelete);
            gbActionManagement.Controls.Add(btnClearAll);
            gbActionManagement.Controls.Add(btnRemoveSelected);
            gbActionManagement.Location = new Point(23, 308);
            gbActionManagement.Name = "gbActionManagement";
            gbActionManagement.Size = new Size(373, 222);
            gbActionManagement.TabIndex = 14;
            gbActionManagement.TabStop = false;
            gbActionManagement.Text = "Action Management";
            // 
            // btnExportCsv
            // 
            btnExportCsv.Location = new Point(264, 21);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(93, 48);
            btnExportCsv.TabIndex = 3;
            btnExportCsv.Text = "Export";
            btnExportCsv.UseVisualStyleBackColor = true;
            btnExportCsv.Click += btnExportCsv_Click;
            // 
            // chkConfirmDelete
            // 
            chkConfirmDelete.AutoSize = true;
            chkConfirmDelete.Location = new Point(135, 94);
            chkConfirmDelete.Name = "chkConfirmDelete";
            chkConfirmDelete.Size = new Size(118, 20);
            chkConfirmDelete.TabIndex = 2;
            chkConfirmDelete.Text = "Confirm Delete";
            chkConfirmDelete.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(147, 21);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(93, 48);
            btnClearAll.TabIndex = 1;
            btnClearAll.Text = "Clear All";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // btnRemoveSelected
            // 
            btnRemoveSelected.Location = new Point(31, 21);
            btnRemoveSelected.Name = "btnRemoveSelected";
            btnRemoveSelected.Size = new Size(93, 48);
            btnRemoveSelected.TabIndex = 0;
            btnRemoveSelected.Text = "Remove Selected";
            btnRemoveSelected.UseVisualStyleBackColor = true;
            btnRemoveSelected.Click += btnRemoveSelected_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { lblStatus, lblCounts });
            toolStrip1.Location = new Point(0, 654);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1150, 25);
            toolStrip1.TabIndex = 15;
            toolStrip1.Text = "toolStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 22);
            // 
            // lblCounts
            // 
            lblCounts.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCounts.Name = "lblCounts";
            lblCounts.Size = new Size(0, 22);
            // 
            // gbFilteringSearching
            // 
            gbFilteringSearching.Controls.Add(btnResetFilter);
            gbFilteringSearching.Controls.Add(btnApplyFilter);
            gbFilteringSearching.Controls.Add(lblSearch);
            gbFilteringSearching.Controls.Add(txtSearch);
            gbFilteringSearching.Controls.Add(lblFilterGender);
            gbFilteringSearching.Controls.Add(cmbFilterGender);
            gbFilteringSearching.Location = new Point(450, 12);
            gbFilteringSearching.Name = "gbFilteringSearching";
            gbFilteringSearching.Size = new Size(576, 80);
            gbFilteringSearching.TabIndex = 16;
            gbFilteringSearching.TabStop = false;
            gbFilteringSearching.Text = "Filtering Searching";
            // 
            // btnResetFilter
            // 
            btnResetFilter.Location = new Point(445, 32);
            btnResetFilter.Name = "btnResetFilter";
            btnResetFilter.Size = new Size(111, 26);
            btnResetFilter.TabIndex = 5;
            btnResetFilter.Text = "Reset Filter";
            btnResetFilter.UseVisualStyleBackColor = true;
            // 
            // btnApplyFilter
            // 
            btnApplyFilter.Location = new Point(318, 32);
            btnApplyFilter.Name = "btnApplyFilter";
            btnApplyFilter.Size = new Size(111, 26);
            btnApplyFilter.TabIndex = 4;
            btnApplyFilter.Text = "Apply Filter";
            btnApplyFilter.UseVisualStyleBackColor = true;
            btnApplyFilter.Click += btnApplyFilter_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(22, 53);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(53, 16);
            lblSearch.TabIndex = 3;
            lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(121, 50);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(163, 22);
            txtSearch.TabIndex = 2;
            // 
            // lblFilterGender
            // 
            lblFilterGender.AutoSize = true;
            lblFilterGender.Location = new Point(22, 23);
            lblFilterGender.Name = "lblFilterGender";
            lblFilterGender.Size = new Size(93, 16);
            lblFilterGender.TabIndex = 1;
            lblFilterGender.Text = "Filter Gender:";
            // 
            // cmbFilterGender
            // 
            cmbFilterGender.FormattingEnabled = true;
            cmbFilterGender.Items.AddRange(new object[] { "Male", "Female", "Non-binary", "Prefer not to say" });
            cmbFilterGender.Location = new Point(121, 20);
            cmbFilterGender.Name = "cmbFilterGender";
            cmbFilterGender.Size = new Size(163, 24);
            cmbFilterGender.TabIndex = 0;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(1150, 679);
            Controls.Add(gbFilteringSearching);
            Controls.Add(toolStrip1);
            Controls.Add(gbActionManagement);
            Controls.Add(dgContacts);
            Controls.Add(btnUpdateContact);
            Controls.Add(lblBirthDate);
            Controls.Add(dtpBirthDate);
            Controls.Add(lblGender);
            Controls.Add(cmbGender);
            Controls.Add(lblPhone);
            Controls.Add(mtbPhone);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblFullName);
            Controls.Add(txtFullName);
            Controls.Add(btnAddContact);
            Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ContactsManager";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgContacts).EndInit();
            gbActionManagement.ResumeLayout(false);
            gbActionManagement.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            gbFilteringSearching.ResumeLayout(false);
            gbFilteringSearching.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddContact;
        private TextBox txtFullName;
        private Label lblFullName;
        private Label lblEmail;
        private TextBox txtEmail;
        private TextBox mtbPhone;
        private Label lblPhone;
        private ComboBox cmbGender;
        private Label lblGender;
        private DateTimePicker dtpBirthDate;
        private Label lblBirthDate;
        private Button btnUpdateContact;
        private DataGridView dgContacts;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colGender;
        private DataGridViewTextBoxColumn colBirthDate;
        private DataGridViewTextBoxColumn colCreatedAt;
        private GroupBox gbActionManagement;
        private Button btnClearAll;
        private Button btnRemoveSelected;
        private ToolStrip toolStrip1;
        private ToolStripLabel lblStatus;
        private ToolStripLabel lblCounts;
        private CheckBox chkConfirmDelete;
        private Button btnExportCsv;
        private GroupBox gbFilteringSearching;
        private TextBox txtSearch;
        private Label lblFilterGender;
        private ComboBox cmbFilterGender;
        private Label lblSearch;
        private Button btnResetFilter;
        private Button btnApplyFilter;
        private ErrorProvider errorProvider;
    }
}
