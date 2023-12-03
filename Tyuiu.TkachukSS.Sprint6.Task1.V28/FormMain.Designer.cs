
namespace Tyuiu.TkachukSS.Sprint6.Task1.V28
{
    partial class Form1
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
            this.groupBoxDefine = new System.Windows.Forms.GroupBox();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.labelTextDefine = new System.Windows.Forms.Label();
            this.buttonRun = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxDefine.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDefine
            // 
            this.groupBoxDefine.Controls.Add(this.labelTextDefine);
            this.groupBoxDefine.Location = new System.Drawing.Point(24, 26);
            this.groupBoxDefine.Name = "groupBoxDefine";
            this.groupBoxDefine.Size = new System.Drawing.Size(444, 217);
            this.groupBoxDefine.TabIndex = 0;
            this.groupBoxDefine.TabStop = false;
            this.groupBoxDefine.Text = "Условие";
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.textBox3);
            this.groupBoxOutput.Location = new System.Drawing.Point(474, 26);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(169, 300);
            this.groupBoxOutput.TabIndex = 1;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Вывод";
            // 
            // labelTextDefine
            // 
            this.labelTextDefine.AutoSize = true;
            this.labelTextDefine.Location = new System.Drawing.Point(6, 16);
            this.labelTextDefine.Name = "labelTextDefine";
            this.labelTextDefine.Size = new System.Drawing.Size(347, 13);
            this.labelTextDefine.TabIndex = 0;
            this.labelTextDefine.Text = "Написать программу, которая выводит таблицу значений функции";
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(371, 261);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(97, 51);
            this.buttonRun.TabIndex = 2;
            this.buttonRun.Text = "Выполнить";
            this.buttonRun.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(315, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.label2);
            this.groupBoxInput.Controls.Add(this.label1);
            this.groupBoxInput.Controls.Add(this.textBox2);
            this.groupBoxInput.Controls.Add(this.textBox1);
            this.groupBoxInput.Location = new System.Drawing.Point(24, 249);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(285, 77);
            this.groupBoxInput.TabIndex = 2;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Ввод данных";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(161, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 19);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(157, 267);
            this.textBox3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Старт шага";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Конец шага";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 338);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.groupBoxDefine);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxDefine.ResumeLayout(false);
            this.groupBoxDefine.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDefine;
        private System.Windows.Forms.Label labelTextDefine;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

