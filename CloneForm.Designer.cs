
namespace DBF_Editor
{
    partial class CloneForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.originalBankTextBox = new System.Windows.Forms.TextBox();
            this.originalFamTextBox = new System.Windows.Forms.TextBox();
            this.originalNameTextBox = new System.Windows.Forms.TextBox();
            this.originalOtchTextBox = new System.Windows.Forms.TextBox();
            this.originalSumTextBox = new System.Windows.Forms.TextBox();
            this.cloneSumTextBox = new System.Windows.Forms.TextBox();
            this.cloneOtchTextBox = new System.Windows.Forms.TextBox();
            this.cloneNameTextBox = new System.Windows.Forms.TextBox();
            this.cloneFamTextBox = new System.Windows.Forms.TextBox();
            this.cloneBankTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.moveNowCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Исходная строка";
            // 
            // originalBankTextBox
            // 
            this.originalBankTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.originalBankTextBox.Enabled = false;
            this.originalBankTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.originalBankTextBox.Location = new System.Drawing.Point(16, 45);
            this.originalBankTextBox.Name = "originalBankTextBox";
            this.originalBankTextBox.Size = new System.Drawing.Size(229, 31);
            this.originalBankTextBox.TabIndex = 1;
            this.originalBankTextBox.TabStop = false;
            this.originalBankTextBox.Text = "40817810611250108383";
            // 
            // originalFamTextBox
            // 
            this.originalFamTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.originalFamTextBox.Enabled = false;
            this.originalFamTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.originalFamTextBox.Location = new System.Drawing.Point(16, 81);
            this.originalFamTextBox.Name = "originalFamTextBox";
            this.originalFamTextBox.Size = new System.Drawing.Size(229, 31);
            this.originalFamTextBox.TabIndex = 2;
            this.originalFamTextBox.TabStop = false;
            this.originalFamTextBox.Text = "40817810611250108383";
            // 
            // originalNameTextBox
            // 
            this.originalNameTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.originalNameTextBox.Enabled = false;
            this.originalNameTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.originalNameTextBox.Location = new System.Drawing.Point(16, 118);
            this.originalNameTextBox.Name = "originalNameTextBox";
            this.originalNameTextBox.Size = new System.Drawing.Size(229, 31);
            this.originalNameTextBox.TabIndex = 3;
            this.originalNameTextBox.TabStop = false;
            this.originalNameTextBox.Text = "40817810611250108383";
            // 
            // originalOtchTextBox
            // 
            this.originalOtchTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.originalOtchTextBox.Enabled = false;
            this.originalOtchTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.originalOtchTextBox.Location = new System.Drawing.Point(16, 155);
            this.originalOtchTextBox.Name = "originalOtchTextBox";
            this.originalOtchTextBox.Size = new System.Drawing.Size(229, 31);
            this.originalOtchTextBox.TabIndex = 4;
            this.originalOtchTextBox.TabStop = false;
            this.originalOtchTextBox.Text = "40817810611250108383";
            // 
            // originalSumTextBox
            // 
            this.originalSumTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.originalSumTextBox.Enabled = false;
            this.originalSumTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.originalSumTextBox.Location = new System.Drawing.Point(16, 192);
            this.originalSumTextBox.Name = "originalSumTextBox";
            this.originalSumTextBox.Size = new System.Drawing.Size(229, 31);
            this.originalSumTextBox.TabIndex = 5;
            this.originalSumTextBox.TabStop = false;
            this.originalSumTextBox.Text = "40817810611250108383";
            // 
            // cloneSumTextBox
            // 
            this.cloneSumTextBox.BackColor = System.Drawing.Color.White;
            this.cloneSumTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cloneSumTextBox.Location = new System.Drawing.Point(297, 192);
            this.cloneSumTextBox.Name = "cloneSumTextBox";
            this.cloneSumTextBox.Size = new System.Drawing.Size(229, 31);
            this.cloneSumTextBox.TabIndex = 1;
            this.cloneSumTextBox.Text = "0";
            this.toolTip1.SetToolTip(this.cloneSumTextBox, "Должны использоваться только цифры, разделитель \\\"точка\\\" и ДВЕ цифры после него." +
        " Не может быть больше исходной суммы.");
            this.cloneSumTextBox.TextChanged += new System.EventHandler(this.cloneSumTextBox_TextChanged);
            // 
            // cloneOtchTextBox
            // 
            this.cloneOtchTextBox.BackColor = System.Drawing.Color.White;
            this.cloneOtchTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cloneOtchTextBox.Location = new System.Drawing.Point(297, 155);
            this.cloneOtchTextBox.Name = "cloneOtchTextBox";
            this.cloneOtchTextBox.Size = new System.Drawing.Size(229, 31);
            this.cloneOtchTextBox.TabIndex = 7;
            this.cloneOtchTextBox.Text = "0";
            // 
            // cloneNameTextBox
            // 
            this.cloneNameTextBox.BackColor = System.Drawing.Color.White;
            this.cloneNameTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cloneNameTextBox.Location = new System.Drawing.Point(297, 118);
            this.cloneNameTextBox.Name = "cloneNameTextBox";
            this.cloneNameTextBox.Size = new System.Drawing.Size(229, 31);
            this.cloneNameTextBox.TabIndex = 6;
            this.cloneNameTextBox.Text = "0";
            // 
            // cloneFamTextBox
            // 
            this.cloneFamTextBox.BackColor = System.Drawing.Color.White;
            this.cloneFamTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cloneFamTextBox.Location = new System.Drawing.Point(297, 81);
            this.cloneFamTextBox.Name = "cloneFamTextBox";
            this.cloneFamTextBox.Size = new System.Drawing.Size(229, 31);
            this.cloneFamTextBox.TabIndex = 5;
            this.cloneFamTextBox.Text = "0";
            // 
            // cloneBankTextBox
            // 
            this.cloneBankTextBox.BackColor = System.Drawing.Color.White;
            this.cloneBankTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cloneBankTextBox.Location = new System.Drawing.Point(297, 44);
            this.cloneBankTextBox.Name = "cloneBankTextBox";
            this.cloneBankTextBox.Size = new System.Drawing.Size(229, 31);
            this.cloneBankTextBox.TabIndex = 4;
            this.cloneBankTextBox.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(293, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Новая строка";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.AliceBlue;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(158, 274);
            this.saveButton.MaximumSize = new System.Drawing.Size(229, 32);
            this.saveButton.MinimumSize = new System.Drawing.Size(229, 32);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(229, 32);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "ОК";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(199, 312);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(147, 25);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "ОТМЕНА";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Примечание";
            // 
            // moveNowCheckBox
            // 
            this.moveNowCheckBox.AutoSize = true;
            this.moveNowCheckBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moveNowCheckBox.Location = new System.Drawing.Point(297, 229);
            this.moveNowCheckBox.Name = "moveNowCheckBox";
            this.moveNowCheckBox.Size = new System.Drawing.Size(180, 27);
            this.moveNowCheckBox.TabIndex = 12;
            this.moveNowCheckBox.Text = "Сразу переместить";
            this.toolTip1.SetToolTip(this.moveNowCheckBox, "Сразу переместить новую строку в другую таблицу");
            this.moveNowCheckBox.UseVisualStyleBackColor = true;
            this.moveNowCheckBox.CheckedChanged += new System.EventHandler(this.moveNowCheckBox_CheckedChanged);
            // 
            // CloneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 351);
            this.Controls.Add(this.moveNowCheckBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cloneSumTextBox);
            this.Controls.Add(this.cloneOtchTextBox);
            this.Controls.Add(this.cloneNameTextBox);
            this.Controls.Add(this.cloneFamTextBox);
            this.Controls.Add(this.cloneBankTextBox);
            this.Controls.Add(this.originalSumTextBox);
            this.Controls.Add(this.originalOtchTextBox);
            this.Controls.Add(this.originalNameTextBox);
            this.Controls.Add(this.originalFamTextBox);
            this.Controls.Add(this.originalBankTextBox);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CloneForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Клонирование строки";
            this.Load += new System.EventHandler(this.CloneForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox originalBankTextBox;
        private System.Windows.Forms.TextBox originalFamTextBox;
        private System.Windows.Forms.TextBox originalNameTextBox;
        private System.Windows.Forms.TextBox originalOtchTextBox;
        private System.Windows.Forms.TextBox originalSumTextBox;
        private System.Windows.Forms.TextBox cloneSumTextBox;
        private System.Windows.Forms.TextBox cloneOtchTextBox;
        private System.Windows.Forms.TextBox cloneNameTextBox;
        private System.Windows.Forms.TextBox cloneFamTextBox;
        private System.Windows.Forms.TextBox cloneBankTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox moveNowCheckBox;
    }
}