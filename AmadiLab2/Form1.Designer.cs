namespace AmadiLab2
{
    partial class amadiLab2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(amadiLab2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculate_Click = new System.Windows.Forms.Button();
            this.btnReset_Click = new System.Windows.Forms.Button();
            this.btnPicture_Click = new System.Windows.Forms.Button();
            this.btnData_Click = new System.Windows.Forms.Button();
            this.btnHide_Click = new System.Windows.Forms.Button();
            this.btnExit_Click = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.picUche = new System.Windows.Forms.PictureBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUche)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAnswer);
            this.groupBox1.Controls.Add(this.btnReset_Click);
            this.groupBox1.Controls.Add(this.btnCalculate_Click);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 307);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Multiplier";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnExit_Click);
            this.groupBox2.Controls.Add(this.btnHide_Click);
            this.groupBox2.Controls.Add(this.btnData_Click);
            this.groupBox2.Controls.Add(this.btnPicture_Click);
            this.groupBox2.Controls.Add(this.lblText);
            this.groupBox2.Controls.Add(this.picUche);
            this.groupBox2.Location = new System.Drawing.Point(274, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 307);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Multiplier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Answer";
            // 
            // btnCalculate_Click
            // 
            this.btnCalculate_Click.Location = new System.Drawing.Point(6, 278);
            this.btnCalculate_Click.Name = "btnCalculate_Click";
            this.btnCalculate_Click.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate_Click.TabIndex = 2;
            this.btnCalculate_Click.Text = "&Calculate";
            this.btnCalculate_Click.UseVisualStyleBackColor = true;
            this.btnCalculate_Click.Click += new System.EventHandler(this.btnCalculate_Click_Click);
            // 
            // btnReset_Click
            // 
            this.btnReset_Click.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset_Click.Location = new System.Drawing.Point(136, 278);
            this.btnReset_Click.Name = "btnReset_Click";
            this.btnReset_Click.Size = new System.Drawing.Size(75, 23);
            this.btnReset_Click.TabIndex = 3;
            this.btnReset_Click.Text = "&Reset";
            this.btnReset_Click.UseVisualStyleBackColor = true;
            this.btnReset_Click.Click += new System.EventHandler(this.btnReset_Click_Click);
            // 
            // btnPicture_Click
            // 
            this.btnPicture_Click.Location = new System.Drawing.Point(33, 278);
            this.btnPicture_Click.Name = "btnPicture_Click";
            this.btnPicture_Click.Size = new System.Drawing.Size(75, 23);
            this.btnPicture_Click.TabIndex = 0;
            this.btnPicture_Click.Text = "&Picture";
            this.btnPicture_Click.UseVisualStyleBackColor = true;
            this.btnPicture_Click.Click += new System.EventHandler(this.btnPicture_Click_Click);
            // 
            // btnData_Click
            // 
            this.btnData_Click.Location = new System.Drawing.Point(131, 278);
            this.btnData_Click.Name = "btnData_Click";
            this.btnData_Click.Size = new System.Drawing.Size(75, 23);
            this.btnData_Click.TabIndex = 1;
            this.btnData_Click.Text = "&Data";
            this.btnData_Click.UseVisualStyleBackColor = true;
            this.btnData_Click.Click += new System.EventHandler(this.btnData_Click_Click);
            // 
            // btnHide_Click
            // 
            this.btnHide_Click.Location = new System.Drawing.Point(231, 278);
            this.btnHide_Click.Name = "btnHide_Click";
            this.btnHide_Click.Size = new System.Drawing.Size(75, 23);
            this.btnHide_Click.TabIndex = 2;
            this.btnHide_Click.Text = "&Hide";
            this.btnHide_Click.UseVisualStyleBackColor = true;
            this.btnHide_Click.Click += new System.EventHandler(this.btnHide_Click_Click);
            // 
            // btnExit_Click
            // 
            this.btnExit_Click.Location = new System.Drawing.Point(326, 278);
            this.btnExit_Click.Name = "btnExit_Click";
            this.btnExit_Click.Size = new System.Drawing.Size(75, 23);
            this.btnExit_Click.TabIndex = 3;
            this.btnExit_Click.Text = "E&xit";
            this.btnExit_Click.UseVisualStyleBackColor = true;
            this.btnExit_Click.Click += new System.EventHandler(this.btnExit_Click_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Me, Myself and I";
            // 
            // picUche
            // 
            this.picUche.Image = ((System.Drawing.Image)(resources.GetObject("picUche.Image")));
            this.picUche.Location = new System.Drawing.Point(33, 41);
            this.picUche.Name = "picUche";
            this.picUche.Size = new System.Drawing.Size(368, 219);
            this.picUche.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUche.TabIndex = 5;
            this.picUche.TabStop = false;
            this.picUche.Click += new System.EventHandler(this.picUche_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnswer.Location = new System.Drawing.Point(111, 180);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(100, 27);
            this.lblAnswer.TabIndex = 7;
            // 
            // lblText
            // 
            this.lblText.Location = new System.Drawing.Point(33, 41);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(368, 219);
            this.lblText.TabIndex = 6;
            // 
            // amadiLab2
            // 
            this.AcceptButton = this.btnPicture_Click;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset_Click;
            this.ClientSize = new System.Drawing.Size(719, 331);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "amadiLab2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 2 by Amadi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUche)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnReset_Click;
        private System.Windows.Forms.Button btnCalculate_Click;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit_Click;
        private System.Windows.Forms.Button btnHide_Click;
        private System.Windows.Forms.Button btnData_Click;
        private System.Windows.Forms.Button btnPicture_Click;
        private System.Windows.Forms.PictureBox picUche;
        private System.Windows.Forms.Label lblText;
    }
}

