
namespace Model1
{
    partial class WinForValues
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
            this.inputStrBox = new System.Windows.Forms.TextBox();
            this.variables = new System.Windows.Forms.GroupBox();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.symbols = new System.Windows.Forms.GroupBox();
            this.degree = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.rightBracket = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.leftBracket = new System.Windows.Forms.Button();
            this.functions = new System.Windows.Forms.GroupBox();
            this.buttonArctg = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.buttonArcsin = new System.Windows.Forms.Button();
            this.buttonTg = new System.Windows.Forms.Button();
            this.buttonCos = new System.Windows.Forms.Button();
            this.buttonSin = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.panelWFV = new System.Windows.Forms.Panel();
            this.deleteAll = new System.Windows.Forms.Button();
            this.variables.SuspendLayout();
            this.symbols.SuspendLayout();
            this.functions.SuspendLayout();
            this.panelWFV.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputStrBox
            // 
            this.inputStrBox.BackColor = System.Drawing.SystemColors.Window;
            this.inputStrBox.Location = new System.Drawing.Point(25, 25);
            this.inputStrBox.Name = "inputStrBox";
            this.inputStrBox.ReadOnly = true;
            this.inputStrBox.Size = new System.Drawing.Size(488, 22);
            this.inputStrBox.TabIndex = 0;
            this.inputStrBox.TextChanged += new System.EventHandler(this.InputStrBox_TextChanged);
            // 
            // variables
            // 
            this.variables.Controls.Add(this.buttonA);
            this.variables.Controls.Add(this.buttonD);
            this.variables.Controls.Add(this.buttonC);
            this.variables.Controls.Add(this.buttonB);
            this.variables.Location = new System.Drawing.Point(198, 70);
            this.variables.Name = "variables";
            this.variables.Size = new System.Drawing.Size(134, 179);
            this.variables.TabIndex = 1;
            this.variables.TabStop = false;
            this.variables.Text = "Переменные:";
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonA.Location = new System.Drawing.Point(16, 47);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(45, 45);
            this.buttonA.TabIndex = 9;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = false;
            this.buttonA.Click += new System.EventHandler(this.ButtonVarSymb_Click);
            // 
            // buttonD
            // 
            this.buttonD.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonD.Location = new System.Drawing.Point(67, 97);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(45, 45);
            this.buttonD.TabIndex = 8;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = false;
            this.buttonD.Click += new System.EventHandler(this.ButtonVarSymb_Click);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonC.Location = new System.Drawing.Point(16, 98);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(45, 45);
            this.buttonC.TabIndex = 7;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.ButtonVarSymb_Click);
            // 
            // buttonB
            // 
            this.buttonB.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonB.Location = new System.Drawing.Point(67, 47);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(45, 45);
            this.buttonB.TabIndex = 6;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = false;
            this.buttonB.Click += new System.EventHandler(this.ButtonVarSymb_Click);
            // 
            // symbols
            // 
            this.symbols.Controls.Add(this.degree);
            this.symbols.Controls.Add(this.divide);
            this.symbols.Controls.Add(this.multiply);
            this.symbols.Controls.Add(this.minus);
            this.symbols.Controls.Add(this.rightBracket);
            this.symbols.Controls.Add(this.plus);
            this.symbols.Controls.Add(this.leftBracket);
            this.symbols.Location = new System.Drawing.Point(338, 70);
            this.symbols.Name = "symbols";
            this.symbols.Size = new System.Drawing.Size(175, 179);
            this.symbols.TabIndex = 2;
            this.symbols.TabStop = false;
            this.symbols.Text = "Символы:";
            // 
            // degree
            // 
            this.degree.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.degree.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.degree.Location = new System.Drawing.Point(108, 21);
            this.degree.Name = "degree";
            this.degree.Size = new System.Drawing.Size(45, 45);
            this.degree.TabIndex = 6;
            this.degree.Text = "^";
            this.degree.UseVisualStyleBackColor = false;
            this.degree.Click += new System.EventHandler(this.ButtonVarSymb_Click);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.divide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.divide.Location = new System.Drawing.Point(57, 123);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(45, 45);
            this.divide.TabIndex = 17;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.ButtonVarSymb_Click);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.multiply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multiply.Location = new System.Drawing.Point(6, 123);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(45, 45);
            this.multiply.TabIndex = 16;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.ButtonVarSymb_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minus.Location = new System.Drawing.Point(57, 72);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(45, 45);
            this.minus.TabIndex = 15;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.ButtonVarSymb_Click);
            // 
            // rightBracket
            // 
            this.rightBracket.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rightBracket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rightBracket.Location = new System.Drawing.Point(57, 21);
            this.rightBracket.Name = "rightBracket";
            this.rightBracket.Size = new System.Drawing.Size(45, 45);
            this.rightBracket.TabIndex = 14;
            this.rightBracket.Text = ")";
            this.rightBracket.UseVisualStyleBackColor = false;
            this.rightBracket.Click += new System.EventHandler(this.ButtonVarSymb_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plus.Location = new System.Drawing.Point(6, 69);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(45, 45);
            this.plus.TabIndex = 13;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.ButtonVarSymb_Click);
            // 
            // leftBracket
            // 
            this.leftBracket.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.leftBracket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.leftBracket.Location = new System.Drawing.Point(6, 21);
            this.leftBracket.Name = "leftBracket";
            this.leftBracket.Size = new System.Drawing.Size(45, 45);
            this.leftBracket.TabIndex = 12;
            this.leftBracket.Text = "(";
            this.leftBracket.UseVisualStyleBackColor = false;
            this.leftBracket.Click += new System.EventHandler(this.ButtonVarSymb_Click);
            // 
            // functions
            // 
            this.functions.Controls.Add(this.buttonArctg);
            this.functions.Controls.Add(this.button23);
            this.functions.Controls.Add(this.buttonArcsin);
            this.functions.Controls.Add(this.buttonTg);
            this.functions.Controls.Add(this.buttonCos);
            this.functions.Controls.Add(this.buttonSin);
            this.functions.Location = new System.Drawing.Point(25, 70);
            this.functions.Name = "functions";
            this.functions.Size = new System.Drawing.Size(167, 179);
            this.functions.TabIndex = 3;
            this.functions.TabStop = false;
            this.functions.Text = "Функции:";
            // 
            // buttonArctg
            // 
            this.buttonArctg.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonArctg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonArctg.Location = new System.Drawing.Point(82, 111);
            this.buttonArctg.Name = "buttonArctg";
            this.buttonArctg.Size = new System.Drawing.Size(70, 26);
            this.buttonArctg.TabIndex = 5;
            this.buttonArctg.Text = "arctg";
            this.buttonArctg.UseVisualStyleBackColor = false;
            this.buttonArctg.Click += new System.EventHandler(this.ButtonFunc_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button23.Location = new System.Drawing.Point(82, 79);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(70, 26);
            this.button23.TabIndex = 4;
            this.button23.Text = "arccos";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.ButtonFunc_Click);
            // 
            // buttonArcsin
            // 
            this.buttonArcsin.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonArcsin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonArcsin.Location = new System.Drawing.Point(82, 47);
            this.buttonArcsin.Name = "buttonArcsin";
            this.buttonArcsin.Size = new System.Drawing.Size(70, 26);
            this.buttonArcsin.TabIndex = 3;
            this.buttonArcsin.Text = "arcsin";
            this.buttonArcsin.UseVisualStyleBackColor = false;
            this.buttonArcsin.Click += new System.EventHandler(this.ButtonFunc_Click);
            // 
            // buttonTg
            // 
            this.buttonTg.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonTg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTg.Location = new System.Drawing.Point(6, 111);
            this.buttonTg.Name = "buttonTg";
            this.buttonTg.Size = new System.Drawing.Size(70, 26);
            this.buttonTg.TabIndex = 2;
            this.buttonTg.Text = "tg";
            this.buttonTg.UseVisualStyleBackColor = false;
            this.buttonTg.Click += new System.EventHandler(this.ButtonFunc_Click);
            // 
            // buttonCos
            // 
            this.buttonCos.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonCos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCos.Location = new System.Drawing.Point(6, 79);
            this.buttonCos.Name = "buttonCos";
            this.buttonCos.Size = new System.Drawing.Size(70, 26);
            this.buttonCos.TabIndex = 1;
            this.buttonCos.Text = "cos";
            this.buttonCos.UseVisualStyleBackColor = false;
            this.buttonCos.Click += new System.EventHandler(this.ButtonFunc_Click);
            // 
            // buttonSin
            // 
            this.buttonSin.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonSin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSin.Location = new System.Drawing.Point(6, 47);
            this.buttonSin.Name = "buttonSin";
            this.buttonSin.Size = new System.Drawing.Size(70, 26);
            this.buttonSin.TabIndex = 0;
            this.buttonSin.Text = "sin";
            this.buttonSin.UseVisualStyleBackColor = false;
            this.buttonSin.Click += new System.EventHandler(this.ButtonFunc_Click);
            // 
            // backspace
            // 
            this.backspace.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.backspace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backspace.Location = new System.Drawing.Point(540, 22);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(89, 25);
            this.backspace.TabIndex = 6;
            this.backspace.Text = "← Удалить";
            this.backspace.UseVisualStyleBackColor = false;
            this.backspace.Click += new System.EventHandler(this.Backspace_Click);
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OK.Location = new System.Drawing.Point(540, 211);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(89, 38);
            this.OK.TabIndex = 4;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = false;
            // 
            // panelWFV
            // 
            this.panelWFV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelWFV.Controls.Add(this.deleteAll);
            this.panelWFV.Controls.Add(this.inputStrBox);
            this.panelWFV.Controls.Add(this.backspace);
            this.panelWFV.Controls.Add(this.variables);
            this.panelWFV.Controls.Add(this.OK);
            this.panelWFV.Controls.Add(this.symbols);
            this.panelWFV.Controls.Add(this.functions);
            this.panelWFV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWFV.Location = new System.Drawing.Point(0, 0);
            this.panelWFV.Name = "panelWFV";
            this.panelWFV.Size = new System.Drawing.Size(661, 279);
            this.panelWFV.TabIndex = 7;
            // 
            // deleteAll
            // 
            this.deleteAll.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.deleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteAll.Location = new System.Drawing.Point(540, 79);
            this.deleteAll.Name = "deleteAll";
            this.deleteAll.Size = new System.Drawing.Size(89, 25);
            this.deleteAll.TabIndex = 7;
            this.deleteAll.Text = "Очистить";
            this.deleteAll.UseVisualStyleBackColor = false;
            this.deleteAll.Click += new System.EventHandler(this.DeleteAll_Click);
            // 
            // WinForValues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(661, 279);
            this.Controls.Add(this.panelWFV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "WinForValues";
            this.Text = "Входная строка (в инфиксной форме)";
            this.variables.ResumeLayout(false);
            this.symbols.ResumeLayout(false);
            this.functions.ResumeLayout(false);
            this.panelWFV.ResumeLayout(false);
            this.panelWFV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox inputStrBox;
        private System.Windows.Forms.GroupBox variables;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.GroupBox symbols;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button rightBracket;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button leftBracket;
        private System.Windows.Forms.GroupBox functions;
        private System.Windows.Forms.Button degree;
        private System.Windows.Forms.Button buttonArctg;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button buttonArcsin;
        private System.Windows.Forms.Button buttonTg;
        private System.Windows.Forms.Button buttonCos;
        private System.Windows.Forms.Button buttonSin;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Panel panelWFV;
        private System.Windows.Forms.Button deleteAll;
    }
}