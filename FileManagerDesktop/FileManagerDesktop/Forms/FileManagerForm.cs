using FileManagerDesktop.Models;
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
    public partial class FileManagerForm : Form
    {
        internal readonly IFileService _fileService;
        public FileManagerForm(IFileService fileService)
        {
            InitializeComponent();
            _fileService = fileService;
        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            var filesList = new List<FilesModel>();

            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() != DialogResult.OK)
                return;

            tbSelectedFolder.Text = folderDialog.SelectedPath;

            var files = Directory.EnumerateFiles(tbSelectedFolder.Text).Select(f => new FileInfo(f)).ToList();

            filesList = (from f in files
                         select new FilesModel
                         {
                             FileName = f.Name,
                             FilePath = f.FullName
                         }).ToList();

            dgFiles.DataSource = filesList;
        }

        private void dgFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgFiles.SelectedRows.Count != 0)
            {
                var selectedRow = dgFiles.SelectedRows[0];

                tbFileName.Text = selectedRow.Cells[0].Value.ToString();
                tbFilePath.Text = selectedRow.Cells[1].Value.ToString();
            }
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFilePath.Text))
            {
                MessageBox.Show("There is no selected file!");
                return;
            }

            var result = _fileService.DeleteFile(tbFilePath.Text);

            MessageBox.Show(result == "OK" ? "Successfuly deleted file!" : "File could not be deleted!");
            ClearFormData();
        }

        private void btnMoveFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFilePath.Text))
            {
                MessageBox.Show("There is no selected file!");
                return;
            }

            string movePath = "";
            MessageBox.Show("Choose folder where you want file moved.");
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Could not take folder path!");
                return;
            }

            movePath = folderDialog.SelectedPath;
            if (string.IsNullOrEmpty(movePath))
            {
                MessageBox.Show("There is no selected move folder!");
                return;
            }

            var result = _fileService.MoveFile(tbFilePath.Text, movePath + "\\" + tbFileName.Text);
            MessageBox.Show(result == "OK" ? "Successfuly moved file!" : "File could not be moved!");
            ClearFormData();
        }

        private void btnCopyFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFilePath.Text))
            {
                MessageBox.Show("There is no selected file!");
                return;
            }

            string copyPath = "";
            MessageBox.Show("Choose folder where you want file copied.");
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Could not take folder path!");
                return;
            }

            copyPath = folderDialog.SelectedPath;
            if (string.IsNullOrEmpty(copyPath))
            {
                MessageBox.Show("There is no selected move folder!");
                return;
            }

            var result = _fileService.CopyFile(tbFilePath.Text, copyPath + "\\" + tbFileName.Text);
            MessageBox.Show(result == "OK" ? "Successfuly copied file!" : "File could not be copied!");
            ClearFormData();
        }

        private void ClearFormData()
        {
            tbFileName.Clear();
            tbFilePath.Clear();
            tbSelectedFolder.Clear();
            dgFiles.DataSource = null;

        }
    }
}
