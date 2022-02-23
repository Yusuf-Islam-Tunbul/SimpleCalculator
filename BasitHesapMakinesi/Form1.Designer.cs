
namespace BasitHesapMakinesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.number_text1 = new System.Windows.Forms.TextBox();
            this.addition_button = new System.Windows.Forms.Button();
            this.number_text2 = new System.Windows.Forms.TextBox();
            this.subtraction_button = new System.Windows.Forms.Button();
            this.multiplication_button = new System.Windows.Forms.Button();
            this.division_button = new System.Windows.Forms.Button();
            this.mod_button = new System.Windows.Forms.Button();
            this.result_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // number_text1
            // 
            this.number_text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.number_text1.Location = new System.Drawing.Point(12, 12);
            this.number_text1.Multiline = true;
            this.number_text1.Name = "number_text1";
            this.number_text1.Size = new System.Drawing.Size(274, 44);
            this.number_text1.TabIndex = 0;
            // 
            // addition_button
            // 
            this.addition_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addition_button.Location = new System.Drawing.Point(12, 112);
            this.addition_button.Name = "addition_button";
            this.addition_button.Size = new System.Drawing.Size(50, 50);
            this.addition_button.TabIndex = 2;
            this.addition_button.Text = "+";
            this.addition_button.UseVisualStyleBackColor = true;
            // 
            // number_text2
            // 
            this.number_text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.number_text2.Location = new System.Drawing.Point(12, 62);
            this.number_text2.Multiline = true;
            this.number_text2.Name = "number_text2";
            this.number_text2.Size = new System.Drawing.Size(274, 44);
            this.number_text2.TabIndex = 7;
            // 
            // subtraction_button
            // 
            this.subtraction_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.subtraction_button.Location = new System.Drawing.Point(68, 112);
            this.subtraction_button.Name = "subtraction_button";
            this.subtraction_button.Size = new System.Drawing.Size(50, 50);
            this.subtraction_button.TabIndex = 8;
            this.subtraction_button.Text = "-";
            this.subtraction_button.UseVisualStyleBackColor = true;
            // 
            // multiplication_button
            // 
            this.multiplication_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.multiplication_button.Location = new System.Drawing.Point(124, 112);
            this.multiplication_button.Name = "multiplication_button";
            this.multiplication_button.Size = new System.Drawing.Size(50, 50);
            this.multiplication_button.TabIndex = 9;
            this.multiplication_button.Text = "*";
            this.multiplication_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.multiplication_button.UseVisualStyleBackColor = true;
            // 
            // division_button
            // 
            this.division_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.division_button.Location = new System.Drawing.Point(180, 112);
            this.division_button.Name = "division_button";
            this.division_button.Size = new System.Drawing.Size(50, 50);
            this.division_button.TabIndex = 10;
            this.division_button.Text = "/";
            this.division_button.UseVisualStyleBackColor = true;
            // 
            // mod_button
            // 
            this.mod_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mod_button.Location = new System.Drawing.Point(236, 112);
            this.mod_button.Name = "mod_button";
            this.mod_button.Size = new System.Drawing.Size(50, 50);
            this.mod_button.TabIndex = 11;
            this.mod_button.Text = "%";
            this.mod_button.UseVisualStyleBackColor = true;
            // 
            // result_label
            // 
            this.result_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.result_label.Location = new System.Drawing.Point(12, 174);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(274, 44);
            this.result_label.TabIndex = 12;
            this.result_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 230);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.mod_button);
            this.Controls.Add(this.division_button);
            this.Controls.Add(this.multiplication_button);
            this.Controls.Add(this.subtraction_button);
            this.Controls.Add(this.number_text2);
            this.Controls.Add(this.addition_button);
            this.Controls.Add(this.number_text1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox number_text1;
        private System.Windows.Forms.Button addition_button;
        private System.Windows.Forms.TextBox number_text2;
        private System.Windows.Forms.Button subtraction_button;
        private System.Windows.Forms.Button multiplication_button;
        private System.Windows.Forms.Button division_button;
        private System.Windows.Forms.Button mod_button;
        private System.Windows.Forms.Label result_label;
    }
}

