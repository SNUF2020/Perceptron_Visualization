namespace Ver2._1_Perceptrons
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Description = new System.Windows.Forms.Label();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_Stop = new System.Windows.Forms.Button();
            this.textBox_Alpha = new System.Windows.Forms.TextBox();
            this.label_Alpha = new System.Windows.Forms.Label();
            this.label_maxEpochs = new System.Windows.Forms.Label();
            this.textBox_maxEpochs = new System.Windows.Forms.TextBox();
            this.label_TrainData = new System.Windows.Forms.Label();
            this.textBox_TrainData = new System.Windows.Forms.TextBox();
            this.label_TestData = new System.Windows.Forms.Label();
            this.textBox_TestData = new System.Windows.Forms.TextBox();
            this.eventLog1 = new System.Diagnostics.EventLog();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Description.Location = new System.Drawing.Point(61, 38);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(433, 29);
            this.label_Description.TabIndex = 0;
            this.label_Description.Text = "Perceptron Program - Logic Separation";
            // 
            // button_Start
            // 
            this.button_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Start.Location = new System.Drawing.Point(63, 113);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(140, 70);
            this.button_Start.TabIndex = 1;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_Stop
            // 
            this.button_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Stop.Location = new System.Drawing.Point(63, 210);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(140, 70);
            this.button_Stop.TabIndex = 2;
            this.button_Stop.Text = "Stop";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // textBox_Alpha
            // 
            this.textBox_Alpha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Alpha.Location = new System.Drawing.Point(479, 113);
            this.textBox_Alpha.Name = "textBox_Alpha";
            this.textBox_Alpha.Size = new System.Drawing.Size(120, 35);
            this.textBox_Alpha.TabIndex = 3;
            this.textBox_Alpha.Text = "0.001";
            this.textBox_Alpha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Alpha_KeyPress);
            // 
            // label_Alpha
            // 
            this.label_Alpha.AutoSize = true;
            this.label_Alpha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Alpha.Location = new System.Drawing.Point(380, 113);
            this.label_Alpha.Name = "label_Alpha";
            this.label_Alpha.Size = new System.Drawing.Size(74, 29);
            this.label_Alpha.TabIndex = 4;
            this.label_Alpha.Text = "Alpha";
            // 
            // label_maxEpochs
            // 
            this.label_maxEpochs.AutoSize = true;
            this.label_maxEpochs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_maxEpochs.Location = new System.Drawing.Point(343, 168);
            this.label_maxEpochs.Name = "label_maxEpochs";
            this.label_maxEpochs.Size = new System.Drawing.Size(111, 29);
            this.label_maxEpochs.TabIndex = 5;
            this.label_maxEpochs.Text = "Iterations";
            // 
            // textBox_maxEpochs
            // 
            this.textBox_maxEpochs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_maxEpochs.Location = new System.Drawing.Point(479, 168);
            this.textBox_maxEpochs.Name = "textBox_maxEpochs";
            this.textBox_maxEpochs.Size = new System.Drawing.Size(117, 35);
            this.textBox_maxEpochs.TabIndex = 6;
            this.textBox_maxEpochs.Text = "200";
            this.textBox_maxEpochs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_maxEpochs_KeyPress);
            // 
            // label_TrainData
            // 
            this.label_TrainData.AutoSize = true;
            this.label_TrainData.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TrainData.Location = new System.Drawing.Point(244, 221);
            this.label_TrainData.Name = "label_TrainData";
            this.label_TrainData.Size = new System.Drawing.Size(210, 29);
            this.label_TrainData.TabIndex = 7;
            this.label_TrainData.Text = "# Points TrainData";
            // 
            // textBox_TrainData
            // 
            this.textBox_TrainData.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TrainData.Location = new System.Drawing.Point(479, 221);
            this.textBox_TrainData.Name = "textBox_TrainData";
            this.textBox_TrainData.Size = new System.Drawing.Size(117, 35);
            this.textBox_TrainData.TabIndex = 8;
            this.textBox_TrainData.Text = "10";
            this.textBox_TrainData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_TrainData_KeyPress);
            // 
            // label_TestData
            // 
            this.label_TestData.AutoSize = true;
            this.label_TestData.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TestData.Location = new System.Drawing.Point(244, 279);
            this.label_TestData.Name = "label_TestData";
            this.label_TestData.Size = new System.Drawing.Size(202, 29);
            this.label_TestData.TabIndex = 9;
            this.label_TestData.Text = "# Points TestData";
            // 
            // textBox_TestData
            // 
            this.textBox_TestData.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TestData.Location = new System.Drawing.Point(479, 279);
            this.textBox_TestData.Name = "textBox_TestData";
            this.textBox_TestData.Size = new System.Drawing.Size(117, 35);
            this.textBox_TestData.TabIndex = 10;
            this.textBox_TestData.Text = "10";
            this.textBox_TestData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_TestData_KeyPress);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_TestData);
            this.Controls.Add(this.label_TestData);
            this.Controls.Add(this.textBox_TrainData);
            this.Controls.Add(this.label_TrainData);
            this.Controls.Add(this.textBox_maxEpochs);
            this.Controls.Add(this.label_maxEpochs);
            this.Controls.Add(this.label_Alpha);
            this.Controls.Add(this.textBox_Alpha);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.label_Description);
            this.Name = "Form1";
            this.Text = "S.NUF.2020";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.TextBox textBox_Alpha;
        private System.Windows.Forms.Label label_Alpha;
        private System.Windows.Forms.Label label_maxEpochs;
        private System.Windows.Forms.TextBox textBox_maxEpochs;
        private System.Windows.Forms.Label label_TrainData;
        private System.Windows.Forms.TextBox textBox_TrainData;
        private System.Windows.Forms.Label label_TestData;
        private System.Windows.Forms.TextBox textBox_TestData;
        private System.Diagnostics.EventLog eventLog1;
    }
}

