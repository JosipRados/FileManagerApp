using FileManagerDesktop.Services;
using FileManagerDesktop.Services.Implementation;
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
    public partial class LoginForm : Form
    {
        private readonly IAuthenticationService _authService;
        private readonly IFileService _fileService;
        private readonly FileManagerForm _frmFileManager;
        public LoginForm(IAuthenticationService authService, IFileService fileService, FileManagerForm frmFileManager)
        {
            InitializeComponent();
            _fileService = fileService;
            _frmFileManager = frmFileManager;
            _authService = authService;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //_frmFileManager.ShowDialog();
            var response = _authService.AuthenticateUser(tbUsername.Text, tbPassword.Text);
            if (response == "OK")
                _frmFileManager.ShowDialog();
            else
                MessageBox.Show(response);
        }
    }
}
