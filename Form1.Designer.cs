namespace StPap {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.firstSelection = new System.Windows.Forms.TextBox();
            this.secondSelection = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eredmeny = new System.Windows.Forms.Label();
            this.specsf = new System.Windows.Forms.Label();
            this.tovabbiJatekok = new System.Windows.Forms.Label();
            this.statsText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstSelection
            // 
            this.firstSelection.Location = new System.Drawing.Point(37, 49);
            this.firstSelection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firstSelection.Name = "firstSelection";
            this.firstSelection.Size = new System.Drawing.Size(217, 22);
            this.firstSelection.TabIndex = 0;
            this.firstSelection.TextChanged += new System.EventHandler(this.Selection_TextChanged);
            // 
            // secondSelection
            // 
            this.secondSelection.Location = new System.Drawing.Point(578, 49);
            this.secondSelection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.secondSelection.Name = "secondSelection";
            this.secondSelection.Size = new System.Drawing.Size(217, 22);
            this.secondSelection.TabIndex = 2;
            this.secondSelection.TextChanged += new System.EventHandler(this.Selection_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "1. játékos választása";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(575, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "2. játékos választása";
            // 
            // eredmeny
            // 
            this.eredmeny.AutoSize = true;
            this.eredmeny.Location = new System.Drawing.Point(345, 115);
            this.eredmeny.Name = "eredmeny";
            this.eredmeny.Size = new System.Drawing.Size(44, 16);
            this.eredmeny.TabIndex = 5;
            this.eredmeny.Text = "label3";
            this.eredmeny.Visible = false;
            // 
            // specsf
            // 
            this.specsf.AutoSize = true;
            this.specsf.Location = new System.Drawing.Point(350, 17);
            this.specsf.Name = "specsf";
            this.specsf.Size = new System.Drawing.Size(39, 16);
            this.specsf.TabIndex = 6;
            this.specsf.Text = "0 - kő";
            // 
            // tovabbiJatekok
            // 
            this.tovabbiJatekok.AutoSize = true;
            this.tovabbiJatekok.Location = new System.Drawing.Point(345, 186);
            this.tovabbiJatekok.Name = "tovabbiJatekok";
            this.tovabbiJatekok.Size = new System.Drawing.Size(44, 16);
            this.tovabbiJatekok.TabIndex = 7;
            this.tovabbiJatekok.Text = "label3";
            // 
            // statsText
            // 
            this.statsText.AutoSize = true;
            this.statsText.Location = new System.Drawing.Point(348, 240);
            this.statsText.Name = "statsText";
            this.statsText.Size = new System.Drawing.Size(44, 16);
            this.statsText.TabIndex = 8;
            this.statsText.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 339);
            this.Controls.Add(this.statsText);
            this.Controls.Add(this.tovabbiJatekok);
            this.Controls.Add(this.specsf);
            this.Controls.Add(this.eredmeny);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondSelection);
            this.Controls.Add(this.firstSelection);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kő papír olló";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstSelection;
        private System.Windows.Forms.TextBox secondSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label eredmeny;
        private System.Windows.Forms.Label specsf;
        private System.Windows.Forms.Label tovabbiJatekok;
        private System.Windows.Forms.Label statsText;
    }
}

