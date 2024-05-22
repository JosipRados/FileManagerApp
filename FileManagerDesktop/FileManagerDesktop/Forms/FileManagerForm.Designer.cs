namespace FileManagerDesktop.Forms
{
    partial class FileManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tbFileName = new TextBox();
            btnChooseFolder = new Button();
            label1 = new Label();
            dgFiles = new DataGridView();
            fileNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            filePathDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            filesModelBindingSource = new BindingSource(components);
            btnCopyFile = new Button();
            btnMoveFile = new Button();
            btnDeleteFile = new Button();
            label2 = new Label();
            tbFilePath = new TextBox();
            label3 = new Label();
            tbSelectedFolder = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgFiles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filesModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tbFileName
            // 
            tbFileName.Location = new Point(58, 126);
            tbFileName.Name = "tbFileName";
            tbFileName.ReadOnly = true;
            tbFileName.Size = new Size(328, 27);
            tbFileName.TabIndex = 0;
            // 
            // btnChooseFolder
            // 
            btnChooseFolder.Location = new Point(58, 46);
            btnChooseFolder.Name = "btnChooseFolder";
            btnChooseFolder.Size = new Size(328, 42);
            btnChooseFolder.TabIndex = 1;
            btnChooseFolder.Text = "CHOOSE FOLDER";
            btnChooseFolder.UseVisualStyleBackColor = true;
            btnChooseFolder.Click += btnChooseFolder_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 103);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 2;
            label1.Text = "File Name:";
            // 
            // dgFiles
            // 
            dgFiles.AllowUserToAddRows = false;
            dgFiles.AllowUserToDeleteRows = false;
            dgFiles.AllowUserToResizeColumns = false;
            dgFiles.AllowUserToResizeRows = false;
            dgFiles.AutoGenerateColumns = false;
            dgFiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgFiles.Columns.AddRange(new DataGridViewColumn[] { fileNameDataGridViewTextBoxColumn, filePathDataGridViewTextBoxColumn });
            dgFiles.DataSource = filesModelBindingSource;
            dgFiles.Location = new Point(440, 46);
            dgFiles.MultiSelect = false;
            dgFiles.Name = "dgFiles";
            dgFiles.ReadOnly = true;
            dgFiles.RowHeadersVisible = false;
            dgFiles.RowHeadersWidth = 51;
            dgFiles.ScrollBars = ScrollBars.Vertical;
            dgFiles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgFiles.Size = new Size(474, 437);
            dgFiles.TabIndex = 3;
            dgFiles.CellClick += dgFiles_CellClick;
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            fileNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            fileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName";
            fileNameDataGridViewTextBoxColumn.HeaderText = "Name";
            fileNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            fileNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filePathDataGridViewTextBoxColumn
            // 
            filePathDataGridViewTextBoxColumn.DataPropertyName = "FilePath";
            filePathDataGridViewTextBoxColumn.HeaderText = "Path";
            filePathDataGridViewTextBoxColumn.MinimumWidth = 6;
            filePathDataGridViewTextBoxColumn.Name = "filePathDataGridViewTextBoxColumn";
            filePathDataGridViewTextBoxColumn.ReadOnly = true;
            filePathDataGridViewTextBoxColumn.Visible = false;
            filePathDataGridViewTextBoxColumn.Width = 125;
            // 
            // filesModelBindingSource
            // 
            filesModelBindingSource.DataSource = typeof(Models.FilesModel);
            // 
            // btnCopyFile
            // 
            btnCopyFile.Location = new Point(128, 358);
            btnCopyFile.Name = "btnCopyFile";
            btnCopyFile.Size = new Size(258, 29);
            btnCopyFile.TabIndex = 4;
            btnCopyFile.Text = "COPY FILE";
            btnCopyFile.UseVisualStyleBackColor = true;
            btnCopyFile.Click += btnCopyFile_Click;
            // 
            // btnMoveFile
            // 
            btnMoveFile.Location = new Point(128, 393);
            btnMoveFile.Name = "btnMoveFile";
            btnMoveFile.Size = new Size(258, 29);
            btnMoveFile.TabIndex = 5;
            btnMoveFile.Text = "MOVE FILE";
            btnMoveFile.UseVisualStyleBackColor = true;
            btnMoveFile.Click += btnMoveFile_Click;
            // 
            // btnDeleteFile
            // 
            btnDeleteFile.Location = new Point(128, 454);
            btnDeleteFile.Name = "btnDeleteFile";
            btnDeleteFile.Size = new Size(258, 29);
            btnDeleteFile.TabIndex = 6;
            btnDeleteFile.Text = "DELETE FILE";
            btnDeleteFile.UseVisualStyleBackColor = true;
            btnDeleteFile.Click += btnDeleteFile_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 174);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 8;
            label2.Text = "File Path:";
            // 
            // tbFilePath
            // 
            tbFilePath.Location = new Point(58, 197);
            tbFilePath.Name = "tbFilePath";
            tbFilePath.ReadOnly = true;
            tbFilePath.Size = new Size(328, 27);
            tbFilePath.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 245);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 10;
            label3.Text = "Selected Folder:";
            // 
            // tbSelectedFolder
            // 
            tbSelectedFolder.Location = new Point(58, 268);
            tbSelectedFolder.Name = "tbSelectedFolder";
            tbSelectedFolder.ReadOnly = true;
            tbSelectedFolder.Size = new Size(328, 27);
            tbSelectedFolder.TabIndex = 9;
            // 
            // FileManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 514);
            Controls.Add(label3);
            Controls.Add(tbSelectedFolder);
            Controls.Add(label2);
            Controls.Add(tbFilePath);
            Controls.Add(btnDeleteFile);
            Controls.Add(btnMoveFile);
            Controls.Add(btnCopyFile);
            Controls.Add(dgFiles);
            Controls.Add(label1);
            Controls.Add(btnChooseFolder);
            Controls.Add(tbFileName);
            Name = "FileManagerForm";
            Text = "FileManagerForm";
            ((System.ComponentModel.ISupportInitialize)dgFiles).EndInit();
            ((System.ComponentModel.ISupportInitialize)filesModelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbFileName;
        private Button btnChooseFolder;
        private Label label1;
        private DataGridView dgFiles;
        private Button btnCopyFile;
        private Button btnMoveFile;
        private Button btnDeleteFile;
        private Label label2;
        private TextBox tbFilePath;
        private DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn filePathDataGridViewTextBoxColumn;
        private BindingSource filesModelBindingSource;
        private Label label3;
        private TextBox tbSelectedFolder;
    }
}