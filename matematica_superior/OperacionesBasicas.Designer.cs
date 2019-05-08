namespace matematica_superior
{
    partial class OperacionesBasicas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errorZ2Label = new System.Windows.Forms.Label();
            this.errorZ1Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.n2Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.n1Text = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.botonDiv = new System.Windows.Forms.Button();
            this.botonResta = new System.Windows.Forms.Button();
            this.botonSuma = new System.Windows.Forms.Button();
            this.botonMult = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.binomialButton = new System.Windows.Forms.RadioButton();
            this.polarOption = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.resultadoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.errorZ2Label);
            this.groupBox1.Controls.Add(this.errorZ1Label);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.n2Text);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.n1Text);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso numeros";
            // 
            // errorZ2Label
            // 
            this.errorZ2Label.ForeColor = System.Drawing.Color.Red;
            this.errorZ2Label.Location = new System.Drawing.Point(51, 131);
            this.errorZ2Label.Name = "errorZ2Label";
            this.errorZ2Label.Size = new System.Drawing.Size(260, 42);
            this.errorZ2Label.TabIndex = 5;
            this.errorZ2Label.Text = "Este es un mensaje de error";
            // 
            // errorZ1Label
            // 
            this.errorZ1Label.ForeColor = System.Drawing.Color.Red;
            this.errorZ1Label.Location = new System.Drawing.Point(51, 55);
            this.errorZ1Label.Name = "errorZ1Label";
            this.errorZ1Label.Size = new System.Drawing.Size(260, 37);
            this.errorZ1Label.TabIndex = 4;
            this.errorZ1Label.Text = "Este es un mensaje de error";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Z2";
            // 
            // n2Text
            // 
            this.n2Text.Location = new System.Drawing.Point(54, 95);
            this.n2Text.Name = "n2Text";
            this.n2Text.Size = new System.Drawing.Size(143, 22);
            this.n2Text.TabIndex = 2;
            this.n2Text.TextChanged += new System.EventHandler(this.n2Text_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Z1";
            // 
            // n1Text
            // 
            this.n1Text.Location = new System.Drawing.Point(54, 30);
            this.n1Text.Name = "n1Text";
            this.n1Text.Size = new System.Drawing.Size(143, 22);
            this.n1Text.TabIndex = 0;
            this.n1Text.TextChanged += new System.EventHandler(this.n1Text_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.botonDiv);
            this.groupBox2.Controls.Add(this.botonResta);
            this.groupBox2.Controls.Add(this.botonSuma);
            this.groupBox2.Controls.Add(this.botonMult);
            this.groupBox2.Location = new System.Drawing.Point(400, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 189);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones";
            // 
            // botonDiv
            // 
            this.botonDiv.Location = new System.Drawing.Point(192, 123);
            this.botonDiv.Name = "botonDiv";
            this.botonDiv.Size = new System.Drawing.Size(109, 36);
            this.botonDiv.TabIndex = 5;
            this.botonDiv.Text = "Division";
            this.botonDiv.UseVisualStyleBackColor = true;
            this.botonDiv.Click += new System.EventHandler(this.botonDiv_Click);
            // 
            // botonResta
            // 
            this.botonResta.Location = new System.Drawing.Point(192, 41);
            this.botonResta.Name = "botonResta";
            this.botonResta.Size = new System.Drawing.Size(109, 36);
            this.botonResta.TabIndex = 4;
            this.botonResta.Text = "Resta";
            this.botonResta.UseVisualStyleBackColor = true;
            this.botonResta.Click += new System.EventHandler(this.botonResta_Click);
            // 
            // botonSuma
            // 
            this.botonSuma.Location = new System.Drawing.Point(25, 41);
            this.botonSuma.Name = "botonSuma";
            this.botonSuma.Size = new System.Drawing.Size(109, 36);
            this.botonSuma.TabIndex = 3;
            this.botonSuma.Text = "Suma";
            this.botonSuma.UseVisualStyleBackColor = true;
            this.botonSuma.Click += new System.EventHandler(this.botonSuma_Click);
            // 
            // botonMult
            // 
            this.botonMult.Location = new System.Drawing.Point(25, 123);
            this.botonMult.Name = "botonMult";
            this.botonMult.Size = new System.Drawing.Size(109, 36);
            this.botonMult.TabIndex = 2;
            this.botonMult.Text = "Multiplicacion";
            this.botonMult.UseVisualStyleBackColor = true;
            this.botonMult.Click += new System.EventHandler(this.botonMult_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.resultadoLabel);
            this.groupBox3.Controls.Add(this.binomialButton);
            this.groupBox3.Controls.Add(this.polarOption);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(21, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 124);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado";
            // 
            // binomialButton
            // 
            this.binomialButton.AutoSize = true;
            this.binomialButton.Location = new System.Drawing.Point(211, 97);
            this.binomialButton.Name = "binomialButton";
            this.binomialButton.Size = new System.Drawing.Size(125, 21);
            this.binomialButton.TabIndex = 7;
            this.binomialButton.Text = "Forma binomial";
            this.binomialButton.UseVisualStyleBackColor = true;
            this.binomialButton.CheckedChanged += new System.EventHandler(this.binomialButton_CheckedChanged);
            // 
            // polarOption
            // 
            this.polarOption.AutoSize = true;
            this.polarOption.Checked = true;
            this.polarOption.Location = new System.Drawing.Point(211, 70);
            this.polarOption.Name = "polarOption";
            this.polarOption.Size = new System.Drawing.Size(105, 21);
            this.polarOption.TabIndex = 6;
            this.polarOption.TabStop = true;
            this.polarOption.Text = "Forma polar";
            this.polarOption.UseVisualStyleBackColor = true;
            this.polarOption.CheckedChanged += new System.EventHandler(this.polarOption_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Z3";
            // 
            // resultadoLabel
            // 
            this.resultadoLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultadoLabel.Location = new System.Drawing.Point(51, 42);
            this.resultadoLabel.Name = "resultadoLabel";
            this.resultadoLabel.Size = new System.Drawing.Size(251, 20);
            this.resultadoLabel.TabIndex = 8;
            // 
            // OperacionesBasicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 352);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "OperacionesBasicas";
            this.Text = "OperacionesBasicas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox n1Text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox n2Text;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button botonDiv;
        private System.Windows.Forms.Button botonResta;
        private System.Windows.Forms.Button botonSuma;
        private System.Windows.Forms.Button botonMult;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label errorZ2Label;
        private System.Windows.Forms.Label errorZ1Label;
        private System.Windows.Forms.RadioButton binomialButton;
        private System.Windows.Forms.RadioButton polarOption;
        private System.Windows.Forms.Label resultadoLabel;
    }
}