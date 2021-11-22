namespace IanLasku
{
    partial class Form1
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.Vuosissa = new System.Windows.Forms.Label();
            this.Sekunneissa = new System.Windows.Forms.Label();
            this.Minuuteissa = new System.Windows.Forms.Label();
            this.Tunneissa = new System.Windows.Forms.Label();
            this.Paivissa = new System.Windows.Forms.Label();
            this.Kuukausissa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(105, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(191, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Laske kauan olet elänyt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Vuosissa
            // 
            this.Vuosissa.AutoSize = true;
            this.Vuosissa.Location = new System.Drawing.Point(77, 107);
            this.Vuosissa.Name = "Vuosissa";
            this.Vuosissa.Size = new System.Drawing.Size(55, 13);
            this.Vuosissa.TabIndex = 2;
            this.Vuosissa.Text = "Vuosissa: ";
            this.Vuosissa.Visible = false;
            // 
            // Sekunneissa
            // 
            this.Sekunneissa.AutoSize = true;
            this.Sekunneissa.Location = new System.Drawing.Point(273, 192);
            this.Sekunneissa.Name = "Sekunneissa";
            this.Sekunneissa.Size = new System.Drawing.Size(74, 13);
            this.Sekunneissa.TabIndex = 3;
            this.Sekunneissa.Text = "Sekunneissa: ";
            this.Sekunneissa.Visible = false;
            // 
            // Minuuteissa
            // 
            this.Minuuteissa.AutoSize = true;
            this.Minuuteissa.Location = new System.Drawing.Point(273, 149);
            this.Minuuteissa.Name = "Minuuteissa";
            this.Minuuteissa.Size = new System.Drawing.Size(69, 13);
            this.Minuuteissa.TabIndex = 4;
            this.Minuuteissa.Text = "Minuuteissa: ";
            this.Minuuteissa.Visible = false;
            // 
            // Tunneissa
            // 
            this.Tunneissa.AutoSize = true;
            this.Tunneissa.Location = new System.Drawing.Point(273, 107);
            this.Tunneissa.Name = "Tunneissa";
            this.Tunneissa.Size = new System.Drawing.Size(62, 13);
            this.Tunneissa.TabIndex = 5;
            this.Tunneissa.Text = "Tunneissa: ";
            this.Tunneissa.Visible = false;
            // 
            // Paivissa
            // 
            this.Paivissa.AutoSize = true;
            this.Paivissa.Location = new System.Drawing.Point(77, 192);
            this.Paivissa.Name = "Paivissa";
            this.Paivissa.Size = new System.Drawing.Size(52, 13);
            this.Paivissa.TabIndex = 6;
            this.Paivissa.Text = "Päivissä: ";
            this.Paivissa.Visible = false;
            // 
            // Kuukausissa
            // 
            this.Kuukausissa.AutoSize = true;
            this.Kuukausissa.Location = new System.Drawing.Point(77, 149);
            this.Kuukausissa.Name = "Kuukausissa";
            this.Kuukausissa.Size = new System.Drawing.Size(73, 13);
            this.Kuukausissa.TabIndex = 7;
            this.Kuukausissa.Text = "Kuukausissa: ";
            this.Kuukausissa.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Kuukausissa);
            this.Controls.Add(this.Paivissa);
            this.Controls.Add(this.Tunneissa);
            this.Controls.Add(this.Minuuteissa);
            this.Controls.Add(this.Sekunneissa);
            this.Controls.Add(this.Vuosissa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Vuosissa;
        private System.Windows.Forms.Label Sekunneissa;
        private System.Windows.Forms.Label Minuuteissa;
        private System.Windows.Forms.Label Tunneissa;
        private System.Windows.Forms.Label Paivissa;
        private System.Windows.Forms.Label Kuukausissa;
    }
}

