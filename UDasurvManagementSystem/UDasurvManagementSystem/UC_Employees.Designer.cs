namespace UDasurvManagementSystem
{
    partial class UC_Employees
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            TableEmployees = new DataGridView();
            colNumber = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colLocation = new DataGridViewTextBoxColumn();
            colContact = new DataGridViewTextBoxColumn();
            colDepartment = new DataGridViewTextBoxColumn();
            colPosition = new DataGridViewTextBoxColumn();
            label5 = new Label();
            button1 = new Button();
            textBox6 = new TextBox();
            label10 = new Label();
            button4 = new Button();
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)TableEmployees).BeginInit();
            SuspendLayout();
            // 
            // TableEmployees
            // 
            TableEmployees.AllowUserToAddRows = false;
            TableEmployees.AllowUserToDeleteRows = false;
            TableEmployees.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(250, 250, 250);
            TableEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            TableEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TableEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TableEmployees.BackgroundColor = Color.White;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(34, 90, 140);
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = Color.White;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            TableEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            TableEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TableEmployees.Columns.AddRange(new DataGridViewColumn[] { colNumber, colName, colLocation, colContact, colDepartment, colPosition });
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = SystemColors.Window;
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle16.ForeColor = Color.FromArgb(45, 45, 45);
            dataGridViewCellStyle16.Padding = new Padding(6, 0, 6, 0);
            dataGridViewCellStyle16.SelectionBackColor = Color.FromArgb(230, 240, 250);
            dataGridViewCellStyle16.SelectionForeColor = Color.FromArgb(20, 20, 20);
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.False;
            TableEmployees.DefaultCellStyle = dataGridViewCellStyle16;
            TableEmployees.EnableHeadersVisualStyles = false;
            TableEmployees.GridColor = Color.LightGray;
            TableEmployees.Location = new Point(16, 80);
            TableEmployees.MultiSelect = false;
            TableEmployees.Name = "TableEmployees";
            TableEmployees.ReadOnly = true;
            TableEmployees.RowTemplate.Height = 30;
            TableEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TableEmployees.Size = new Size(1051, 605);
            TableEmployees.TabIndex = 0;
            // 
            // colNumber
            // 
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colNumber.DefaultCellStyle = dataGridViewCellStyle15;
            colNumber.FillWeight = 35F;
            colNumber.HeaderText = "#";
            colNumber.Name = "colNumber";
            colNumber.ReadOnly = true;
            // 
            // colName
            // 
            colName.FillWeight = 180F;
            colName.HeaderText = "Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colLocation
            // 
            colLocation.FillWeight = 140F;
            colLocation.HeaderText = "Location";
            colLocation.Name = "colLocation";
            colLocation.ReadOnly = true;
            // 
            // colContact
            // 
            colContact.FillWeight = 120F;
            colContact.HeaderText = "Contact";
            colContact.Name = "colContact";
            colContact.ReadOnly = true;
            // 
            // colDepartment
            // 
            colDepartment.FillWeight = 140F;
            colDepartment.HeaderText = "Department";
            colDepartment.Name = "colDepartment";
            colDepartment.ReadOnly = true;
            // 
            // colPosition
            // 
            colPosition.FillWeight = 130F;
            colPosition.HeaderText = "Position";
            colPosition.Name = "colPosition";
            colPosition.ReadOnly = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 9);
            label5.Name = "label5";
            label5.Size = new Size(270, 22);
            label5.TabIndex = 4;
            label5.Text = "EMPLOYEES INFORMATION";
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(304, 50);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Arial", 12F);
            textBox6.Location = new Point(84, 48);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(214, 26);
            textBox6.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(16, 51);
            label10.Name = "label10";
            label10.Size = new Size(62, 18);
            label10.TabIndex = 6;
            label10.Text = "Search:";
            // 
            // button4
            // 
            button4.Location = new Point(749, 51);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 13;
            button4.Text = "ADD";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(830, 51);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 12;
            button5.Text = "UPDATE";
            button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(911, 51);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 11;
            button3.Text = "LOAD";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(992, 51);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "DELETE";
            button2.UseVisualStyleBackColor = true;
            // 
            // UC_Employees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(TableEmployees);
            Name = "UC_Employees";
            Size = new Size(1083, 702);
            ((System.ComponentModel.ISupportInitialize)TableEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView TableEmployees;
        private DataGridViewTextBoxColumn colNumber;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colLocation;
        private DataGridViewTextBoxColumn colContact;
        private DataGridViewTextBoxColumn colDepartment;
        private DataGridViewTextBoxColumn colPosition;
        private Label label5;
        private Button button1;
        private TextBox textBox6;
        private Label label10;
        private Button button4;
        private Button button5;
        private Button button3;
        private Button button2;
    }
}
