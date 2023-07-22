using System;
using System.Windows.Forms;

namespace CRUDWinFormsMVP.Views
{
    public partial class PetView : Form, IPetView
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        //Constructor
        public PetView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            TabControl1.TabPages.Remove(TabPetDetail);
            BtnClose.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            //Search
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            //Add new
            BtnAddNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                TabControl1.TabPages.Remove(TabPetList);
                TabControl1.TabPages.Add(TabPetDetail);
                TabPetDetail.Text = "Add new pet";
            };
            //Edit
            BtnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                TabControl1.TabPages.Remove(TabPetList);
                TabControl1.TabPages.Add(TabPetDetail);
                TabPetDetail.Text = "Edit pet";
            };
            //Save changes
            BtnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    TabControl1.TabPages.Remove(TabPetDetail);
                    TabControl1.TabPages.Add(TabPetList);
                }
                MessageBox.Show(Message);
            };
            //Cancel
            BtnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                TabControl1.TabPages.Remove(TabPetDetail);
                TabControl1.TabPages.Add(TabPetList);
            };
            //Delete
            BtnDelete.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected pet?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }

        //Properties
        public string PetId { get => TxtPetID.Text; set => TxtPetID.Text = value; }
        public string PetName { get => TxtPetName.Text; set => TxtPetName.Text = value; }
        public string PetType { get => TxtPetType.Text; set => TxtPetType.Text = value; }
        public string PetColour { get => TxtPetColour.Text; set => TxtPetColour.Text = value; }
        public string SearchValue { get => TxtSearch.Text; set => TxtSearch.Text = value; }
        public bool IsEdit { get => isEdit; set => isEdit = value; }
        public bool IsSuccessful { get => isSuccessful; set => isSuccessful = value; }
        public string Message { get => message; set => message = value; }

        //Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        //Methods
        public void SetPetListBindingSource(BindingSource petList)
        {
            DgvPet.DataSource = petList;
        }

        //Singleton pattern (Open a single form instance)
        private static PetView instance;
        public static PetView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new PetView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }
    }
}
