namespace WinFormsApp1
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
            //
            txtPrecio = new Label();
            checkBox1 = new CheckBox();
            CalcularPrecio_Click = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 91);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 0;
            label1.Text = "Texto";
            label1.Click += label1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(169, 241);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(91, 24);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Urgente?";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // CalcularPrecio_Click
            // 
            CalcularPrecio_Click.Location = new Point(525, 320);
            CalcularPrecio_Click.Name = "CalcularPrecio_Click";
            CalcularPrecio_Click.Size = new Size(161, 72);
            CalcularPrecio_Click.TabIndex = 2;
            CalcularPrecio_Click.Text = "Calcular";
            CalcularPrecio_Click.UseVisualStyleBackColor = true;
            CalcularPrecio_Click.Click += button_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 300);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "Coste:";
            // 
            // textBox1
            // 
            txtTelegrama.Location = new Point(169, 300);
            txtTelegrama.Name = "textBox1";
            txtTelegrama.Size = new Size(115, 27);
            Texto.TabIndex = 4;
            txtTelegrama.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            txtPrecio.Location = new Point(128, 114);
            txtPrecio.Multiline = true;
            txtPrecio.Name = "textBox2";
            txtPrecio.Size = new Size(389, 79);
            Coste.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtTelegrama);
            Controls.Add(Texto);
            Controls.Add(Coste);
            Controls.Add(txtPrecio);
            Controls.Add(chkUrgente);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }
       
        #endregion

        private CheckBox chkUrgente;
        private TextBox txtPrecio;
        private Label Coste;
        private Label Texto;
        private TextBox txtTelegrama;
        private Button button1;
    }
}
