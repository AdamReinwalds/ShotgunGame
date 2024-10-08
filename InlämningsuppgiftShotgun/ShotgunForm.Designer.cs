using System.Runtime.CompilerServices;

namespace InlämningsuppgiftShotgun
{
    partial class ShotgunForm
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
            buttonReload = new Button();
            buttonBlock = new Button();
            buttonShoot = new Button();
            textBoxPlayerAmmo = new TextBox();
            textBoxComputerAmmo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxComputerAction = new TextBox();
            label3 = new Label();
            textBoxPlayerAction = new TextBox();
            label5 = new Label();
            buttonShotgun = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // buttonReload
            // 
            buttonReload.Location = new Point(12, 262);
            buttonReload.Name = "buttonReload";
            buttonReload.Size = new Size(158, 45);
            buttonReload.TabIndex = 0;
            buttonReload.Text = "Reload";
            buttonReload.UseVisualStyleBackColor = true;
            buttonReload.Click += buttonReload_Click;
            // 
            // buttonBlock
            // 
            buttonBlock.Location = new Point(176, 262);
            buttonBlock.Name = "buttonBlock";
            buttonBlock.Size = new Size(163, 45);
            buttonBlock.TabIndex = 1;
            buttonBlock.Text = "Block";
            buttonBlock.UseVisualStyleBackColor = true;
            buttonBlock.Click += buttonBlock_Click;
            // 
            // buttonShoot
            // 
            buttonShoot.Location = new Point(345, 262);
            buttonShoot.Name = "buttonShoot";
            buttonShoot.Size = new Size(158, 45);
            buttonShoot.TabIndex = 2;
            buttonShoot.Text = "Shoot";
            buttonShoot.UseVisualStyleBackColor = true;
            buttonShoot.Click += buttonShoot_Click;
            // 
            // textBoxPlayerAmmo
            // 
            textBoxPlayerAmmo.Location = new Point(453, 208);
            textBoxPlayerAmmo.Name = "textBoxPlayerAmmo";
            textBoxPlayerAmmo.ReadOnly = true;
            textBoxPlayerAmmo.Size = new Size(33, 31);
            textBoxPlayerAmmo.TabIndex = 3;
            // 
            // textBoxComputerAmmo
            // 
            textBoxComputerAmmo.Location = new Point(453, 67);
            textBoxComputerAmmo.Name = "textBoxComputerAmmo";
            textBoxComputerAmmo.ReadOnly = true;
            textBoxComputerAmmo.Size = new Size(33, 31);
            textBoxComputerAmmo.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(320, 208);
            label1.Name = "label1";
            label1.Size = new Size(127, 25);
            label1.TabIndex = 5;
            label1.Text = "Current ammo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(329, 67);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 6;
            label2.Text = "Comp ammo";
            // 
            // textBoxComputerAction
            // 
            textBoxComputerAction.Location = new Point(61, 75);
            textBoxComputerAction.Name = "textBoxComputerAction";
            textBoxComputerAction.ReadOnly = true;
            textBoxComputerAction.Size = new Size(225, 31);
            textBoxComputerAction.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 47);
            label3.Name = "label3";
            label3.Size = new Size(145, 25);
            label3.TabIndex = 10;
            label3.Text = "Computer action";
            // 
            // textBoxPlayerAction
            // 
            textBoxPlayerAction.Location = new Point(61, 208);
            textBoxPlayerAction.Name = "textBoxPlayerAction";
            textBoxPlayerAction.ReadOnly = true;
            textBoxPlayerAction.Size = new Size(225, 31);
            textBoxPlayerAction.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(99, 180);
            label5.Name = "label5";
            label5.Size = new Size(100, 25);
            label5.TabIndex = 13;
            label5.Text = "Your action";
            // 
            // buttonShotgun
            // 
            buttonShotgun.Location = new Point(12, 313);
            buttonShotgun.Name = "buttonShotgun";
            buttonShotgun.Size = new Size(491, 55);
            buttonShotgun.TabIndex = 14;
            buttonShotgun.Text = "Shotgun";
            buttonShotgun.UseVisualStyleBackColor = true;
            buttonShotgun.Click += buttonShotgun_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(329, 233);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(372, 233);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(418, 233);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(418, 95);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(29, 23);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 20;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(372, 95);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(29, 23);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 19;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(329, 95);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(27, 23);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 388);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(buttonShotgun);
            Controls.Add(label5);
            Controls.Add(textBoxPlayerAction);
            Controls.Add(label3);
            Controls.Add(textBoxComputerAction);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxComputerAmmo);
            Controls.Add(textBoxPlayerAmmo);
            Controls.Add(buttonShoot);
            Controls.Add(buttonBlock);
            Controls.Add(buttonReload);
            Name = "Form1";
            Text = "Shotgun Game";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonReload;
        private Button buttonBlock;
        private Button buttonShoot;
        private TextBox textBoxPlayerAmmo;
        private TextBox textBoxComputerAmmo;
        private Label label1;
        private Label label2;
        private TextBox textBoxComputerAction;
        private Label label3;
        private TextBox textBoxPlayerAction;
        private Label label5;
        private Button buttonShotgun;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
    }
}
