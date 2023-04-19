namespace CoinFlip_App
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
         this.flipButton = new System.Windows.Forms.Button();
         this.coinImage = new System.Windows.Forms.PictureBox();
         this.headsLabel = new System.Windows.Forms.Label();
         this.tailsLabel = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.coinImage)).BeginInit();
         this.SuspendLayout();
         // 
         // flipButton
         // 
         this.flipButton.Cursor = System.Windows.Forms.Cursors.Hand;
         this.flipButton.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.flipButton.Location = new System.Drawing.Point(200, 300);
         this.flipButton.Name = "flipButton";
         this.flipButton.Size = new System.Drawing.Size(100, 50);
         this.flipButton.TabIndex = 0;
         this.flipButton.Text = "Flip";
         this.flipButton.UseVisualStyleBackColor = true;
         this.flipButton.Click += new System.EventHandler(this.flipButton_Click);
         // 
         // coinImage
         // 
         this.coinImage.Location = new System.Drawing.Point(150, 75);
         this.coinImage.MaximumSize = new System.Drawing.Size(200, 200);
         this.coinImage.MinimumSize = new System.Drawing.Size(200, 200);
         this.coinImage.Name = "coinImage";
         this.coinImage.Size = new System.Drawing.Size(200, 200);
         this.coinImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.coinImage.TabIndex = 1;
         this.coinImage.TabStop = false;
         // 
         // headsLabel
         // 
         this.headsLabel.AutoSize = true;
         this.headsLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.headsLabel.Location = new System.Drawing.Point(356, 75);
         this.headsLabel.Name = "headsLabel";
         this.headsLabel.Size = new System.Drawing.Size(68, 18);
         this.headsLabel.TabIndex = 2;
         this.headsLabel.Text = "Heads:";
         // 
         // tailsLabel
         // 
         this.tailsLabel.AutoSize = true;
         this.tailsLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tailsLabel.Location = new System.Drawing.Point(356, 109);
         this.tailsLabel.Name = "tailsLabel";
         this.tailsLabel.Size = new System.Drawing.Size(68, 18);
         this.tailsLabel.TabIndex = 3;
         this.tailsLabel.Text = "Tails:";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(484, 461);
         this.Controls.Add(this.tailsLabel);
         this.Controls.Add(this.headsLabel);
         this.Controls.Add(this.coinImage);
         this.Controls.Add(this.flipButton);
         this.Name = "Form1";
         this.Text = "Coin Flip";
         ((System.ComponentModel.ISupportInitialize)(this.coinImage)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button flipButton;
      private System.Windows.Forms.PictureBox coinImage;
      private System.Windows.Forms.Label headsLabel;
      private System.Windows.Forms.Label tailsLabel;
   }
}

