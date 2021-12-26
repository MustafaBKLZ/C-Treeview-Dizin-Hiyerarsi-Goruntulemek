namespace C_Treeview_Dizin_Hiyerarsi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imlFiles = new System.Windows.Forms.ImageList(this.components);
            this.trvDirectory = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // imlFiles
            // 
            this.imlFiles.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlFiles.ImageStream")));
            this.imlFiles.TransparentColor = System.Drawing.Color.Transparent;
            this.imlFiles.Images.SetKeyName(0, "Folder_Open.png");
            this.imlFiles.Images.SetKeyName(1, "Document_Text.png");
            // 
            // trvDirectory
            // 
            this.trvDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trvDirectory.ImageIndex = 0;
            this.trvDirectory.ImageList = this.imlFiles;
            this.trvDirectory.Location = new System.Drawing.Point(12, 12);
            this.trvDirectory.Name = "trvDirectory";
            this.trvDirectory.SelectedImageIndex = 0;
            this.trvDirectory.Size = new System.Drawing.Size(360, 237);
            this.trvDirectory.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.trvDirectory);
            this.Name = "Form1";
            this.Text = "howto_treeview_directory";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imlFiles;
        private System.Windows.Forms.TreeView trvDirectory;
    }
}

