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
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            lblCounts = new ToolStripStatusLabel();
            lblErrorProvider = new ToolStripStatusLabel();
            dgContacts = new DataGridView();
            colFullName = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colGender = new DataGridViewTextBoxColumn();
            colBirthDate = new DataGridViewTextBoxColumn();
            colCreatedAt = new DataGridViewTextBoxColumn();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgContacts).BeginInit();
            SuspendLayout();
            // 
            // btnAddContact
            // 
            btnAddContact.Location = new Point(178, 255);
            btnAddContact.Name = "btnAddContact";
            btnAddContact.Size = new Size(75, 23);
            btnAddContact.TabIndex = 0;
            btnAddContact.Text = "Add";
            btnAddContact.UseVisualStyleBackColor = true;
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
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus, lblCounts, lblErrorProvider });
            statusStrip1.Location = new Point(0, 488);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(981, 22);
            statusStrip1.TabIndex = 12;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 17);
            lblStatus.Text = "Status:";
            // 
            // lblCounts
            // 
            lblCounts.Name = "lblCounts";
            lblCounts.Size = new Size(48, 17);
            lblCounts.Text = "Counts:";
            // 
            // lblErrorProvider
            // 
            lblErrorProvider.ForeColor = Color.Red;
            lblErrorProvider.Name = "lblErrorProvider";
            lblErrorProvider.Size = new Size(35, 17);
            lblErrorProvider.Text = "Error:";
            // 
            // dgContacts
            // 
            dgContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgContacts.Columns.AddRange(new DataGridViewColumn[] { colFullName, colEmail, colPhone, colGender, colBirthDate, colCreatedAt });
            dgContacts.Location = new Point(414, 62);
            dgContacts.Name = "dgContacts";
            dgContacts.Size = new Size(546, 374);
            dgContacts.TabIndex = 13;
            // 
            // colFullName
            // 
            colFullName.HeaderText = "Full Name";
            colFullName.Name = "colFullName";
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email";
            colEmail.Name = "colEmail";
            // 
            // colPhone
            // 
            colPhone.HeaderText = "Phone";
            colPhone.Name = "colPhone";
            // 
            // colGender
            // 
            colGender.HeaderText = "Gender";
            colGender.Name = "colGender";
            // 
            // colBirthDate
            // 
            colBirthDate.HeaderText = "Birth Date";
            colBirthDate.Name = "colBirthDate";
            // 
            // colCreatedAt
            // 
            colCreatedAt.HeaderText = "CreatedAt";
            colCreatedAt.Name = "colCreatedAt";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(981, 510);
            Controls.Add(dgContacts);
            Controls.Add(statusStrip1);
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
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgContacts).EndInit();
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
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private ToolStripStatusLabel lblCounts;
        private ToolStripStatusLabel lblErrorProvider;
        private DataGridView dgContacts;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colGender;
        private DataGridViewTextBoxColumn colBirthDate;
        private DataGridViewTextBoxColumn colCreatedAt;
    }
}
