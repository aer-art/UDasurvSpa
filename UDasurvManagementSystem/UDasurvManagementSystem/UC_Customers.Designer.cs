namespace UDasurvManagementSystem
{
    partial class UC_Customers
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
            label5 = new Label();
            tableCustomers = new DataGridView();
            colCustomerId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colContact = new DataGridViewTextBoxColumn();
            colAddress = new DataGridViewTextBoxColumn();
            colPreferredTherapist = new DataGridViewTextBoxColumn();
            button4 = new Button();
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox6 = new TextBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)tableCustomers).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 9);
            label5.Name = "label5";
            label5.Size = new Size(228, 22);
            label5.TabIndex = 4;
            label5.Text = "CUSTOMERS' HISTORY";
            // 
            // tableCustomers
            // 
            tableCustomers.AllowUserToAddRows = false;
            tableCustomers.AllowUserToDeleteRows = false;
            tableCustomers.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(250, 250, 250);
            tableCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            tableCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableCustomers.BackgroundColor = Color.White;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(40, 96, 144);
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = Color.White;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            tableCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            tableCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableCustomers.Columns.AddRange(new DataGridViewColumn[] { colCustomerId, colName, colContact, colAddress, colPreferredTherapist });
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = SystemColors.Window;
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle16.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle16.Padding = new Padding(4, 0, 4, 0);
            dataGridViewCellStyle16.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.False;
            tableCustomers.DefaultCellStyle = dataGridViewCellStyle16;
            tableCustomers.EnableHeadersVisualStyles = false;
            tableCustomers.GridColor = Color.LightGray;
            tableCustomers.Location = new Point(16, 80);
            tableCustomers.MultiSelect = false;
            tableCustomers.Name = "tableCustomers";
            tableCustomers.ReadOnly = true;
            tableCustomers.RowTemplate.Height = 30;
            tableCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableCustomers.Size = new Size(1051, 605);
            tableCustomers.TabIndex = 5;
            // 
            // colCustomerId
            // 
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colCustomerId.DefaultCellStyle = dataGridViewCellStyle15;
            colCustomerId.FillWeight = 60F;
            colCustomerId.HeaderText = "Customer ID";
            colCustomerId.Name = "colCustomerId";
            colCustomerId.ReadOnly = true;
            // 
            // colName
            // 
            colName.FillWeight = 180F;
            colName.HeaderText = "Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colContact
            // 
            colContact.FillWeight = 120F;
            colContact.HeaderText = "Contact";
            colContact.Name = "colContact";
            colContact.ReadOnly = true;
            // 
            // colAddress
            // 
            colAddress.FillWeight = 260F;
            colAddress.HeaderText = "Address";
            colAddress.Name = "colAddress";
            colAddress.ReadOnly = true;
            // 
            // colPreferredTherapist
            // 
            colPreferredTherapist.FillWeight = 150F;
            colPreferredTherapist.HeaderText = "Preferred Therapist";
            colPreferredTherapist.Name = "colPreferredTherapist";
            colPreferredTherapist.ReadOnly = true;
            // 
            // button4
            // 
            button4.Location = new Point(745, 51);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 20;
            button4.Text = "ADD";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(826, 51);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 19;
            button5.Text = "UPDATE";
            button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(907, 51);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 18;
            button3.Text = "LOAD";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(988, 51);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 17;
            button2.Text = "DELETE";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(303, 51);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 16;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Arial", 12F);
            textBox6.Location = new Point(83, 48);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(214, 26);
            textBox6.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(15, 51);
            label10.Name = "label10";
            label10.Size = new Size(62, 18);
            label10.TabIndex = 14;
            label10.Text = "Search:";
            // 
            // UC_Customers
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
            Controls.Add(tableCustomers);
            Controls.Add(label5);
            Name = "UC_Customers";
            Size = new Size(1083, 702);
            ((System.ComponentModel.ISupportInitialize)tableCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private DataGridView tableCustomers;
        private DataGridViewTextBoxColumn colCustomerId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colContact;
        private DataGridViewTextBoxColumn colAddress;
        private DataGridViewTextBoxColumn colPreferredTherapist;
        private Button button4;
        private Button button5;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox6;
        private Label label10;
    }
}
