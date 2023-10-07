namespace Ejercicio4ADSExamenPractico2
{
    partial class RegistroPasajero
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            idPasajero = new TextBox();
            nombrePasajero = new TextBox();
            apellidoPasajero = new TextBox();
            tipoAsiento = new ComboBox();
            pasajeroGrid = new DataGridView();
            IDPasajero1 = new DataGridViewTextBoxColumn();
            NombrePasajero1 = new DataGridViewTextBoxColumn();
            ApellidoPasajero1 = new DataGridViewTextBoxColumn();
            TipoAsiento1 = new DataGridViewTextBoxColumn();
            registro = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pasajeroGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(224, 30);
            label1.Name = "label1";
            label1.Size = new Size(340, 45);
            label1.TabIndex = 0;
            label1.Text = "Registro de Pasajeros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 108);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 1;
            label2.Text = "ID del pasajero:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 181);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre del pasajero:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 256);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 3;
            label4.Text = "Apellido del pasajero:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 341);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 4;
            label5.Text = "Tipo de asiento";
            // 
            // idPasajero
            // 
            idPasajero.Location = new Point(46, 147);
            idPasajero.Name = "idPasajero";
            idPasajero.Size = new Size(160, 23);
            idPasajero.TabIndex = 5;
            // 
            // nombrePasajero
            // 
            nombrePasajero.Location = new Point(47, 220);
            nombrePasajero.Name = "nombrePasajero";
            nombrePasajero.Size = new Size(159, 23);
            nombrePasajero.TabIndex = 6;
            // 
            // apellidoPasajero
            // 
            apellidoPasajero.Location = new Point(47, 296);
            apellidoPasajero.Name = "apellidoPasajero";
            apellidoPasajero.Size = new Size(159, 23);
            apellidoPasajero.TabIndex = 7;
            // 
            // tipoAsiento
            // 
            tipoAsiento.FormattingEnabled = true;
            tipoAsiento.Items.AddRange(new object[] { "VIP", "Estandar" });
            tipoAsiento.Location = new Point(46, 375);
            tipoAsiento.Name = "tipoAsiento";
            tipoAsiento.Size = new Size(160, 23);
            tipoAsiento.TabIndex = 8;
            // 
            // pasajeroGrid
            // 
            pasajeroGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pasajeroGrid.Columns.AddRange(new DataGridViewColumn[] { IDPasajero1, NombrePasajero1, ApellidoPasajero1, TipoAsiento1 });
            pasajeroGrid.Location = new Point(301, 105);
            pasajeroGrid.Name = "pasajeroGrid";
            pasajeroGrid.RowTemplate.Height = 25;
            pasajeroGrid.Size = new Size(443, 293);
            pasajeroGrid.TabIndex = 9;
            // 
            // IDPasajero1
            // 
            IDPasajero1.HeaderText = "ID del pasajero";
            IDPasajero1.Name = "IDPasajero1";
            // 
            // NombrePasajero1
            // 
            NombrePasajero1.HeaderText = "Nombre";
            NombrePasajero1.Name = "NombrePasajero1";
            // 
            // ApellidoPasajero1
            // 
            ApellidoPasajero1.HeaderText = "Apellido";
            ApellidoPasajero1.Name = "ApellidoPasajero1";
            // 
            // TipoAsiento1
            // 
            TipoAsiento1.HeaderText = "Tipo de asiento";
            TipoAsiento1.Name = "TipoAsiento1";
            // 
            // registro
            // 
            registro.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            registro.Location = new Point(345, 412);
            registro.Name = "registro";
            registro.Size = new Size(136, 43);
            registro.TabIndex = 10;
            registro.Text = "Registrar";
            registro.UseVisualStyleBackColor = true;
            registro.Click += registro_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(502, 412);
            button1.Name = "button1";
            button1.Size = new Size(242, 43);
            button1.TabIndex = 11;
            button1.Text = "Regresar al menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RegistroPasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 467);
            Controls.Add(button1);
            Controls.Add(registro);
            Controls.Add(pasajeroGrid);
            Controls.Add(tipoAsiento);
            Controls.Add(apellidoPasajero);
            Controls.Add(nombrePasajero);
            Controls.Add(idPasajero);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistroPasajero";
            Text = "RegistroPasajero";
            ((System.ComponentModel.ISupportInitialize)pasajeroGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox idPasajero;
        private TextBox nombrePasajero;
        private TextBox apellidoPasajero;
        private ComboBox tipoAsiento;
        private DataGridView pasajeroGrid;
        private Button registro;
        private DataGridViewTextBoxColumn IDPasajero1;
        private DataGridViewTextBoxColumn NombrePasajero1;
        private DataGridViewTextBoxColumn ApellidoPasajero1;
        private DataGridViewTextBoxColumn TipoAsiento1;
        private Button button1;
    }
}