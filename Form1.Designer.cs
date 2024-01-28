namespace OrionProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.betelgeuseLabel = new System.Windows.Forms.Label();
            this.alnitakLabel = new System.Windows.Forms.Label();
            this.saiphLabel = new System.Windows.Forms.Label();
            this.alnilamLabel = new System.Windows.Forms.Label();
            this.meissaLabel = new System.Windows.Forms.Label();
            this.mintakaLabel = new System.Windows.Forms.Label();
            this.rigelLabel = new System.Windows.Forms.Label();
            this.displayStarNameButton = new System.Windows.Forms.Button();
            this.hideStarNameButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(561, 457);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // betelgeuseLabel
            // 
            this.betelgeuseLabel.AutoSize = true;
            this.betelgeuseLabel.Location = new System.Drawing.Point(61, 41);
            this.betelgeuseLabel.Name = "betelgeuseLabel";
            this.betelgeuseLabel.Size = new System.Drawing.Size(76, 16);
            this.betelgeuseLabel.TabIndex = 1;
            this.betelgeuseLabel.Text = "Betelgeuse";
            this.betelgeuseLabel.Visible = false;
            // 
            // alnitakLabel
            // 
            this.alnitakLabel.AutoSize = true;
            this.alnitakLabel.Location = new System.Drawing.Point(128, 218);
            this.alnitakLabel.Name = "alnitakLabel";
            this.alnitakLabel.Size = new System.Drawing.Size(47, 16);
            this.alnitakLabel.TabIndex = 2;
            this.alnitakLabel.Text = "Alnitak";
            this.alnitakLabel.Visible = false;
            this.alnitakLabel.Click += new System.EventHandler(this.alnitakLabel_Click);
            // 
            // saiphLabel
            // 
            this.saiphLabel.AutoSize = true;
            this.saiphLabel.Location = new System.Drawing.Point(104, 375);
            this.saiphLabel.Name = "saiphLabel";
            this.saiphLabel.Size = new System.Drawing.Size(42, 16);
            this.saiphLabel.TabIndex = 3;
            this.saiphLabel.Text = "Saiph";
            this.saiphLabel.Visible = false;
            this.saiphLabel.Click += new System.EventHandler(this.saiphLabel_Click);
            // 
            // alnilamLabel
            // 
            this.alnilamLabel.AutoSize = true;
            this.alnilamLabel.Location = new System.Drawing.Point(239, 218);
            this.alnilamLabel.Name = "alnilamLabel";
            this.alnilamLabel.Size = new System.Drawing.Size(51, 16);
            this.alnilamLabel.TabIndex = 4;
            this.alnilamLabel.Text = "Alnilam";
            this.alnilamLabel.Visible = false;
            // 
            // meissaLabel
            // 
            this.meissaLabel.AutoSize = true;
            this.meissaLabel.Location = new System.Drawing.Point(379, 63);
            this.meissaLabel.Name = "meissaLabel";
            this.meissaLabel.Size = new System.Drawing.Size(51, 16);
            this.meissaLabel.TabIndex = 5;
            this.meissaLabel.Text = "Meissa";
            this.meissaLabel.Visible = false;
            // 
            // mintakaLabel
            // 
            this.mintakaLabel.AutoSize = true;
            this.mintakaLabel.Location = new System.Drawing.Point(332, 189);
            this.mintakaLabel.Name = "mintakaLabel";
            this.mintakaLabel.Size = new System.Drawing.Size(54, 16);
            this.mintakaLabel.TabIndex = 6;
            this.mintakaLabel.Text = "Mintaka";
            this.mintakaLabel.Visible = false;
            // 
            // rigelLabel
            // 
            this.rigelLabel.AutoSize = true;
            this.rigelLabel.Location = new System.Drawing.Point(405, 327);
            this.rigelLabel.Name = "rigelLabel";
            this.rigelLabel.Size = new System.Drawing.Size(39, 16);
            this.rigelLabel.TabIndex = 7;
            this.rigelLabel.Text = "Rigel";
            this.rigelLabel.Visible = false;
            // 
            // displayStarNameButton
            // 
            this.displayStarNameButton.Location = new System.Drawing.Point(28, 485);
            this.displayStarNameButton.Name = "displayStarNameButton";
            this.displayStarNameButton.Size = new System.Drawing.Size(134, 75);
            this.displayStarNameButton.TabIndex = 8;
            this.displayStarNameButton.Text = "Display Star Names";
            this.displayStarNameButton.UseVisualStyleBackColor = true;
            this.displayStarNameButton.Click += new System.EventHandler(this.displayStarNameButton_Click);
            // 
            // hideStarNameButton
            // 
            this.hideStarNameButton.Location = new System.Drawing.Point(215, 486);
            this.hideStarNameButton.Name = "hideStarNameButton";
            this.hideStarNameButton.Size = new System.Drawing.Size(148, 72);
            this.hideStarNameButton.TabIndex = 9;
            this.hideStarNameButton.Text = "Hide Star Names";
            this.hideStarNameButton.UseVisualStyleBackColor = true;
            this.hideStarNameButton.Click += new System.EventHandler(this.hideStarNameButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(394, 486);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(140, 72);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 574);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.hideStarNameButton);
            this.Controls.Add(this.displayStarNameButton);
            this.Controls.Add(this.rigelLabel);
            this.Controls.Add(this.mintakaLabel);
            this.Controls.Add(this.meissaLabel);
            this.Controls.Add(this.alnilamLabel);
            this.Controls.Add(this.saiphLabel);
            this.Controls.Add(this.alnitakLabel);
            this.Controls.Add(this.betelgeuseLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Orion Constellation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label betelgeuseLabel;
        private System.Windows.Forms.Label alnitakLabel;
        private System.Windows.Forms.Label saiphLabel;
        private System.Windows.Forms.Label alnilamLabel;
        private System.Windows.Forms.Label meissaLabel;
        private System.Windows.Forms.Label mintakaLabel;
        private System.Windows.Forms.Label rigelLabel;
        private System.Windows.Forms.Button displayStarNameButton;
        private System.Windows.Forms.Button hideStarNameButton;
        private System.Windows.Forms.Button exitButton;
    }
}

