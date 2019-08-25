namespace Cap
{
    partial class UserDash
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
            this.fNameShow = new System.Windows.Forms.TextBox();
            this.lNameShow = new System.Windows.Forms.TextBox();
            this.emailShow = new System.Windows.Forms.TextBox();
            this.pNumShow = new System.Windows.Forms.TextBox();
            this.addressShow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fieldBoxShow = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fNameShow
            // 
            this.fNameShow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fNameShow.Location = new System.Drawing.Point(54, 23);
            this.fNameShow.Name = "fNameShow";
            this.fNameShow.ReadOnly = true;
            this.fNameShow.Size = new System.Drawing.Size(100, 13);
            this.fNameShow.TabIndex = 0;
            // 
            // lNameShow
            // 
            this.lNameShow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lNameShow.Location = new System.Drawing.Point(160, 23);
            this.lNameShow.Name = "lNameShow";
            this.lNameShow.ReadOnly = true;
            this.lNameShow.Size = new System.Drawing.Size(100, 13);
            this.lNameShow.TabIndex = 1;
            // 
            // emailShow
            // 
            this.emailShow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailShow.Location = new System.Drawing.Point(98, 98);
            this.emailShow.Name = "emailShow";
            this.emailShow.ReadOnly = true;
            this.emailShow.Size = new System.Drawing.Size(100, 13);
            this.emailShow.TabIndex = 2;
            // 
            // pNumShow
            // 
            this.pNumShow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pNumShow.Location = new System.Drawing.Point(98, 69);
            this.pNumShow.Name = "pNumShow";
            this.pNumShow.ReadOnly = true;
            this.pNumShow.Size = new System.Drawing.Size(100, 13);
            this.pNumShow.TabIndex = 3;
            // 
            // addressShow
            // 
            this.addressShow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressShow.Location = new System.Drawing.Point(98, 128);
            this.addressShow.Name = "addressShow";
            this.addressShow.ReadOnly = true;
            this.addressShow.Size = new System.Drawing.Size(100, 13);
            this.addressShow.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hello, ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Phone number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address:";
            // 
            // fieldBoxShow
            // 
            this.fieldBoxShow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fieldBoxShow.Location = new System.Drawing.Point(98, 156);
            this.fieldBoxShow.Name = "fieldBoxShow";
            this.fieldBoxShow.ReadOnly = true;
            this.fieldBoxShow.Size = new System.Drawing.Size(100, 13);
            this.fieldBoxShow.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Career field:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(540, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(357, 118);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 13;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // UserDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 406);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fieldBoxShow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addressShow);
            this.Controls.Add(this.pNumShow);
            this.Controls.Add(this.emailShow);
            this.Controls.Add(this.lNameShow);
            this.Controls.Add(this.fNameShow);
            this.MaximumSize = new System.Drawing.Size(645, 445);
            this.MinimumSize = new System.Drawing.Size(645, 445);
            this.Name = "UserDash";
            this.Text = "UserDash";
            this.Load += new System.EventHandler(this.UserDash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fNameShow;
        private System.Windows.Forms.TextBox lNameShow;
        private System.Windows.Forms.TextBox emailShow;
        private System.Windows.Forms.TextBox pNumShow;
        private System.Windows.Forms.TextBox addressShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fieldBoxShow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button refreshButton;
    }
}