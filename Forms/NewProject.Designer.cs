
namespace Gen.GenForms
{
    partial class NewProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProject));
            this.fbdPath = new System.Windows.Forms.FolderBrowserDialog();
            this.btnLocation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtSVNLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFolderName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFolderNameFinal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLocation
            // 
            this.btnLocation.Location = new System.Drawing.Point(491, 276);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(30, 23);
            this.btnLocation.TabIndex = 4;
            this.btnLocation.Text = "...";
            this.btnLocation.UseVisualStyleBackColor = true;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Project ID (6 characters)";
            // 
            // txtID
            // 
            this.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(15, 25);
            this.txtID.MaxLength = 6;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(95, 23);
            this.txtID.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::Gen.Properties.Resources.cancel1;
            this.btnCancel.Location = new System.Drawing.Point(446, 417);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.Image")));
            this.btnAccept.Location = new System.Drawing.Point(365, 417);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 25);
            this.btnAccept.TabIndex = 5;
            this.btnAccept.Text = "Accept";
            this.btnAccept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccept.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccept.UseCompatibleTextRendering = true;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Project Location";
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(15, 277);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(470, 21);
            this.txtLocation.TabIndex = 3;
            // 
            // txtSVNLocation
            // 
            this.txtSVNLocation.Enabled = false;
            this.txtSVNLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSVNLocation.Location = new System.Drawing.Point(15, 337);
            this.txtSVNLocation.Name = "txtSVNLocation";
            this.txtSVNLocation.Size = new System.Drawing.Size(470, 21);
            this.txtSVNLocation.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "SVN Location / Server Location";
            // 
            // txtFolderName
            // 
            this.txtFolderName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFolderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolderName.Location = new System.Drawing.Point(15, 82);
            this.txtFolderName.MaxLength = 35;
            this.txtFolderName.Name = "txtFolderName";
            this.txtFolderName.Size = new System.Drawing.Size(218, 23);
            this.txtFolderName.TabIndex = 1;
            this.txtFolderName.TextChanged += new System.EventHandler(this.txtFolderName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Folder Name";
            // 
            // txtFolderNameFinal
            // 
            this.txtFolderNameFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFolderNameFinal.Enabled = false;
            this.txtFolderNameFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolderNameFinal.Location = new System.Drawing.Point(15, 144);
            this.txtFolderNameFinal.MaxLength = 35;
            this.txtFolderNameFinal.Name = "txtFolderNameFinal";
            this.txtFolderNameFinal.Size = new System.Drawing.Size(218, 23);
            this.txtFolderNameFinal.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Folder Name Final";
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDatabaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatabaseName.Location = new System.Drawing.Point(15, 209);
            this.txtDatabaseName.MaxLength = 30;
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(218, 23);
            this.txtDatabaseName.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Database Name";
            // 
            // NewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 454);
            this.Controls.Add(this.txtDatabaseName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFolderNameFinal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFolderName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSVNLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbdPath;
        private System.Windows.Forms.Button btnLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtSVNLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFolderName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFolderNameFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.Label label6;
    }
}