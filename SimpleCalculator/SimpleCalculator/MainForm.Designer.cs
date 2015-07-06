using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleCalculator
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.FirstArgument = new TextBox();
            this.SecondArgument = new TextBox();
            this.Result = new TextBox();
            this.Addition = new Button();
            this.Substraction = new Button();
            this.Multiplication = new Button();
            this.Division = new Button();
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.reset = new Button();
            this.SuspendLayout();
            // 
            // FirstArgument
            // 
            this.FirstArgument.BackColor = SystemColors.Window;
            this.FirstArgument.Location = new Point(12, 26);
            this.FirstArgument.Name = "FirstArgument";
            this.FirstArgument.Size = new Size(215, 20);
            this.FirstArgument.TabIndex = 0;
            this.FirstArgument.KeyPress += new KeyPressEventHandler(this.FirstArgumentKeyPress);
            // 
            // SecondArgument
            // 
            this.SecondArgument.Location = new Point(12, 75);
            this.SecondArgument.Name = "SecondArgument";
            this.SecondArgument.Size = new Size(215, 20);
            this.SecondArgument.TabIndex = 1;
            // 
            // Result
            // 
            this.Result.Location = new Point(12, 125);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new Size(215, 20);
            this.Result.TabIndex = 2;
            this.Result.TextChanged += new EventHandler(this.ResultTextChanged);
            // 
            // Addition
            // 
            this.Addition.BackColor = SystemColors.Control;
            this.Addition.Location = new Point(12, 151);
            this.Addition.Name = "Addition";
            this.Addition.Size = new Size(60, 42);
            this.Addition.TabIndex = 3;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = false;
            this.Addition.Click += new EventHandler(this.Operations);
            // 
            // Substraction
            // 
            this.Substraction.Location = new Point(79, 151);
            this.Substraction.Name = "Substraction";
            this.Substraction.Size = new Size(60, 42);
            this.Substraction.TabIndex = 4;
            this.Substraction.Text = "-";
            this.Substraction.UseVisualStyleBackColor = true;
            this.Substraction.Click += new EventHandler(this.Operations);
            // 
            // Multiplication
            // 
            this.Multiplication.Location = new Point(145, 151);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new Size(60, 42);
            this.Multiplication.TabIndex = 5;
            this.Multiplication.Text = "*";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new EventHandler(this.Operations);
            // 
            // Division
            // 
            this.Division.Location = new Point(211, 151);
            this.Division.Name = "Division";
            this.Division.Size = new Size(60, 42);
            this.Division.TabIndex = 6;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new EventHandler(this.Operations);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new Size(73, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "First argument";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new Size(91, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Second argument";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new Point(9, 109);
            this.label3.Name = "label3";
            this.label3.Size = new Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Result";
            // 
            // reset
            // 
            this.reset.Location = new Point(10, 199);
            this.reset.Name = "reset";
            this.reset.Size = new Size(259, 46);
            this.reset.TabIndex = 10;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new EventHandler(this.resetClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.ClientSize = new Size(281, 281);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.Substraction);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.SecondArgument);
            this.Controls.Add(this.FirstArgument);
            this.MaximumSize = new Size(297, 320);
            this.MinimumSize = new Size(297, 320);
            this.Name = "MainForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Simple calculator";
            this.Load += new EventHandler(this.MainFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox FirstArgument;
        private TextBox SecondArgument;
        private TextBox Result;
        private Button Addition;
        private Button Substraction;
        private Button Multiplication;
        private Button Division;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button reset;

    }
}

