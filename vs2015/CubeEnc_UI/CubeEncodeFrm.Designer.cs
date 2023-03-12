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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CubeEncodeFrm));
            this.EncodeBtn = new System.Windows.Forms.Button();
            this.OutputBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.OutputFolderTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenFileBtn = new System.Windows.Forms.Button();
            this.FilePathTB = new System.Windows.Forms.TextBox();
            this.EncoderSelBtn = new System.Windows.Forms.Button();
            this.EncoderPath = new System.Windows.Forms.TextBox();
            this.cubeEncodeFrmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FilenameCB = new System.Windows.Forms.CheckBox();
            this.FolderCB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.cubeEncodeFrmBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EncodeBtn
            // 
            this.EncodeBtn.Location = new System.Drawing.Point(857, 218);
            this.EncodeBtn.Name = "EncodeBtn";
            this.EncodeBtn.Size = new System.Drawing.Size(112, 34);
            this.EncodeBtn.TabIndex = 13;
            this.EncodeBtn.Text = "Encode";
            this.EncodeBtn.UseVisualStyleBackColor = true;
            this.EncodeBtn.Click += new System.EventHandler(this.EncodeBtn_Click);
            // 
            // OutputBtn
            // 
            this.OutputBtn.Image = ((System.Drawing.Image)(resources.GetObject("OutputBtn.Image")));
            this.OutputBtn.Location = new System.Drawing.Point(975, 164);
            this.OutputBtn.Name = "OutputBtn";
            this.OutputBtn.Size = new System.Drawing.Size(62, 31);
            this.OutputBtn.TabIndex = 12;
            this.OutputBtn.UseVisualStyleBackColor = true;
            this.OutputBtn.Click += new System.EventHandler(this.OutputBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Save To";
            // 
            // OutputFolderTB
            // 
            this.OutputFolderTB.Location = new System.Drawing.Point(156, 164);
            this.OutputFolderTB.Name = "OutputFolderTB";
            this.OutputFolderTB.Size = new System.Drawing.Size(813, 31);
            this.OutputFolderTB.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Open File";
            // 
            // OpenFileBtn
            // 
            this.OpenFileBtn.Image = ((System.Drawing.Image)(resources.GetObject("OpenFileBtn.Image")));
            this.OpenFileBtn.Location = new System.Drawing.Point(975, 103);
            this.OpenFileBtn.Name = "OpenFileBtn";
            this.OpenFileBtn.Size = new System.Drawing.Size(62, 31);
            this.OpenFileBtn.TabIndex = 8;
            this.OpenFileBtn.UseVisualStyleBackColor = true;
            this.OpenFileBtn.Click += new System.EventHandler(this.OpenFileBtn_Click);
            // 
            // FilePathTB
            // 
            this.FilePathTB.Location = new System.Drawing.Point(156, 103);
            this.FilePathTB.Name = "FilePathTB";
            this.FilePathTB.Size = new System.Drawing.Size(813, 31);
            this.FilePathTB.TabIndex = 7;
            // 
            // EncoderSelBtn
            // 
            this.EncoderSelBtn.Image = ((System.Drawing.Image)(resources.GetObject("EncoderSelBtn.Image")));
            this.EncoderSelBtn.Location = new System.Drawing.Point(975, 299);
            this.EncoderSelBtn.Name = "EncoderSelBtn";
            this.EncoderSelBtn.Size = new System.Drawing.Size(62, 31);
            this.EncoderSelBtn.TabIndex = 16;
            this.EncoderSelBtn.UseVisualStyleBackColor = true;
            this.EncoderSelBtn.Click += new System.EventHandler(this.EncoderSelBtn_Click);
            // 
            // EncoderPath
            // 
            this.EncoderPath.Location = new System.Drawing.Point(156, 299);
            this.EncoderPath.Name = "EncoderPath";
            this.EncoderPath.Size = new System.Drawing.Size(813, 31);
            this.EncoderPath.TabIndex = 15;
            // 
            // cubeEncodeFrmBindingSource
            // 
            this.cubeEncodeFrmBindingSource.DataSource = typeof(CubeEnc_UI.CubeEncodeFrm);
            // 
            // FilenameCB
            // 
            this.FilenameCB.AutoSize = true;
            this.FilenameCB.Location = new System.Drawing.Point(406, 218);
            this.FilenameCB.Name = "FilenameCB";
            this.FilenameCB.Size = new System.Drawing.Size(236, 29);
            this.FilenameCB.TabIndex = 17;
            this.FilenameCB.Text = "Output to same filename";
            this.FilenameCB.UseVisualStyleBackColor = true;
            this.FilenameCB.CheckedChanged += new System.EventHandler(this.FileCBChg);
            // 
            // FolderCB
            // 
            this.FolderCB.AutoSize = true;
            this.FolderCB.Location = new System.Drawing.Point(156, 218);
            this.FolderCB.Name = "FolderCB";
            this.FolderCB.Size = new System.Drawing.Size(216, 29);
            this.FolderCB.TabIndex = 14;
            this.FolderCB.Text = "Output to same folder";
            this.FolderCB.UseVisualStyleBackColor = true;
            this.FolderCB.CheckedChanged += new System.EventHandler(this.FileCBChg);
            // 
            // CubeEncodeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 387);
            this.Controls.Add(this.FilenameCB);
            this.Controls.Add(this.EncoderSelBtn);
            this.Controls.Add(this.EncoderPath);
            this.Controls.Add(this.FolderCB);
            this.Controls.Add(this.EncodeBtn);
            this.Controls.Add(this.OutputBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OutputFolderTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpenFileBtn);
            this.Controls.Add(this.FilePathTB);
            this.Name = "CubeEncodeFrm";
            this.Text = "Cube Encoder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmClosing);
            ((System.ComponentModel.ISupportInitialize)(this.cubeEncodeFrmBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}