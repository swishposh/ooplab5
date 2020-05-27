namespace oop5_4_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.circle1 = new oop5_4_.Circle();
            this.galery1 = new oop5_4_.Galery();
            this.SuspendLayout();
            // 
            // circle1
            // 
            this.circle1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circle1.ForeColor = System.Drawing.Color.White;
            this.circle1.Location = new System.Drawing.Point(457, 85);
            this.circle1.Name = "circle1";
            this.circle1.Size = new System.Drawing.Size(265, 230);
            this.circle1.TabIndex = 1;
            this.circle1.Text = "circle1";
            this.circle1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.circle1.UseVisualStyleBackColor = true;
            // 
            // galery1
            // 
            this.galery1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.galery1.ForeColor = System.Drawing.Color.White;
            this.galery1.Image = ((System.Drawing.Image)(resources.GetObject("galery1.Image")));
            this.galery1.Location = new System.Drawing.Point(98, 85);
            this.galery1.Name = "galery1";
            this.galery1.Size = new System.Drawing.Size(265, 230);
            this.galery1.TabIndex = 0;
            this.galery1.Text = "galery1";
            this.galery1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.galery1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.circle1);
            this.Controls.Add(this.galery1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Galery galery1;
        private Circle circle1;
    }
}

