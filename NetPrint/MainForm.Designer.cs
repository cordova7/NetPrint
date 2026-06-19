using System.Drawing;
using System.Windows.Forms;

namespace NetPrint
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.INEcheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tarea1checkBox = new System.Windows.Forms.CheckBox();
            this.tarea2checkBox = new System.Windows.Forms.CheckBox();
            this.tarea3checkBox = new System.Windows.Forms.CheckBox();
            this.tarea4checkBox = new System.Windows.Forms.CheckBox();
            this.tarea5checkBox = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tarea1mode = new System.Windows.Forms.CheckBox();
            this.tarea2mode = new System.Windows.Forms.CheckBox();
            this.tarea3mode = new System.Windows.Forms.CheckBox();
            this.tarea4mode = new System.Windows.Forms.CheckBox();
            this.tarea5mode = new System.Windows.Forms.CheckBox();
            this.duplexCheckBox = new System.Windows.Forms.CheckBox();
            this.tarea5INE = new System.Windows.Forms.CheckBox();
            this.tarea4INE = new System.Windows.Forms.CheckBox();
            this.tarea3INE = new System.Windows.Forms.CheckBox();
            this.tarea2INE = new System.Windows.Forms.CheckBox();
            this.tarea1INE = new System.Windows.Forms.CheckBox();
            this.tarea1copies = new System.Windows.Forms.NumericUpDown();
            this.tarea2copies = new System.Windows.Forms.NumericUpDown();
            this.tarea3copies = new System.Windows.Forms.NumericUpDown();
            this.tarea4copies = new System.Windows.Forms.NumericUpDown();
            this.tarea5copies = new System.Windows.Forms.NumericUpDown();
            this.ventasTextBox = new System.Windows.Forms.TextBox();
            this.buttonShowHide = new System.Windows.Forms.Button();
            this.clearTextBox = new System.Windows.Forms.Button();
            this.colorCheckBox = new System.Windows.Forms.CheckBox();
            this.opcionesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarea1copies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarea2copies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarea3copies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarea4copies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarea5copies)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Arial", 12F);
            this.numericUpDown1.Location = new System.Drawing.Point(148, 13);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(44, 26);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDown1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUpDown1_KeyDown);
            this.numericUpDown1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown1_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(116, 230);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 24);
            this.button1.TabIndex = 6;
            this.button1.Text = "Stop!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // INEcheckBox
            // 
            this.INEcheckBox.AutoSize = true;
            this.INEcheckBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.INEcheckBox.Location = new System.Drawing.Point(12, 15);
            this.INEcheckBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.INEcheckBox.Name = "INEcheckBox";
            this.INEcheckBox.Size = new System.Drawing.Size(49, 20);
            this.INEcheckBox.TabIndex = 8;
            this.INEcheckBox.Text = "INE";
            this.INEcheckBox.UseVisualStyleBackColor = true;
            this.INEcheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label4.Location = new System.Drawing.Point(76, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tareas";
            // 
            // tarea1checkBox
            // 
            this.tarea1checkBox.AutoSize = true;
            this.tarea1checkBox.BackColor = System.Drawing.Color.Black;
            this.tarea1checkBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tarea1checkBox.Location = new System.Drawing.Point(14, 80);
            this.tarea1checkBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tarea1checkBox.Name = "tarea1checkBox";
            this.tarea1checkBox.Size = new System.Drawing.Size(15, 14);
            this.tarea1checkBox.TabIndex = 10;
            this.tarea1checkBox.UseVisualStyleBackColor = false;
            this.tarea1checkBox.CheckedChanged += new System.EventHandler(this.tarea1checkBox_CheckedChanged);
            // 
            // tarea2checkBox
            // 
            this.tarea2checkBox.AutoSize = true;
            this.tarea2checkBox.BackColor = System.Drawing.Color.Black;
            this.tarea2checkBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tarea2checkBox.Location = new System.Drawing.Point(14, 111);
            this.tarea2checkBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tarea2checkBox.Name = "tarea2checkBox";
            this.tarea2checkBox.Size = new System.Drawing.Size(15, 14);
            this.tarea2checkBox.TabIndex = 11;
            this.tarea2checkBox.UseVisualStyleBackColor = false;
            this.tarea2checkBox.CheckedChanged += new System.EventHandler(this.tarea2checkBox_CheckedChanged);
            // 
            // tarea3checkBox
            // 
            this.tarea3checkBox.AutoSize = true;
            this.tarea3checkBox.BackColor = System.Drawing.Color.Black;
            this.tarea3checkBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tarea3checkBox.Location = new System.Drawing.Point(14, 141);
            this.tarea3checkBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tarea3checkBox.Name = "tarea3checkBox";
            this.tarea3checkBox.Size = new System.Drawing.Size(15, 14);
            this.tarea3checkBox.TabIndex = 12;
            this.tarea3checkBox.UseVisualStyleBackColor = false;
            this.tarea3checkBox.CheckedChanged += new System.EventHandler(this.tarea3checkBox_CheckedChanged);
            // 
            // tarea4checkBox
            // 
            this.tarea4checkBox.AutoSize = true;
            this.tarea4checkBox.BackColor = System.Drawing.Color.Black;
            this.tarea4checkBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tarea4checkBox.Location = new System.Drawing.Point(14, 171);
            this.tarea4checkBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tarea4checkBox.Name = "tarea4checkBox";
            this.tarea4checkBox.Size = new System.Drawing.Size(15, 14);
            this.tarea4checkBox.TabIndex = 13;
            this.tarea4checkBox.UseVisualStyleBackColor = false;
            this.tarea4checkBox.CheckedChanged += new System.EventHandler(this.tarea4checkBox_CheckedChanged);
            // 
            // tarea5checkBox
            // 
            this.tarea5checkBox.AutoSize = true;
            this.tarea5checkBox.BackColor = System.Drawing.Color.Black;
            this.tarea5checkBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tarea5checkBox.Location = new System.Drawing.Point(14, 202);
            this.tarea5checkBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tarea5checkBox.Name = "tarea5checkBox";
            this.tarea5checkBox.Size = new System.Drawing.Size(15, 14);
            this.tarea5checkBox.TabIndex = 14;
            this.tarea5checkBox.UseVisualStyleBackColor = false;
            this.tarea5checkBox.CheckedChanged += new System.EventHandler(this.tarea5checkBox_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Arial", 8F);
            this.button2.Location = new System.Drawing.Point(14, 230);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 24);
            this.button2.TabIndex = 15;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(14, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 2);
            this.label5.TabIndex = 16;
            // 
            // tarea1mode
            // 
            this.tarea1mode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tarea1mode.Font = new System.Drawing.Font("Arial", 7F);
            this.tarea1mode.Location = new System.Drawing.Point(94, 80);
            this.tarea1mode.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tarea1mode.Name = "tarea1mode";
            this.tarea1mode.Size = new System.Drawing.Size(60, 24);
            this.tarea1mode.TabIndex = 32;
            this.tarea1mode.Text = "Duplex";
            this.tarea1mode.UseVisualStyleBackColor = true;
            this.tarea1mode.CheckedChanged += new System.EventHandler(this.tarea1mode_CheckedChanged);
            // 
            // tarea2mode
            // 
            this.tarea2mode.Font = new System.Drawing.Font("Arial", 7F);
            this.tarea2mode.Location = new System.Drawing.Point(94, 111);
            this.tarea2mode.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tarea2mode.Name = "tarea2mode";
            this.tarea2mode.Size = new System.Drawing.Size(60, 24);
            this.tarea2mode.TabIndex = 33;
            this.tarea2mode.Text = "Duplex";
            this.tarea2mode.UseVisualStyleBackColor = true;
            this.tarea2mode.CheckedChanged += new System.EventHandler(this.tarea2mode_CheckedChanged);
            // 
            // tarea3mode
            // 
            this.tarea3mode.Font = new System.Drawing.Font("Arial", 7F);
            this.tarea3mode.Location = new System.Drawing.Point(94, 141);
            this.tarea3mode.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tarea3mode.Name = "tarea3mode";
            this.tarea3mode.Size = new System.Drawing.Size(60, 24);
            this.tarea3mode.TabIndex = 34;
            this.tarea3mode.Text = "Duplex";
            this.tarea3mode.UseVisualStyleBackColor = true;
            this.tarea3mode.CheckedChanged += new System.EventHandler(this.tarea3mode_CheckedChanged);
            // 
            // tarea4mode
            // 
            this.tarea4mode.Font = new System.Drawing.Font("Arial", 7F);
            this.tarea4mode.Location = new System.Drawing.Point(94, 171);
            this.tarea4mode.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tarea4mode.Name = "tarea4mode";
            this.tarea4mode.Size = new System.Drawing.Size(60, 24);
            this.tarea4mode.TabIndex = 35;
            this.tarea4mode.Text = "Duplex";
            this.tarea4mode.UseVisualStyleBackColor = true;
            this.tarea4mode.CheckedChanged += new System.EventHandler(this.tarea4mode_CheckedChanged);
            // 
            // tarea5mode
            // 
            this.tarea5mode.Font = new System.Drawing.Font("Arial", 7F);
            this.tarea5mode.Location = new System.Drawing.Point(94, 202);
            this.tarea5mode.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tarea5mode.Name = "tarea5mode";
            this.tarea5mode.Size = new System.Drawing.Size(60, 24);
            this.tarea5mode.TabIndex = 36;
            this.tarea5mode.Text = "Duplex";
            this.tarea5mode.UseVisualStyleBackColor = true;
            this.tarea5mode.CheckedChanged += new System.EventHandler(this.tarea5mode_CheckedChanged);
            // 
            // duplexCheckBox
            // 
            this.duplexCheckBox.AutoSize = true;
            this.duplexCheckBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.duplexCheckBox.Location = new System.Drawing.Point(68, 15);
            this.duplexCheckBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.duplexCheckBox.Name = "duplexCheckBox";
            this.duplexCheckBox.Size = new System.Drawing.Size(75, 20);
            this.duplexCheckBox.TabIndex = 37;
            this.duplexCheckBox.Text = "Duplex";
            this.duplexCheckBox.UseVisualStyleBackColor = true;
            this.duplexCheckBox.CheckedChanged += new System.EventHandler(this.duplexCheckBox_CheckedChanged);
            // 
            // tarea5INE
            // 
            this.tarea5INE.Font = new System.Drawing.Font("Arial", 7F);
            this.tarea5INE.Location = new System.Drawing.Point(44, 202);
            this.tarea5INE.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tarea5INE.Name = "tarea5INE";
            this.tarea5INE.Size = new System.Drawing.Size(44, 24);
            this.tarea5INE.TabIndex = 42;
            this.tarea5INE.Text = "INE";
            this.tarea5INE.UseVisualStyleBackColor = true;
            this.tarea5INE.CheckedChanged += new System.EventHandler(this.tarea5INE_CheckedChanged);
            // 
            // tarea4INE
            // 
            this.tarea4INE.Font = new System.Drawing.Font("Arial", 7F);
            this.tarea4INE.Location = new System.Drawing.Point(44, 171);
            this.tarea4INE.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tarea4INE.Name = "tarea4INE";
            this.tarea4INE.Size = new System.Drawing.Size(44, 24);
            this.tarea4INE.TabIndex = 41;
            this.tarea4INE.Text = "INE";
            this.tarea4INE.UseVisualStyleBackColor = true;
            this.tarea4INE.CheckedChanged += new System.EventHandler(this.tarea4INE_CheckedChanged);
            // 
            // tarea3INE
            // 
            this.tarea3INE.Font = new System.Drawing.Font("Arial", 7F);
            this.tarea3INE.Location = new System.Drawing.Point(44, 141);
            this.tarea3INE.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tarea3INE.Name = "tarea3INE";
            this.tarea3INE.Size = new System.Drawing.Size(44, 24);
            this.tarea3INE.TabIndex = 40;
            this.tarea3INE.Text = "INE";
            this.tarea3INE.UseVisualStyleBackColor = true;
            this.tarea3INE.CheckedChanged += new System.EventHandler(this.tarea3INE_CheckedChanged);
            // 
            // tarea2INE
            // 
            this.tarea2INE.Font = new System.Drawing.Font("Arial", 7F);
            this.tarea2INE.Location = new System.Drawing.Point(44, 111);
            this.tarea2INE.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tarea2INE.Name = "tarea2INE";
            this.tarea2INE.Size = new System.Drawing.Size(44, 24);
            this.tarea2INE.TabIndex = 39;
            this.tarea2INE.Text = "INE";
            this.tarea2INE.UseVisualStyleBackColor = true;
            this.tarea2INE.CheckedChanged += new System.EventHandler(this.tarea2INE_CheckedChanged);
            // 
            // tarea1INE
            // 
            this.tarea1INE.Cursor = System.Windows.Forms.Cursors.Default;
            this.tarea1INE.Font = new System.Drawing.Font("Arial", 7F);
            this.tarea1INE.Location = new System.Drawing.Point(44, 80);
            this.tarea1INE.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tarea1INE.Name = "tarea1INE";
            this.tarea1INE.Size = new System.Drawing.Size(44, 24);
            this.tarea1INE.TabIndex = 38;
            this.tarea1INE.Text = "INE";
            this.tarea1INE.UseVisualStyleBackColor = true;
            this.tarea1INE.CheckedChanged += new System.EventHandler(this.tarea1INE_CheckedChanged);
            // 
            // tarea1copies
            // 
            this.tarea1copies.Font = new System.Drawing.Font("Arial", 9F);
            this.tarea1copies.Location = new System.Drawing.Point(156, 80);
            this.tarea1copies.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tarea1copies.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tarea1copies.Name = "tarea1copies";
            this.tarea1copies.Size = new System.Drawing.Size(36, 21);
            this.tarea1copies.TabIndex = 43;
            this.tarea1copies.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tarea1copies.ValueChanged += new System.EventHandler(this.tarea1copies_ValueChanged);
            // 
            // tarea2copies
            // 
            this.tarea2copies.Font = new System.Drawing.Font("Arial", 9F);
            this.tarea2copies.Location = new System.Drawing.Point(156, 111);
            this.tarea2copies.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tarea2copies.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tarea2copies.Name = "tarea2copies";
            this.tarea2copies.Size = new System.Drawing.Size(36, 21);
            this.tarea2copies.TabIndex = 44;
            this.tarea2copies.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tarea2copies.ValueChanged += new System.EventHandler(this.tarea2copies_ValueChanged);
            // 
            // tarea3copies
            // 
            this.tarea3copies.Font = new System.Drawing.Font("Arial", 9F);
            this.tarea3copies.Location = new System.Drawing.Point(156, 141);
            this.tarea3copies.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tarea3copies.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tarea3copies.Name = "tarea3copies";
            this.tarea3copies.Size = new System.Drawing.Size(36, 21);
            this.tarea3copies.TabIndex = 45;
            this.tarea3copies.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tarea3copies.ValueChanged += new System.EventHandler(this.tarea3copies_ValueChanged);
            // 
            // tarea4copies
            // 
            this.tarea4copies.Font = new System.Drawing.Font("Arial", 9F);
            this.tarea4copies.Location = new System.Drawing.Point(156, 171);
            this.tarea4copies.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tarea4copies.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tarea4copies.Name = "tarea4copies";
            this.tarea4copies.Size = new System.Drawing.Size(36, 21);
            this.tarea4copies.TabIndex = 46;
            this.tarea4copies.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tarea4copies.ValueChanged += new System.EventHandler(this.tarea4copies_ValueChanged);
            // 
            // tarea5copies
            // 
            this.tarea5copies.Font = new System.Drawing.Font("Arial", 9F);
            this.tarea5copies.Location = new System.Drawing.Point(156, 202);
            this.tarea5copies.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tarea5copies.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tarea5copies.Name = "tarea5copies";
            this.tarea5copies.Size = new System.Drawing.Size(36, 21);
            this.tarea5copies.TabIndex = 47;
            this.tarea5copies.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tarea5copies.ValueChanged += new System.EventHandler(this.tarea5copies_ValueChanged);
            // 
            // ventasTextBox
            // 
            this.ventasTextBox.AcceptsReturn = true;
            this.ventasTextBox.AcceptsTab = true;
            this.ventasTextBox.BackColor = System.Drawing.Color.White;
            this.ventasTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ventasTextBox.Font = new System.Drawing.Font("Arial", 8.25F);
            this.ventasTextBox.Location = new System.Drawing.Point(206, 30);
            this.ventasTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ventasTextBox.MaximumSize = new System.Drawing.Size(140, 175);
            this.ventasTextBox.MinimumSize = new System.Drawing.Size(145, 195);
            this.ventasTextBox.Multiline = true;
            this.ventasTextBox.Name = "ventasTextBox";
            this.ventasTextBox.ReadOnly = true;
            this.ventasTextBox.Size = new System.Drawing.Size(145, 195);
            this.ventasTextBox.TabIndex = 48;
            this.ventasTextBox.Text = "\tVentas";
            // 
            // buttonShowHide
            // 
            this.buttonShowHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowHide.Font = new System.Drawing.Font("Arial", 6.5F, System.Drawing.FontStyle.Bold);
            this.buttonShowHide.Location = new System.Drawing.Point(168, 52);
            this.buttonShowHide.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonShowHide.Name = "buttonShowHide";
            this.buttonShowHide.Size = new System.Drawing.Size(24, 18);
            this.buttonShowHide.TabIndex = 49;
            this.buttonShowHide.Text = "<<";
            this.buttonShowHide.UseVisualStyleBackColor = true;
            this.buttonShowHide.Click += new System.EventHandler(this.buttonShowHide_Click);
            // 
            // clearTextBox
            // 
            this.clearTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.clearTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearTextBox.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clearTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearTextBox.Font = new System.Drawing.Font("Arial", 8F);
            this.clearTextBox.Location = new System.Drawing.Point(275, 231);
            this.clearTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.clearTextBox.Name = "clearTextBox";
            this.clearTextBox.Size = new System.Drawing.Size(60, 24);
            this.clearTextBox.TabIndex = 50;
            this.clearTextBox.Text = "Clear";
            this.clearTextBox.UseVisualStyleBackColor = false;
            this.clearTextBox.Click += new System.EventHandler(this.clearTextBox_Click);
            // 
            // colorCheckBox
            // 
            this.colorCheckBox.AutoSize = true;
            this.colorCheckBox.Location = new System.Drawing.Point(206, 8);
            this.colorCheckBox.Name = "colorCheckBox";
            this.colorCheckBox.Size = new System.Drawing.Size(50, 17);
            this.colorCheckBox.TabIndex = 51;
            this.colorCheckBox.Text = "Color";
            this.colorCheckBox.UseVisualStyleBackColor = true;
            this.colorCheckBox.CheckedChanged += new System.EventHandler(this.colorCheckBox_CheckedChanged);
            // 
            // opcionesButton
            // 
            this.opcionesButton.BackColor = System.Drawing.Color.AliceBlue;
            this.opcionesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcionesButton.Location = new System.Drawing.Point(330, 5);
            this.opcionesButton.Name = "opcionesButton";
            this.opcionesButton.Size = new System.Drawing.Size(22, 20);
            this.opcionesButton.TabIndex = 52;
            this.opcionesButton.Text = "≡";
            this.opcionesButton.UseVisualStyleBackColor = false;
            this.opcionesButton.Click += new System.EventHandler(this.opcionesButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 262);
            this.Controls.Add(this.opcionesButton);
            this.Controls.Add(this.colorCheckBox);
            this.Controls.Add(this.clearTextBox);
            this.Controls.Add(this.buttonShowHide);
            this.Controls.Add(this.ventasTextBox);
            this.Controls.Add(this.tarea5copies);
            this.Controls.Add(this.tarea4copies);
            this.Controls.Add(this.tarea3copies);
            this.Controls.Add(this.tarea2copies);
            this.Controls.Add(this.tarea1copies);
            this.Controls.Add(this.tarea5INE);
            this.Controls.Add(this.tarea4INE);
            this.Controls.Add(this.tarea3INE);
            this.Controls.Add(this.tarea2INE);
            this.Controls.Add(this.tarea1INE);
            this.Controls.Add(this.duplexCheckBox);
            this.Controls.Add(this.tarea5mode);
            this.Controls.Add(this.tarea4mode);
            this.Controls.Add(this.tarea3mode);
            this.Controls.Add(this.tarea2mode);
            this.Controls.Add(this.tarea1mode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tarea5checkBox);
            this.Controls.Add(this.tarea4checkBox);
            this.Controls.Add(this.tarea3checkBox);
            this.Controls.Add(this.tarea2checkBox);
            this.Controls.Add(this.tarea1checkBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.INEcheckBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C        O        P        I        A        S";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarea1copies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarea2copies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarea3copies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarea4copies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarea5copies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown numericUpDown1;
        private Button button1;
        private CheckBox INEcheckBox;
        private Label label4;
        private CheckBox tarea1checkBox;
        private CheckBox tarea2checkBox;
        private CheckBox tarea3checkBox;
        private CheckBox tarea4checkBox;
        private CheckBox tarea5checkBox;
        private Button button2;
        private Label label5;
        private CheckBox tarea1mode;
        private CheckBox tarea2mode;
        private CheckBox tarea3mode;
        private CheckBox tarea4mode;
        private CheckBox tarea5mode;
        private CheckBox duplexCheckBox;
        private CheckBox tarea5INE;
        private CheckBox tarea4INE;
        private CheckBox tarea3INE;
        private CheckBox tarea2INE;
        private CheckBox tarea1INE;
        private NumericUpDown tarea1copies;
        private NumericUpDown tarea2copies;
        private NumericUpDown tarea3copies;
        private NumericUpDown tarea4copies;
        private NumericUpDown tarea5copies;
        private TextBox ventasTextBox;
        private Button buttonShowHide;
        private Button clearTextBox;
        private CheckBox colorCheckBox;
        private Button opcionesButton;
    }
}