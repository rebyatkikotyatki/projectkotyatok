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
            this.button1 = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.nudAccuracy = new System.Windows.Forms.NumericUpDown();
            this.lbAccuracy = new System.Windows.Forms.Label();
            this.bt_ru = new System.Windows.Forms.Button();
            this.bt_eng = new System.Windows.Forms.Button();
            this.bt_ch = new System.Windows.Forms.Button();
            this.bt_h = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAccuracy)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSimpleRoot
            // 
            this.btnSimpleRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnSimpleRoot.Location = new System.Drawing.Point(620, 15);
            this.btnSimpleRoot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSimpleRoot.Name = "btnSimpleRoot";
            this.btnSimpleRoot.Size = new System.Drawing.Size(345, 71);
            this.btnSimpleRoot.TabIndex = 1;
            this.btnSimpleRoot.Text = "Вычислить арифметический корень\r\n";
            this.btnSimpleRoot.UseVisualStyleBackColor = true;
            this.btnSimpleRoot.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbHeader.Location = new System.Drawing.Point(51, 27);
            this.lbHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(417, 29);
            this.lbHeader.TabIndex = 2;
            this.lbHeader.Text = "Введите подкоренное выражение:";
            // 
            // rtbPodkorennoe
            // 
            this.rtbPodkorennoe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbPodkorennoe.Location = new System.Drawing.Point(56, 68);
            this.rtbPodkorennoe.Margin = new System.Windows.Forms.Padding(27, 25, 4, 4);
            this.rtbPodkorennoe.Multiline = false;
            this.rtbPodkorennoe.Name = "rtbPodkorennoe";
            this.rtbPodkorennoe.Size = new System.Drawing.Size(421, 70);
            this.rtbPodkorennoe.TabIndex = 3;
            this.rtbPodkorennoe.Text = "";
            this.rtbPodkorennoe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbPodkorennoe_KeyPress);
            // 
            // rtbAnswer
            // 
            this.rtbAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbAnswer.Location = new System.Drawing.Point(56, 299);
            this.rtbAnswer.Margin = new System.Windows.Forms.Padding(27, 25, 4, 4);
            this.rtbAnswer.Name = "rtbAnswer";
            this.rtbAnswer.ReadOnly = true;
            this.rtbAnswer.Size = new System.Drawing.Size(421, 74);
            this.rtbAnswer.TabIndex = 4;
            this.rtbAnswer.Text = "";
            // 
            // lbAnswer
            // 
            this.lbAnswer.AutoSize = true;
            this.lbAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbAnswer.Location = new System.Drawing.Point(51, 265);
            this.lbAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAnswer.Name = "lbAnswer";
            this.lbAnswer.Size = new System.Drawing.Size(138, 29);
            this.lbAnswer.TabIndex = 5;
            this.lbAnswer.Text = "Результат:";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(56, 405);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(189, 75);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Сброс";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAlgebRoot
            // 
            this.btnAlgebRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAlgebRoot.Location = new System.Drawing.Point(620, 108);
            this.btnAlgebRoot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlgebRoot.Name = "btnAlgebRoot";
            this.btnAlgebRoot.Size = new System.Drawing.Size(345, 71);
            this.btnAlgebRoot.TabIndex = 7;
            this.btnAlgebRoot.Text = "Вычислить алгебраический корень";
            this.btnAlgebRoot.UseVisualStyleBackColor = true;
            this.btnAlgebRoot.Click += new System.EventHandler(this.btnAlgebRoot_Click);
            // 
            // btnComplexRoot
            // 
            this.btnComplexRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnComplexRoot.Location = new System.Drawing.Point(620, 303);
            this.btnComplexRoot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnComplexRoot.Name = "btnComplexRoot";
            this.btnComplexRoot.Size = new System.Drawing.Size(345, 71);
            this.btnComplexRoot.TabIndex = 8;
            this.btnComplexRoot.Text = "Вычислить комплексные корни";
            this.btnComplexRoot.UseVisualStyleBackColor = true;
            this.btnComplexRoot.Click += new System.EventHandler(this.btnComplexRoot_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(620, 405);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(345, 71);
            this.button1.TabIndex = 9;
            this.button1.Text = "Вычислить аналитический корень";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(56, 146);
            this.btnX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(45, 38);
            this.btnX.TabIndex = 10;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            // 
            // btnY
            // 
            this.btnY.Location = new System.Drawing.Point(151, 148);
            this.btnY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(44, 37);
            this.btnY.TabIndex = 11;
            this.btnY.Text = "Y";
            this.btnY.UseVisualStyleBackColor = true;
            // 
            // nudAccuracy
            // 
            this.nudAccuracy.Location = new System.Drawing.Point(843, 226);
            this.nudAccuracy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.nudAccuracy.Size = new System.Drawing.Size(123, 22);
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
            this.lbAccuracy.Location = new System.Drawing.Point(620, 225);
            this.lbAccuracy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAccuracy.Name = "lbAccuracy";
            this.lbAccuracy.Size = new System.Drawing.Size(176, 22);
            this.lbAccuracy.TabIndex = 13;
            this.lbAccuracy.Text = "Заданная точность:";
            // 
            // bt_ru
            // 
            this.bt_ru.Location = new System.Drawing.Point(1006, 12);
            this.bt_ru.Name = "bt_ru";
            this.bt_ru.Size = new System.Drawing.Size(75, 23);
            this.bt_ru.TabIndex = 14;
            this.bt_ru.Text = "bt_ru";
            this.bt_ru.UseVisualStyleBackColor = true;
            this.bt_ru.Click += new System.EventHandler(this.bt_ru_Click);
            // 
            // bt_eng
            // 
            this.bt_eng.Location = new System.Drawing.Point(1006, 41);
            this.bt_eng.Name = "bt_eng";
            this.bt_eng.Size = new System.Drawing.Size(75, 23);
            this.bt_eng.TabIndex = 15;
            this.bt_eng.Text = "bt_eng";
            this.bt_eng.UseVisualStyleBackColor = true;
            this.bt_eng.Click += new System.EventHandler(this.bt_eng_Click);
            // 
            // bt_ch
            // 
            this.bt_ch.Location = new System.Drawing.Point(1006, 71);
            this.bt_ch.Name = "bt_ch";
            this.bt_ch.Size = new System.Drawing.Size(75, 23);
            this.bt_ch.TabIndex = 16;
            this.bt_ch.Text = "bt_ch";
            this.bt_ch.UseVisualStyleBackColor = true;
            this.bt_ch.Click += new System.EventHandler(this.bt_ch_Click);
            // 
            // bt_h
            // 
            this.bt_h.Location = new System.Drawing.Point(1006, 101);
            this.bt_h.Name = "bt_h";
            this.bt_h.Size = new System.Drawing.Size(75, 23);
            this.bt_h.TabIndex = 17;
            this.bt_h.Text = "bt_h";
            this.bt_h.UseVisualStyleBackColor = true;
            this.bt_h.Click += new System.EventHandler(this.bt_h_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 506);
            this.Controls.Add(this.bt_h);
            this.Controls.Add(this.bt_ch);
            this.Controls.Add(this.bt_eng);
            this.Controls.Add(this.bt_ru);
            this.Controls.Add(this.lbAccuracy);
            this.Controls.Add(this.nudAccuracy);
            this.Controls.Add(this.btnY);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnComplexRoot);
            this.Controls.Add(this.btnAlgebRoot);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lbAnswer);
            this.Controls.Add(this.rtbAnswer);
            this.Controls.Add(this.rtbPodkorennoe);
            this.Controls.Add(this.lbHeader);
            this.Controls.Add(this.btnSimpleRoot);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.NumericUpDown nudAccuracy;
        private System.Windows.Forms.Label lbAccuracy;
        private System.Windows.Forms.Button bt_ru;
        private System.Windows.Forms.Button bt_eng;
        private System.Windows.Forms.Button bt_ch;
        private System.Windows.Forms.Button bt_h;
    }
}

