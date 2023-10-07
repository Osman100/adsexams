namespace Ejercicio4ADSExamenPractico2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            nombreAER = new TextBox();
            ApellidoAER = new TextBox();
            SueldoAER = new TextBox();
            aeromozaRegistry = new DataGridView();
            idAeromoza = new DataGridViewTextBoxColumn();
            nombreAeromoza = new DataGridViewTextBoxColumn();
            apellidoAeromoza = new DataGridViewTextBoxColumn();
            sueldo = new DataGridViewTextBoxColumn();
            button1 = new Button();
            labelAER = new Label();
            IDAER = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)aeromozaRegistry).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(241, 40);
            label1.Name = "label1";
            label1.Size = new Size(348, 45);
            label1.TabIndex = 0;
            label1.Text = "Registro de aeromoza";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 221);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 298);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 374);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 3;
            label4.Text = "Sueldo:";
            // 
            // nombreAER
            // 
            nombreAER.Location = new Point(31, 252);
            nombreAER.Name = "nombreAER";
            nombreAER.Size = new Size(214, 23);
            nombreAER.TabIndex = 4;
            // 
            // ApellidoAER
            // 
            ApellidoAER.Location = new Point(31, 329);
            ApellidoAER.Name = "ApellidoAER";
            ApellidoAER.Size = new Size(214, 23);
            ApellidoAER.TabIndex = 5;
            // 
            // SueldoAER
            // 
            SueldoAER.Location = new Point(31, 401);
            SueldoAER.Name = "SueldoAER";
            SueldoAER.Size = new Size(214, 23);
            SueldoAER.TabIndex = 6;
            // 
            // aeromozaRegistry
            // 
            aeromozaRegistry.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            aeromozaRegistry.Columns.AddRange(new DataGridViewColumn[] { idAeromoza, nombreAeromoza, apellidoAeromoza, sueldo });
            aeromozaRegistry.Location = new Point(315, 114);
            aeromozaRegistry.Name = "aeromozaRegistry";
            aeromozaRegistry.RowTemplate.Height = 25;
            aeromozaRegistry.Size = new Size(443, 303);
            aeromozaRegistry.TabIndex = 7;
            aeromozaRegistry.CellContentClick += dataGridView1_CellContentClick;
            // 
            // idAeromoza
            // 
            idAeromoza.HeaderText = "ID Aeromoza";
            idAeromoza.Name = "idAeromoza";
            // 
            // nombreAeromoza
            // 
            nombreAeromoza.HeaderText = "Nombre de Aeromoza";
            nombreAeromoza.Name = "nombreAeromoza";
            // 
            // apellidoAeromoza
            // 
            apellidoAeromoza.HeaderText = "Apellido de Aeromoza";
            apellidoAeromoza.Name = "apellidoAeromoza";
            // 
            // sueldo
            // 
            sueldo.HeaderText = "Sueldo";
            sueldo.Name = "sueldo";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(356, 444);
            button1.Name = "button1";
            button1.Size = new Size(114, 37);
            button1.TabIndex = 8;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelAER
            // 
            labelAER.AutoSize = true;
            labelAER.Location = new Point(31, 153);
            labelAER.Name = "labelAER";
            labelAER.Size = new Size(94, 15);
            labelAER.TabIndex = 9;
            labelAER.Text = "ID de Aeromoza:";
            // 
            // IDAER
            // 
            IDAER.Location = new Point(31, 181);
            IDAER.Name = "IDAER";
            IDAER.Size = new Size(214, 23);
            IDAER.TabIndex = 10;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(548, 444);
            button2.Name = "button2";
            button2.Size = new Size(198, 37);
            button2.TabIndex = 11;
            button2.Text = "Regresar al menu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 491);
            Controls.Add(button2);
            Controls.Add(IDAER);
            Controls.Add(labelAER);
            Controls.Add(button1);
            Controls.Add(aeromozaRegistry);
            Controls.Add(SueldoAER);
            Controls.Add(ApellidoAER);
            Controls.Add(nombreAER);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)aeromozaRegistry).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox nombreAER;
        private TextBox ApellidoAER;
        private TextBox SueldoAER;
        private DataGridView aeromozaRegistry;
        private DataGridViewTextBoxColumn idAeromoza;
        private DataGridViewTextBoxColumn nombreAeromoza;
        private DataGridViewTextBoxColumn apellidoAeromoza;
        private DataGridViewTextBoxColumn sueldo;
        private Button button1;
        private Label labelAER;
        private TextBox IDAER;
        private Button button2;
    }
}