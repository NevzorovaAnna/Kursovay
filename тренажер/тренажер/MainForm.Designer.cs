﻿namespace тренажер
{
    partial class MainForm
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            Level = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(66, 142);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(174, 58);
            button1.TabIndex = 0;
            button1.Text = "Начать тренировку";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(66, 210);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(174, 58);
            button2.TabIndex = 1;
            button2.Text = "Результаты";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Level
            // 
            Level.FormattingEnabled = true;
            Level.Items.AddRange(new object[] { "Низкий", "Средний", "Высокий" });
            Level.Location = new Point(66, 93);
            Level.Margin = new Padding(4, 5, 4, 5);
            Level.Name = "Level";
            Level.Size = new Size(171, 33);
            Level.TabIndex = 2;
            Level.Text = "Низкий";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(187, 25);
            label1.TabIndex = 3;
            label1.Text = "Уровень подготовки:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 352);
            Controls.Add(label1);
            Controls.Add(Level);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}