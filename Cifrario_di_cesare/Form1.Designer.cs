namespace Cifrario_di_cesare
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
            btn_cifra = new Button();
            lbl_cifrare = new Label();
            lbl_chiave_1 = new Label();
            lbl_cifrato = new Label();
            txt_cifrare = new TextBox();
            txt_chiave_1 = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btn_cifra
            // 
            btn_cifra.Location = new Point(80, 272);
            btn_cifra.Name = "btn_cifra";
            btn_cifra.Size = new Size(75, 23);
            btn_cifra.TabIndex = 1;
            btn_cifra.Text = "Cifra";
            btn_cifra.UseVisualStyleBackColor = true;
            btn_cifra.Click += btn_cifra_Click;
            // 
            // lbl_cifrare
            // 
            lbl_cifrare.AutoSize = true;
            lbl_cifrare.Location = new Point(21, 124);
            lbl_cifrare.Name = "lbl_cifrare";
            lbl_cifrare.Size = new Size(134, 15);
            lbl_cifrare.TabIndex = 4;
            lbl_cifrare.Text = "Inserire chiave da cifrare";
            // 
            // lbl_chiave_1
            // 
            lbl_chiave_1.AutoSize = true;
            lbl_chiave_1.Location = new Point(20, 187);
            lbl_chiave_1.Name = "lbl_chiave_1";
            lbl_chiave_1.Size = new Size(135, 15);
            lbl_chiave_1.TabIndex = 5;
            lbl_chiave_1.Text = "Inserire chiave numerica";
            // 
            // lbl_cifrato
            // 
            lbl_cifrato.AutoSize = true;
            lbl_cifrato.Location = new Point(197, 276);
            lbl_cifrato.Name = "lbl_cifrato";
            lbl_cifrato.Size = new Size(106, 15);
            lbl_cifrato.TabIndex = 6;
            lbl_cifrato.Text = "La parola cifrata è :";
            // 
            // txt_cifrare
            // 
            txt_cifrare.Location = new Point(173, 121);
            txt_cifrare.Name = "txt_cifrare";
            txt_cifrare.Size = new Size(100, 23);
            txt_cifrare.TabIndex = 10;
            // 
            // txt_chiave_1
            // 
            txt_chiave_1.Location = new Point(173, 179);
            txt_chiave_1.Name = "txt_chiave_1";
            txt_chiave_1.Size = new Size(100, 23);
            txt_chiave_1.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(576, 179);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(576, 121);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(600, 276);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 15;
            label1.Text = "La parola cifrata è :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(423, 187);
            label2.Name = "label2";
            label2.Size = new Size(135, 15);
            label2.TabIndex = 14;
            label2.Text = "Inserire chiave numerica";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(424, 124);
            label3.Name = "label3";
            label3.Size = new Size(134, 15);
            label3.TabIndex = 13;
            label3.Text = "Inserire chiave da cifrare";
            // 
            // button1
            // 
            button1.Location = new Point(483, 272);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Cifra";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(txt_chiave_1);
            Controls.Add(txt_cifrare);
            Controls.Add(lbl_cifrato);
            Controls.Add(lbl_chiave_1);
            Controls.Add(lbl_cifrare);
            Controls.Add(btn_cifra);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cifra;
        private Label lbl_cifrare;
        private Label lbl_chiave_1;
        private Label lbl_cifrato;
        private TextBox txt_cifrare;
        private TextBox txt_chiave_1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}
