namespace EmpresaManzanilla.FE
{
    partial class FormRegistroEmpleados
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
            tableLayoutPanelEmpleados = new TableLayoutPanel();
            label5 = new Label();
            label3 = new Label();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            textBoxNombre = new TextBox();
            textBoxApellido = new TextBox();
            checkBoxInactivo = new CheckBox();
            label1 = new Label();
            textBoxDNI = new TextBox();
            textBoxTelefono = new TextBox();
            numericUpDownSueldoHora = new NumericUpDown();
            flowLayoutPanelEmpleado = new FlowLayoutPanel();
            buttonRegistrar = new Button();
            groupBox1.SuspendLayout();
            tableLayoutPanelEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSueldoHora).BeginInit();
            flowLayoutPanelEmpleado.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanelEmpleados);
            groupBox1.Location = new Point(191, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(373, 298);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Empleado";
            // 
            // tableLayoutPanelEmpleados
            // 
            tableLayoutPanelEmpleados.ColumnCount = 2;
            tableLayoutPanelEmpleados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.8598576F));
            tableLayoutPanelEmpleados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.1401443F));
            tableLayoutPanelEmpleados.Controls.Add(label5, 0, 2);
            tableLayoutPanelEmpleados.Controls.Add(label3, 0, 1);
            tableLayoutPanelEmpleados.Controls.Add(label6, 0, 5);
            tableLayoutPanelEmpleados.Controls.Add(label4, 0, 4);
            tableLayoutPanelEmpleados.Controls.Add(label2, 0, 3);
            tableLayoutPanelEmpleados.Controls.Add(textBoxNombre, 1, 0);
            tableLayoutPanelEmpleados.Controls.Add(textBoxApellido, 1, 1);
            tableLayoutPanelEmpleados.Controls.Add(checkBoxInactivo, 1, 5);
            tableLayoutPanelEmpleados.Controls.Add(label1, 0, 0);
            tableLayoutPanelEmpleados.Controls.Add(textBoxDNI, 1, 2);
            tableLayoutPanelEmpleados.Controls.Add(textBoxTelefono, 1, 3);
            tableLayoutPanelEmpleados.Controls.Add(numericUpDownSueldoHora, 1, 4);
            tableLayoutPanelEmpleados.Dock = DockStyle.Fill;
            tableLayoutPanelEmpleados.Location = new Point(3, 23);
            tableLayoutPanelEmpleados.Name = "tableLayoutPanelEmpleados";
            tableLayoutPanelEmpleados.RowCount = 6;
            tableLayoutPanelEmpleados.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelEmpleados.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelEmpleados.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelEmpleados.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelEmpleados.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelEmpleados.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelEmpleados.Size = new Size(367, 272);
            tableLayoutPanelEmpleados.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 90);
            label5.Name = "label5";
            label5.Size = new Size(99, 45);
            label5.TabIndex = 4;
            label5.Text = "DNI";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 45);
            label3.Name = "label3";
            label3.Size = new Size(99, 45);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 225);
            label6.Name = "label6";
            label6.Size = new Size(99, 47);
            label6.TabIndex = 5;
            label6.Text = "Inactivo";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 180);
            label4.Name = "label4";
            label4.Size = new Size(99, 45);
            label4.TabIndex = 3;
            label4.Text = "SueldoHora";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 135);
            label2.Name = "label2";
            label2.Size = new Size(99, 45);
            label2.TabIndex = 1;
            label2.Text = "Teléfono";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Anchor = AnchorStyles.Left;
            textBoxNombre.Cursor = Cursors.Hand;
            textBoxNombre.Location = new Point(108, 9);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(256, 27);
            textBoxNombre.TabIndex = 6;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Anchor = AnchorStyles.Left;
            textBoxApellido.Location = new Point(108, 54);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(256, 27);
            textBoxApellido.TabIndex = 7;
            // 
            // checkBoxInactivo
            // 
            checkBoxInactivo.Anchor = AnchorStyles.Left;
            checkBoxInactivo.AutoSize = true;
            checkBoxInactivo.CheckAlign = ContentAlignment.BottomLeft;
            checkBoxInactivo.ImageAlign = ContentAlignment.TopLeft;
            checkBoxInactivo.Location = new Point(108, 240);
            checkBoxInactivo.Name = "checkBoxInactivo";
            checkBoxInactivo.Size = new Size(18, 17);
            checkBoxInactivo.TabIndex = 11;
            checkBoxInactivo.TextAlign = ContentAlignment.BottomRight;
            checkBoxInactivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 45);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxDNI
            // 
            textBoxDNI.Anchor = AnchorStyles.Left;
            textBoxDNI.Location = new Point(108, 99);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.Size = new Size(256, 27);
            textBoxDNI.TabIndex = 8;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Anchor = AnchorStyles.Left;
            textBoxTelefono.Location = new Point(108, 144);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(256, 27);
            textBoxTelefono.TabIndex = 9;
            // 
            // numericUpDownSueldoHora
            // 
            numericUpDownSueldoHora.Anchor = AnchorStyles.Left;
            numericUpDownSueldoHora.Location = new Point(108, 189);
            numericUpDownSueldoHora.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownSueldoHora.Name = "numericUpDownSueldoHora";
            numericUpDownSueldoHora.Size = new Size(256, 27);
            numericUpDownSueldoHora.TabIndex = 10;
            // 
            // flowLayoutPanelEmpleado
            // 
            flowLayoutPanelEmpleado.Controls.Add(buttonRegistrar);
            flowLayoutPanelEmpleado.Location = new Point(256, 316);
            flowLayoutPanelEmpleado.Name = "flowLayoutPanelEmpleado";
            flowLayoutPanelEmpleado.Size = new Size(236, 64);
            flowLayoutPanelEmpleado.TabIndex = 1;
            // 
            // buttonRegistrar
            // 
            buttonRegistrar.Location = new Point(3, 3);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(230, 58);
            buttonRegistrar.TabIndex = 0;
            buttonRegistrar.Text = "Registrar";
            buttonRegistrar.UseVisualStyleBackColor = true;
            buttonRegistrar.Click += buttonRegistrar_Click;
            // 
            // FormRegistroEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 477);
            Controls.Add(flowLayoutPanelEmpleado);
            Controls.Add(groupBox1);
            Name = "FormRegistroEmpleados";
            Text = "FormRegistroEmpleados";
            groupBox1.ResumeLayout(false);
            tableLayoutPanelEmpleados.ResumeLayout(false);
            tableLayoutPanelEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSueldoHora).EndInit();
            flowLayoutPanelEmpleado.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanelEmpleados;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label4;
        private TextBox textBoxNombre;
        private TextBox textBoxApellido;
        private CheckBox checkBoxInactivo;
        private TextBox textBoxDNI;
        private TextBox textBoxTelefono;
        private NumericUpDown numericUpDownSueldoHora;
        private FlowLayoutPanel flowLayoutPanelEmpleado;
        private Button buttonRegistrar;
    }
}