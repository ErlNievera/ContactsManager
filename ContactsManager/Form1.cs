using System.ComponentModel;
using System.Text;

namespace ContactsManager
{
    public partial class Form1 : Form
    {
        private readonly BindingList<Contact> _contacts = new();
        private BindingSource _contactsSource = new();
        public Form1()
        {
            InitializeComponent();
            InitializeDataGrid();

            _contacts.Add(new Contact
            {
                FullName = "Erl Nievera",
                Email = "erlnievera@gmail.com",
                Phone = "091105021508",
                Gender = "Male",
                BirthDate = new DateTime(2004, 11, 5)
            });
        }
        private void InitializeDataGrid()
        {
            _contactsSource.DataSource = _contacts;
            dgContacts.DataSource = _contactsSource;
            

            dgContacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgContacts.ReadOnly = true;
            dgContacts.AllowUserToAddRows = false;
            dgContacts.AutoGenerateColumns = false;

            dgContacts.Columns.Clear();

            dgContacts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FullName",
                HeaderText = "Full Name",
                Width = 150
            });
            dgContacts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Email",
                HeaderText = "Email",
                Width = 200
            });
            dgContacts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Phone",
                HeaderText = "Phone",
                Width = 120
            });
            dgContacts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Gender",
                HeaderText = "Gender",
                Width = 100
            });
            dgContacts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "BirthDate",
                HeaderText = "Birth Date",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "d" } 
            });
            dgContacts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CreatedAt",
                HeaderText = "Created At",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "g" } 
            });
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            bool isValid =
                IsValidFullName() &
                IsValidEmail() &
                IsValidGender();

            if (!isValid)
            {
                DisplayStatus("Please fix validation errors.", true);
                return;
            }

            var contact = new Contact
            {
                FullName = txtFullName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Phone = mtbPhone.Text.Trim(),
                Gender = cmbGender.SelectedItem.ToString(),
                BirthDate = dtpBirthDate.Value
            };

            _contacts.Add(contact);
            ClearInputs();
            UpdateCounts();
            DisplayStatus($"Added: {contact.FullName}");
        }
        private void DisplayStatus(string message, bool isError = false)
        {
            lblStatus.Text = message;
            lblStatus.ForeColor = isError ? Color.Red : Color.Black;
        }

        private bool IsValidFullName()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                errorProvider.SetError(txtFullName, "Full name is required.");
                return false;
            }

            if (txtFullName.Text.Any(char.IsDigit))
            {
                errorProvider.SetError(txtFullName, "No numbers allowed in name.");
                return false;
            }

            errorProvider.SetError(txtFullName, "");
            return true;
        }
        private bool IsValidEmail(Contact ignoreContact = null)
        {
            string email = txtEmail.Text.Trim();

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
            }
            catch
            {
                errorProvider.SetError(txtEmail, "Invalid email format.");
                return false;
            }

            bool exists = _contacts.Any(c =>
                c.Email.Equals(email, StringComparison.OrdinalIgnoreCase)
                && c != ignoreContact);

            if (exists)
            {
                errorProvider.SetError(txtEmail, "Email already exists.");
                return false;
            }

            errorProvider.SetError(txtEmail, "");
            return true;
        }
        private bool IsValidGender()
        {
            if (cmbGender.SelectedIndex < 0)
            {
                errorProvider.SetError(cmbGender, "Please select a gender.");
                return false;
            }

            errorProvider.SetError(cmbGender, "");
            return true;
        }
        private void ClearInputs()
        {
            txtFullName.Clear();
            txtEmail.Clear();
            mtbPhone.Clear();
            cmbGender.SelectedIndex = -1;
            dtpBirthDate.Value = DateTime.Today;
        }

        private void UpdateCounts()
        {
            lblCounts.Text = $"Visible: {_contactsSource.Count} / Total: {_contacts.Count}";
        }

        private void btnUpdateContact_Click(object sender, EventArgs e)
        {
            if (dgContacts.SelectedRows.Count == 0)
            {
                DisplayStatus("No contact selected.");
                return;
            }

            var selected = dgContacts.SelectedRows[0].DataBoundItem as Contact;

            errorProvider.Clear();

            bool isValid =
                IsValidFullName() &&
                IsValidEmail(selected) &&
                IsValidGender();

            if (!isValid)
            {
                DisplayStatus("Please fix validation errors.");
                return;
            }

            selected.FullName = txtFullName.Text.Trim();
            selected.Email = txtEmail.Text.Trim();
            selected.Phone = mtbPhone.Text.Trim();
            selected.Gender = cmbGender.SelectedItem.ToString();
            selected.BirthDate = dtpBirthDate.Value;

            _contactsSource.ResetBindings(false);
            UpdateCounts();
            DisplayStatus($"Updated: {selected.FullName}");
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (dgContacts.SelectedRows.Count == 0)
            {
                DisplayStatus("No contact selected.");
                return;
            }

            if (chkConfirmDelete.Checked)
            {
                if (dgContacts.SelectedRows.Count == 0)
                {
                    DisplayStatus("No contact selected.");
                    return;
                }

                if (chkConfirmDelete.Checked)
                {
                    var result = MessageBox.Show(
                        "Are you sure you want to delete the selected contact(s)?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result != DialogResult.Yes)
                    {
                        DisplayStatus("Delete cancelled.");
                        return; 
                    }
                }

                foreach (DataGridViewRow row in dgContacts.SelectedRows)
                {
                    var contact = row.DataBoundItem as Contact;
                    if (contact != null)
                        _contacts.Remove(contact);
                }
                _contactsSource.ResetBindings(false);
                UpdateCounts();
                DisplayStatus("Selected contact(s) removed.");
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            if (_contacts.Count == 0)
            {
                DisplayStatus("No contacts to clear.");
                return;
            }

            var result = MessageBox.Show("Are you sure you want to clear all contacts?",
                "Confirm Clear All", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
                return;

            _contacts.Clear();
            _contactsSource.ResetBindings(false);
            UpdateCounts();
            DisplayStatus("All contacts cleared.");
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            string genderFilter = cmbFilterGender.SelectedItem.ToString();
            string searchText = txtSearch.Text.Trim().ToLower();

            var filtered = _contacts.Where(c =>
                (genderFilter == "All" || c.Gender == genderFilter) &&
                (c.FullName.ToLower().Contains(searchText) || c.Email.ToLower().Contains(searchText))
            ).ToList();

            _contactsSource.DataSource = filtered;
            _contactsSource.ResetBindings(false);
            UpdateCounts();
            DisplayStatus($"Filter applied ({filtered.Count} contacts).");
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            _contactsSource.DataSource = _contacts;
            _contactsSource.ResetBindings(false);
            cmbFilterGender.SelectedIndex = 0;
            txtSearch.Clear();
            UpdateCounts();
            DisplayStatus("Filter reset.");
        }
        private void dgContacts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgContacts.SelectedRows.Count == 0) return;

            var contact = dgContacts.SelectedRows[0].DataBoundItem as Contact;

            txtFullName.Text = contact.FullName;
            txtEmail.Text = contact.Email;
            mtbPhone.Text = contact.Phone;
            cmbGender.SelectedItem = contact.Gender;
            dtpBirthDate.Value = contact.BirthDate ?? DateTime.Today;

            DisplayStatus($"Selected: {contact.FullName} | Email: {contact.Email}");
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            if (dgContacts.Rows.Count == 0)
            {
                MessageBox.Show("No contacts to export.", "Export CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
                saveFileDialog.FileName = "Contacts.csv";

                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    StringBuilder csv = new StringBuilder();
                    for (int i = 0; i < dgContacts.Columns.Count; i++)
                    {
                        csv.Append(dgContacts.Columns[i].HeaderText);
                        if (i < dgContacts.Columns.Count - 1)
                            csv.Append(",");
                    }
                    csv.AppendLine();
                    foreach (DataGridViewRow row in dgContacts.Rows)
                    {
                        if (row.IsNewRow) continue;

                        for (int i = 0; i < dgContacts.Columns.Count; i++)
                        {
                            string value = row.Cells[i].Value?.ToString() ?? "";
                            value = value.Replace("\"", "\"\"");
                            csv.Append($"\"{value}\"");
                            if (i < dgContacts.Columns.Count - 1)
                                csv.Append(",");
                        }
                        csv.AppendLine();
                    }

                    File.WriteAllText(saveFileDialog.FileName, csv.ToString(), Encoding.UTF8);
                    MessageBox.Show("Export completed successfully!", "Export CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error exporting CSV:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
