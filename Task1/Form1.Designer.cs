namespace Task1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            Model = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            bindingSource1 = new BindingSource(components);
            groupBox1 = new GroupBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonAdd = new Button();
            textBox_max = new TextBox();
            textBox_density = new TextBox();
            textBox_type = new TextBox();
            textBox_date = new TextBox();
            textBox_model = new TextBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label5 = new Label();
            buttonUnload = new Button();
            buttonLoad = new Button();
            textBox_load = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Model, Date, Column2, Column4, Column5, Column1, Column3 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(808, 417);
            dataGridView1.TabIndex = 0;
            // 
            // Model
            // 
            Model.DataPropertyName = "Model";
            Model.HeaderText = "Модель";
            Model.MinimumWidth = 6;
            Model.Name = "Model";
            Model.ReadOnly = true;
            // 
            // Date
            // 
            Date.DataPropertyName = "Date_of_issue";
            Date.HeaderText = "Дата производства";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Liquid_type";
            Column2.HeaderText = "Тип жидкости";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Density";
            Column4.HeaderText = "Плотность жидкости";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "MaxCarrying";
            Column5.HeaderText = "Максимальная подъемность";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Carrying";
            Column1.HeaderText = "Масса текущего груза";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Volume";
            Column3.HeaderText = "Объем";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(buttonAdd);
            groupBox1.Controls.Add(textBox_max);
            groupBox1.Controls.Add(textBox_density);
            groupBox1.Controls.Add(textBox_type);
            groupBox1.Controls.Add(textBox_date);
            groupBox1.Controls.Add(textBox_model);
            groupBox1.Location = new Point(832, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(348, 255);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавление корабля";
            // 
            // label6
            // 
            label6.Location = new Point(188, 76);
            label6.Name = "label6";
            label6.Size = new Size(143, 48);
            label6.TabIndex = 13;
            label6.Text = "Плотность жидкости(кг/м^3)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 171);
            label4.Name = "label4";
            label4.Size = new Size(264, 20);
            label4.TabIndex = 10;
            label4.Text = "Максимальная подъемность(тонны)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 104);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 9;
            label3.Text = "Тип жидкости";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 23);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 8;
            label2.Text = "Дата производства";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 23);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 7;
            label1.Text = "Модель";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(237, 203);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBox_max
            // 
            textBox_max.Location = new Point(33, 203);
            textBox_max.Name = "textBox_max";
            textBox_max.Size = new Size(102, 27);
            textBox_max.TabIndex = 4;
            // 
            // textBox_density
            // 
            textBox_density.Location = new Point(189, 127);
            textBox_density.Name = "textBox_density";
            textBox_density.Size = new Size(125, 27);
            textBox_density.TabIndex = 3;
            // 
            // textBox_type
            // 
            textBox_type.Location = new Point(22, 127);
            textBox_type.Name = "textBox_type";
            textBox_type.Size = new Size(125, 27);
            textBox_type.TabIndex = 2;
            // 
            // textBox_date
            // 
            textBox_date.Location = new Point(189, 46);
            textBox_date.Name = "textBox_date";
            textBox_date.Size = new Size(125, 27);
            textBox_date.TabIndex = 1;
            // 
            // textBox_model
            // 
            textBox_model.Location = new Point(22, 46);
            textBox_model.Name = "textBox_model";
            textBox_model.Size = new Size(125, 27);
            textBox_model.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(814, 443);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Список кораблей";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(buttonUnload);
            groupBox3.Controls.Add(buttonLoad);
            groupBox3.Controls.Add(textBox_load);
            groupBox3.Location = new Point(832, 273);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(348, 182);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Загрузка/разгрузка груза";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 44);
            label5.Name = "label5";
            label5.Size = new Size(112, 20);
            label5.TabIndex = 3;
            label5.Text = "Введите массу:";
            // 
            // buttonUnload
            // 
            buttonUnload.Location = new Point(189, 112);
            buttonUnload.Name = "buttonUnload";
            buttonUnload.Size = new Size(94, 29);
            buttonUnload.TabIndex = 2;
            buttonUnload.Text = "Разгрузить";
            buttonUnload.UseVisualStyleBackColor = true;
            buttonUnload.Click += buttonUnload_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(53, 112);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(94, 29);
            buttonLoad.TabIndex = 1;
            buttonLoad.Text = "Загрузить";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // textBox_load
            // 
            textBox_load.Location = new Point(172, 41);
            textBox_load.Name = "textBox_load";
            textBox_load.Size = new Size(125, 27);
            textBox_load.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 478);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource bindingSource1;
        private GroupBox groupBox1;
        private TextBox textBox_model;
        private TextBox textBox_max;
        private TextBox textBox_density;
        private TextBox textBox_type;
        private TextBox textBox_date;
        private Button buttonAdd;
        private GroupBox groupBox2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private DataGridViewTextBoxColumn Model;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private GroupBox groupBox3;
        private Label label5;
        private Button buttonUnload;
        private Button buttonLoad;
        private TextBox textBox_load;
    }
}
