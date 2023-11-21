
using ClinicDesktopApi;
using System.Collections.ObjectModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ClinicDesktop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Update_listViewClients()
        {
            ClientClinic clientClinic = new("http://127.0.0.1:8000/", new HttpClient());
            List<Client> clients = clientClinic.ClientGetAllAsync().Result.ToList();
            listViewClients.Items.Clear();
            foreach (Client client in clients)
            {
                if (client != null)
                {
                    ListViewItem item = new()
                    {
                        Text = client.Id.ToString()
                    };

                    ListViewItem.ListViewSubItem subItem1 = new()
                    {
                        Text = client.Surname
                    };
                    item.SubItems.Add(subItem1);

                    ListViewItem.ListViewSubItem subItem2 = new()
                    {
                        Text = client.Firstname
                    };
                    item.SubItems.Add(subItem2);

                    ListViewItem.ListViewSubItem subItem3 = new()
                    {
                        Text = client.Patronymic
                    };
                    item.SubItems.Add(subItem3);

                    ListViewItem.ListViewSubItem subItem4 = new()
                    {
                        Text = client.Document
                    };
                    item.SubItems.Add(subItem4);

                    ListViewItem.ListViewSubItem subItem5 = new()
                    {
                        Text = client.Birthday.ToString()
                    };
                    item.SubItems.Add(subItem5);

                    ListViewItem.ListViewSubItem subItem6 = new()
                    {
                        Text = client.Phone
                    };
                    item.SubItems.Add(subItem6);

                    ListViewItem.ListViewSubItem subItem7 = new()
                    {
                        Text = client.Email
                    };
                    item.SubItems.Add(subItem7);

                    listViewClients.Items.Add(item);

                }
            }

        }

        private void LoadClients_Click(object sender, EventArgs e)
        {
            Update_listViewClients();
        }


        private void AddClient_Click(object sender, EventArgs e)
        {
            ClientIn clientIn = new()
            {
                Surname = textBoxSurname.Text,
                Firstname = textBoxName.Text,
                Patronymic = textBoxPatronomic.Text,
                Document = textBoxDocument.Text,
                Birthday = dateTimePickerBirthday.Value,
                Phone = textBoxPhone.Text,
                Email = textBoxEmail.Text,
            };

            if (clientIn != null)
            {
                ClientClinic clientClinic1 = new("http://127.0.0.1:8000/", new HttpClient());
                clientClinic1.ClientAddAsync(clientIn);

                textBoxSurname.Text = null;
                textBoxName.Text = null;
                textBoxPatronomic.Text = null;
                textBoxDocument.Text = null;
                dateTimePickerBirthday.Text = null;
                textBoxPhone.Text = null;
                textBoxEmail.Text = null;
                
            }
            Update_listViewClients();

        }



        private void DeleteClient_Click(object sender, EventArgs e)
        {
            if (listViewClients.FocusedItem != null)
            {
                ClientClinic clientClinic2 = new("http://127.0.0.1:8000/", new HttpClient());
                String item = listViewClients.FocusedItem.Text;
                int clientId = Int32.Parse(item);
                clientClinic2.ClientDeleteAsync(clientId);
                
            }
            Update_listViewClients();



        }
        private void EditClient_Click(object sender, EventArgs e)
        {
            loadClients.Enabled = false;
            editClient.Enabled = false;
            deleteClient.Enabled = false;
            addClient.Visible = false;
            updateClient.Visible = true;
            label_ID.Visible = true;
            textBoxID.Visible = true;
            if (listViewClients.FocusedItem != null)
            {
                ClientClinic clientClinic3 = new("http://127.0.0.1:8000/", new HttpClient());
                String item = listViewClients.FocusedItem.Text;
                int clientId = Int32.Parse(item);
                Client client = clientClinic3.ClientGetAsync(clientId).Result;
                if (client != null)
                {
                    textBoxSurname.Text = client.Surname;
                    textBoxName.Text = client.Firstname;
                    textBoxPatronomic.Text = client.Patronymic;
                    textBoxDocument.Text = client.Document;
                    dateTimePickerBirthday.Text = client.Birthday.ToString();
                    textBoxPhone.Text = client.Phone;
                    textBoxEmail.Text = client.Email;
                    textBoxID.Text = client.Id.ToString();
                }
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void UpdateClient_Click(object sender, EventArgs e)
        {
            ClientIn clientIn = new()
            {
                Surname = textBoxSurname.Text,
                Firstname = textBoxName.Text,
                Patronymic = textBoxPatronomic.Text,
                Document = textBoxDocument.Text,
                Birthday = dateTimePickerBirthday.Value,
                Phone = textBoxPhone.Text,
                Email = textBoxEmail.Text,
            };

            if (clientIn != null && textBoxID != null)
            {
                int clientID = Int32.Parse(textBoxID.Text);
                ClientClinic clientClinic4 = new("http://127.0.0.1:8000/", new HttpClient());
                clientClinic4.ClientUpdateAsync(clientID, clientIn);
               
                textBoxSurname.Text = null;
                textBoxName.Text = null;
                textBoxPatronomic.Text = null;
                textBoxDocument.Text = null;
                dateTimePickerBirthday.Text = null;
                textBoxPhone.Text = null;
                textBoxEmail.Text = null;
                label_ID.Visible = false;
                textBoxID.Visible = false;
                addClient.Visible = true;
                updateClient.Visible = false;
                loadClients.Enabled = true;
                editClient.Enabled = true;
                deleteClient.Enabled = true;
            }
            Update_listViewClients();
        }
    }
}

