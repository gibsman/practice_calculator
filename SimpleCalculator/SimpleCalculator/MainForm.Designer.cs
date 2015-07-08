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
            this.Sqrt = new System.Windows.Forms.Button();
            this.Lg = new System.Windows.Forms.Button();
            this.Ln = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.Tan = new System.Windows.Forms.Button();
            this.Power = new System.Windows.Forms.Button();
            this.Expanenta = new System.Windows.Forms.Button();
            this.Module = new System.Windows.Forms.Button();
            this.InverseValue = new System.Windows.Forms.Button();
            this.Bubble = new System.Windows.Forms.Button();
            this.Selection = new System.Windows.Forms.Button();
            this.Bucket = new System.Windows.Forms.Button();
            this.Insertion = new System.Windows.Forms.Button();
            this.Acos = new System.Windows.Forms.Button();
            this.Asin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstArgument
            // 
            this.FirstArgument.BackColor = System.Drawing.SystemColors.Window;
            this.FirstArgument.Location = new System.Drawing.Point(12, 26);
            this.FirstArgument.Name = "FirstArgument";
            this.FirstArgument.Size = new System.Drawing.Size(269, 20);
            this.FirstArgument.TabIndex = 0;
            this.FirstArgument.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstArgumentKeyPress);
            // 
            // SecondArgument
            // 
            this.SecondArgument.Location = new System.Drawing.Point(12, 75);
            this.SecondArgument.Name = "SecondArgument";
            this.SecondArgument.Size = new System.Drawing.Size(269, 20);
            this.SecondArgument.TabIndex = 1;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(12, 125);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(269, 20);
            this.Result.TabIndex = 2;
            this.Result.TextChanged += new System.EventHandler(this.ResultTextChanged);
            // 
            // Addition
            // 
            this.Addition.BackColor = System.Drawing.SystemColors.Control;
            this.Addition.Location = new System.Drawing.Point(10, 195);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(51, 38);
            this.Addition.TabIndex = 3;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.OperationsWithTwoAgument);
            // 
            // Substraction
            // 
            this.Substraction.Location = new System.Drawing.Point(67, 195);
            this.Substraction.Name = "Substraction";
            this.Substraction.Size = new System.Drawing.Size(49, 38);
            this.Substraction.TabIndex = 4;
            this.Substraction.Text = "-";
            this.Substraction.UseVisualStyleBackColor = true;
            this.Substraction.Click += new System.EventHandler(this.OperationsWithTwoAgument);
            // 
            // Multiplication
            // 
            this.Multiplication.Location = new System.Drawing.Point(122, 195);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(49, 38);
            this.Multiplication.TabIndex = 5;
            this.Multiplication.Text = "*";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.OperationsWithTwoAgument);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(178, 195);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(49, 38);
            this.Division.TabIndex = 6;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.OperationsWithTwoAgument);
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
            this.reset.Size = new System.Drawing.Size(271, 38);
            this.reset.TabIndex = 10;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.resetClick);
            // 
            // Sin
            // 
            this.Sin.BackColor = System.Drawing.SystemColors.Control;
            this.Sin.Location = new System.Drawing.Point(10, 239);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(51, 38);
            this.Sin.TabIndex = 11;
            this.Sin.Text = "Sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.OperationsWithOneArgument);
            // 
            // Squared
            // 
            this.Squared.BackColor = System.Drawing.SystemColors.Control;
            this.Squared.Location = new System.Drawing.Point(67, 283);
            this.Squared.Name = "Squared";
            this.Squared.Size = new System.Drawing.Size(49, 38);
            this.Squared.TabIndex = 12;
            this.Squared.Text = "x^2";
            this.Squared.UseVisualStyleBackColor = true;
            this.Squared.Click += new System.EventHandler(this.OperationsWithOneArgument);
            // 
            // Sqrt
            // 
            this.Sqrt.BackColor = System.Drawing.SystemColors.Control;
            this.Sqrt.Location = new System.Drawing.Point(178, 283);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(49, 38);
            this.Sqrt.TabIndex = 13;
            this.Sqrt.Text = "Sqrt";
            this.Sqrt.UseVisualStyleBackColor = true;
            this.Sqrt.Click += new System.EventHandler(this.OperationsWithOneArgument);
            // 
            // Lg
            // 
            this.Lg.BackColor = System.Drawing.SystemColors.Control;
            this.Lg.Location = new System.Drawing.Point(10, 283);
            this.Lg.Name = "Lg";
            this.Lg.Size = new System.Drawing.Size(51, 38);
            this.Lg.TabIndex = 14;
            this.Lg.Text = "Lg";
            this.Lg.UseVisualStyleBackColor = true;
            this.Lg.Click += new System.EventHandler(this.OperationsWithOneArgument);
            // 
            // Ln
            // 
            this.Ln.BackColor = System.Drawing.SystemColors.Control;
            this.Ln.Location = new System.Drawing.Point(177, 239);
            this.Ln.Name = "Ln";
            this.Ln.Size = new System.Drawing.Size(49, 38);
            this.Ln.TabIndex = 15;
            this.Ln.Text = "Ln";
            this.Ln.UseVisualStyleBackColor = true;
            this.Ln.Click += new System.EventHandler(this.OperationsWithOneArgument);
            // 
            // Cos
            // 
            this.Cos.BackColor = System.Drawing.SystemColors.Control;
            this.Cos.Location = new System.Drawing.Point(67, 239);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(49, 38);
            this.Cos.TabIndex = 16;
            this.Cos.Text = "Cos";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.OperationsWithOneArgument);
            // 
            // Tan
            // 
            this.Tan.BackColor = System.Drawing.SystemColors.Control;
            this.Tan.Location = new System.Drawing.Point(122, 239);
            this.Tan.Name = "Tan";
            this.Tan.Size = new System.Drawing.Size(49, 38);
            this.Tan.TabIndex = 17;
            this.Tan.Text = "Tan";
            this.Tan.UseVisualStyleBackColor = true;
            this.Tan.Click += new System.EventHandler(this.OperationsWithOneArgument);
            // 
            // Power
            // 
            this.Power.BackColor = System.Drawing.SystemColors.Control;
            this.Power.Location = new System.Drawing.Point(120, 283);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(49, 38);
            this.Power.TabIndex = 18;
            this.Power.Text = "x^y";
            this.Power.UseVisualStyleBackColor = true;
            this.Power.Click += new System.EventHandler(this.OperationsWithTwoAgument);
            // 
            // Expanenta
            // 
            this.Expanenta.BackColor = System.Drawing.SystemColors.Control;
            this.Expanenta.Location = new System.Drawing.Point(232, 195);
            this.Expanenta.Name = "Expanenta";
            this.Expanenta.Size = new System.Drawing.Size(49, 38);
            this.Expanenta.TabIndex = 19;
            this.Expanenta.Text = "Exp";
            this.Expanenta.UseVisualStyleBackColor = true;
            this.Expanenta.Click += new System.EventHandler(this.OperationsWithOneArgument);
            // 
            // Module
            // 
            this.Module.BackColor = System.Drawing.SystemColors.Control;
            this.Module.Location = new System.Drawing.Point(232, 283);
            this.Module.Name = "Module";
            this.Module.Size = new System.Drawing.Size(49, 38);
            this.Module.TabIndex = 20;
            this.Module.Text = "|x|";
            this.Module.UseVisualStyleBackColor = true;
            this.Module.Click += new System.EventHandler(this.OperationsWithOneArgument);
            // 
            // InverseValue
            // 
            this.InverseValue.BackColor = System.Drawing.SystemColors.Control;
            this.InverseValue.Location = new System.Drawing.Point(232, 239);
            this.InverseValue.Name = "InverseValue";
            this.InverseValue.Size = new System.Drawing.Size(49, 38);
            this.InverseValue.TabIndex = 22;
            this.InverseValue.Text = "1/x";
            this.InverseValue.UseVisualStyleBackColor = true;
            this.InverseValue.Click += new System.EventHandler(this.OperationsWithOneArgument);
            // 
            // Bubble
            // 
            this.Bubble.BackColor = System.Drawing.SystemColors.Control;
            this.Bubble.Location = new System.Drawing.Point(10, 327);
            this.Bubble.Name = "Bubble";
            this.Bubble.Size = new System.Drawing.Size(106, 38);
            this.Bubble.TabIndex = 23;
            this.Bubble.Text = "BubbleSort";
            this.Bubble.UseVisualStyleBackColor = true;
            this.Bubble.Click += new System.EventHandler(this.SortingMassives);
            // 
            // Selection
            // 
            this.Selection.BackColor = System.Drawing.SystemColors.Control;
            this.Selection.Location = new System.Drawing.Point(10, 375);
            this.Selection.Name = "Selection";
            this.Selection.Size = new System.Drawing.Size(106, 38);
            this.Selection.TabIndex = 24;
            this.Selection.Text = "SelectionSort";
            this.Selection.UseVisualStyleBackColor = true;
            this.Selection.Click += new System.EventHandler(this.SortingMassives);
            // 
            // Bucket
            // 
            this.Bucket.BackColor = System.Drawing.SystemColors.Control;
            this.Bucket.Location = new System.Drawing.Point(122, 327);
            this.Bucket.Name = "Bucket";
            this.Bucket.Size = new System.Drawing.Size(104, 38);
            this.Bucket.TabIndex = 25;
            this.Bucket.Text = "BucketSort";
            this.Bucket.UseVisualStyleBackColor = true;
            this.Bucket.Click += new System.EventHandler(this.SortingMassives);
            // 
            // Insertion
            // 
            this.Insertion.BackColor = System.Drawing.SystemColors.Control;
            this.Insertion.Location = new System.Drawing.Point(123, 375);
            this.Insertion.Name = "Insertion";
            this.Insertion.Size = new System.Drawing.Size(104, 38);
            this.Insertion.TabIndex = 26;
            this.Insertion.Text = "InsertionSort";
            this.Insertion.UseVisualStyleBackColor = true;
            this.Insertion.Click += new System.EventHandler(this.SortingMassives);
            // 
            // Acos
            // 
            this.Acos.BackColor = System.Drawing.SystemColors.Control;
            this.Acos.Location = new System.Drawing.Point(232, 375);
            this.Acos.Name = "Acos";
            this.Acos.Size = new System.Drawing.Size(49, 38);
            this.Acos.TabIndex = 27;
            this.Acos.Text = "Acos";
            this.Acos.UseVisualStyleBackColor = true;
            this.Acos.Click += new System.EventHandler(this.OperationsWithOneArgument);
            // 
            // Asin
            // 
            this.Asin.BackColor = System.Drawing.SystemColors.Control;
            this.Asin.Location = new System.Drawing.Point(232, 327);
            this.Asin.Name = "Asin";
            this.Asin.Size = new System.Drawing.Size(49, 38);
            this.Asin.TabIndex = 28;
            this.Asin.Text = "Asin";
            this.Asin.UseVisualStyleBackColor = true;
            this.Asin.Click += new System.EventHandler(this.OperationsWithOneArgument);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(289, 426);
            this.Controls.Add(this.Asin);
            this.Controls.Add(this.Acos);
            this.Controls.Add(this.Insertion);
            this.Controls.Add(this.Bucket);
            this.Controls.Add(this.Selection);
            this.Controls.Add(this.Bubble);
            this.Controls.Add(this.InverseValue);
            this.Controls.Add(this.Module);
            this.Controls.Add(this.Expanenta);
            this.Controls.Add(this.Power);
            this.Controls.Add(this.Tan);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Ln);
            this.Controls.Add(this.Lg);
            this.Controls.Add(this.Sqrt);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(305, 460);
            this.MinimumSize = new System.Drawing.Size(305, 460);
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
        private Button Sqrt;
        private Button Lg;
        private Button Ln;
        private Button Cos;
        private Button Tan;
        private Button Power;
        private Button Expanenta;
        private Button Module;
        private Button InverseValue;
        private Button Bubble;
        private Button Selection;
        private Button Bucket;
        private Button Insertion;
        private Button Acos;
        private Button Asin;

    }
}

