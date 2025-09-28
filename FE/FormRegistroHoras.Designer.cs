namespace EmpresaManzanilla.FE
{
    partial class FormRegistroHoras
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
            groupBox1 = new GroupBox();
            buttonRegistrarHoras = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            Descanso = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePickerFechaRegistroHoras = new DateTimePicker();
            comboBoxEmpleado = new ComboBox();
            label6 = new Label();
            checkBoxFeriado = new CheckBox();
            label5 = new Label();
            numericUpDownPrecioHoraRegistroHoras = new NumericUpDown();
            tableLayoutPanel2 = new TableLayoutPanel();
            numericUpDownDescanso = new NumericUpDown();
            numericUpDownHoraIngreso = new NumericUpDown();
            numericUpDownMinutoIngreso = new NumericUpDown();
            numericUpDownHoraSalida = new NumericUpDown();
            numericUpDownMinutoSalida = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecioHoraRegistroHoras).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDescanso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHoraIngreso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinutoIngreso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHoraSalida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinutoSalida).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel3);
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Controls.Add(buttonRegistrarHoras);
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1144, 474);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro de horas";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // buttonRegistrarHoras
            // 
            buttonRegistrarHoras.Location = new Point(751, 166);
            buttonRegistrarHoras.Name = "buttonRegistrarHoras";
            buttonRegistrarHoras.Size = new Size(149, 57);
            buttonRegistrarHoras.TabIndex = 1;
            buttonRegistrarHoras.Text = "Registrar horas";
            buttonRegistrarHoras.UseVisualStyleBackColor = true;
            buttonRegistrarHoras.Click += buttonRegistrarHoras_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.10185F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.89815F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(dateTimePickerFechaRegistroHoras, 1, 1);
            tableLayoutPanel1.Controls.Add(comboBoxEmpleado, 1, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(label6, 0, 3);
            tableLayoutPanel1.Controls.Add(checkBoxFeriado, 1, 3);
            tableLayoutPanel1.Controls.Add(numericUpDownPrecioHoraRegistroHoras, 1, 2);
            tableLayoutPanel1.Location = new Point(158, 56);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(432, 149);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Descanso
            // 
            Descanso.Anchor = AnchorStyles.Left;
            Descanso.AutoSize = true;
            Descanso.Location = new Point(3, 11);
            Descanso.Name = "Descanso";
            Descanso.Size = new Size(72, 20);
            Descanso.TabIndex = 2;
            Descanso.Text = "Descanso";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 8);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 1;
            label1.Text = "Empleado";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 45);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 2;
            label2.Text = "Fecha";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 9);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 3;
            label3.Text = "Hora Ingreso";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 47);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 4;
            label4.Text = "Hora Salida";
            // 
            // dateTimePickerFechaRegistroHoras
            // 
            dateTimePickerFechaRegistroHoras.Anchor = AnchorStyles.Left;
            dateTimePickerFechaRegistroHoras.Format = DateTimePickerFormat.Short;
            dateTimePickerFechaRegistroHoras.Location = new Point(145, 42);
            dateTimePickerFechaRegistroHoras.Name = "dateTimePickerFechaRegistroHoras";
            dateTimePickerFechaRegistroHoras.Size = new Size(250, 27);
            dateTimePickerFechaRegistroHoras.TabIndex = 7;
            // 
            // comboBoxEmpleado
            // 
            comboBoxEmpleado.Anchor = AnchorStyles.Left;
            comboBoxEmpleado.FormattingEnabled = true;
            comboBoxEmpleado.Location = new Point(145, 4);
            comboBoxEmpleado.Name = "comboBoxEmpleado";
            comboBoxEmpleado.Size = new Size(251, 28);
            comboBoxEmpleado.TabIndex = 1;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 120);
            label6.Name = "label6";
            label6.Size = new Size(128, 20);
            label6.TabIndex = 6;
            label6.Text = "Feriado/Domingo";
            // 
            // checkBoxFeriado
            // 
            checkBoxFeriado.Anchor = AnchorStyles.Left;
            checkBoxFeriado.AutoSize = true;
            checkBoxFeriado.Location = new Point(145, 121);
            checkBoxFeriado.Name = "checkBoxFeriado";
            checkBoxFeriado.Size = new Size(18, 17);
            checkBoxFeriado.TabIndex = 11;
            checkBoxFeriado.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 82);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 5;
            label5.Text = "Precio/Hora";
            // 
            // numericUpDownPrecioHoraRegistroHoras
            // 
            numericUpDownPrecioHoraRegistroHoras.Anchor = AnchorStyles.Left;
            numericUpDownPrecioHoraRegistroHoras.Location = new Point(145, 79);
            numericUpDownPrecioHoraRegistroHoras.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownPrecioHoraRegistroHoras.Name = "numericUpDownPrecioHoraRegistroHoras";
            numericUpDownPrecioHoraRegistroHoras.Size = new Size(250, 27);
            numericUpDownPrecioHoraRegistroHoras.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.1F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.725F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.725F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.725F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.725F));
            tableLayoutPanel2.Controls.Add(label10, 4, 1);
            tableLayoutPanel2.Controls.Add(label9, 2, 1);
            tableLayoutPanel2.Controls.Add(label8, 4, 0);
            tableLayoutPanel2.Controls.Add(numericUpDownHoraSalida, 1, 1);
            tableLayoutPanel2.Controls.Add(numericUpDownHoraIngreso, 1, 0);
            tableLayoutPanel2.Controls.Add(label4, 0, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Controls.Add(numericUpDownMinutoIngreso, 3, 0);
            tableLayoutPanel2.Controls.Add(numericUpDownMinutoSalida, 3, 1);
            tableLayoutPanel2.Controls.Add(label7, 2, 0);
            tableLayoutPanel2.Location = new Point(158, 259);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(432, 76);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // numericUpDownDescanso
            // 
            numericUpDownDescanso.Anchor = AnchorStyles.Left;
            numericUpDownDescanso.Location = new Point(145, 4);
            numericUpDownDescanso.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            numericUpDownDescanso.Name = "numericUpDownDescanso";
            numericUpDownDescanso.Size = new Size(138, 27);
            numericUpDownDescanso.TabIndex = 12;
            // 
            // numericUpDownHoraIngreso
            // 
            numericUpDownHoraIngreso.Anchor = AnchorStyles.Left;
            numericUpDownHoraIngreso.Location = new Point(145, 5);
            numericUpDownHoraIngreso.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            numericUpDownHoraIngreso.Name = "numericUpDownHoraIngreso";
            numericUpDownHoraIngreso.Size = new Size(66, 27);
            numericUpDownHoraIngreso.TabIndex = 13;
            numericUpDownHoraIngreso.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // numericUpDownMinutoIngreso
            // 
            numericUpDownMinutoIngreso.Anchor = AnchorStyles.Left;
            numericUpDownMinutoIngreso.Location = new Point(289, 5);
            numericUpDownMinutoIngreso.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDownMinutoIngreso.Name = "numericUpDownMinutoIngreso";
            numericUpDownMinutoIngreso.Size = new Size(66, 27);
            numericUpDownMinutoIngreso.TabIndex = 14;
            // 
            // numericUpDownHoraSalida
            // 
            numericUpDownHoraSalida.Anchor = AnchorStyles.Left;
            numericUpDownHoraSalida.Location = new Point(145, 43);
            numericUpDownHoraSalida.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            numericUpDownHoraSalida.Name = "numericUpDownHoraSalida";
            numericUpDownHoraSalida.Size = new Size(66, 27);
            numericUpDownHoraSalida.TabIndex = 15;
            numericUpDownHoraSalida.Value = new decimal(new int[] { 16, 0, 0, 0 });
            // 
            // numericUpDownMinutoSalida
            // 
            numericUpDownMinutoSalida.Anchor = AnchorStyles.Left;
            numericUpDownMinutoSalida.Location = new Point(289, 43);
            numericUpDownMinutoSalida.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDownMinutoSalida.Name = "numericUpDownMinutoSalida";
            numericUpDownMinutoSalida.Size = new Size(66, 27);
            numericUpDownMinutoSalida.TabIndex = 16;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(217, 9);
            label7.Name = "label7";
            label7.Size = new Size(26, 20);
            label7.TabIndex = 17;
            label7.Text = "Hs";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(361, 9);
            label8.Name = "label8";
            label8.Size = new Size(34, 20);
            label8.TabIndex = 18;
            label8.Text = "Min";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(217, 47);
            label9.Name = "label9";
            label9.Size = new Size(26, 20);
            label9.TabIndex = 19;
            label9.Text = "Hs";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Location = new Point(361, 47);
            label10.Name = "label10";
            label10.Size = new Size(34, 20);
            label10.TabIndex = 20;
            label10.Text = "Min";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Location = new Point(289, 11);
            label11.Name = "label11";
            label11.Size = new Size(62, 20);
            label11.TabIndex = 6;
            label11.Text = "Minutos";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.1F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.45F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.45F));
            tableLayoutPanel3.Controls.Add(Descanso, 0, 0);
            tableLayoutPanel3.Controls.Add(label11, 2, 0);
            tableLayoutPanel3.Controls.Add(numericUpDownDescanso, 1, 0);
            tableLayoutPanel3.Location = new Point(158, 211);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(432, 42);
            tableLayoutPanel3.TabIndex = 13;
            // 
            // FormRegistroHoras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 474);
            Controls.Add(groupBox1);
            Name = "FormRegistroHoras";
            Text = "FormRegistroHoras";
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecioHoraRegistroHoras).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDescanso).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHoraIngreso).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinutoIngreso).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHoraSalida).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinutoSalida).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label6;
        private ComboBox comboBoxEmpleado;
        private DateTimePicker dateTimePickerFechaRegistroHoras;
        private NumericUpDown numericUpDownPrecioHoraRegistroHoras;
        private CheckBox checkBoxFeriado;
        private Button buttonRegistrarHoras;
        private Label Descanso;
        private TableLayoutPanel tableLayoutPanel2;
        private NumericUpDown numericUpDownHoraSalida;
        private NumericUpDown numericUpDownHoraIngreso;
        private NumericUpDown numericUpDownMinutoIngreso;
        private NumericUpDown numericUpDownMinutoSalida;
        private NumericUpDown numericUpDownDescanso;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label11;
    }
}