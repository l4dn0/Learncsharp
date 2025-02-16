namespace Task15_1
{
    partial class DispatcherForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.AddCruise = new System.Windows.Forms.GroupBox();
            this.addCompletedCruiseCheckbox = new System.Windows.Forms.CheckBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.addCarBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addDriverBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addCruiseDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.addFromToBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.completedCruiseCheckbox = new System.Windows.Forms.CheckBox();
            this.editButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.carBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.driverBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cruiseDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.fromToBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.driverListbox = new System.Windows.Forms.ListBox();
            this.carBrokenCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.driverCarBrokenCheckbox = new System.Windows.Forms.CheckBox();
            this.driverCompletedCruiseCheckbox = new System.Windows.Forms.CheckBox();
            this.driverEditButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.driverCarBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.driverDriverBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.driverDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.driverFromToBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.AddCruise.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 332);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.AddCruise);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 306);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Диспетчер";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(8, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Список рейсов";
            // 
            // AddCruise
            // 
            this.AddCruise.Controls.Add(this.addCompletedCruiseCheckbox);
            this.AddCruise.Controls.Add(this.addButton);
            this.AddCruise.Controls.Add(this.label6);
            this.AddCruise.Controls.Add(this.addCarBox);
            this.AddCruise.Controls.Add(this.label7);
            this.AddCruise.Controls.Add(this.addDriverBox);
            this.AddCruise.Controls.Add(this.label8);
            this.AddCruise.Controls.Add(this.addCruiseDatePicker);
            this.AddCruise.Controls.Add(this.label9);
            this.AddCruise.Controls.Add(this.addFromToBox);
            this.AddCruise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCruise.Location = new System.Drawing.Point(10, 160);
            this.AddCruise.Name = "AddCruise";
            this.AddCruise.Size = new System.Drawing.Size(776, 138);
            this.AddCruise.TabIndex = 2;
            this.AddCruise.TabStop = false;
            this.AddCruise.Text = "Создать новый рейс";
            // 
            // addCompletedCruiseCheckbox
            // 
            this.addCompletedCruiseCheckbox.AutoSize = true;
            this.addCompletedCruiseCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCompletedCruiseCheckbox.Location = new System.Drawing.Point(447, 109);
            this.addCompletedCruiseCheckbox.Name = "addCompletedCruiseCheckbox";
            this.addCompletedCruiseCheckbox.Size = new System.Drawing.Size(77, 17);
            this.addCompletedCruiseCheckbox.TabIndex = 19;
            this.addCompletedCruiseCheckbox.Text = "Завершён";
            this.addCompletedCruiseCheckbox.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(676, 104);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 24);
            this.addButton.TabIndex = 18;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(298, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Машина";
            // 
            // addCarBox
            // 
            this.addCarBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCarBox.Location = new System.Drawing.Point(301, 108);
            this.addCarBox.Name = "addCarBox";
            this.addCarBox.Size = new System.Drawing.Size(131, 20);
            this.addCarBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(130, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Водитель";
            // 
            // addDriverBox
            // 
            this.addDriverBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addDriverBox.Location = new System.Drawing.Point(133, 108);
            this.addDriverBox.Name = "addDriverBox";
            this.addDriverBox.Size = new System.Drawing.Size(126, 20);
            this.addDriverBox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Дата";
            // 
            // addCruiseDatePicker
            // 
            this.addCruiseDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCruiseDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.addCruiseDatePicker.Location = new System.Drawing.Point(9, 108);
            this.addCruiseDatePicker.Name = "addCruiseDatePicker";
            this.addCruiseDatePicker.Size = new System.Drawing.Size(95, 20);
            this.addCruiseDatePicker.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Откуда - куда";
            // 
            // addFromToBox
            // 
            this.addFromToBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addFromToBox.Location = new System.Drawing.Point(9, 49);
            this.addFromToBox.Name = "addFromToBox";
            this.addFromToBox.Size = new System.Drawing.Size(290, 20);
            this.addFromToBox.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.carBrokenCheckbox);
            this.groupBox1.Controls.Add(this.completedCruiseCheckbox);
            this.groupBox1.Controls.Add(this.editButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.carBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.driverBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cruiseDatePicker);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fromToBox);
            this.groupBox1.Location = new System.Drawing.Point(255, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 114);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // completedCruiseCheckbox
            // 
            this.completedCruiseCheckbox.AutoSize = true;
            this.completedCruiseCheckbox.Location = new System.Drawing.Point(333, 34);
            this.completedCruiseCheckbox.Name = "completedCruiseCheckbox";
            this.completedCruiseCheckbox.Size = new System.Drawing.Size(77, 17);
            this.completedCruiseCheckbox.TabIndex = 9;
            this.completedCruiseCheckbox.Text = "Завершён";
            this.completedCruiseCheckbox.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(429, 32);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 67);
            this.editButton.TabIndex = 8;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Машина";
            // 
            // carBox
            // 
            this.carBox.Location = new System.Drawing.Point(247, 79);
            this.carBox.Name = "carBox";
            this.carBox.Size = new System.Drawing.Size(59, 20);
            this.carBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Водитель";
            // 
            // driverBox
            // 
            this.driverBox.Location = new System.Drawing.Point(135, 79);
            this.driverBox.Name = "driverBox";
            this.driverBox.Size = new System.Drawing.Size(88, 20);
            this.driverBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дата";
            // 
            // cruiseDatePicker
            // 
            this.cruiseDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cruiseDatePicker.Location = new System.Drawing.Point(24, 79);
            this.cruiseDatePicker.Name = "cruiseDatePicker";
            this.cruiseDatePicker.Size = new System.Drawing.Size(95, 20);
            this.cruiseDatePicker.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Откуда - куда";
            // 
            // fromToBox
            // 
            this.fromToBox.Location = new System.Drawing.Point(24, 32);
            this.fromToBox.Name = "fromToBox";
            this.fromToBox.Size = new System.Drawing.Size(290, 20);
            this.fromToBox.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(8, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(241, 108);
            this.listBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.driverListbox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 306);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Водитель";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // driverListbox
            // 
            this.driverListbox.FormattingEnabled = true;
            this.driverListbox.Location = new System.Drawing.Point(8, 6);
            this.driverListbox.Name = "driverListbox";
            this.driverListbox.Size = new System.Drawing.Size(241, 108);
            this.driverListbox.TabIndex = 1;
            // 
            // carBrokenCheckbox
            // 
            this.carBrokenCheckbox.AutoSize = true;
            this.carBrokenCheckbox.Enabled = false;
            this.carBrokenCheckbox.Location = new System.Drawing.Point(333, 79);
            this.carBrokenCheckbox.Name = "carBrokenCheckbox";
            this.carBrokenCheckbox.Size = new System.Drawing.Size(80, 17);
            this.carBrokenCheckbox.TabIndex = 10;
            this.carBrokenCheckbox.Text = "На ремонт";
            this.carBrokenCheckbox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.driverCarBrokenCheckbox);
            this.groupBox2.Controls.Add(this.driverCompletedCruiseCheckbox);
            this.groupBox2.Controls.Add(this.driverEditButton);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.driverCarBox);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.driverDriverBox);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.driverDateTimePicker);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.driverFromToBox);
            this.groupBox2.Location = new System.Drawing.Point(255, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(529, 114);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // driverCarBrokenCheckbox
            // 
            this.driverCarBrokenCheckbox.AutoSize = true;
            this.driverCarBrokenCheckbox.Location = new System.Drawing.Point(333, 79);
            this.driverCarBrokenCheckbox.Name = "driverCarBrokenCheckbox";
            this.driverCarBrokenCheckbox.Size = new System.Drawing.Size(80, 17);
            this.driverCarBrokenCheckbox.TabIndex = 10;
            this.driverCarBrokenCheckbox.Text = "На ремонт";
            this.driverCarBrokenCheckbox.UseVisualStyleBackColor = true;
            // 
            // driverCompletedCruiseCheckbox
            // 
            this.driverCompletedCruiseCheckbox.AutoSize = true;
            this.driverCompletedCruiseCheckbox.Location = new System.Drawing.Point(333, 34);
            this.driverCompletedCruiseCheckbox.Name = "driverCompletedCruiseCheckbox";
            this.driverCompletedCruiseCheckbox.Size = new System.Drawing.Size(77, 17);
            this.driverCompletedCruiseCheckbox.TabIndex = 9;
            this.driverCompletedCruiseCheckbox.Text = "Завершён";
            this.driverCompletedCruiseCheckbox.UseVisualStyleBackColor = true;
            // 
            // driverEditButton
            // 
            this.driverEditButton.Location = new System.Drawing.Point(429, 32);
            this.driverEditButton.Name = "driverEditButton";
            this.driverEditButton.Size = new System.Drawing.Size(75, 67);
            this.driverEditButton.TabIndex = 8;
            this.driverEditButton.Text = "Изменить";
            this.driverEditButton.UseVisualStyleBackColor = true;
            this.driverEditButton.Click += new System.EventHandler(this.driverEditButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(244, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Машина";
            // 
            // driverCarBox
            // 
            this.driverCarBox.Location = new System.Drawing.Point(247, 79);
            this.driverCarBox.Name = "driverCarBox";
            this.driverCarBox.Size = new System.Drawing.Size(59, 20);
            this.driverCarBox.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(132, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Водитель";
            // 
            // driverDriverBox
            // 
            this.driverDriverBox.Enabled = false;
            this.driverDriverBox.Location = new System.Drawing.Point(135, 79);
            this.driverDriverBox.Name = "driverDriverBox";
            this.driverDriverBox.Size = new System.Drawing.Size(88, 20);
            this.driverDriverBox.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Дата";
            // 
            // driverDateTimePicker
            // 
            this.driverDateTimePicker.Enabled = false;
            this.driverDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.driverDateTimePicker.Location = new System.Drawing.Point(24, 79);
            this.driverDateTimePicker.Name = "driverDateTimePicker";
            this.driverDateTimePicker.Size = new System.Drawing.Size(95, 20);
            this.driverDateTimePicker.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Откуда - куда";
            // 
            // driverFromToBox
            // 
            this.driverFromToBox.Enabled = false;
            this.driverFromToBox.Location = new System.Drawing.Point(24, 32);
            this.driverFromToBox.Name = "driverFromToBox";
            this.driverFromToBox.Size = new System.Drawing.Size(290, 20);
            this.driverFromToBox.TabIndex = 0;
            // 
            // DispatcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 332);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DispatcherForm";
            this.Text = "Меню диспетчера";
            this.Load += new System.EventHandler(this.DispatcherForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.AddCruise.ResumeLayout(false);
            this.AddCruise.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fromToBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox carBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox driverBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker cruiseDatePicker;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.CheckBox completedCruiseCheckbox;
        private System.Windows.Forms.GroupBox AddCruise;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox addCompletedCruiseCheckbox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addCarBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addDriverBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker addCruiseDatePicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox addFromToBox;
        private System.Windows.Forms.ListBox driverListbox;
        private System.Windows.Forms.CheckBox carBrokenCheckbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox driverCarBrokenCheckbox;
        private System.Windows.Forms.CheckBox driverCompletedCruiseCheckbox;
        private System.Windows.Forms.Button driverEditButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox driverCarBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox driverDriverBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker driverDateTimePicker;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox driverFromToBox;
    }
}

