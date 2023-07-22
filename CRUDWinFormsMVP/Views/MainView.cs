using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CRUDWinFormsMVP.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            BtnPets.Click += delegate { ShowPetView?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler ShowPetView;
        public event EventHandler ShowOwnerView;
        public event EventHandler ShowVetsView;

        private void LinkSource_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/RJCodeAdvance/CRUD-MVP-C-SHARP-SQL-WINFORMS-PART-3-FINAL.git");
        }
    }
}
