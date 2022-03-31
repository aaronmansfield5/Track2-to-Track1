namespace Track2toTrack1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Track2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.Forename = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HasPin = new System.Windows.Forms.CheckBox();
            this.Pin = new System.Windows.Forms.TextBox();
            this.Generate = new System.Windows.Forms.Button();
            this.Track1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Track2
            // 
            this.Track2.Location = new System.Drawing.Point(12, 31);
            this.Track2.Name = "Track2";
            this.Track2.PlaceholderText = "Track2 Data";
            this.Track2.Size = new System.Drawing.Size(369, 23);
            this.Track2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Track 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Forename";
            // 
            // Forename
            // 
            this.Forename.Location = new System.Drawing.Point(12, 75);
            this.Forename.Name = "Forename";
            this.Forename.PlaceholderText = "Forename";
            this.Forename.Size = new System.Drawing.Size(177, 23);
            this.Forename.TabIndex = 3;
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(195, 75);
            this.Surname.Name = "Surname";
            this.Surname.PlaceholderText = "Surname";
            this.Surname.Size = new System.Drawing.Size(186, 23);
            this.Surname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(195, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Surname";
            // 
            // HasPin
            // 
            this.HasPin.AutoSize = true;
            this.HasPin.BackColor = System.Drawing.Color.Transparent;
            this.HasPin.Location = new System.Drawing.Point(12, 104);
            this.HasPin.Name = "HasPin";
            this.HasPin.Size = new System.Drawing.Size(110, 19);
            this.HasPin.TabIndex = 6;
            this.HasPin.Text = "Is Pin Available?";
            this.HasPin.UseVisualStyleBackColor = false;
            this.HasPin.CheckedChanged += new System.EventHandler(this.HasPin_CheckedChanged);
            // 
            // Pin
            // 
            this.Pin.Location = new System.Drawing.Point(12, 129);
            this.Pin.Name = "Pin";
            this.Pin.PlaceholderText = "Pin";
            this.Pin.Size = new System.Drawing.Size(100, 23);
            this.Pin.TabIndex = 7;
            this.Pin.Tag = "";
            this.Pin.Visible = false;
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(122, 162);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(138, 23);
            this.Generate.TabIndex = 8;
            this.Generate.Text = "Generate Track1";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Track1
            // 
            this.Track1.Location = new System.Drawing.Point(12, 191);
            this.Track1.Name = "Track1";
            this.Track1.PlaceholderText = "Track1 Data";
            this.Track1.ReadOnly = true;
            this.Track1.Size = new System.Drawing.Size(369, 23);
            this.Track1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 224);
            this.Controls.Add(this.Track1);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.Pin);
            this.Controls.Add(this.HasPin);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Forename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Track2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Track2 To Track1";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Track2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Forename;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox HasPin;
        private System.Windows.Forms.TextBox Pin;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.TextBox Track1;
    }
}
