namespace Ventana1_lab3
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
            txtFruta = new TextBox();
            txtCajas = new TextBox();
            txtDistancia = new TextBox();
            txtPagot = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(175, 79);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 0;
            label1.Text = "Tipo de fruta:\r\n";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(175, 121);
            label2.Name = "label2";
            label2.Size = new Size(165, 25);
            label2.TabIndex = 1;
            label2.Text = "Cantidad de cajas:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(175, 166);
            label3.Name = "label3";
            label3.Size = new Size(178, 25);
            label3.TabIndex = 2;
            label3.Text = "Distancia Recorrida:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(175, 211);
            label4.Name = "label4";
            label4.Size = new Size(103, 25);
            label4.TabIndex = 3;
            label4.Text = "Pago Total:";
            // 
            // txtFruta
            // 
            txtFruta.Location = new Point(435, 79);
            txtFruta.Name = "txtFruta";
            txtFruta.Size = new Size(100, 23);
            txtFruta.TabIndex = 4;
            // 
            // txtCajas
            // 
            txtCajas.Location = new Point(435, 123);
            txtCajas.Name = "txtCajas";
            txtCajas.Size = new Size(100, 23);
            txtCajas.TabIndex = 5;
            // 
            // txtDistancia
            // 
            txtDistancia.Location = new Point(435, 166);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.Size = new Size(100, 23);
            txtDistancia.TabIndex = 6;
            // 
            // txtPagot
            // 
            txtPagot.Location = new Point(435, 211);
            txtPagot.Name = "txtPagot";
            txtPagot.Size = new Size(100, 23);
            txtPagot.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(331, 274);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtPagot);
            Controls.Add(txtDistancia);
            Controls.Add(txtCajas);
            Controls.Add(txtFruta);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtFruta;
        private TextBox txtCajas;
        private TextBox txtDistancia;
        private TextBox txtPagot;
        private Button button1;
    }
}