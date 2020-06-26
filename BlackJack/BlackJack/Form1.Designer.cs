namespace BlackJack
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.PlayerCardPictureBox1 = new System.Windows.Forms.PictureBox();
            this.DrawButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCardPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerCardPictureBox1
            // 
            this.PlayerCardPictureBox1.Image = global::BlackJack.Properties.Resources.card_01;
            this.PlayerCardPictureBox1.Location = new System.Drawing.Point(46, 150);
            this.PlayerCardPictureBox1.Name = "PlayerCardPictureBox1";
            this.PlayerCardPictureBox1.Size = new System.Drawing.Size(70, 140);
            this.PlayerCardPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayerCardPictureBox1.TabIndex = 0;
            this.PlayerCardPictureBox1.TabStop = false;
            // 
            // DrawButton
            // 
            this.DrawButton.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DrawButton.Location = new System.Drawing.Point(266, 228);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(120, 45);
            this.DrawButton.TabIndex = 14;
            this.DrawButton.Text = "引く";
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(442, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 45);
            this.button2.TabIndex = 15;
            this.button2.Text = "引かない";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 465);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DrawButton);
            this.Controls.Add(this.PlayerCardPictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCardPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PlayerCardPictureBox1;
        private System.Windows.Forms.Button DrawButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}

