namespace AppDemo_JessicaWeiss
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_value1 = new System.Windows.Forms.TextBox();
            this.cmb_operator = new System.Windows.Forms.ComboBox();
            this.txt_value2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(73, 45);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(285, 26);
            this.txtInfo.TabIndex = 0;
            this.txtInfo.TextChanged += new System.EventHandler(this.txtInfo_TextChanged);
            this.txtInfo.MouseLeave += new System.EventHandler(this.txtInfo_MouseLeave);
            this.txtInfo.MouseHover += new System.EventHandler(this.txtInfo_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_value1
            // 
            this.txt_value1.Location = new System.Drawing.Point(73, 219);
            this.txt_value1.Name = "txt_value1";
            this.txt_value1.Size = new System.Drawing.Size(100, 26);
            this.txt_value1.TabIndex = 3;
            // 
            // cmb_operator
            // 
            this.cmb_operator.FormattingEnabled = true;
            this.cmb_operator.Items.AddRange(new object[] {
            "+",
            "-",
            "x",
            ":"});
            this.cmb_operator.Location = new System.Drawing.Point(201, 219);
            this.cmb_operator.Name = "cmb_operator";
            this.cmb_operator.Size = new System.Drawing.Size(121, 28);
            this.cmb_operator.TabIndex = 4;
            // 
            // txt_value2
            // 
            this.txt_value2.Location = new System.Drawing.Point(349, 219);
            this.txt_value2.Name = "txt_value2";
            this.txt_value2.Size = new System.Drawing.Size(100, 26);
            this.txt_value2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "=";
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(510, 219);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(287, 26);
            this.txt_result.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "ausrechnen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_value2);
            this.Controls.Add(this.cmb_operator);
            this.Controls.Add(this.txt_value1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInfo);
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_value1;
        private System.Windows.Forms.ComboBox cmb_operator;
        private System.Windows.Forms.TextBox txt_value2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Button button1;
    }
}

