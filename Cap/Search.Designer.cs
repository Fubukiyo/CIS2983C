namespace Cap
{
    partial class Search
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
            this.fNameRB = new System.Windows.Forms.RadioButton();
            this.lNameRB = new System.Windows.Forms.RadioButton();
            this.pNumRB = new System.Windows.Forms.RadioButton();
            this.emailRB = new System.Windows.Forms.RadioButton();
            this.pAddressRB = new System.Windows.Forms.RadioButton();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.red_DBDataSet1 = new Cap.Red_DBDataSet1();
            this.redDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.redDBDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.redDBDataSet1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.redDBDataSet1BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.red_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redDBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redDBDataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redDBDataSet1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redDBDataSet1BindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fNameRB
            // 
            this.fNameRB.AutoSize = true;
            this.fNameRB.Location = new System.Drawing.Point(12, 43);
            this.fNameRB.Name = "fNameRB";
            this.fNameRB.Size = new System.Drawing.Size(75, 17);
            this.fNameRB.TabIndex = 0;
            this.fNameRB.TabStop = true;
            this.fNameRB.Text = "First Name";
            this.fNameRB.UseVisualStyleBackColor = true;
            // 
            // lNameRB
            // 
            this.lNameRB.AutoSize = true;
            this.lNameRB.Location = new System.Drawing.Point(12, 67);
            this.lNameRB.Name = "lNameRB";
            this.lNameRB.Size = new System.Drawing.Size(76, 17);
            this.lNameRB.TabIndex = 1;
            this.lNameRB.TabStop = true;
            this.lNameRB.Text = "Last Name";
            this.lNameRB.UseVisualStyleBackColor = true;
            // 
            // pNumRB
            // 
            this.pNumRB.AutoSize = true;
            this.pNumRB.Location = new System.Drawing.Point(12, 91);
            this.pNumRB.Name = "pNumRB";
            this.pNumRB.Size = new System.Drawing.Size(96, 17);
            this.pNumRB.TabIndex = 2;
            this.pNumRB.TabStop = true;
            this.pNumRB.Text = "Phone Number";
            this.pNumRB.UseVisualStyleBackColor = true;
            // 
            // emailRB
            // 
            this.emailRB.AutoSize = true;
            this.emailRB.Location = new System.Drawing.Point(12, 114);
            this.emailRB.Name = "emailRB";
            this.emailRB.Size = new System.Drawing.Size(91, 17);
            this.emailRB.TabIndex = 3;
            this.emailRB.TabStop = true;
            this.emailRB.Text = "Email Address";
            this.emailRB.UseVisualStyleBackColor = true;
            // 
            // pAddressRB
            // 
            this.pAddressRB.AutoSize = true;
            this.pAddressRB.Location = new System.Drawing.Point(12, 137);
            this.pAddressRB.Name = "pAddressRB";
            this.pAddressRB.Size = new System.Drawing.Size(63, 17);
            this.pAddressRB.TabIndex = 4;
            this.pAddressRB.TabStop = true;
            this.pAddressRB.Text = "Address";
            this.pAddressRB.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(12, 160);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 23;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(13, 13);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(291, 20);
            this.searchBox.TabIndex = 24;
            // 
            // red_DBDataSet1
            // 
            this.red_DBDataSet1.DataSetName = "Red_DBDataSet1";
            this.red_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // redDBDataSet1BindingSource
            // 
            this.redDBDataSet1BindingSource.DataSource = this.red_DBDataSet1;
            this.redDBDataSet1BindingSource.Position = 0;
            // 
            // redDBDataSet1BindingSource1
            // 
            this.redDBDataSet1BindingSource1.DataSource = this.red_DBDataSet1;
            this.redDBDataSet1BindingSource1.Position = 0;
            // 
            // redDBDataSet1BindingSource2
            // 
            this.redDBDataSet1BindingSource2.DataSource = this.red_DBDataSet1;
            this.redDBDataSet1BindingSource2.Position = 0;
            // 
            // redDBDataSet1BindingSource3
            // 
            this.redDBDataSet1BindingSource3.DataSource = this.red_DBDataSet1;
            this.redDBDataSet1BindingSource3.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(122, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(461, 150);
            this.dataGridView1.TabIndex = 25;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 195);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.pAddressRB);
            this.Controls.Add(this.emailRB);
            this.Controls.Add(this.pNumRB);
            this.Controls.Add(this.lNameRB);
            this.Controls.Add(this.fNameRB);
            this.Name = "Search";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.red_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redDBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redDBDataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redDBDataSet1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redDBDataSet1BindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton fNameRB;
        private System.Windows.Forms.RadioButton lNameRB;
        private System.Windows.Forms.RadioButton pNumRB;
        private System.Windows.Forms.RadioButton emailRB;
        private System.Windows.Forms.RadioButton pAddressRB;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.BindingSource redDBDataSet1BindingSource;
        private Red_DBDataSet1 red_DBDataSet1;
        private System.Windows.Forms.BindingSource redDBDataSet1BindingSource1;
        private System.Windows.Forms.BindingSource redDBDataSet1BindingSource3;
        private System.Windows.Forms.BindingSource redDBDataSet1BindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}