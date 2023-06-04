namespace тренажер
{
    partial class InputForm
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
            components = new System.ComponentModel.Container();
            LevelLable = new Label();
            TaskString = new Label();
            SecondLable = new Label();
            ErrorsLable = new Label();
            timer = new System.Windows.Forms.Timer(components);
            InputString = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // LevelLable
            // 
            LevelLable.AutoSize = true;
            LevelLable.Location = new Point(29, 87);
            LevelLable.Name = "LevelLable";
            LevelLable.Size = new Size(0, 25);
            LevelLable.TabIndex = 0;
            // 
            // TaskString
            // 
            TaskString.AutoSize = true;
            TaskString.Location = new Point(29, 132);
            TaskString.Name = "TaskString";
            TaskString.Size = new Size(0, 25);
            TaskString.TabIndex = 1;
            // 
            // SecondLable
            // 
            SecondLable.AutoSize = true;
            SecondLable.Location = new Point(504, 43);
            SecondLable.Name = "SecondLable";
            SecondLable.Size = new Size(68, 25);
            SecondLable.TabIndex = 3;
            SecondLable.Text = "Время:";
            // 
            // ErrorsLable
            // 
            ErrorsLable.AutoSize = true;
            ErrorsLable.Location = new Point(657, 43);
            ErrorsLable.Name = "ErrorsLable";
            ErrorsLable.Size = new Size(83, 25);
            ErrorsLable.TabIndex = 4;
            ErrorsLable.Text = "Ошибки:";
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // InputString
            // 
            InputString.Location = new Point(29, 197);
            InputString.Margin = new Padding(4, 5, 4, 5);
            InputString.Name = "InputString";
            InputString.Size = new Size(872, 31);
            InputString.TabIndex = 5;
            InputString.TextChanged += InputString_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 43);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 6;
            label1.Text = "Уровень:";
            // 
            // InputForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 334);
            Controls.Add(label1);
            Controls.Add(InputString);
            Controls.Add(ErrorsLable);
            Controls.Add(SecondLable);
            Controls.Add(TaskString);
            Controls.Add(LevelLable);
            Name = "InputForm";
            Text = "InputForm";
            Load += InputForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LevelLable;
        private Label TaskString;
        private Label SecondLable;
        private Label ErrorsLable;
        private System.Windows.Forms.Timer timer;
        private TextBox InputString;
        private Label label1;
    }
}