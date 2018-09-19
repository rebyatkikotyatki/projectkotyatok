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
            this.btnCalc = new System.Windows.Forms.Button();
            this.lbHeader = new System.Windows.Forms.Label();
            this.rtbPodkorennoe = new System.Windows.Forms.RichTextBox();
            this.rtbAnswer = new System.Windows.Forms.RichTextBox();
            this.lbAnswer = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnCalc.Location = new System.Drawing.Point(388, 55);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(151, 58);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "Вычислить";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
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
            this.rtbPodkorennoe.Size = new System.Drawing.Size(317, 58);
            this.rtbPodkorennoe.TabIndex = 3;
            this.rtbPodkorennoe.Text = "";
            this.rtbPodkorennoe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbPodkorennoe_KeyPress);
            // 
            // rtbAnswer
            // 
            this.rtbAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbAnswer.Location = new System.Drawing.Point(42, 168);
            this.rtbAnswer.Margin = new System.Windows.Forms.Padding(20, 20, 3, 3);
            this.rtbAnswer.Name = "rtbAnswer";
            this.rtbAnswer.ReadOnly = true;
            this.rtbAnswer.Size = new System.Drawing.Size(317, 61);
            this.rtbAnswer.TabIndex = 4;
            this.rtbAnswer.Text = "";
            // 
            // lbAnswer
            // 
            this.lbAnswer.AutoSize = true;
            this.lbAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbAnswer.Location = new System.Drawing.Point(39, 137);
            this.lbAnswer.Name = "lbAnswer";
            this.lbAnswer.Size = new System.Drawing.Size(108, 24);
            this.lbAnswer.TabIndex = 5;
            this.lbAnswer.Text = "Результат:";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(388, 168);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(142, 61);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Сброс";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 346);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lbAnswer);
            this.Controls.Add(this.rtbAnswer);
            this.Controls.Add(this.rtbPodkorennoe);
            this.Controls.Add(this.lbHeader);
            this.Controls.Add(this.btnCalc);
            this.Name = "Form1";
            this.Text = "Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.RichTextBox rtbPodkorennoe;
        private System.Windows.Forms.RichTextBox rtbAnswer;
        private System.Windows.Forms.Label lbAnswer;
        private System.Windows.Forms.Button btnClear;
    }
}

