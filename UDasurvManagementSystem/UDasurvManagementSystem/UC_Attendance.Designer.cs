namespace UDasurvManagementSystem
{
    partial class UC_Attendance
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
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle28 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
            TableAttendance = new DataGridView();
            colEmployeeName = new DataGridViewTextBoxColumn();
            colTimeIn = new DataGridViewTextBoxColumn();
            colTimeOut = new DataGridViewTextBoxColumn();
            colTotalHours = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            label5 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            label6 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button1 = new Button();
            textBox6 = new TextBox();
            label10 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)TableAttendance).BeginInit();
            SuspendLayout();
            // 
            // TableAttendance
            // 
            TableAttendance.AllowUserToAddRows = false;
            TableAttendance.AllowUserToDeleteRows = false;
            TableAttendance.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.BackColor = Color.FromArgb(250, 250, 250);
            TableAttendance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            TableAttendance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TableAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TableAttendance.BackgroundColor = Color.White;
            dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = Color.FromArgb(40, 96, 144);
            dataGridViewCellStyle26.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle26.ForeColor = Color.White;
            dataGridViewCellStyle26.WrapMode = DataGridViewTriState.True;
            TableAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            TableAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TableAttendance.Columns.AddRange(new DataGridViewColumn[] { colEmployeeName, colTimeIn, colTimeOut, colTotalHours, colStatus });
            dataGridViewCellStyle28.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = SystemColors.Window;
            dataGridViewCellStyle28.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle28.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle28.Padding = new Padding(4, 0, 4, 0);
            dataGridViewCellStyle28.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = DataGridViewTriState.False;
            TableAttendance.DefaultCellStyle = dataGridViewCellStyle28;
            TableAttendance.EnableHeadersVisualStyles = false;
            TableAttendance.GridColor = Color.LightGray;
            TableAttendance.Location = new Point(16, 171);
            TableAttendance.MultiSelect = false;
            TableAttendance.Name = "TableAttendance";
            TableAttendance.ReadOnly = true;
            TableAttendance.RowTemplate.Height = 30;
            TableAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TableAttendance.Size = new Size(1050, 514);
            TableAttendance.TabIndex = 0;
            // 
            // colEmployeeName
            // 
            colEmployeeName.FillWeight = 200F;
            colEmployeeName.HeaderText = "Employee Name";
            colEmployeeName.Name = "colEmployeeName";
            colEmployeeName.ReadOnly = true;
            // 
            // colTimeIn
            // 
            colTimeIn.FillWeight = 90F;
            colTimeIn.HeaderText = "Time In";
            colTimeIn.Name = "colTimeIn";
            colTimeIn.ReadOnly = true;
            // 
            // colTimeOut
            // 
            colTimeOut.FillWeight = 90F;
            colTimeOut.HeaderText = "Time Out";
            colTimeOut.Name = "colTimeOut";
            colTimeOut.ReadOnly = true;
            // 
            // colTotalHours
            // 
            colTotalHours.FillWeight = 80F;
            colTotalHours.HeaderText = "Total Hours";
            colTotalHours.Name = "colTotalHours";
            colTotalHours.ReadOnly = true;
            // 
            // colStatus
            // 
            dataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colStatus.DefaultCellStyle = dataGridViewCellStyle27;
            colStatus.FillWeight = 80F;
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 13);
            label5.Name = "label5";
            label5.Size = new Size(254, 22);
            label5.TabIndex = 3;
            label5.Text = "EMPLOYEE ATTENDANCE";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 12F);
            textBox1.Location = new Point(161, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(249, 26);
            textBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 59);
            label1.Name = "label1";
            label1.Size = new Size(139, 19);
            label1.TabIndex = 4;
            label1.Text = "Employee Name:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 12F);
            textBox2.Location = new Point(92, 89);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(118, 26);
            textBox2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 92);
            label2.Name = "label2";
            label2.Size = new Size(70, 19);
            label2.TabIndex = 6;
            label2.Text = "Time in:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Arial", 12F);
            textBox3.Location = new Point(292, 89);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(118, 26);
            textBox3.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(216, 92);
            label3.Name = "label3";
            label3.Size = new Size(70, 19);
            label3.TabIndex = 8;
            label3.Text = "Time in:";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Arial", 12F);
            textBox4.Location = new Point(550, 56);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(118, 26);
            textBox4.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(441, 59);
            label4.Name = "label4";
            label4.Size = new Size(103, 19);
            label4.TabIndex = 10;
            label4.Text = "Total Hours:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(441, 92);
            label6.Name = "label6";
            label6.Size = new Size(64, 19);
            label6.TabIndex = 12;
            label6.Text = "Status:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Arial", 11.25F);
            radioButton1.Location = new Point(511, 91);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(77, 21);
            radioButton1.TabIndex = 13;
            radioButton1.TabStop = true;
            radioButton1.Text = "Present";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Arial", 11.25F);
            radioButton2.Location = new Point(597, 91);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(71, 21);
            radioButton2.TabIndex = 14;
            radioButton2.TabStop = true;
            radioButton2.Text = "Absent";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(303, 142);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 19;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Arial", 12F);
            textBox6.Location = new Point(83, 139);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(214, 26);
            textBox6.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(15, 142);
            label10.Name = "label10";
            label10.Size = new Size(62, 18);
            label10.TabIndex = 17;
            label10.Text = "Search:";
            // 
            // button2
            // 
            button2.Location = new Point(690, 58);
            button2.Name = "button2";
            button2.Size = new Size(163, 23);
            button2.TabIndex = 20;
            button2.Text = "ADD";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(690, 91);
            button3.Name = "button3";
            button3.Size = new Size(163, 23);
            button3.TabIndex = 21;
            button3.Text = "CLEAR";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(910, 142);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 23;
            button4.Text = "LOAD";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(829, 141);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 22;
            button5.Text = "UPDATE";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(991, 142);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 24;
            button6.Text = "DELETE";
            button6.UseVisualStyleBackColor = true;
            // 
            // UC_Attendance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(label10);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(TableAttendance);
            Name = "UC_Attendance";
            Size = new Size(1083, 702);
            ((System.ComponentModel.ISupportInitialize)TableAttendance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView TableAttendance;
        private DataGridViewTextBoxColumn colEmployeeName;
        private DataGridViewTextBoxColumn colTimeIn;
        private DataGridViewTextBoxColumn colTimeOut;
        private DataGridViewTextBoxColumn colTotalHours;
        private DataGridViewTextBoxColumn colStatus;
        private Label label5;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Label label6;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button1;
        private TextBox textBox6;
        private Label label10;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
