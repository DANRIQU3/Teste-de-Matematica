namespace Teste_de_Matemática
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
            components = new System.ComponentModel.Container();
            timeLabel = new Label();
            label2 = new Label();
            plusLeftLabel = new Label();
            plusRightLabel = new Label();
            label4 = new Label();
            label5 = new Label();
            soma = new NumericUpDown();
            timesLeftLabel = new Label();
            minusLeftLabel = new Label();
            startButton = new Button();
            dividedLeftLabel = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            timesRightLabel = new Label();
            dividedRightLabel = new Label();
            minusRightLabel = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            produto = new NumericUpDown();
            quociente = new NumericUpDown();
            diferença = new NumericUpDown();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)soma).BeginInit();
            ((System.ComponentModel.ISupportInitialize)produto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quociente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)diferença).BeginInit();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.BorderStyle = BorderStyle.FixedSingle;
            timeLabel.Font = new Font("Segoe UI", 15.75F);
            timeLabel.Location = new Point(272, 9);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(200, 30);
            timeLabel.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F);
            label2.Location = new Point(154, 9);
            label2.Name = "label2";
            label2.Size = new Size(99, 30);
            label2.TabIndex = 1;
            label2.Text = "Time Left";
            // 
            // plusLeftLabel
            // 
            plusLeftLabel.Font = new Font("Segoe UI", 18F);
            plusLeftLabel.Location = new Point(26, 60);
            plusLeftLabel.Name = "plusLeftLabel";
            plusLeftLabel.Size = new Size(60, 50);
            plusLeftLabel.TabIndex = 2;
            plusLeftLabel.Text = "?";
            plusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            plusRightLabel.Font = new Font("Segoe UI", 18F);
            plusRightLabel.Location = new Point(205, 60);
            plusRightLabel.Name = "plusRightLabel";
            plusRightLabel.Size = new Size(60, 50);
            plusRightLabel.TabIndex = 3;
            plusRightLabel.Text = "?";
            plusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(271, 60);
            label4.Name = "label4";
            label4.Size = new Size(60, 50);
            label4.TabIndex = 4;
            label4.Text = "=";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 18F);
            label5.Location = new Point(114, 59);
            label5.Name = "label5";
            label5.Size = new Size(60, 50);
            label5.TabIndex = 5;
            label5.Text = "+";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // soma
            // 
            soma.Font = new Font("Segoe UI", 18F);
            soma.Location = new Point(347, 67);
            soma.Name = "soma";
            soma.Size = new Size(100, 39);
            soma.TabIndex = 1;
            soma.ValueChanged += answer_Enter;
            soma.Click += answer_Enter;
            soma.Enter += answer_Enter;
            // 
            // timesLeftLabel
            // 
            timesLeftLabel.Font = new Font("Segoe UI", 18F);
            timesLeftLabel.Location = new Point(26, 180);
            timesLeftLabel.Name = "timesLeftLabel";
            timesLeftLabel.Size = new Size(60, 50);
            timesLeftLabel.TabIndex = 9;
            timesLeftLabel.Text = "?";
            timesLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusLeftLabel
            // 
            minusLeftLabel.Font = new Font("Segoe UI", 18F);
            minusLeftLabel.Location = new Point(26, 120);
            minusLeftLabel.Name = "minusLeftLabel";
            minusLeftLabel.Size = new Size(60, 50);
            minusLeftLabel.TabIndex = 10;
            minusLeftLabel.Text = "?";
            minusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            startButton.AutoSize = true;
            startButton.Font = new Font("Segoe UI", 14F);
            startButton.Location = new Point(165, 305);
            startButton.Name = "startButton";
            startButton.Size = new Size(135, 35);
            startButton.TabIndex = 0;
            startButton.Text = "Iniciar o teste";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // dividedLeftLabel
            // 
            dividedLeftLabel.Font = new Font("Segoe UI", 18F);
            dividedLeftLabel.Location = new Point(26, 240);
            dividedLeftLabel.Name = "dividedLeftLabel";
            dividedLeftLabel.Size = new Size(60, 50);
            dividedLeftLabel.TabIndex = 24;
            dividedLeftLabel.Text = "?";
            dividedLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 18F);
            label6.Location = new Point(114, 240);
            label6.Name = "label6";
            label6.Size = new Size(60, 50);
            label6.TabIndex = 25;
            label6.Text = "÷";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 18F);
            label8.Location = new Point(114, 180);
            label8.Name = "label8";
            label8.Size = new Size(60, 50);
            label8.TabIndex = 26;
            label8.Text = "×";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 18F);
            label9.Location = new Point(114, 120);
            label9.Name = "label9";
            label9.Size = new Size(60, 50);
            label9.TabIndex = 27;
            label9.Text = "-";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            timesRightLabel.Font = new Font("Segoe UI", 18F);
            timesRightLabel.Location = new Point(205, 180);
            timesRightLabel.Name = "timesRightLabel";
            timesRightLabel.Size = new Size(60, 50);
            timesRightLabel.TabIndex = 28;
            timesRightLabel.Text = "?";
            timesRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedRightLabel
            // 
            dividedRightLabel.Font = new Font("Segoe UI", 18F);
            dividedRightLabel.Location = new Point(205, 240);
            dividedRightLabel.Name = "dividedRightLabel";
            dividedRightLabel.Size = new Size(60, 50);
            dividedRightLabel.TabIndex = 29;
            dividedRightLabel.Text = "?";
            dividedRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            minusRightLabel.Font = new Font("Segoe UI", 18F);
            minusRightLabel.Location = new Point(205, 120);
            minusRightLabel.Name = "minusRightLabel";
            minusRightLabel.Size = new Size(60, 50);
            minusRightLabel.TabIndex = 30;
            minusRightLabel.Text = "?";
            minusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 18F);
            label13.Location = new Point(271, 240);
            label13.Name = "label13";
            label13.Size = new Size(60, 50);
            label13.TabIndex = 31;
            label13.Text = "=";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI", 18F);
            label14.Location = new Point(271, 180);
            label14.Name = "label14";
            label14.Size = new Size(60, 50);
            label14.TabIndex = 32;
            label14.Text = "=";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.Font = new Font("Segoe UI", 18F);
            label15.Location = new Point(271, 120);
            label15.Name = "label15";
            label15.Size = new Size(60, 50);
            label15.TabIndex = 33;
            label15.Text = "=";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // produto
            // 
            produto.Font = new Font("Segoe UI", 18F);
            produto.Location = new Point(347, 187);
            produto.Name = "produto";
            produto.Size = new Size(100, 39);
            produto.TabIndex = 3;
            produto.ValueChanged += answer_Enter;
            produto.Click += answer_Enter;
            produto.Enter += answer_Enter;
            // 
            // quociente
            // 
            quociente.Font = new Font("Segoe UI", 18F);
            quociente.Location = new Point(347, 247);
            quociente.Name = "quociente";
            quociente.Size = new Size(100, 39);
            quociente.TabIndex = 4;
            quociente.ValueChanged += answer_Enter;
            quociente.Click += answer_Enter;
            quociente.Enter += answer_Enter;
            // 
            // diferença
            // 
            diferença.Font = new Font("Segoe UI", 18F);
            diferença.Location = new Point(347, 127);
            diferença.Name = "diferença";
            diferença.Size = new Size(100, 39);
            diferença.TabIndex = 2;
            diferença.ValueChanged += answer_Enter;
            diferença.Click += answer_Enter;
            diferença.Enter += answer_Enter;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(diferença);
            Controls.Add(quociente);
            Controls.Add(produto);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(minusRightLabel);
            Controls.Add(dividedRightLabel);
            Controls.Add(timesRightLabel);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(dividedLeftLabel);
            Controls.Add(startButton);
            Controls.Add(minusLeftLabel);
            Controls.Add(timesLeftLabel);
            Controls.Add(soma);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(plusRightLabel);
            Controls.Add(plusLeftLabel);
            Controls.Add(label2);
            Controls.Add(timeLabel);
            Name = "Form1";
            Text = "Teste de Matemática";
            ((System.ComponentModel.ISupportInitialize)soma).EndInit();
            ((System.ComponentModel.ISupportInitialize)produto).EndInit();
            ((System.ComponentModel.ISupportInitialize)quociente).EndInit();
            ((System.ComponentModel.ISupportInitialize)diferença).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timeLabel;
        private Label label2;
        private Label plusLeftLabel;
        private Label plusRightLabel;
        private Label label4;
        private Label label5;
        private NumericUpDown soma;
        private Label timesLeftLabel;
        private Label minusLeftLabel;
        private Button startButton;
        private Label dividedLeftLabel;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label timesRightLabel;
        private Label dividedRightLabel;
        private Label minusRightLabel;
        private Label label13;
        private Label label14;
        private Label label15;
        private NumericUpDown produto;
        private NumericUpDown quociente;
        private NumericUpDown diferença;
        private System.Windows.Forms.Timer timer1;
    }
}
