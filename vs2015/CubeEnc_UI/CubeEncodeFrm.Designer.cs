namespace CubeEnc_UI
{
    partial class CubeEncodeFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CubeEncodeFrm));
            EncodeBtn = new Button();
            OutputBtn = new Button();
            label2 = new Label();
            OutputFolderTB = new TextBox();
            label1 = new Label();
            OpenFileBtn = new Button();
            FilePathTB = new TextBox();
            EncoderSelBtn = new Button();
            EncoderPath = new TextBox();
            cubeEncodeFrmBindingSource = new BindingSource(components);
            FilenameCB = new CheckBox();
            FolderCB = new CheckBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)cubeEncodeFrmBindingSource).BeginInit();
            SuspendLayout();
            // 
            // EncodeBtn
            // 
            EncodeBtn.Location = new Point(600, 131);
            EncodeBtn.Margin = new Padding(2, 2, 2, 2);
            EncodeBtn.Name = "EncodeBtn";
            EncodeBtn.Size = new Size(78, 20);
            EncodeBtn.TabIndex = 13;
            EncodeBtn.Text = "Encode";
            EncodeBtn.UseVisualStyleBackColor = true;
            EncodeBtn.Click += EncodeBtn_Click;
            // 
            // OutputBtn
            // 
            OutputBtn.Image = (Image)resources.GetObject("OutputBtn.Image");
            OutputBtn.Location = new Point(682, 98);
            OutputBtn.Margin = new Padding(2, 2, 2, 2);
            OutputBtn.Name = "OutputBtn";
            OutputBtn.Size = new Size(43, 19);
            OutputBtn.TabIndex = 12;
            OutputBtn.UseVisualStyleBackColor = true;
            OutputBtn.Click += OutputBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 100);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 11;
            label2.Text = "Save To";
            // 
            // OutputFolderTB
            // 
            OutputFolderTB.Location = new Point(109, 98);
            OutputFolderTB.Margin = new Padding(2, 2, 2, 2);
            OutputFolderTB.Name = "OutputFolderTB";
            OutputFolderTB.Size = new Size(570, 23);
            OutputFolderTB.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 64);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 9;
            label1.Text = "Open File";
            // 
            // OpenFileBtn
            // 
            OpenFileBtn.Image = (Image)resources.GetObject("OpenFileBtn.Image");
            OpenFileBtn.Location = new Point(682, 62);
            OpenFileBtn.Margin = new Padding(2, 2, 2, 2);
            OpenFileBtn.Name = "OpenFileBtn";
            OpenFileBtn.Size = new Size(43, 19);
            OpenFileBtn.TabIndex = 8;
            OpenFileBtn.UseVisualStyleBackColor = true;
            OpenFileBtn.Click += OpenFileBtn_Click;
            // 
            // FilePathTB
            // 
            FilePathTB.Location = new Point(109, 62);
            FilePathTB.Margin = new Padding(2, 2, 2, 2);
            FilePathTB.Name = "FilePathTB";
            FilePathTB.Size = new Size(570, 23);
            FilePathTB.TabIndex = 7;
            // 
            // EncoderSelBtn
            // 
            EncoderSelBtn.Image = (Image)resources.GetObject("EncoderSelBtn.Image");
            EncoderSelBtn.Location = new Point(682, 179);
            EncoderSelBtn.Margin = new Padding(2, 2, 2, 2);
            EncoderSelBtn.Name = "EncoderSelBtn";
            EncoderSelBtn.Size = new Size(43, 19);
            EncoderSelBtn.TabIndex = 16;
            EncoderSelBtn.UseVisualStyleBackColor = true;
            EncoderSelBtn.Click += EncoderSelBtn_Click;
            // 
            // EncoderPath
            // 
            EncoderPath.Location = new Point(109, 179);
            EncoderPath.Margin = new Padding(2, 2, 2, 2);
            EncoderPath.Name = "EncoderPath";
            EncoderPath.Size = new Size(570, 23);
            EncoderPath.TabIndex = 15;
            // 
            // cubeEncodeFrmBindingSource
            // 
            cubeEncodeFrmBindingSource.DataSource = typeof(CubeEncodeFrm);
            // 
            // FilenameCB
            // 
            FilenameCB.AutoSize = true;
            FilenameCB.Location = new Point(284, 131);
            FilenameCB.Margin = new Padding(2, 2, 2, 2);
            FilenameCB.Name = "FilenameCB";
            FilenameCB.Size = new Size(158, 19);
            FilenameCB.TabIndex = 17;
            FilenameCB.Text = "Output to same filename";
            FilenameCB.UseVisualStyleBackColor = true;
            FilenameCB.CheckedChanged += FileCBChg;
            // 
            // FolderCB
            // 
            FolderCB.AutoSize = true;
            FolderCB.Location = new Point(109, 131);
            FolderCB.Margin = new Padding(2, 2, 2, 2);
            FolderCB.Name = "FolderCB";
            FolderCB.Size = new Size(143, 19);
            FolderCB.TabIndex = 14;
            FolderCB.Text = "Output to same folder";
            FolderCB.UseVisualStyleBackColor = true;
            FolderCB.CheckedChanged += FileCBChg;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 183);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 18;
            label3.Text = "Encoder Path";
            // 
            // CubeEncodeFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 232);
            Controls.Add(label3);
            Controls.Add(FilenameCB);
            Controls.Add(EncoderSelBtn);
            Controls.Add(EncoderPath);
            Controls.Add(FolderCB);
            Controls.Add(EncodeBtn);
            Controls.Add(OutputBtn);
            Controls.Add(label2);
            Controls.Add(OutputFolderTB);
            Controls.Add(label1);
            Controls.Add(OpenFileBtn);
            Controls.Add(FilePathTB);
            Margin = new Padding(2, 2, 2, 2);
            Name = "CubeEncodeFrm";
            Text = "Cube Encoder";
            FormClosing += FrmClosing;
            ((System.ComponentModel.ISupportInitialize)cubeEncodeFrmBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EncodeBtn;
        private Button OutputBtn;
        private Label label2;
        private TextBox OutputFolderTB;
        private Label label1;
        private Button OpenFileBtn;
        private TextBox FilePathTB;
        private Button EncoderSelBtn;
        private TextBox EncoderPath;
        private BindingSource cubeEncodeFrmBindingSource;
        private CheckBox FilenameCB;
        private CheckBox FolderCB;
        private Label label3;
    }
}