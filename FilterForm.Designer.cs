namespace SS_OpenCV
{
    partial class FilterForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.c11 = new System.Windows.Forms.TextBox();
            this.c33 = new System.Windows.Forms.MaskedTextBox();
            this.c32 = new System.Windows.Forms.MaskedTextBox();
            this.c31 = new System.Windows.Forms.MaskedTextBox();
            this.Weight = new System.Windows.Forms.Label();
            this.Peso = new System.Windows.Forms.TextBox();
            this.c23 = new System.Windows.Forms.TextBox();
            this.c22 = new System.Windows.Forms.TextBox();
            this.c21 = new System.Windows.Forms.TextBox();
            this.c13 = new System.Windows.Forms.TextBox();
            this.c12 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.c11);
            this.panel1.Controls.Add(this.c33);
            this.panel1.Controls.Add(this.c32);
            this.panel1.Controls.Add(this.c31);
            this.panel1.Controls.Add(this.Weight);
            this.panel1.Controls.Add(this.Peso);
            this.panel1.Controls.Add(this.c23);
            this.panel1.Controls.Add(this.c22);
            this.panel1.Controls.Add(this.c21);
            this.panel1.Controls.Add(this.c13);
            this.panel1.Controls.Add(this.c12);
            this.panel1.Location = new System.Drawing.Point(47, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 191);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // c11
            // 
            this.c11.Location = new System.Drawing.Point(18, 21);
            this.c11.Name = "c11";
            this.c11.Size = new System.Drawing.Size(25, 20);
            this.c11.TabIndex = 10;
            this.c11.TextChanged += new System.EventHandler(this.c11_TextChanged);
            // 
            // c33
            // 
            this.c33.Location = new System.Drawing.Point(120, 98);
            this.c33.Name = "c33";
            this.c33.Size = new System.Drawing.Size(24, 20);
            this.c33.TabIndex = 9;
            // 
            // c32
            // 
            this.c32.Location = new System.Drawing.Point(67, 98);
            this.c32.Name = "c32";
            this.c32.Size = new System.Drawing.Size(24, 20);
            this.c32.TabIndex = 8;
            // 
            // c31
            // 
            this.c31.Location = new System.Drawing.Point(18, 98);
            this.c31.Name = "c31";
            this.c31.Size = new System.Drawing.Size(24, 20);
            this.c31.TabIndex = 7;
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.Location = new System.Drawing.Point(26, 143);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(41, 13);
            this.Weight.TabIndex = 3;
            this.Weight.Text = "Weight";
            this.Weight.Click += new System.EventHandler(this.label1_Click);
            // 
            // Peso
            // 
            this.Peso.Location = new System.Drawing.Point(82, 140);
            this.Peso.Name = "Peso";
            this.Peso.Size = new System.Drawing.Size(63, 20);
            this.Peso.TabIndex = 6;
            // 
            // c23
            // 
            this.c23.Location = new System.Drawing.Point(120, 58);
            this.c23.Name = "c23";
            this.c23.Size = new System.Drawing.Size(25, 20);
            this.c23.TabIndex = 5;
            this.c23.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // c22
            // 
            this.c22.Location = new System.Drawing.Point(66, 58);
            this.c22.Name = "c22";
            this.c22.Size = new System.Drawing.Size(25, 20);
            this.c22.TabIndex = 4;
            this.c22.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // c21
            // 
            this.c21.Location = new System.Drawing.Point(17, 58);
            this.c21.Name = "c21";
            this.c21.Size = new System.Drawing.Size(25, 20);
            this.c21.TabIndex = 3;
            this.c21.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // c13
            // 
            this.c13.Location = new System.Drawing.Point(120, 21);
            this.c13.Name = "c13";
            this.c13.Size = new System.Drawing.Size(25, 20);
            this.c13.TabIndex = 2;
            // 
            // c12
            // 
            this.c12.Location = new System.Drawing.Point(66, 21);
            this.c12.Name = "c12";
            this.c12.Size = new System.Drawing.Size(25, 20);
            this.c12.TabIndex = 1;
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 254);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "FilterForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox c12;
        public System.Windows.Forms.TextBox Peso;
        public System.Windows.Forms.TextBox c23;
        public System.Windows.Forms.TextBox c22;
        public System.Windows.Forms.TextBox c21;
        public System.Windows.Forms.TextBox c13;
        private System.Windows.Forms.Label Weight;
        public System.Windows.Forms.TextBox c11;
        public System.Windows.Forms.MaskedTextBox c33;
        public System.Windows.Forms.MaskedTextBox c32;
        public System.Windows.Forms.MaskedTextBox c31;
    }
}