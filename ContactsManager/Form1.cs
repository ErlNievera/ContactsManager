using System.ComponentModel;

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
            InitializeComboBoxes();

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
        }
        private void InitializeComboBoxes()
        {
            cmbGender.Items.AddRange(new[]
            {
                "Male", "Female", "Non-binary", "Prefer not to say"
            });

            cmbFilterGender.Items.AddRange(new[]
            {
                "All", "Male", "Female", "Non-binary", "Prefer not to say"
            });

            cmbFilterGender.SelectedIndex = 0;
        }
    }
}
