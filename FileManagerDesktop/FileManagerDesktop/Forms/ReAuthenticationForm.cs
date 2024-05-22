using FileManagerDesktop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManagerDesktop.Forms
{
    public partial class ReAuthenticationForm : Form
    {
        private readonly IAuthenticationService _authService;
        public string response = "";

        public ReAuthenticationForm(IAuthenticationService authService)
        {
            InitializeComponent();
            _authService = authService;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            response = _authService.AuthenticateUser(tbEmail.Text, tbPassword.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
