namespace adventure_game
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.blueButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.blueLabel = new System.Windows.Forms.Label();
            this.redlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.Location = new System.Drawing.Point(12, 9);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(776, 280);
            this.outputLabel.TabIndex = 0;
            // 
            // blueButton
            // 
            this.blueButton.FlatAppearance.BorderSize = 0;
            this.blueButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.blueButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.blueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blueButton.ForeColor = System.Drawing.Color.Black;
            this.blueButton.Image = global::adventure_game.Properties.Resources.blue_50x50;
            this.blueButton.Location = new System.Drawing.Point(12, 292);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(64, 58);
            this.blueButton.TabIndex = 1;
            this.blueButton.UseVisualStyleBackColor = true;
            // 
            // redButton
            // 
            this.redButton.FlatAppearance.BorderSize = 0;
            this.redButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.redButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.redButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redButton.Image = global::adventure_game.Properties.Resources.red_50x50;
            this.redButton.Location = new System.Drawing.Point(-12, 356);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(113, 91);
            this.redButton.TabIndex = 2;
            this.redButton.UseVisualStyleBackColor = true;
            // 
            // greenButton
            // 
            this.greenButton.FlatAppearance.BorderSize = 0;
            this.greenButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.greenButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.greenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.greenButton.Image = global::adventure_game.Properties.Resources.green_50x50;
            this.greenButton.Location = new System.Drawing.Point(339, 296);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(64, 54);
            this.greenButton.TabIndex = 3;
            this.greenButton.UseVisualStyleBackColor = true;
            // 
            // blueLabel
            // 
            this.blueLabel.Location = new System.Drawing.Point(82, 296);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(251, 75);
            this.blueLabel.TabIndex = 5;
            this.blueLabel.Text = "Start";
            // 
            // redlabel
            // 
            this.redlabel.Location = new System.Drawing.Point(85, 371);
            this.redlabel.Name = "redlabel";
            this.redlabel.Size = new System.Drawing.Size(248, 70);
            this.redlabel.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(409, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 65);
            this.label2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.redlabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.outputLabel);
            this.ForeColor = System.Drawing.Color.Lime;
            this.Name = "Form1";
            this.Text = "Dungeon raiders";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label redlabel;
        private System.Windows.Forms.Label label2;
    }
}

