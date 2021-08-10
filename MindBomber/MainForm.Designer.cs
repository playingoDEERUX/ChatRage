
namespace ChatRage
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.fireBtn = new System.Windows.Forms.Button();
            this.setIntervBtn = new System.Windows.Forms.Button();
            this.intervBox = new System.Windows.Forms.TextBox();
            this.agroBox = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hateBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fireBtn
            // 
            this.fireBtn.Location = new System.Drawing.Point(221, 275);
            this.fireBtn.Margin = new System.Windows.Forms.Padding(2);
            this.fireBtn.Name = "fireBtn";
            this.fireBtn.Size = new System.Drawing.Size(131, 43);
            this.fireBtn.TabIndex = 0;
            this.fireBtn.Text = "Fire artillery!";
            this.fireBtn.UseVisualStyleBackColor = true;
            this.fireBtn.Click += new System.EventHandler(this.fireBtn_Click);
            // 
            // setIntervBtn
            // 
            this.setIntervBtn.Location = new System.Drawing.Point(16, 240);
            this.setIntervBtn.Margin = new System.Windows.Forms.Padding(2);
            this.setIntervBtn.Name = "setIntervBtn";
            this.setIntervBtn.Size = new System.Drawing.Size(101, 77);
            this.setIntervBtn.TabIndex = 1;
            this.setIntervBtn.Text = "set interval for each message to be sent (in ms)";
            this.setIntervBtn.UseVisualStyleBackColor = true;
            // 
            // intervBox
            // 
            this.intervBox.Location = new System.Drawing.Point(16, 218);
            this.intervBox.Margin = new System.Windows.Forms.Padding(2);
            this.intervBox.Name = "intervBox";
            this.intervBox.Size = new System.Drawing.Size(102, 20);
            this.intervBox.TabIndex = 2;
            this.intervBox.Text = "400";
            // 
            // agroBox
            // 
            this.agroBox.AutoSize = true;
            this.agroBox.Location = new System.Drawing.Point(370, 240);
            this.agroBox.Margin = new System.Windows.Forms.Padding(2);
            this.agroBox.Name = "agroBox";
            this.agroBox.Size = new System.Drawing.Size(221, 43);
            this.agroBox.TabIndex = 3;
            this.agroBox.Text = "accelerate sending speed after each\r\nmessage (makes it seem more aggressive\r\nto t" +
    "he recipient)";
            this.agroBox.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hateBox
            // 
            this.hateBox.Location = new System.Drawing.Point(16, 28);
            this.hateBox.Margin = new System.Windows.Forms.Padding(2);
            this.hateBox.Name = "hateBox";
            this.hateBox.Size = new System.Drawing.Size(576, 186);
            this.hateBox.TabIndex = 4;
            this.hateBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Preload with sentences here (each new line = new message). Can be used for trolli" +
    "ng too (or hateful speech).";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "How to use?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 322);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hateBox);
            this.Controls.Add(this.agroBox);
            this.Controls.Add(this.intervBox);
            this.Controls.Add(this.setIntervBtn);
            this.Controls.Add(this.fireBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(616, 361);
            this.MinimumSize = new System.Drawing.Size(616, 361);
            this.Name = "MainForm";
            this.Text = "ChatRage (bully-tool)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fireBtn;
        private System.Windows.Forms.Button setIntervBtn;
        private System.Windows.Forms.TextBox intervBox;
        private System.Windows.Forms.CheckBox agroBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox hateBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

