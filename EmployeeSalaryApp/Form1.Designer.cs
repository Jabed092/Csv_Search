namespace EmployeeSalaryApp
{
    partial class EmployeeAdvancedApp
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
            this.saveButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.pcontactTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.pcontactLabel = new System.Windows.Forms.Label();
            this.hcontactTextBox = new System.Windows.Forms.TextBox();
            this.hcontactLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.detailListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchButton = new System.Windows.Forms.Button();
            this.nameSearchTextBox = new System.Windows.Forms.TextBox();
            this.addressSearchTextBox = new System.Windows.Forms.TextBox();
            this.hcontactSearchTextBox = new System.Windows.Forms.TextBox();
            this.pcontactSearchTextBox = new System.Windows.Forms.TextBox();
            this.emailSearchTextBox = new System.Windows.Forms.TextBox();
            this.nameSearchLabel = new System.Windows.Forms.Label();
            this.emailSearchLabel = new System.Windows.Forms.Label();
            this.pcontactSearchLabel = new System.Windows.Forms.Label();
            this.hcontactSearchLabel = new System.Windows.Forms.Label();
            this.addressSearchLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(39, 401);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(352, 401);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 1;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(113, 21);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(220, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(113, 47);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(220, 20);
            this.emailTextBox.TabIndex = 3;
            // 
            // pcontactTextBox
            // 
            this.pcontactTextBox.Location = new System.Drawing.Point(113, 73);
            this.pcontactTextBox.Name = "pcontactTextBox";
            this.pcontactTextBox.Size = new System.Drawing.Size(220, 20);
            this.pcontactTextBox.TabIndex = 4;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(9, 24);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(9, 50);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email";
            // 
            // pcontactLabel
            // 
            this.pcontactLabel.AutoSize = true;
            this.pcontactLabel.Location = new System.Drawing.Point(9, 76);
            this.pcontactLabel.Name = "pcontactLabel";
            this.pcontactLabel.Size = new System.Drawing.Size(88, 13);
            this.pcontactLabel.TabIndex = 7;
            this.pcontactLabel.Text = "Personal Contact";
            // 
            // hcontactTextBox
            // 
            this.hcontactTextBox.Location = new System.Drawing.Point(113, 99);
            this.hcontactTextBox.Name = "hcontactTextBox";
            this.hcontactTextBox.Size = new System.Drawing.Size(220, 20);
            this.hcontactTextBox.TabIndex = 12;
            // 
            // hcontactLabel
            // 
            this.hcontactLabel.AutoSize = true;
            this.hcontactLabel.Location = new System.Drawing.Point(9, 102);
            this.hcontactLabel.Name = "hcontactLabel";
            this.hcontactLabel.Size = new System.Drawing.Size(75, 13);
            this.hcontactLabel.TabIndex = 13;
            this.hcontactLabel.Text = "Home Contact";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(9, 128);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 14;
            this.addressLabel.Text = "Address";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(113, 125);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(220, 20);
            this.addressTextBox.TabIndex = 15;
            // 
            // detailListView
            // 
            this.detailListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.detailListView.FullRowSelect = true;
            this.detailListView.GridLines = true;
            this.detailListView.Location = new System.Drawing.Point(12, 174);
            this.detailListView.Name = "detailListView";
            this.detailListView.Size = new System.Drawing.Size(693, 206);
            this.detailListView.TabIndex = 16;
            this.detailListView.UseCompatibleStateImageBehavior = false;
            this.detailListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 123;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Email";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Persoanl Contact";
            this.columnHeader3.Width = 122;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Home Contact";
            this.columnHeader4.Width = 128;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Address";
            this.columnHeader5.Width = 193;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(194, 401);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 17;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // nameSearchTextBox
            // 
            this.nameSearchTextBox.Location = new System.Drawing.Point(470, 21);
            this.nameSearchTextBox.Name = "nameSearchTextBox";
            this.nameSearchTextBox.Size = new System.Drawing.Size(235, 20);
            this.nameSearchTextBox.TabIndex = 18;
            // 
            // addressSearchTextBox
            // 
            this.addressSearchTextBox.Location = new System.Drawing.Point(470, 125);
            this.addressSearchTextBox.Name = "addressSearchTextBox";
            this.addressSearchTextBox.Size = new System.Drawing.Size(235, 20);
            this.addressSearchTextBox.TabIndex = 19;
            // 
            // hcontactSearchTextBox
            // 
            this.hcontactSearchTextBox.Location = new System.Drawing.Point(470, 99);
            this.hcontactSearchTextBox.Name = "hcontactSearchTextBox";
            this.hcontactSearchTextBox.Size = new System.Drawing.Size(235, 20);
            this.hcontactSearchTextBox.TabIndex = 20;
            // 
            // pcontactSearchTextBox
            // 
            this.pcontactSearchTextBox.Location = new System.Drawing.Point(470, 73);
            this.pcontactSearchTextBox.Name = "pcontactSearchTextBox";
            this.pcontactSearchTextBox.Size = new System.Drawing.Size(235, 20);
            this.pcontactSearchTextBox.TabIndex = 21;
            // 
            // emailSearchTextBox
            // 
            this.emailSearchTextBox.Location = new System.Drawing.Point(470, 47);
            this.emailSearchTextBox.Name = "emailSearchTextBox";
            this.emailSearchTextBox.Size = new System.Drawing.Size(235, 20);
            this.emailSearchTextBox.TabIndex = 22;
            // 
            // nameSearchLabel
            // 
            this.nameSearchLabel.AutoSize = true;
            this.nameSearchLabel.Location = new System.Drawing.Point(365, 24);
            this.nameSearchLabel.Name = "nameSearchLabel";
            this.nameSearchLabel.Size = new System.Drawing.Size(35, 13);
            this.nameSearchLabel.TabIndex = 23;
            this.nameSearchLabel.Text = "Name";
            // 
            // emailSearchLabel
            // 
            this.emailSearchLabel.AutoSize = true;
            this.emailSearchLabel.Location = new System.Drawing.Point(365, 50);
            this.emailSearchLabel.Name = "emailSearchLabel";
            this.emailSearchLabel.Size = new System.Drawing.Size(32, 13);
            this.emailSearchLabel.TabIndex = 24;
            this.emailSearchLabel.Text = "Email";
            // 
            // pcontactSearchLabel
            // 
            this.pcontactSearchLabel.AutoSize = true;
            this.pcontactSearchLabel.Location = new System.Drawing.Point(365, 76);
            this.pcontactSearchLabel.Name = "pcontactSearchLabel";
            this.pcontactSearchLabel.Size = new System.Drawing.Size(88, 13);
            this.pcontactSearchLabel.TabIndex = 25;
            this.pcontactSearchLabel.Text = "Personal Contact";
            // 
            // hcontactSearchLabel
            // 
            this.hcontactSearchLabel.AutoSize = true;
            this.hcontactSearchLabel.Location = new System.Drawing.Point(365, 102);
            this.hcontactSearchLabel.Name = "hcontactSearchLabel";
            this.hcontactSearchLabel.Size = new System.Drawing.Size(75, 13);
            this.hcontactSearchLabel.TabIndex = 26;
            this.hcontactSearchLabel.Text = "Home Contact";
            // 
            // addressSearchLabel
            // 
            this.addressSearchLabel.AutoSize = true;
            this.addressSearchLabel.Location = new System.Drawing.Point(365, 128);
            this.addressSearchLabel.Name = "addressSearchLabel";
            this.addressSearchLabel.Size = new System.Drawing.Size(45, 13);
            this.addressSearchLabel.TabIndex = 27;
            this.addressSearchLabel.Text = "Address";
            // 
            // EmployeeAdvancedApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 440);
            this.Controls.Add(this.addressSearchLabel);
            this.Controls.Add(this.hcontactSearchLabel);
            this.Controls.Add(this.pcontactSearchLabel);
            this.Controls.Add(this.emailSearchLabel);
            this.Controls.Add(this.nameSearchLabel);
            this.Controls.Add(this.emailSearchTextBox);
            this.Controls.Add(this.pcontactSearchTextBox);
            this.Controls.Add(this.hcontactSearchTextBox);
            this.Controls.Add(this.addressSearchTextBox);
            this.Controls.Add(this.nameSearchTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.detailListView);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.hcontactLabel);
            this.Controls.Add(this.hcontactTextBox);
            this.Controls.Add(this.pcontactLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.pcontactTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.saveButton);
            this.Name = "EmployeeAdvancedApp";
            this.Text = "Application 01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox pcontactTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label pcontactLabel;
        private System.Windows.Forms.TextBox hcontactTextBox;
        private System.Windows.Forms.Label hcontactLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.ListView detailListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox nameSearchTextBox;
        private System.Windows.Forms.TextBox addressSearchTextBox;
        private System.Windows.Forms.TextBox hcontactSearchTextBox;
        private System.Windows.Forms.TextBox pcontactSearchTextBox;
        private System.Windows.Forms.TextBox emailSearchTextBox;
        private System.Windows.Forms.Label nameSearchLabel;
        private System.Windows.Forms.Label emailSearchLabel;
        private System.Windows.Forms.Label pcontactSearchLabel;
        private System.Windows.Forms.Label hcontactSearchLabel;
        private System.Windows.Forms.Label addressSearchLabel;
    }
}

