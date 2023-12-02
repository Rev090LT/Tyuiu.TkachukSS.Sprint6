
using System;

namespace Tyuiu.TkachukSS.Sprint6.Task0.V3
{
    partial class FormTask0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTask0));
            this.textBoxVar = new System.Windows.Forms.TextBox();
            this.groupBoxDefinition = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxInputData = new System.Windows.Forms.GroupBox();
            this.labelVarible = new System.Windows.Forms.Label();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.groupBoxDefinition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxInputData.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxVar
            // 
            this.textBoxVar.Location = new System.Drawing.Point(44, 47);
            this.textBoxVar.Name = "textBoxVar";
            this.textBoxVar.Size = new System.Drawing.Size(100, 20);
            this.textBoxVar.TabIndex = 0;
            this.textBoxVar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVar_KeyPress);
            // 
            // groupBoxDefinition
            // 
            this.groupBoxDefinition.Controls.Add(this.pictureBox1);
            this.groupBoxDefinition.Controls.Add(this.label1);
            this.groupBoxDefinition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDefinition.Location = new System.Drawing.Point(34, 40);
            this.groupBoxDefinition.Name = "groupBoxDefinition";
            this.groupBoxDefinition.Size = new System.Drawing.Size(534, 226);
            this.groupBoxDefinition.TabIndex = 1;
            this.groupBoxDefinition.TabStop = false;
            this.groupBoxDefinition.Text = "Условие";
            //this.groupBoxDefinition.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(414, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 57);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Дано выражение. Вычислить его значение";
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBoxInputData
            // 
            this.groupBoxInputData.Controls.Add(this.labelVarible);
            this.groupBoxInputData.Controls.Add(this.textBoxVar);
            this.groupBoxInputData.Location = new System.Drawing.Point(34, 272);
            this.groupBoxInputData.Name = "groupBoxInputData";
            this.groupBoxInputData.Size = new System.Drawing.Size(200, 100);
            this.groupBoxInputData.TabIndex = 2;
            this.groupBoxInputData.TabStop = false;
            this.groupBoxInputData.Text = "Ввод данных";
            //this.groupBoxInputData.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // labelVarible
            // 
            this.labelVarible.AutoSize = true;
            this.labelVarible.Location = new System.Drawing.Point(51, 31);
            this.labelVarible.Name = "labelVarible";
            this.labelVarible.Size = new System.Drawing.Size(81, 13);
            this.labelVarible.TabIndex = 1;
            this.labelVarible.Text = "Переменная X";
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.textBoxResult);
            this.groupBoxResult.Location = new System.Drawing.Point(368, 272);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(200, 67);
            this.groupBoxResult.TabIndex = 3;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Результат";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(18, 28);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(167, 20);
            this.textBoxResult.TabIndex = 0;
            this.textBoxResult.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(419, 345);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(149, 39);
            this.buttonRun.TabIndex = 4;
            this.buttonRun.Text = "Выполнить";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp.Location = new System.Drawing.Point(368, 345);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(45, 39);
            this.buttonHelp.TabIndex = 5;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // FormTask0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 387);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxInputData);
            this.Controls.Add(this.groupBoxDefinition);
            this.Name = "FormTask0";
            this.Text = "Спринт 6 | Таск 0 | Вариант 3 | Ткачук С.С";
            //this.Load += new System.EventHandler(this.FormTask0_Load);
            this.groupBoxDefinition.ResumeLayout(false);
            this.groupBoxDefinition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxInputData.ResumeLayout(false);
            this.groupBoxInputData.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.ResumeLayout(false);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxVar;
        private System.Windows.Forms.GroupBox groupBoxDefinition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxInputData;
        private System.Windows.Forms.Label labelVarible;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonHelp;
    }
}

