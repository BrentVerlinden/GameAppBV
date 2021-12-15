namespace GameAppBV.Forms
{
    partial class Pokésearch
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPokeName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonSubmitAPI = new System.Windows.Forms.Button();
            this.listBoxType = new System.Windows.Forms.ListBox();
            this.pictureBoxPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(87)))));
            this.label4.Location = new System.Drawing.Point(168, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "The website of the API is \"https://pokeapi.co/\".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(87)))));
            this.label1.Location = new System.Drawing.Point(189, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fill in the name of a Pokémon below.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(87)))));
            this.label3.Location = new System.Drawing.Point(103, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(397, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Our application will retrieve some information about it using an API.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(87)))));
            this.label2.Location = new System.Drawing.Point(208, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Search a Pokémon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(87)))));
            this.label5.Location = new System.Drawing.Point(128, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Enter a Pokémon name:";
            // 
            // textBoxPokeName
            // 
            this.textBoxPokeName.Location = new System.Drawing.Point(293, 181);
            this.textBoxPokeName.Name = "textBoxPokeName";
            this.textBoxPokeName.Size = new System.Drawing.Size(168, 20);
            this.textBoxPokeName.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(87)))));
            this.label6.Location = new System.Drawing.Point(186, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "We have retrieved the following data:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(87)))));
            this.label7.Location = new System.Drawing.Point(98, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(87)))));
            this.label8.Location = new System.Drawing.Point(102, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Type:";
            // 
            // textBoxName
            // 
            this.textBoxName.Enabled = false;
            this.textBoxName.Location = new System.Drawing.Point(151, 259);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(168, 20);
            this.textBoxName.TabIndex = 22;
            // 
            // buttonSubmitAPI
            // 
            this.buttonSubmitAPI.Location = new System.Drawing.Point(488, 179);
            this.buttonSubmitAPI.Name = "buttonSubmitAPI";
            this.buttonSubmitAPI.Size = new System.Drawing.Size(90, 23);
            this.buttonSubmitAPI.TabIndex = 24;
            this.buttonSubmitAPI.Text = "Submit";
            this.buttonSubmitAPI.UseVisualStyleBackColor = true;
            this.buttonSubmitAPI.Click += new System.EventHandler(this.buttonSubmitAPI_Click);
            // 
            // listBoxType
            // 
            this.listBoxType.Enabled = false;
            this.listBoxType.FormattingEnabled = true;
            this.listBoxType.Location = new System.Drawing.Point(151, 284);
            this.listBoxType.Name = "listBoxType";
            this.listBoxType.Size = new System.Drawing.Size(168, 56);
            this.listBoxType.TabIndex = 25;
            // 
            // pictureBoxPic
            // 
            this.pictureBoxPic.Location = new System.Drawing.Point(385, 253);
            this.pictureBoxPic.Name = "pictureBoxPic";
            this.pictureBoxPic.Size = new System.Drawing.Size(87, 86);
            this.pictureBoxPic.TabIndex = 26;
            this.pictureBoxPic.TabStop = false;
            // 
            // Pokésearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxPic);
            this.Controls.Add(this.listBoxType);
            this.Controls.Add(this.buttonSubmitAPI);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPokeName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Pokésearch";
            this.Text = "Pokésearch";
            this.Load += new System.EventHandler(this.Pokésearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPokeName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonSubmitAPI;
        private System.Windows.Forms.ListBox listBoxType;
        private System.Windows.Forms.PictureBox pictureBoxPic;
    }
}