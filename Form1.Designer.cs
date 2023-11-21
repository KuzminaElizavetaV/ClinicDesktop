namespace ClinicDesktop
{
    partial class MainForm
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
            listViewClients = new ListView();
            columnHeaderClientID = new ColumnHeader();
            columnHeaderSurname = new ColumnHeader();
            columnHeaderFirstName = new ColumnHeader();
            columnHeaderPatronomic = new ColumnHeader();
            columnHeaderClientDocument = new ColumnHeader();
            columnHeaderClientBirth = new ColumnHeader();
            columnHeaderClientPhone = new ColumnHeader();
            columnHeaderClientEmail = new ColumnHeader();
            loadClients = new Button();
            addClient = new Button();
            deleteClient = new Button();
            editClient = new Button();
            textBoxSurname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxName = new TextBox();
            label3 = new Label();
            textBoxPatronomic = new TextBox();
            label4 = new Label();
            textBoxDocument = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBoxPhone = new TextBox();
            label7 = new Label();
            textBoxEmail = new TextBox();
            dateTimePickerBirthday = new DateTimePicker();
            updateClient = new Button();
            label_ID = new Label();
            textBoxID = new TextBox();
            buttonPets = new Button();
            buttonConsultations = new Button();
            SuspendLayout();
            // 
            // listViewClients
            // 
            listViewClients.BackColor = SystemColors.MenuBar;
            listViewClients.Columns.AddRange(new ColumnHeader[] { columnHeaderClientID, columnHeaderSurname, columnHeaderFirstName, columnHeaderPatronomic, columnHeaderClientDocument, columnHeaderClientBirth, columnHeaderClientPhone, columnHeaderClientEmail });
            listViewClients.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            listViewClients.FullRowSelect = true;
            listViewClients.GridLines = true;
            listViewClients.Location = new Point(16, 9);
            listViewClients.MultiSelect = false;
            listViewClients.Name = "listViewClients";
            listViewClients.Size = new Size(768, 275);
            listViewClients.TabIndex = 0;
            listViewClients.UseCompatibleStateImageBehavior = false;
            listViewClients.View = View.Details;
            // 
            // columnHeaderClientID
            // 
            columnHeaderClientID.Text = "ID";
            columnHeaderClientID.Width = 40;
            // 
            // columnHeaderSurname
            // 
            columnHeaderSurname.Text = "Фамилия";
            columnHeaderSurname.TextAlign = HorizontalAlignment.Center;
            columnHeaderSurname.Width = 100;
            // 
            // columnHeaderFirstName
            // 
            columnHeaderFirstName.Text = "Имя";
            columnHeaderFirstName.TextAlign = HorizontalAlignment.Center;
            columnHeaderFirstName.Width = 100;
            // 
            // columnHeaderPatronomic
            // 
            columnHeaderPatronomic.Text = "Отчество";
            columnHeaderPatronomic.TextAlign = HorizontalAlignment.Center;
            columnHeaderPatronomic.Width = 100;
            // 
            // columnHeaderClientDocument
            // 
            columnHeaderClientDocument.Text = "Документ";
            columnHeaderClientDocument.TextAlign = HorizontalAlignment.Center;
            columnHeaderClientDocument.Width = 100;
            // 
            // columnHeaderClientBirth
            // 
            columnHeaderClientBirth.Text = "Дата рождения";
            columnHeaderClientBirth.TextAlign = HorizontalAlignment.Center;
            columnHeaderClientBirth.Width = 120;
            // 
            // columnHeaderClientPhone
            // 
            columnHeaderClientPhone.Text = "Телефон";
            columnHeaderClientPhone.TextAlign = HorizontalAlignment.Center;
            columnHeaderClientPhone.Width = 100;
            // 
            // columnHeaderClientEmail
            // 
            columnHeaderClientEmail.Text = "Email";
            columnHeaderClientEmail.TextAlign = HorizontalAlignment.Center;
            columnHeaderClientEmail.Width = 100;
            // 
            // loadClients
            // 
            loadClients.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            loadClients.Location = new Point(16, 299);
            loadClients.Name = "loadClients";
            loadClients.Size = new Size(154, 48);
            loadClients.TabIndex = 1;
            loadClients.Text = "Загрузить данные";
            loadClients.UseVisualStyleBackColor = true;
            loadClients.Click += LoadClients_Click;
            // 
            // addClient
            // 
            addClient.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            addClient.Location = new Point(661, 385);
            addClient.Name = "addClient";
            addClient.Size = new Size(123, 33);
            addClient.TabIndex = 2;
            addClient.Text = "Добавить";
            addClient.UseVisualStyleBackColor = true;
            addClient.Click += AddClient_Click;
            // 
            // deleteClient
            // 
            deleteClient.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            deleteClient.Location = new Point(344, 299);
            deleteClient.Name = "deleteClient";
            deleteClient.Size = new Size(132, 48);
            deleteClient.TabIndex = 3;
            deleteClient.Text = "Удалить";
            deleteClient.UseVisualStyleBackColor = true;
            deleteClient.Click += DeleteClient_Click;
            // 
            // editClient
            // 
            editClient.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            editClient.Location = new Point(187, 299);
            editClient.Name = "editClient";
            editClient.Size = new Size(137, 48);
            editClient.TabIndex = 4;
            editClient.Text = "Редактировать";
            editClient.UseVisualStyleBackColor = true;
            editClient.Click += EditClient_Click;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(111, 385);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(188, 23);
            textBoxSurname.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 393);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 6;
            label1.Text = "Фамилия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(328, 393);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 8;
            label2.Text = "Имя";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(419, 385);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(188, 23);
            textBoxName.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 435);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 10;
            label3.Text = "Отчество";
            // 
            // textBoxPatronomic
            // 
            textBoxPatronomic.Location = new Point(112, 427);
            textBoxPatronomic.Name = "textBoxPatronomic";
            textBoxPatronomic.Size = new Size(188, 23);
            textBoxPatronomic.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(329, 435);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 12;
            label4.Text = "Документ";
            // 
            // textBoxDocument
            // 
            textBoxDocument.Location = new Point(419, 427);
            textBoxDocument.Name = "textBoxDocument";
            textBoxDocument.Size = new Size(188, 23);
            textBoxDocument.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 481);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 14;
            label5.Text = "Дата рождения";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(330, 482);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 16;
            label6.Text = "Телефон";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(419, 474);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(188, 23);
            textBoxPhone.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 530);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 18;
            label7.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(112, 522);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(188, 23);
            textBoxEmail.TabIndex = 17;
            // 
            // dateTimePickerBirthday
            // 
            dateTimePickerBirthday.Location = new Point(112, 476);
            dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            dateTimePickerBirthday.Size = new Size(187, 23);
            dateTimePickerBirthday.TabIndex = 13;
            dateTimePickerBirthday.TabStop = false;
            // 
            // updateClient
            // 
            updateClient.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            updateClient.Location = new Point(661, 463);
            updateClient.Name = "updateClient";
            updateClient.Size = new Size(123, 33);
            updateClient.TabIndex = 19;
            updateClient.Text = "Обновить";
            updateClient.UseVisualStyleBackColor = true;
            updateClient.Visible = false;
            updateClient.Click += UpdateClient_Click;
            // 
            // label_ID
            // 
            label_ID.AutoSize = true;
            label_ID.Location = new Point(331, 530);
            label_ID.Name = "label_ID";
            label_ID.Size = new Size(21, 15);
            label_ID.TabIndex = 21;
            label_ID.Text = " ID";
            label_ID.Visible = false;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(420, 522);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(67, 23);
            textBoxID.TabIndex = 20;
            textBoxID.Visible = false;
            // 
            // buttonPets
            // 
            buttonPets.Enabled = false;
            buttonPets.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPets.Location = new Point(499, 299);
            buttonPets.Name = "buttonPets";
            buttonPets.Size = new Size(132, 48);
            buttonPets.TabIndex = 22;
            buttonPets.Text = "Питомцы";
            buttonPets.UseVisualStyleBackColor = true;
            // 
            // buttonConsultations
            // 
            buttonConsultations.Cursor = Cursors.SizeNESW;
            buttonConsultations.Enabled = false;
            buttonConsultations.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonConsultations.Location = new Point(652, 299);
            buttonConsultations.Name = "buttonConsultations";
            buttonConsultations.Size = new Size(132, 48);
            buttonConsultations.TabIndex = 23;
            buttonConsultations.Text = "Консультации";
            buttonConsultations.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 582);
            Controls.Add(buttonConsultations);
            Controls.Add(buttonPets);
            Controls.Add(label_ID);
            Controls.Add(textBoxID);
            Controls.Add(updateClient);
            Controls.Add(dateTimePickerBirthday);
            Controls.Add(label7);
            Controls.Add(textBoxEmail);
            Controls.Add(label6);
            Controls.Add(textBoxPhone);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxDocument);
            Controls.Add(label3);
            Controls.Add(textBoxPatronomic);
            Controls.Add(label2);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Controls.Add(textBoxSurname);
            Controls.Add(editClient);
            Controls.Add(deleteClient);
            Controls.Add(addClient);
            Controls.Add(loadClients);
            Controls.Add(listViewClients);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Моя клиника";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewClients;
        private Button loadClients;
        private Button addClient;
        private Button deleteClient;
        private Button editClient;
        private ColumnHeader columnHeaderClientID;
        private ColumnHeader columnHeaderSurname;
        private ColumnHeader columnHeaderFirstName;
        private ColumnHeader columnHeaderPatronomic;
        private ColumnHeader columnHeaderClientDocument;
        private ColumnHeader columnHeaderClientBirth;
        private TextBox textBoxSurname;
        private Label label1;
        private Label label2;
        private TextBox textBoxName;
        private Label label3;
        private TextBox textBoxPatronomic;
        private Label label4;
        private TextBox textBoxDocument;
        private ColumnHeader columnHeaderClientPhone;
        private Label label5;
        private Label label6;
        private TextBox textBoxPhone;
        private ColumnHeader columnHeaderClientEmail;
        private Label label7;
        private TextBox textBoxEmail;
        private DateTimePicker dateTimePickerBirthday;
        private Button updateClient;
        private Label label_ID;
        private TextBox textBoxID;
        private Button buttonPets;
        private Button buttonConsultations;
    }
}
