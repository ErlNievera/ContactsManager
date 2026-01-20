using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsManager
{
    public class GridHelper
    {
        public static void SetupContactsGrid(DataGridView dgContacts, BindingSource contactsSource, BindingList<Contact> contacts)
        {
            contactsSource.DataSource = contacts;
            dgContacts.DataSource = contactsSource;

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
    }
}
