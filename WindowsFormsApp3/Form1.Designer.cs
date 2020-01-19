namespace WindowsFormsApp3 {
	partial class Form1 {
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent() {
			this.button2 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(822, 475);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(145, 69);
			this.button2.TabIndex = 0;
			this.button2.Text = "Построить график";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.panel2.Location = new System.Drawing.Point(12, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(778, 532);
			this.panel2.TabIndex = 1;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint_1);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(822, 385);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(145, 68);
			this.button3.TabIndex = 2;
			this.button3.Text = "Сбросить построение";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(929, 74);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(38, 20);
			this.textBox1.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(809, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 26);
			this.label1.TabIndex = 4;
			this.label1.Text = "Введите значение \r\nпараметра a";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(834, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "y^2  = x^3/(2*a - x)";
			this.label2.Click += new System.EventHandler(this.Label2_Click);
			// 
			// Form1
			// 
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(979, 556);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.button2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form1";
			this.Text = "График функции Циссоида Диокла.";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

