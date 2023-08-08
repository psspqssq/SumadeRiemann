namespace SumadeRiemann
{
    partial class frmMain
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
            txtFunction = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtLimitA = new TextBox();
            txtLimitB = new TextBox();
            txtArea = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnGraph = new Button();
            picGraph = new PictureBox();
            lblValidFunction = new Label();
            lblA = new Label();
            lblB = new Label();
            label7 = new Label();
            txtApprox = new TextBox();
            lblApprox = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)picGraph).BeginInit();
            SuspendLayout();
            // 
            // txtFunction
            // 
            txtFunction.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtFunction.Location = new Point(45, 29);
            txtFunction.Name = "txtFunction";
            txtFunction.Size = new Size(614, 23);
            txtFunction.TabIndex = 0;
            txtFunction.Text = "(-x * x)/( (4 + 2)*(x + 5))";
            txtFunction.TextChanged += txtFunction_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 1;
            label1.Text = "f(x)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 2;
            label2.Text = "Límites";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 92);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 3;
            label3.Text = "a";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 122);
            label4.Name = "label4";
            label4.Size = new Size(14, 15);
            label4.TabIndex = 4;
            label4.Text = "b";
            // 
            // txtLimitA
            // 
            txtLimitA.Location = new Point(53, 92);
            txtLimitA.Name = "txtLimitA";
            txtLimitA.Size = new Size(50, 23);
            txtLimitA.TabIndex = 5;
            txtLimitA.Text = "0";
            txtLimitA.TextChanged += txtLimitA_TextChanged;
            // 
            // txtLimitB
            // 
            txtLimitB.Location = new Point(53, 122);
            txtLimitB.Name = "txtLimitB";
            txtLimitB.Size = new Size(50, 23);
            txtLimitB.TabIndex = 6;
            txtLimitB.Text = "5";
            txtLimitB.TextChanged += txtLimitB_TextChanged;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(53, 212);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(114, 23);
            txtArea.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 194);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 8;
            label5.Text = "Área bajo la curva";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(173, 220);
            label6.Name = "label6";
            label6.Size = new Size(17, 15);
            label6.TabIndex = 9;
            label6.Text = "u²";
            // 
            // btnGraph
            // 
            btnGraph.Location = new Point(584, 57);
            btnGraph.Name = "btnGraph";
            btnGraph.Size = new Size(75, 23);
            btnGraph.TabIndex = 10;
            btnGraph.Text = "Graficar";
            btnGraph.UseVisualStyleBackColor = true;
            btnGraph.Click += btnGraph_Click;
            // 
            // picGraph
            // 
            picGraph.Location = new Point(263, 95);
            picGraph.Name = "picGraph";
            picGraph.Size = new Size(400, 200);
            picGraph.TabIndex = 11;
            picGraph.TabStop = false;
            // 
            // lblValidFunction
            // 
            lblValidFunction.AutoSize = true;
            lblValidFunction.Location = new Point(45, 11);
            lblValidFunction.Name = "lblValidFunction";
            lblValidFunction.RightToLeft = RightToLeft.Yes;
            lblValidFunction.Size = new Size(85, 15);
            lblValidFunction.TabIndex = 12;
            lblValidFunction.Text = "Función Válida";
            lblValidFunction.TextAlign = ContentAlignment.TopRight;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(107, 100);
            lblA.Name = "lblA";
            lblA.Size = new Size(87, 15);
            lblA.TabIndex = 13;
            lblA.Text = "define límite A";
            lblA.Visible = false;
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(108, 130);
            lblB.Name = "lblB";
            lblB.Size = new Size(86, 15);
            lblB.TabIndex = 14;
            lblB.Text = "define límite B";
            lblB.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 150);
            label7.Name = "label7";
            label7.Size = new Size(14, 15);
            label7.TabIndex = 15;
            label7.Text = "n";
            // 
            // txtApprox
            // 
            txtApprox.Location = new Point(53, 150);
            txtApprox.Name = "txtApprox";
            txtApprox.Size = new Size(50, 23);
            txtApprox.TabIndex = 16;
            txtApprox.Text = "20";
            txtApprox.TextChanged += txtApprox_TextChanged;
            // 
            // lblApprox
            // 
            lblApprox.AutoSize = true;
            lblApprox.Location = new Point(107, 158);
            lblApprox.Name = "lblApprox";
            lblApprox.Size = new Size(134, 15);
            lblApprox.TabIndex = 17;
            lblApprox.Text = "número de rectángulos";
            lblApprox.Visible = false;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 299);
            Controls.Add(lblApprox);
            Controls.Add(txtApprox);
            Controls.Add(label7);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Controls.Add(lblValidFunction);
            Controls.Add(picGraph);
            Controls.Add(btnGraph);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtArea);
            Controls.Add(txtLimitB);
            Controls.Add(txtLimitA);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFunction);
            Font = new Font("Candara Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmMain";
            Text = "Suma de Riemann";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)picGraph).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFunction;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtLimitA;
        private TextBox txtLimitB;
        private TextBox txtArea;
        private Label label5;
        private Label label6;
        private Button btnGraph;
        private PictureBox picGraph;
        private Label lblValidFunction;
        private Label lblA;
        private Label lblB;
        private Label label7;
        private TextBox txtApprox;
        private Label lblApprox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}