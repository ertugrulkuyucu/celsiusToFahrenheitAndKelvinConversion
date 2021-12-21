
namespace celsiusDonusum
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
            this.convertBtn = new System.Windows.Forms.Button();
            this.celsiusLbl = new System.Windows.Forms.Label();
            this.celsiusText = new System.Windows.Forms.TextBox();
            this.fahrenheitLbl = new System.Windows.Forms.Label();
            this.kelvinLbl = new System.Windows.Forms.Label();
            this.kelvinTxt = new System.Windows.Forms.Label();
            this.fahrenheitTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // convertBtn
            // 
            this.convertBtn.BackColor = System.Drawing.Color.Red;
            this.convertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.convertBtn.Location = new System.Drawing.Point(202, 140);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(100, 33);
            this.convertBtn.TabIndex = 9;
            this.convertBtn.Text = "Cevir";
            this.convertBtn.UseVisualStyleBackColor = false;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // celsiusLbl
            // 
            this.celsiusLbl.AutoSize = true;
            this.celsiusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.celsiusLbl.Location = new System.Drawing.Point(100, 66);
            this.celsiusLbl.Name = "celsiusLbl";
            this.celsiusLbl.Size = new System.Drawing.Size(77, 25);
            this.celsiusLbl.TabIndex = 8;
            this.celsiusLbl.Text = "Celsius";
            // 
            // celsiusText
            // 
            this.celsiusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.celsiusText.Location = new System.Drawing.Point(202, 66);
            this.celsiusText.Name = "celsiusText";
            this.celsiusText.Size = new System.Drawing.Size(100, 30);
            this.celsiusText.TabIndex = 7;
            // 
            // fahrenheitLbl
            // 
            this.fahrenheitLbl.AutoSize = true;
            this.fahrenheitLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fahrenheitLbl.Location = new System.Drawing.Point(100, 239);
            this.fahrenheitLbl.Name = "fahrenheitLbl";
            this.fahrenheitLbl.Size = new System.Drawing.Size(105, 25);
            this.fahrenheitLbl.TabIndex = 13;
            this.fahrenheitLbl.Text = "Fahrenheit";
            // 
            // kelvinLbl
            // 
            this.kelvinLbl.AutoSize = true;
            this.kelvinLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kelvinLbl.Location = new System.Drawing.Point(100, 288);
            this.kelvinLbl.Name = "kelvinLbl";
            this.kelvinLbl.Size = new System.Drawing.Size(66, 25);
            this.kelvinLbl.TabIndex = 14;
            this.kelvinLbl.Text = "Kelvin";
            // 
            // kelvinTxt
            // 
            this.kelvinTxt.AutoSize = true;
            this.kelvinTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kelvinTxt.Location = new System.Drawing.Point(210, 288);
            this.kelvinTxt.Name = "kelvinTxt";
            this.kelvinTxt.Size = new System.Drawing.Size(0, 25);
            this.kelvinTxt.TabIndex = 16;
            // 
            // fahrenheitTxt
            // 
            this.fahrenheitTxt.AutoSize = true;
            this.fahrenheitTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fahrenheitTxt.Location = new System.Drawing.Point(210, 239);
            this.fahrenheitTxt.Name = "fahrenheitTxt";
            this.fahrenheitTxt.Size = new System.Drawing.Size(0, 25);
            this.fahrenheitTxt.TabIndex = 15;
            this.fahrenheitTxt.Click += new System.EventHandler(this.fahrenheitTxt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(466, 450);
            this.Controls.Add(this.kelvinTxt);
            this.Controls.Add(this.fahrenheitTxt);
            this.Controls.Add(this.kelvinLbl);
            this.Controls.Add(this.fahrenheitLbl);
            this.Controls.Add(this.convertBtn);
            this.Controls.Add(this.celsiusLbl);
            this.Controls.Add(this.celsiusText);
            this.Name = "Form1";
            this.Text = "Temperature Convert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button convertBtn;
        private System.Windows.Forms.Label celsiusLbl;
        private System.Windows.Forms.TextBox celsiusText;
        private System.Windows.Forms.Label fahrenheitLbl;
        private System.Windows.Forms.Label kelvinLbl;
        private System.Windows.Forms.Label kelvinTxt;
        private System.Windows.Forms.Label fahrenheitTxt;
    }
}

