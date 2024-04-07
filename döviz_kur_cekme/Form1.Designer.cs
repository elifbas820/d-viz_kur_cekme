namespace döviz_kur_cekme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            lbldolaral = new Label();
            label3 = new Label();
            lbldolarsat = new Label();
            label5 = new Label();
            lbleuroal = new Label();
            label7 = new Label();
            lbleurosat = new Label();
            btndolaral = new Button();
            btndolarsat = new Button();
            btneurosat = new Button();
            btneuroal = new Button();
            groupBox1 = new GroupBox();
            btnsatışyap = new Button();
            txtkalan = new TextBox();
            txttutar = new TextBox();
            label12 = new Label();
            label11 = new Label();
            txtmiktar = new TextBox();
            label10 = new Label();
            txtkur = new TextBox();
            label9 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(45, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 0;
            label1.Text = "Dolar Alış :";
            label1.Click += label1_Click;
            // 
            // lbldolaral
            // 
            lbldolaral.AutoSize = true;
            lbldolaral.BackColor = Color.Transparent;
            lbldolaral.ForeColor = SystemColors.ButtonHighlight;
            lbldolaral.Location = new Point(145, 43);
            lbldolaral.Margin = new Padding(4, 0, 4, 0);
            lbldolaral.Name = "lbldolaral";
            lbldolaral.Size = new Size(19, 21);
            lbldolaral.TabIndex = 1;
            lbldolaral.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(45, 92);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 2;
            label3.Text = "Dolar Satış:";
            // 
            // lbldolarsat
            // 
            lbldolarsat.AutoSize = true;
            lbldolarsat.BackColor = Color.Transparent;
            lbldolarsat.ForeColor = SystemColors.ButtonHighlight;
            lbldolarsat.Location = new Point(145, 92);
            lbldolarsat.Margin = new Padding(4, 0, 4, 0);
            lbldolarsat.Name = "lbldolarsat";
            lbldolarsat.Size = new Size(19, 21);
            lbldolarsat.TabIndex = 3;
            lbldolarsat.Text = "0";
            lbldolarsat.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(50, 186);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(74, 21);
            label5.TabIndex = 4;
            label5.Text = "Euro Alış:";
            label5.Click += label5_Click;
            // 
            // lbleuroal
            // 
            lbleuroal.AutoSize = true;
            lbleuroal.BackColor = Color.Transparent;
            lbleuroal.ForeColor = SystemColors.ButtonHighlight;
            lbleuroal.Location = new Point(145, 186);
            lbleuroal.Margin = new Padding(4, 0, 4, 0);
            lbleuroal.Name = "lbleuroal";
            lbleuroal.Size = new Size(19, 21);
            lbleuroal.TabIndex = 5;
            lbleuroal.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(50, 227);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(82, 21);
            label7.TabIndex = 6;
            label7.Text = "Euro Satış:";
            // 
            // lbleurosat
            // 
            lbleurosat.AutoSize = true;
            lbleurosat.BackColor = Color.Transparent;
            lbleurosat.ForeColor = SystemColors.ButtonHighlight;
            lbleurosat.Location = new Point(145, 227);
            lbleurosat.Margin = new Padding(4, 0, 4, 0);
            lbleurosat.Name = "lbleurosat";
            lbleurosat.Size = new Size(19, 21);
            lbleurosat.TabIndex = 7;
            lbleurosat.Text = "0";
            // 
            // btndolaral
            // 
            btndolaral.Location = new Point(240, 38);
            btndolaral.Margin = new Padding(4);
            btndolaral.Name = "btndolaral";
            btndolaral.Size = new Size(32, 31);
            btndolaral.TabIndex = 8;
            btndolaral.Text = "...";
            btndolaral.UseVisualStyleBackColor = true;
            btndolaral.Click += btndolaral_Click;
            // 
            // btndolarsat
            // 
            btndolarsat.Location = new Point(240, 85);
            btndolarsat.Margin = new Padding(4);
            btndolarsat.Name = "btndolarsat";
            btndolarsat.Size = new Size(32, 31);
            btndolarsat.TabIndex = 9;
            btndolarsat.Text = "...";
            btndolarsat.UseVisualStyleBackColor = true;
            btndolarsat.Click += btndolarsat_Click;
            // 
            // btneurosat
            // 
            btneurosat.Location = new Point(240, 221);
            btneurosat.Margin = new Padding(4);
            btneurosat.Name = "btneurosat";
            btneurosat.Size = new Size(32, 31);
            btneurosat.TabIndex = 10;
            btneurosat.Text = "...";
            btneurosat.UseVisualStyleBackColor = true;
            btneurosat.Click += btneurosat_Click;
            // 
            // btneuroal
            // 
            btneuroal.Location = new Point(240, 181);
            btneuroal.Margin = new Padding(4);
            btneuroal.Name = "btneuroal";
            btneuroal.Size = new Size(32, 31);
            btneuroal.TabIndex = 11;
            btneuroal.Text = "...";
            btneuroal.UseVisualStyleBackColor = true;
            btneuroal.Click += btneuroal_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnsatışyap);
            groupBox1.Controls.Add(txtkalan);
            groupBox1.Controls.Add(txttutar);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtmiktar);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtkur);
            groupBox1.Controls.Add(label9);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(480, 22);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(339, 240);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnsatışyap
            // 
            btnsatışyap.ForeColor = Color.Black;
            btnsatışyap.Location = new Point(92, 205);
            btnsatışyap.Margin = new Padding(4);
            btnsatışyap.Name = "btnsatışyap";
            btnsatışyap.Size = new Size(91, 31);
            btnsatışyap.TabIndex = 19;
            btnsatışyap.Text = "işlem1";
            btnsatışyap.UseVisualStyleBackColor = true;
            btnsatışyap.Click += btnsatışyap_Click;
            // 
            // txtkalan
            // 
            txtkalan.Location = new Point(145, 156);
            txtkalan.Name = "txtkalan";
            txtkalan.Size = new Size(183, 29);
            txtkalan.TabIndex = 18;
            // 
            // txttutar
            // 
            txttutar.Location = new Point(145, 114);
            txttutar.Name = "txttutar";
            txttutar.Size = new Size(183, 29);
            txttutar.TabIndex = 17;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(71, 156);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(51, 21);
            label12.TabIndex = 16;
            label12.Text = "Kalan:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.ForeColor = SystemColors.ButtonFace;
            label11.Location = new Point(80, 114);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(49, 21);
            label11.TabIndex = 15;
            label11.Text = "Tutar:";
            // 
            // txtmiktar
            // 
            txtmiktar.Location = new Point(145, 67);
            txtmiktar.Name = "txtmiktar";
            txtmiktar.Size = new Size(183, 29);
            txtmiktar.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(71, 75);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(58, 21);
            label10.TabIndex = 13;
            label10.Text = "Miktar:";
            label10.Click += label10_Click;
            // 
            // txtkur
            // 
            txtkur.Location = new Point(145, 29);
            txtkur.Name = "txtkur";
            txtkur.Size = new Size(183, 29);
            txtkur.TabIndex = 2;
            txtkur.TextChanged += txtkur_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(92, 37);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(37, 21);
            label9.TabIndex = 1;
            label9.Text = "Kur:";
            label9.Click += label9_Click;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(209, 204);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(89, 31);
            button1.TabIndex = 20;
            button1.Text = "işlem2";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(883, 413);
            Controls.Add(groupBox1);
            Controls.Add(btneuroal);
            Controls.Add(btneurosat);
            Controls.Add(btndolarsat);
            Controls.Add(btndolaral);
            Controls.Add(lbleurosat);
            Controls.Add(label7);
            Controls.Add(lbleuroal);
            Controls.Add(label5);
            Controls.Add(lbldolarsat);
            Controls.Add(label3);
            Controls.Add(lbldolaral);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbldolaral;
        private Label label3;
        private Label lbldolarsat;
        private Label label5;
        private Label lbleuroal;
        private Label label7;
        private Label lbleurosat;
        private Button btndolaral;
        private Button btndolarsat;
        private Button btneurosat;
        private Button btneuroal;
        private GroupBox groupBox1;
        private Label label9;
        private TextBox txtkur;
        private TextBox txtmiktar;
        private Label label10;
        private TextBox txtkalan;
        private TextBox txttutar;
        private Label label12;
        private Label label11;
        private Button btnsatışyap;
        private Button button1;
    }
}
