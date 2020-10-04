using System.Windows.Forms;

namespace WinFormsApp1
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clearAll = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.changeSign = new System.Windows.Forms.Button();
            this.clearOne = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.currentValue = new System.Windows.Forms.Label();
            this.prevValue = new System.Windows.Forms.Label();
            this.one = new System.Windows.Forms.Button();
            this.operandValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clearAll
            // 
            this.clearAll.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (53)))), ((int) (((byte) (57)))), ((int) (((byte) (87)))));
            this.clearAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clearAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearAll.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearAll.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clearAll.FlatAppearance.BorderSize = 0;
            this.clearAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.clearAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (221)))), ((int) (((byte) (60)))));
            this.clearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearAll.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.clearAll.ForeColor = System.Drawing.Color.Transparent;
            this.clearAll.Location = new System.Drawing.Point(5, 104);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(50, 50);
            this.clearAll.TabIndex = 0;
            this.clearAll.Text = "C";
            this.clearAll.UseVisualStyleBackColor = false;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (53)))), ((int) (((byte) (57)))), ((int) (((byte) (87)))));
            this.plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plus.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.plus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.plus.FlatAppearance.BorderSize = 0;
            this.plus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.plus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (221)))), ((int) (((byte) (60)))));
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.plus.ForeColor = System.Drawing.Color.Transparent;
            this.plus.Location = new System.Drawing.Point(173, 272);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(50, 50);
            this.plus.TabIndex = 1;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (53)))), ((int) (((byte) (57)))), ((int) (((byte) (87)))));
            this.minus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minus.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.minus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.minus.FlatAppearance.BorderSize = 0;
            this.minus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (221)))), ((int) (((byte) (60)))));
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.minus.ForeColor = System.Drawing.Color.Transparent;
            this.minus.Location = new System.Drawing.Point(173, 216);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(50, 50);
            this.minus.TabIndex = 2;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (53)))), ((int) (((byte) (57)))), ((int) (((byte) (87)))));
            this.two.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.two.Cursor = System.Windows.Forms.Cursors.Hand;
            this.two.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.two.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.two.FlatAppearance.BorderSize = 0;
            this.two.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.two.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (221)))), ((int) (((byte) (60)))));
            this.two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.two.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.two.ForeColor = System.Drawing.Color.Transparent;
            this.two.Location = new System.Drawing.Point(61, 272);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(50, 50);
            this.two.TabIndex = 3;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (53)))), ((int) (((byte) (57)))), ((int) (((byte) (87)))));
            this.three.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.three.Cursor = System.Windows.Forms.Cursors.Hand;
            this.three.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.three.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.three.FlatAppearance.BorderSize = 0;
            this.three.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.three.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (221)))), ((int) (((byte) (60)))));
            this.three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.three.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.three.ForeColor = System.Drawing.Color.Transparent;
            this.three.Location = new System.Drawing.Point(117, 272);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(50, 50);
            this.three.TabIndex = 5;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (53)))), ((int) (((byte) (57)))), ((int) (((byte) (87)))));
            this.five.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.five.Cursor = System.Windows.Forms.Cursors.Hand;
            this.five.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.five.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.five.FlatAppearance.BorderSize = 0;
            this.five.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.five.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (221)))), ((int) (((byte) (60)))));
            this.five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.five.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.five.ForeColor = System.Drawing.Color.Transparent;
            this.five.Location = new System.Drawing.Point(61, 216);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(50, 50);
            this.five.TabIndex = 6;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (53)))), ((int) (((byte) (57)))), ((int) (((byte) (87)))));
            this.six.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.six.Cursor = System.Windows.Forms.Cursors.Hand;
            this.six.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.six.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.six.FlatAppearance.BorderSize = 0;
            this.six.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.six.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (221)))), ((int) (((byte) (60)))));
            this.six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.six.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.six.ForeColor = System.Drawing.Color.Transparent;
            this.six.Location = new System.Drawing.Point(117, 216);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(50, 50);
            this.six.TabIndex = 7;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (53)))), ((int) (((byte) (57)))), ((int) (((byte) (87)))));
            this.four.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.four.Cursor = System.Windows.Forms.Cursors.Hand;
            this.four.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.four.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.four.FlatAppearance.BorderSize = 0;
            this.four.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.four.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (221)))), ((int) (((byte) (60)))));
            this.four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.four.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.four.ForeColor = System.Drawing.Color.Transparent;
            this.four.Location = new System.Drawing.Point(5, 216);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(50, 50);
            this.four.TabIndex = 8;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (53)))), ((int) (((byte) (57)))), ((int) (((byte) (87)))));
            this.seven.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.seven.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seven.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.seven.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.seven.FlatAppearance.BorderSize = 0;
            this.seven.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.seven.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (221)))), ((int) (((byte) (60)))));
            this.seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seven.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.seven.ForeColor = System.Drawing.Color.Transparent;
            this.seven.Location = new System.Drawing.Point(5, 160);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(50, 50);
            this.seven.TabIndex = 9;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (53)))), ((int) (((byte) (57)))), ((int) (((byte) (87)))));
            this.eight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.eight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eight.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.eight.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.eight.FlatAppearance.BorderSize = 0;
            this.eight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.eight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (221)))), ((int) (((byte) (60)))));
            this.eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eight.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.eight.ForeColor = System.Drawing.Color.Transparent;
            this.eight.Location = new System.Drawing.Point(61, 160);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(50, 50);
            this.eight.TabIndex = 10;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (53)))), ((int) (((byte) (57)))), ((int) (((byte) (87)))));
            this.nine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nine.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.nine.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.nine.FlatAppearance.BorderSize = 0;
            this.nine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.nine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (221)))), ((int) (((byte) (60)))));
            this.nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nine.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.nine.ForeColor = System.Drawing.Color.Transparent;
            this.nine.Location = new System.Drawing.Point(117, 160);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(50, 50);
            this.nine.TabIndex = 11;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // multiplication
            // 
            this.multiplication.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (53)))), ((int) (((byte) (57)))), ((int) (((byte) (87)))));
            this.multiplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.multiplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multiplication.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.multiplication.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.multiplication.FlatAppearance.BorderSize = 0;
            this.multiplication.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.multiplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (221)))), ((int) (((byte) (60)))));
            this.multiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplication.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.multiplication.ForeColor = System.Drawing.Color.Transparent;
            this.multiplication.Location = new System.Drawing.Point(173, 160);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(50, 50);
            this.multiplication.TabIndex = 12;
            this.multiplication.Text = "x";
            this.multiplication.UseVisualStyleBackColor = false;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // division
            // 
            this.division.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (53)))), ((int) (((byte) (57)))), ((int) (((byte) (87)))));
            this.division.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.division.Cursor = System.Windows.Forms.Cursors.Hand;
            this.division.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.division.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.division.FlatAppearance.BorderSize = 0;
            this.division.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.division.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (221)))), ((int) (((byte) (60)))));
            this.division.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.division.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.division.ForeColor = System.Drawing.Color.Transparent;
            this.division.Location = new System.Drawing.Point(173, 104);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(50, 50);
            this.division.TabIndex = 13;
            this.division.Text = "÷";
            this.division.UseVisualStyleBackColor = false;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // changeSign
            // 
            this.changeSign.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (53)))), ((int) (((byte) (57)))), ((int) (((byte) (87)))));
            this.changeSign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.changeSign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeSign.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.changeSign.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.changeSign.FlatAppearance.BorderSize = 0;
            this.changeSign.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.changeSign.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (221)))), ((int) (((byte) (60)))));
            this.changeSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeSign.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.changeSign.ForeColor = System.Drawing.Color.Transparent;
            this.changeSign.Location = new System.Drawing.Point(117, 104);
            this.changeSign.Name = "changeSign";
            this.changeSign.Size = new System.Drawing.Size(50, 50);
            this.changeSign.TabIndex = 14;
            this.changeSign.Text = "±";
            this.changeSign.UseVisualStyleBackColor = false;
            this.changeSign.Click += new System.EventHandler(this.changeSign_Click);
            // 
            // clearOne
            // 
            this.clearOne.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (53)))), ((int) (((byte) (57)))), ((int) (((byte) (87)))));
            this.clearOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clearOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearOne.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearOne.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clearOne.FlatAppearance.BorderSize = 0;
            this.clearOne.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.clearOne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (221)))), ((int) (((byte) (60)))));
            this.clearOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearOne.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.clearOne.ForeColor = System.Drawing.Color.Transparent;
            this.clearOne.Location = new System.Drawing.Point(61, 104);
            this.clearOne.Name = "clearOne";
            this.clearOne.Size = new System.Drawing.Size(50, 50);
            this.clearOne.TabIndex = 15;
            this.clearOne.Text = "AC";
            this.clearOne.UseVisualStyleBackColor = false;
            this.clearOne.Click += new System.EventHandler(this.clearOne_Click);
            // 
            // dot
            // 
            this.dot.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (53)))), ((int) (((byte) (57)))), ((int) (((byte) (87)))));
            this.dot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dot.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.dot.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.dot.FlatAppearance.BorderSize = 0;
            this.dot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.dot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (221)))), ((int) (((byte) (60)))));
            this.dot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dot.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dot.ForeColor = System.Drawing.Color.Transparent;
            this.dot.Location = new System.Drawing.Point(117, 328);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(50, 50);
            this.dot.TabIndex = 16;
            this.dot.Text = ",";
            this.dot.UseVisualStyleBackColor = false;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (221)))), ((int) (((byte) (60)))));
            this.equal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.equal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.equal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.equal.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.equal.FlatAppearance.BorderSize = 0;
            this.equal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.equal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (221)))), ((int) (((byte) (60)))));
            this.equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equal.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.equal.ForeColor = System.Drawing.Color.Transparent;
            this.equal.Location = new System.Drawing.Point(173, 328);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(50, 50);
            this.equal.TabIndex = 17;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (53)))), ((int) (((byte) (57)))), ((int) (((byte) (87)))));
            this.zero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.zero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zero.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.zero.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.zero.FlatAppearance.BorderSize = 0;
            this.zero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.zero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (221)))), ((int) (((byte) (60)))));
            this.zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zero.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.zero.ForeColor = System.Drawing.Color.Transparent;
            this.zero.Location = new System.Drawing.Point(5, 328);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(106, 50);
            this.zero.TabIndex = 18;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // currentValue
            // 
            this.currentValue.AutoEllipsis = true;
            this.currentValue.Font = new System.Drawing.Font("Britannic Bold", 18F);
            this.currentValue.ForeColor = System.Drawing.Color.White;
            this.currentValue.Location = new System.Drawing.Point(5, 56);
            this.currentValue.MaximumSize = new System.Drawing.Size(218, 45);
            this.currentValue.Name = "currentValue";
            this.currentValue.Size = new System.Drawing.Size(218, 34);
            this.currentValue.TabIndex = 19;
            this.currentValue.Text = "label1";
            this.currentValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // prevValue
            // 
            this.prevValue.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.prevValue.ForeColor = System.Drawing.Color.White;
            this.prevValue.Location = new System.Drawing.Point(5, 18);
            this.prevValue.Name = "prevValue";
            this.prevValue.Size = new System.Drawing.Size(218, 27);
            this.prevValue.TabIndex = 20;
            this.prevValue.Text = "label1";
            this.prevValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (53)))), ((int) (((byte) (57)))), ((int) (((byte) (87)))));
            this.one.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.one.Cursor = System.Windows.Forms.Cursors.Hand;
            this.one.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.one.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.one.FlatAppearance.BorderSize = 0;
            this.one.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.one.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (221)))), ((int) (((byte) (60)))));
            this.one.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.one.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.one.ForeColor = System.Drawing.Color.Transparent;
            this.one.Location = new System.Drawing.Point(5, 272);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(50, 50);
            this.one.TabIndex = 21;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // operandValue
            // 
            this.operandValue.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.operandValue.ForeColor = System.Drawing.Color.White;
            this.operandValue.Location = new System.Drawing.Point(5, 36);
            this.operandValue.Name = "operandValue";
            this.operandValue.Size = new System.Drawing.Size(20, 20);
            this.operandValue.TabIndex = 23;
            this.operandValue.Text = "operand";
            this.operandValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (29)))), ((int) (((byte) (41)))), ((int) (((byte) (58)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.clearAll;
            this.ClientSize = new System.Drawing.Size(227, 384);
            this.Controls.Add(this.operandValue);
            this.Controls.Add(this.one);
            this.Controls.Add(this.prevValue);
            this.Controls.Add(this.currentValue);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.clearOne);
            this.Controls.Add(this.changeSign);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.four);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.clearAll);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label operandValue;

        private System.Windows.Forms.Label prevValue;

        private System.Windows.Forms.Label currentValue;

        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;

        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button zero;

        private System.Windows.Forms.Button division;

        private System.Windows.Forms.Button changeSign;

        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.Button clearOne;

        #endregion
    }
}