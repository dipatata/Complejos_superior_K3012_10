namespace matematica_superior
{
    partial class Operaciones
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
            this.nLabel = new System.Windows.Forms.Label();
            this.nText = new System.Windows.Forms.TextBox();
            this.n2LabelColor = new System.Windows.Forms.Label();
            this.n1LabelColor = new System.Windows.Forms.Label();
            this.errorZ2Label = new System.Windows.Forms.Label();
            this.errorZ1Label = new System.Windows.Forms.Label();
            this.n2Label = new System.Windows.Forms.Label();
            this.n2Text = new System.Windows.Forms.TextBox();
            this.n1Label = new System.Windows.Forms.Label();
            this.n1Text = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.raicesPrimitivasButton = new System.Windows.Forms.Button();
            this.potenciaButton = new System.Windows.Forms.Button();
            this.radicacionButton = new System.Windows.Forms.Button();
            this.botonDiv = new System.Windows.Forms.Button();
            this.botonResta = new System.Windows.Forms.Button();
            this.botonSuma = new System.Windows.Forms.Button();
            this.botonMult = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listaPrimitivas = new System.Windows.Forms.ListView();
            this.listaRaices = new System.Windows.Forms.ListBox();
            this.resultadoColor = new System.Windows.Forms.Label();
            this.resultadoLabel = new System.Windows.Forms.Label();
            this.binomialButton = new System.Windows.Forms.RadioButton();
            this.polarOption = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.escalaLabel = new System.Windows.Forms.Label();
            this.dibujarGuiasBox = new System.Windows.Forms.CheckBox();
            this.cortesBox = new System.Windows.Forms.CheckBox();
            this.dibujarEjesCheck = new System.Windows.Forms.CheckBox();
            this.masEscalaLabel = new System.Windows.Forms.Label();
            this.menosEscalaLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nLabel);
            this.groupBox1.Controls.Add(this.nText);
            this.groupBox1.Controls.Add(this.n2LabelColor);
            this.groupBox1.Controls.Add(this.n1LabelColor);
            this.groupBox1.Controls.Add(this.errorZ2Label);
            this.groupBox1.Controls.Add(this.errorZ1Label);
            this.groupBox1.Controls.Add(this.n2Label);
            this.groupBox1.Controls.Add(this.n2Text);
            this.groupBox1.Controls.Add(this.n1Label);
            this.groupBox1.Controls.Add(this.n1Text);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso numeros";
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.Location = new System.Drawing.Point(23, 109);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(18, 17);
            this.nLabel.TabIndex = 9;
            this.nLabel.Text = "N";
            // 
            // nText
            // 
            this.nText.Location = new System.Drawing.Point(54, 106);
            this.nText.Name = "nText";
            this.nText.Size = new System.Drawing.Size(143, 22);
            this.nText.TabIndex = 8;
            this.nText.TextChanged += new System.EventHandler(this.nText_TextChanged);
            // 
            // n2LabelColor
            // 
            this.n2LabelColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.n2LabelColor.Location = new System.Drawing.Point(211, 95);
            this.n2LabelColor.Name = "n2LabelColor";
            this.n2LabelColor.Size = new System.Drawing.Size(19, 20);
            this.n2LabelColor.TabIndex = 7;
            // 
            // n1LabelColor
            // 
            this.n1LabelColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.n1LabelColor.Location = new System.Drawing.Point(211, 30);
            this.n1LabelColor.Name = "n1LabelColor";
            this.n1LabelColor.Size = new System.Drawing.Size(19, 20);
            this.n1LabelColor.TabIndex = 6;
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
            // n2Label
            // 
            this.n2Label.AutoSize = true;
            this.n2Label.Location = new System.Drawing.Point(23, 98);
            this.n2Label.Name = "n2Label";
            this.n2Label.Size = new System.Drawing.Size(25, 17);
            this.n2Label.TabIndex = 3;
            this.n2Label.Text = "Z2";
            // 
            // n2Text
            // 
            this.n2Text.Location = new System.Drawing.Point(54, 95);
            this.n2Text.Name = "n2Text";
            this.n2Text.Size = new System.Drawing.Size(143, 22);
            this.n2Text.TabIndex = 2;
            this.n2Text.TextChanged += new System.EventHandler(this.n2Text_TextChanged);
            // 
            // n1Label
            // 
            this.n1Label.AutoSize = true;
            this.n1Label.Location = new System.Drawing.Point(23, 33);
            this.n1Label.Name = "n1Label";
            this.n1Label.Size = new System.Drawing.Size(25, 17);
            this.n1Label.TabIndex = 1;
            this.n1Label.Text = "Z1";
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
            this.groupBox2.Controls.Add(this.raicesPrimitivasButton);
            this.groupBox2.Controls.Add(this.potenciaButton);
            this.groupBox2.Controls.Add(this.radicacionButton);
            this.groupBox2.Controls.Add(this.botonDiv);
            this.groupBox2.Controls.Add(this.botonResta);
            this.groupBox2.Controls.Add(this.botonSuma);
            this.groupBox2.Controls.Add(this.botonMult);
            this.groupBox2.Location = new System.Drawing.Point(419, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 181);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones";
            // 
            // raicesPrimitivasButton
            // 
            this.raicesPrimitivasButton.Location = new System.Drawing.Point(54, 83);
            this.raicesPrimitivasButton.Name = "raicesPrimitivasButton";
            this.raicesPrimitivasButton.Size = new System.Drawing.Size(218, 36);
            this.raicesPrimitivasButton.TabIndex = 8;
            this.raicesPrimitivasButton.Text = "Raices primitivas";
            this.raicesPrimitivasButton.UseVisualStyleBackColor = true;
            this.raicesPrimitivasButton.Click += new System.EventHandler(this.raicesPrimitivasButton_Click);
            // 
            // potenciaButton
            // 
            this.potenciaButton.Location = new System.Drawing.Point(192, 67);
            this.potenciaButton.Name = "potenciaButton";
            this.potenciaButton.Size = new System.Drawing.Size(109, 36);
            this.potenciaButton.TabIndex = 7;
            this.potenciaButton.Text = "Potenciacion";
            this.potenciaButton.UseVisualStyleBackColor = true;
            this.potenciaButton.Click += new System.EventHandler(this.potenciaButton_Click);
            // 
            // radicacionButton
            // 
            this.radicacionButton.Location = new System.Drawing.Point(25, 65);
            this.radicacionButton.Name = "radicacionButton";
            this.radicacionButton.Size = new System.Drawing.Size(109, 36);
            this.radicacionButton.TabIndex = 6;
            this.radicacionButton.Text = "Radicacion";
            this.radicacionButton.UseVisualStyleBackColor = true;
            this.radicacionButton.Click += new System.EventHandler(this.radicacionButton_Click);
            // 
            // botonDiv
            // 
            this.botonDiv.Location = new System.Drawing.Point(192, 109);
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
            this.botonMult.Location = new System.Drawing.Point(25, 109);
            this.botonMult.Name = "botonMult";
            this.botonMult.Size = new System.Drawing.Size(109, 36);
            this.botonMult.TabIndex = 2;
            this.botonMult.Text = "Multiplicacion";
            this.botonMult.UseVisualStyleBackColor = true;
            this.botonMult.Click += new System.EventHandler(this.botonMult_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listaPrimitivas);
            this.groupBox3.Controls.Add(this.listaRaices);
            this.groupBox3.Controls.Add(this.resultadoColor);
            this.groupBox3.Controls.Add(this.resultadoLabel);
            this.groupBox3.Controls.Add(this.binomialButton);
            this.groupBox3.Controls.Add(this.polarOption);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(21, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(391, 124);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado";
            // 
            // listaPrimitivas
            // 
            this.listaPrimitivas.Location = new System.Drawing.Point(16, 21);
            this.listaPrimitivas.Name = "listaPrimitivas";
            this.listaPrimitivas.Size = new System.Drawing.Size(238, 200);
            this.listaPrimitivas.TabIndex = 12;
            this.listaPrimitivas.UseCompatibleStateImageBehavior = false;
            // 
            // listaRaices
            // 
            this.listaRaices.FormattingEnabled = true;
            this.listaRaices.ItemHeight = 16;
            this.listaRaices.Location = new System.Drawing.Point(16, 21);
            this.listaRaices.Name = "listaRaices";
            this.listaRaices.Size = new System.Drawing.Size(238, 100);
            this.listaRaices.TabIndex = 13;
            // 
            // resultadoColor
            // 
            this.resultadoColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.resultadoColor.Location = new System.Drawing.Point(317, 42);
            this.resultadoColor.Name = "resultadoColor";
            this.resultadoColor.Size = new System.Drawing.Size(19, 20);
            this.resultadoColor.TabIndex = 8;
            // 
            // resultadoLabel
            // 
            this.resultadoLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultadoLabel.Location = new System.Drawing.Point(51, 42);
            this.resultadoLabel.Name = "resultadoLabel";
            this.resultadoLabel.Size = new System.Drawing.Size(251, 20);
            this.resultadoLabel.TabIndex = 8;
            // 
            // binomialButton
            // 
            this.binomialButton.AutoSize = true;
            this.binomialButton.Location = new System.Drawing.Point(260, 92);
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
            this.polarOption.Location = new System.Drawing.Point(260, 65);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Escala: ";
            // 
            // escalaLabel
            // 
            this.escalaLabel.AutoSize = true;
            this.escalaLabel.Location = new System.Drawing.Point(482, 210);
            this.escalaLabel.Name = "escalaLabel";
            this.escalaLabel.Size = new System.Drawing.Size(24, 17);
            this.escalaLabel.TabIndex = 6;
            this.escalaLabel.Text = "10";
            // 
            // dibujarGuiasBox
            // 
            this.dibujarGuiasBox.AutoSize = true;
            this.dibujarGuiasBox.Checked = true;
            this.dibujarGuiasBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dibujarGuiasBox.Location = new System.Drawing.Point(540, 210);
            this.dibujarGuiasBox.Name = "dibujarGuiasBox";
            this.dibujarGuiasBox.Size = new System.Drawing.Size(113, 21);
            this.dibujarGuiasBox.TabIndex = 7;
            this.dibujarGuiasBox.Text = "Dibujar guias";
            this.dibujarGuiasBox.UseVisualStyleBackColor = true;
            this.dibujarGuiasBox.CheckedChanged += new System.EventHandler(this.dibujarGuiasBox_CheckedChanged);
            // 
            // cortesBox
            // 
            this.cortesBox.AutoSize = true;
            this.cortesBox.Checked = true;
            this.cortesBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cortesBox.Location = new System.Drawing.Point(676, 210);
            this.cortesBox.Name = "cortesBox";
            this.cortesBox.Size = new System.Drawing.Size(175, 21);
            this.cortesBox.TabIndex = 8;
            this.cortesBox.Text = "Dibujar cortes con ejes";
            this.cortesBox.UseVisualStyleBackColor = true;
            this.cortesBox.CheckedChanged += new System.EventHandler(this.cortesBox_CheckedChanged);
            // 
            // dibujarEjesCheck
            // 
            this.dibujarEjesCheck.AutoSize = true;
            this.dibujarEjesCheck.Checked = true;
            this.dibujarEjesCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dibujarEjesCheck.Location = new System.Drawing.Point(857, 210);
            this.dibujarEjesCheck.Name = "dibujarEjesCheck";
            this.dibujarEjesCheck.Size = new System.Drawing.Size(105, 21);
            this.dibujarEjesCheck.TabIndex = 9;
            this.dibujarEjesCheck.Text = "Dibujar ejes";
            this.dibujarEjesCheck.UseVisualStyleBackColor = true;
            this.dibujarEjesCheck.CheckedChanged += new System.EventHandler(this.dibujarEjesCheck_CheckedChanged);
            // 
            // masEscalaLabel
            // 
            this.masEscalaLabel.AutoSize = true;
            this.masEscalaLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.masEscalaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masEscalaLabel.Location = new System.Drawing.Point(443, 240);
            this.masEscalaLabel.Name = "masEscalaLabel";
            this.masEscalaLabel.Size = new System.Drawing.Size(19, 20);
            this.masEscalaLabel.TabIndex = 10;
            this.masEscalaLabel.Text = "+";
            this.masEscalaLabel.Click += new System.EventHandler(this.masEscalaLabel_Click);
            // 
            // menosEscalaLabel
            // 
            this.menosEscalaLabel.AutoSize = true;
            this.menosEscalaLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.menosEscalaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menosEscalaLabel.Location = new System.Drawing.Point(482, 240);
            this.menosEscalaLabel.Name = "menosEscalaLabel";
            this.menosEscalaLabel.Size = new System.Drawing.Size(15, 20);
            this.menosEscalaLabel.TabIndex = 11;
            this.menosEscalaLabel.Text = "-";
            this.menosEscalaLabel.Click += new System.EventHandler(this.menosEscalaLabel_Click);
            // 
            // Operaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 624);
            this.Controls.Add(this.menosEscalaLabel);
            this.Controls.Add(this.masEscalaLabel);
            this.Controls.Add(this.dibujarEjesCheck);
            this.Controls.Add(this.cortesBox);
            this.Controls.Add(this.dibujarGuiasBox);
            this.Controls.Add(this.escalaLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Operaciones";
            this.Text = "OperacionesBasicas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label n1Label;
        private System.Windows.Forms.TextBox n1Text;
        private System.Windows.Forms.Label n2Label;
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
        private System.Windows.Forms.Label n1LabelColor;
        private System.Windows.Forms.Label n2LabelColor;
        private System.Windows.Forms.Label resultadoColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label escalaLabel;
        private System.Windows.Forms.CheckBox dibujarGuiasBox;
        private System.Windows.Forms.CheckBox cortesBox;
        private System.Windows.Forms.CheckBox dibujarEjesCheck;
        private System.Windows.Forms.Label masEscalaLabel;
        private System.Windows.Forms.Label menosEscalaLabel;
        private System.Windows.Forms.Button potenciaButton;
        private System.Windows.Forms.Button radicacionButton;
        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.TextBox nText;
        private System.Windows.Forms.Button raicesPrimitivasButton;
        private System.Windows.Forms.ListView listaPrimitivas;
        private System.Windows.Forms.ListBox listaRaices;
    }
}