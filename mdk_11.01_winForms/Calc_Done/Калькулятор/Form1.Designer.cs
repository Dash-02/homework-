using System.Drawing;
using System;
using System.Windows.Forms;

namespace Калькулятор
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button16 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NumberButtonClick);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(53, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NumberButtonClick);
            this.button2.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Controls.Add(this.button20, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.button19, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.button21, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.button18, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button16, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.button14, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.button17, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.button13, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.button15, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.equals, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.button8, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.button7, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.button12, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.button11, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.button10, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.button3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.button4, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.button5, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.min, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.button6, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.button9, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(18, 40);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(212, 339);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(3, 303);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(44, 33);
            this.button20.TabIndex = 24;
            this.button20.Text = "1/x";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(53, 303);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(44, 33);
            this.button19.TabIndex = 23;
            this.button19.Text = "log2(x)";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(103, 303);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(44, 33);
            this.button21.TabIndex = 22;
            this.button21.Text = "x!";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(53, 253);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(44, 44);
            this.button18.TabIndex = 19;
            this.button18.Text = "log10(x)";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // textBox1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.textBox1, 4);
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(153, 253);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(56, 44);
            this.button16.TabIndex = 17;
            this.button16.Text = "CE";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(103, 253);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(44, 44);
            this.button14.TabIndex = 15;
            this.button14.Text = "C";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(3, 253);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(44, 44);
            this.button17.TabIndex = 18;
            this.button17.Text = ",";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(3, 203);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(44, 44);
            this.button13.TabIndex = 14;
            this.button13.Text = "0";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.NumberButtonClick);
            this.button13.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button13.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(53, 203);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(43, 44);
            this.button15.TabIndex = 16;
            this.button15.Text = "+-";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // equals
            // 
            this.equals.Location = new System.Drawing.Point(103, 203);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(44, 44);
            this.equals.TabIndex = 3;
            this.equals.Text = "=";
            this.equals.UseMnemonic = false;
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.EqualsButtonClick);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(153, 203);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(56, 44);
            this.button8.TabIndex = 9;
            this.button8.Text = "/";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.OperatorButtonClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(153, 153);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(56, 44);
            this.button7.TabIndex = 8;
            this.button7.Text = "*";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.OperatorButtonClick);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(103, 153);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(44, 44);
            this.button12.TabIndex = 13;
            this.button12.Text = "9";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.NumberButtonClick);
            this.button12.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button12.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(53, 153);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(44, 44);
            this.button11.TabIndex = 12;
            this.button11.Text = "8";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.NumberButtonClick);
            this.button11.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button11.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(3, 153);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(44, 44);
            this.button10.TabIndex = 11;
            this.button10.Text = "7";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.NumberButtonClick);
            this.button10.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button10.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 44);
            this.button3.TabIndex = 4;
            this.button3.Text = "4";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.NumberButtonClick);
            this.button3.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(53, 103);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(44, 44);
            this.button4.TabIndex = 5;
            this.button4.Text = "5";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.NumberButtonClick);
            this.button4.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button4.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(103, 103);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(44, 44);
            this.button5.TabIndex = 6;
            this.button5.Text = "6";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.NumberButtonClick);
            this.button5.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button5.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(153, 103);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(56, 44);
            this.min.TabIndex = 2;
            this.min.Text = "-";
            this.min.UseVisualStyleBackColor = true;
            this.min.Click += new System.EventHandler(this.OperatorButtonClick);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Location = new System.Drawing.Point(153, 53);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 44);
            this.button6.TabIndex = 7;
            this.button6.Text = "+";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.OperatorButtonClick);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Location = new System.Drawing.Point(103, 53);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(44, 44);
            this.button9.TabIndex = 10;
            this.button9.Text = "3";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.NumberButtonClick);
            this.button9.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button9.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(263, 410);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBox1;
        private Button min;
        private Button equals;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Label label1;
        private Button button21;
        private Button button19;
        private Button button20;
    };
}

