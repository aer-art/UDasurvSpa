namespace UDasurvManagementSystem
{
    partial class UC_Transactions
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            TableTransaction = new DataGridView();
            colNumber = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colTime = new DataGridViewTextBoxColumn();
            colCustomerName = new DataGridViewTextBoxColumn();
            colType = new DataGridViewTextBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();
            label5 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            label6 = new Label();
            btnSearch = new Button();
            textBox6 = new TextBox();
            label10 = new Label();
            btnDelete = new Button();
            btnLoad = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)TableTransaction).BeginInit();
            SuspendLayout();
            // 
            // TableTransaction
            // 
            TableTransaction.AllowUserToAddRows = false;
            TableTransaction.AllowUserToDeleteRows = false;
            TableTransaction.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(250, 250, 250);
            TableTransaction.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            TableTransaction.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TableTransaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TableTransaction.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(34, 90, 140);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            TableTransaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            TableTransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TableTransaction.Columns.AddRange(new DataGridViewColumn[] { colNumber, colDate, colTime, colCustomerName, colType, colAmount });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(45, 45, 45);
            dataGridViewCellStyle6.Padding = new Padding(6, 0, 6, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(220, 235, 250);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            TableTransaction.DefaultCellStyle = dataGridViewCellStyle6;
            TableTransaction.EnableHeadersVisualStyles = false;
            TableTransaction.GridColor = Color.LightGray;
            TableTransaction.Location = new Point(17, 193);
            TableTransaction.MultiSelect = false;
            TableTransaction.Name = "TableTransaction";
            TableTransaction.ReadOnly = true;
            TableTransaction.RowTemplate.Height = 28;
            TableTransaction.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TableTransaction.Size = new Size(1050, 481);
            TableTransaction.TabIndex = 0;
            // 
            // colNumber
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colNumber.DefaultCellStyle = dataGridViewCellStyle3;
            colNumber.FillWeight = 30F;
            colNumber.HeaderText = "#";
            colNumber.Name = "colNumber";
            colNumber.ReadOnly = true;
            // 
            // colDate
            // 
            colDate.FillWeight = 90F;
            colDate.HeaderText = "Date";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            // 
            // colTime
            // 
            colTime.FillWeight = 80F;
            colTime.HeaderText = "Time";
            colTime.Name = "colTime";
            colTime.ReadOnly = true;
            // 
            // colCustomerName
            // 
            colCustomerName.FillWeight = 220F;
            colCustomerName.HeaderText = "Customer Name";
            colCustomerName.Name = "colCustomerName";
            colCustomerName.ReadOnly = true;
            // 
            // colType
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colType.DefaultCellStyle = dataGridViewCellStyle4;
            colType.FillWeight = 80F;
            colType.HeaderText = "Type";
            colType.Name = "colType";
            colType.ReadOnly = true;
            // 
            // colAmount
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            colAmount.DefaultCellStyle = dataGridViewCellStyle5;
            colAmount.HeaderText = "Amount";
            colAmount.Name = "colAmount";
            colAmount.ReadOnly = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(17, 15);
            label5.Name = "label5";
            label5.Size = new Size(161, 22);
            label5.TabIndex = 4;
            label5.Text = "TRANSACTIONS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(531, 66);
            label4.Name = "label4";
            label4.Size = new Size(52, 19);
            label4.TabIndex = 18;
            label4.Text = "Type:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Arial", 12F);
            textBox3.Location = new Point(380, 96);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(118, 26);
            textBox3.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(322, 99);
            label3.Name = "label3";
            label3.Size = new Size(52, 19);
            label3.TabIndex = 16;
            label3.Text = "Time:";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 12F);
            textBox2.Location = new Point(180, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(118, 26);
            textBox2.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(124, 99);
            label2.Name = "label2";
            label2.Size = new Size(50, 19);
            label2.TabIndex = 14;
            label2.Text = "Date:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 12F);
            textBox1.Location = new Point(268, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 26);
            textBox1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(124, 66);
            label1.Name = "label1";
            label1.Size = new Size(138, 19);
            label1.TabIndex = 12;
            label1.Text = "Customer Name:";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Arial", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(589, 63);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(195, 26);
            comboBox1.TabIndex = 19;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Arial", 12F);
            textBox4.Location = new Point(614, 99);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(170, 26);
            textBox4.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(533, 102);
            label6.Name = "label6";
            label6.Size = new Size(75, 19);
            label6.TabIndex = 20;
            label6.Text = "Amount:";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(308, 161);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 24;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Arial", 12F);
            textBox6.Location = new Point(88, 158);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(214, 26);
            textBox6.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(20, 161);
            label10.Name = "label10";
            label10.Size = new Size(62, 18);
            label10.TabIndex = 22;
            label10.Text = "Search:";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(992, 165);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 29;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += button6_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(911, 165);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 28;
            btnLoad.Text = "LOAD";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(830, 164);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(790, 101);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(163, 23);
            btnClear.TabIndex = 26;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(790, 65);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(163, 23);
            btnAdd.TabIndex = 25;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // UC_Transactions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDelete);
            Controls.Add(btnLoad);
            Controls.Add(btnUpdate);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(textBox6);
            Controls.Add(label10);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(TableTransaction);
            Name = "UC_Transactions";
            Size = new Size(1083, 702);
            Load += UC_Transactions_Load;
            ((System.ComponentModel.ISupportInitialize)TableTransaction).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView TableTransaction;
        private DataGridViewTextBoxColumn colNumber;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colTime;
        private DataGridViewTextBoxColumn colCustomerName;
        private DataGridViewTextBoxColumn colType;
        private DataGridViewTextBoxColumn colAmount;
        private Label label5;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox1;
        private TextBox textBox4;
        private Label label6;
        private Button btnSearch;
        private TextBox textBox6;
        private Label label10;
        private Button btnDelete;
        private Button btnLoad;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnAdd;
    }
}
