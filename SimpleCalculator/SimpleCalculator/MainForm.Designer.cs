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
            this.FirstArgument = new System.Windows.Forms.TextBox();
            this.SecondArgument = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.Addition = new System.Windows.Forms.Button();
            this.Substraction = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.Sin = new System.Windows.Forms.Button();
            this.Squared = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.Lg = new System.Windows.Forms.Button();
            this.Ln = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstArgument
            // 
            this.FirstArgument.BackColor = System.Drawing.SystemColors.Window;
            this.FirstArgument.Location = new System.Drawing.Point(12, 26);
            this.FirstArgument.Name = "FirstArgument";
            this.FirstArgument.Size = new System.Drawing.Size(215, 20);
            this.FirstArgument.TabIndex = 0;
            this.FirstArgument.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstArgumentKeyPress);
            // 
            // SecondArgument
            // 
            this.SecondArgument.Location = new System.Drawing.Point(12, 75);
            this.SecondArgument.Name = "SecondArgument";
            this.SecondArgument.Size = new System.Drawing.Size(215, 20);
            this.SecondArgument.TabIndex = 1;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(12, 125);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(215, 20);
            this.Result.TabIndex = 2;
            this.Result.TextChanged += new System.EventHandler(this.ResultTextChanged);
            // 
            // Addition
            // 
            this.Addition.BackColor = System.Drawing.SystemColors.Control;
            this.Addition.Location = new System.Drawing.Point(12, 203);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(60, 42);
            this.Addition.TabIndex = 3;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.Operations);
            // 
            // Substraction
            // 
            this.Substraction.Location = new System.Drawing.Point(77, 203);
            this.Substraction.Name = "Substraction";
            this.Substraction.Size = new System.Drawing.Size(60, 42);
            this.Substraction.TabIndex = 4;
            this.Substraction.Text = "-";
            this.Substraction.UseVisualStyleBackColor = true;
            this.Substraction.Click += new System.EventHandler(this.Operations);
            // 
            // Multiplication
            // 
            this.Multiplication.Location = new System.Drawing.Point(143, 203);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(60, 42);
            this.Multiplication.TabIndex = 5;
            this.Multiplication.Text = "*";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.Operations);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(209, 203);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(60, 42);
            this.Division.TabIndex = 6;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Operations);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "First argument";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Second argument";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Result";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(10, 151);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(259, 46);
            this.reset.TabIndex = 10;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.resetClick);
            // 
            // Sin
            // 
            this.Sin.BackColor = System.Drawing.SystemColors.Control;
            this.Sin.Location = new System.Drawing.Point(12, 251);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(60, 42);
            this.Sin.TabIndex = 11;
            this.Sin.Text = "Sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.OperationsWithOneArgument);
            // 
            // Squared
            // 
            this.Squared.BackColor = System.Drawing.SystemColors.Control;
            this.Squared.Location = new System.Drawing.Point(12, 299);
            this.Squared.Name = "Squared";
            this.Squared.Size = new System.Drawing.Size(60, 42);
            this.Squared.TabIndex = 12;
            this.Squared.Text = "x^2";
            this.Squared.UseVisualStyleBackColor = true;
            this.Squared.Click += new System.EventHandler(this.OperationsWithOneArgument);
            // 
            // sqrt
            // 
            this.sqrt.BackColor = System.Drawing.SystemColors.Control;
            this.sqrt.Location = new System.Drawing.Point(77, 299);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(60, 42);
            this.sqrt.TabIndex = 13;
            this.sqrt.Text = "sqrt";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.Click += new System.EventHandler(this.OperationsWithOneArgument);
            // 
            // Lg
            // 
            this.Lg.BackColor = System.Drawing.SystemColors.Control;
            this.Lg.Location = new System.Drawing.Point(209, 251);
            this.Lg.Name = "Lg";
            this.Lg.Size = new System.Drawing.Size(60, 42);
            this.Lg.TabIndex = 14;
            this.Lg.Text = "Lg";
            this.Lg.UseVisualStyleBackColor = true;
            this.Lg.Click += new System.EventHandler(this.OperationsWithOneArgument);
            // 
            // Ln
            // 
            this.Ln.BackColor = System.Drawing.SystemColors.Control;
            this.Ln.Location = new System.Drawing.Point(143, 251);
            this.Ln.Name = "Ln";
            this.Ln.Size = new System.Drawing.Size(60, 42);
            this.Ln.TabIndex = 15;
            this.Ln.Text = "Ln";
            this.Ln.UseVisualStyleBackColor = true;
            this.Ln.Click += new System.EventHandler(this.OperationsWithOneArgument);
            // 
            // Cos
            // 
            this.Cos.BackColor = System.Drawing.SystemColors.Control;
            this.Cos.Location = new System.Drawing.Point(77, 251);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(60, 42);
            this.Cos.TabIndex = 16;
            this.Cos.Text = "Cos";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.OperationsWithOneArgument);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(281, 382);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Ln);
            this.Controls.Add(this.Lg);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.Squared);
            this.Controls.Add(this.Sin);
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
            this.MaximumSize = new System.Drawing.Size(297, 420);
            this.MinimumSize = new System.Drawing.Size(297, 420);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple calculator";
            this.Load += new System.EventHandler(this.MainFormLoad);
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
        private Button Sin;
        private Button Squared;
        private Button sqrt;
        private Button Lg;
        private Button Ln;
        private Button Cos;

    }
}

