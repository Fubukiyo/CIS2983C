namespace Cap
{
    partial class Dashboard
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
            this.redDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.red_DBDataSet = new Cap.Red_DBDataSet();
            this.searchStudents = new System.Windows.Forms.Button();
            this.addFormButton = new System.Windows.Forms.Button();
            this.addStudentLabel = new System.Windows.Forms.Label();
            this.searchStudentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.redDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // redDBDataSetBindingSource
            // 
            this.redDBDataSetBindingSource.DataSource = this.red_DBDataSet;
            this.redDBDataSetBindingSource.Position = 0;
            // 
            // red_DBDataSet
            // 
            this.red_DBDataSet.DataSetName = "Red_DBDataSet";
            this.red_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchStudents
            // 
            this.searchStudents.Location = new System.Drawing.Point(217, 138);
            this.searchStudents.Name = "searchStudents";
            this.searchStudents.Size = new System.Drawing.Size(75, 23);
            this.searchStudents.TabIndex = 24;
            this.searchStudents.Text = "Search";
            this.searchStudents.UseVisualStyleBackColor = true;
            this.searchStudents.Click += new System.EventHandler(this.searchStudents_Click);
            // 
            // addFormButton
            // 
            this.addFormButton.Location = new System.Drawing.Point(60, 138);
            this.addFormButton.Name = "addFormButton";
            this.addFormButton.Size = new System.Drawing.Size(75, 23);
            this.addFormButton.TabIndex = 25;
            this.addFormButton.Text = "Register";
            this.addFormButton.UseVisualStyleBackColor = true;
            this.addFormButton.Click += new System.EventHandler(this.addFormButton_Click);
            // 
            // addStudentLabel
            // 
            this.addStudentLabel.AutoSize = true;
            this.addStudentLabel.Location = new System.Drawing.Point(60, 119);
            this.addStudentLabel.Name = "addStudentLabel";
            this.addStudentLabel.Size = new System.Drawing.Size(86, 13);
            this.addStudentLabel.TabIndex = 26;
            this.addStudentLabel.Text = "Register Student";
            // 
            // searchStudentLabel
            // 
            this.searchStudentLabel.AutoSize = true;
            this.searchStudentLabel.Location = new System.Drawing.Point(214, 119);
            this.searchStudentLabel.Name = "searchStudentLabel";
            this.searchStudentLabel.Size = new System.Drawing.Size(81, 13);
            this.searchStudentLabel.TabIndex = 27;
            this.searchStudentLabel.Text = "Search Student";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 197);
            this.Controls.Add(this.searchStudentLabel);
            this.Controls.Add(this.addStudentLabel);
            this.Controls.Add(this.addFormButton);
            this.Controls.Add(this.searchStudents);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.redDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.red_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource redDBDataSetBindingSource;
        private Red_DBDataSet red_DBDataSet;
        private System.Windows.Forms.Button searchStudents;
        private System.Windows.Forms.Button addFormButton;
        private System.Windows.Forms.Label addStudentLabel;
        private System.Windows.Forms.Label searchStudentLabel;
    }
}

