namespace Calc
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
            this.btnSimpleRoot = new System.Windows.Forms.Button();
            this.lbHeader = new System.Windows.Forms.Label();
            this.rtbPodkorennoe = new System.Windows.Forms.RichTextBox();
            this.rtbAnswer = new System.Windows.Forms.RichTextBox();
            this.lbAnswer = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAlgebRoot = new System.Windows.Forms.Button();
            this.btnComplexRoot = new System.Windows.Forms.Button();
            this.btnAnalRoot = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.nudAccuracy = new System.Windows.Forms.NumericUpDown();
            this.lbAccuracy = new System.Windows.Forms.Label();
            this.btnI = new System.Windows.Forms.Button();
            this.btnPow = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnLongNumberRoot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAccuracy)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSimpleRoot
            // 
            this.btnSimpleRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnSimpleRoot.Location = new System.Drawing.Point(465, 12);
            this.btnSimpleRoot.Name = "btnSimpleRoot";
            this.btnSimpleRoot.Size = new System.Drawing.Size(259, 58);
            this.btnSimpleRoot.TabIndex = 1;
            this.btnSimpleRoot.Text = "Вычислить арифметический корень\r\n";
            this.btnSimpleRoot.UseVisualStyleBackColor = true;
            this.btnSimpleRoot.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbHeader.Location = new System.Drawing.Point(38, 22);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(326, 24);
            this.lbHeader.TabIndex = 2;
            this.lbHeader.Text = "Введите подкоренное выражение:";
            // 
            // rtbPodkorennoe
            // 
            this.rtbPodkorennoe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbPodkorennoe.Location = new System.Drawing.Point(42, 55);
            this.rtbPodkorennoe.Margin = new System.Windows.Forms.Padding(20, 20, 3, 3);
            this.rtbPodkorennoe.Multiline = false;
            this.rtbPodkorennoe.Name = "rtbPodkorennoe";
            this.rtbPodkorennoe.Size = new System.Drawing.Size(356, 58);
            this.rtbPodkorennoe.TabIndex = 3;
            this.rtbPodkorennoe.Text = "";
            this.rtbPodkorennoe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbPodkorennoe_KeyPress);
            // 
            // rtbAnswer
            // 
            this.rtbAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbAnswer.Location = new System.Drawing.Point(42, 287);
            this.rtbAnswer.Margin = new System.Windows.Forms.Padding(20, 20, 3, 3);
            this.rtbAnswer.Name = "rtbAnswer";
            this.rtbAnswer.ReadOnly = true;
            this.rtbAnswer.Size = new System.Drawing.Size(356, 100);
            this.rtbAnswer.TabIndex = 4;
            this.rtbAnswer.Text = "";
            // 
            // lbAnswer
            // 
            this.lbAnswer.AutoSize = true;
            this.lbAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbAnswer.Location = new System.Drawing.Point(38, 256);
            this.lbAnswer.Name = "lbAnswer";
            this.lbAnswer.Size = new System.Drawing.Size(108, 24);
            this.lbAnswer.TabIndex = 5;
            this.lbAnswer.Text = "Результат:";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(42, 406);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(142, 61);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Сброс";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAlgebRoot
            // 
            this.btnAlgebRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAlgebRoot.Location = new System.Drawing.Point(465, 88);
            this.btnAlgebRoot.Name = "btnAlgebRoot";
            this.btnAlgebRoot.Size = new System.Drawing.Size(259, 58);
            this.btnAlgebRoot.TabIndex = 7;
            this.btnAlgebRoot.Text = "Вычислить алгебраический корень";
            this.btnAlgebRoot.UseVisualStyleBackColor = true;
            this.btnAlgebRoot.Click += new System.EventHandler(this.btnAlgebRoot_Click);
            // 
            // btnComplexRoot
            // 
            this.btnComplexRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnComplexRoot.Location = new System.Drawing.Point(465, 246);
            this.btnComplexRoot.Name = "btnComplexRoot";
            this.btnComplexRoot.Size = new System.Drawing.Size(259, 58);
            this.btnComplexRoot.TabIndex = 8;
            this.btnComplexRoot.Text = "Вычислить комплексные корни";
            this.btnComplexRoot.UseVisualStyleBackColor = true;
            this.btnComplexRoot.Click += new System.EventHandler(this.btnComplexRoot_Click);
            // 
            // btnAnalRoot
            // 
            this.btnAnalRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnalRoot.Location = new System.Drawing.Point(465, 329);
            this.btnAnalRoot.Name = "btnAnalRoot";
            this.btnAnalRoot.Size = new System.Drawing.Size(259, 58);
            this.btnAnalRoot.TabIndex = 9;
            this.btnAnalRoot.Text = "Вычислить аналитический корень";
            this.btnAnalRoot.UseVisualStyleBackColor = true;
            this.btnAnalRoot.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(42, 119);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(34, 31);
            this.btnX.TabIndex = 10;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnY
            // 
            this.btnY.Location = new System.Drawing.Point(96, 120);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(34, 31);
            this.btnY.TabIndex = 11;
            this.btnY.Text = "Y";
            this.btnY.UseVisualStyleBackColor = true;
            this.btnY.Click += new System.EventHandler(this.btnY_Click);
            // 
            // nudAccuracy
            // 
            this.nudAccuracy.Location = new System.Drawing.Point(632, 184);
            this.nudAccuracy.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudAccuracy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAccuracy.Name = "nudAccuracy";
            this.nudAccuracy.Size = new System.Drawing.Size(92, 20);
            this.nudAccuracy.TabIndex = 12;
            this.nudAccuracy.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lbAccuracy
            // 
            this.lbAccuracy.AutoSize = true;
            this.lbAccuracy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAccuracy.Location = new System.Drawing.Point(465, 183);
            this.lbAccuracy.Name = "lbAccuracy";
            this.lbAccuracy.Size = new System.Drawing.Size(141, 17);
            this.lbAccuracy.TabIndex = 13;
            this.lbAccuracy.Text = "Заданная точность:";
            // 
            // btnI
            // 
            this.btnI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnI.Location = new System.Drawing.Point(153, 120);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(245, 31);
            this.btnI.TabIndex = 14;
            this.btnI.Text = "i (complex)";
            this.btnI.UseVisualStyleBackColor = true;
            this.btnI.Click += new System.EventHandler(this.btnI_Click);
            // 
            // btnPow
            // 
            this.btnPow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPow.Location = new System.Drawing.Point(42, 169);
            this.btnPow.Name = "btnPow";
            this.btnPow.Size = new System.Drawing.Size(34, 31);
            this.btnPow.TabIndex = 15;
            this.btnPow.Text = "^";
            this.btnPow.UseVisualStyleBackColor = true;
            this.btnPow.Click += new System.EventHandler(this.btnPow_Click);
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMult.Location = new System.Drawing.Point(96, 169);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(34, 31);
            this.btnMult.TabIndex = 16;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnLongNumberRoot
            // 
            this.btnLongNumberRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLongNumberRoot.Location = new System.Drawing.Point(465, 406);
            this.btnLongNumberRoot.Name = "btnLongNumberRoot";
            this.btnLongNumberRoot.Size = new System.Drawing.Size(259, 61);
            this.btnLongNumberRoot.TabIndex = 17;
            this.btnLongNumberRoot.Text = "Вычислить корень из длинного числа";
            this.btnLongNumberRoot.UseVisualStyleBackColor = true;
            this.btnLongNumberRoot.Click += new System.EventHandler(this.btnLongNumberRoot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 492);
            this.Controls.Add(this.btnLongNumberRoot);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnPow);
            this.Controls.Add(this.btnI);
            this.Controls.Add(this.lbAccuracy);
            this.Controls.Add(this.nudAccuracy);
            this.Controls.Add(this.btnY);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnAnalRoot);
            this.Controls.Add(this.btnComplexRoot);
            this.Controls.Add(this.btnAlgebRoot);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lbAnswer);
            this.Controls.Add(this.rtbAnswer);
            this.Controls.Add(this.rtbPodkorennoe);
            this.Controls.Add(this.lbHeader);
            this.Controls.Add(this.btnSimpleRoot);
            this.Name = "Form1";
            this.Text = "Calc";
            ((System.ComponentModel.ISupportInitialize)(this.nudAccuracy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSimpleRoot;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.RichTextBox rtbPodkorennoe;
        private System.Windows.Forms.RichTextBox rtbAnswer;
        private System.Windows.Forms.Label lbAnswer;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAlgebRoot;
        private System.Windows.Forms.Button btnComplexRoot;
        private System.Windows.Forms.Button btnAnalRoot;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.NumericUpDown nudAccuracy;
        private System.Windows.Forms.Label lbAccuracy;
        private System.Windows.Forms.Button btnI;
        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnLongNumberRoot;
    }
}

