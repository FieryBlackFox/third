namespace Digdes_konverter
{
    partial class Converter
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.convert_button = new System.Windows.Forms.Button();
            this.open_button = new System.Windows.Forms.Button();
            this.pictureB = new System.Windows.Forms.PictureBox();
            this.openFileDialog_image = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB)).BeginInit();
            this.SuspendLayout();
            // 
            // convert_button
            // 
            this.convert_button.Location = new System.Drawing.Point(381, 41);
            this.convert_button.Name = "convert_button";
            this.convert_button.Size = new System.Drawing.Size(101, 23);
            this.convert_button.TabIndex = 0;
            this.convert_button.Text = "Конвертировать";
            this.convert_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.convert_button.UseVisualStyleBackColor = true;
            this.convert_button.Click += new System.EventHandler(this.convert_button_Click);
            // 
            // open_button
            // 
            this.open_button.Location = new System.Drawing.Point(340, 12);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(143, 23);
            this.open_button.TabIndex = 1;
            this.open_button.Text = "Открыть изображение";
            this.open_button.UseVisualStyleBackColor = true;
            this.open_button.Click += new System.EventHandler(this.open_button_Click);
            // 
            // pictureB
            // 
            this.pictureB.Location = new System.Drawing.Point(6, 5);
            this.pictureB.Name = "pictureB";
            this.pictureB.Size = new System.Drawing.Size(328, 212);
            this.pictureB.TabIndex = 2;
            this.pictureB.TabStop = false;
            // 
            // openFileDialog_image
            // 
            this.openFileDialog_image.Filter = "Изображения|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 221);
            this.Controls.Add(this.pictureB);
            this.Controls.Add(this.open_button);
            this.Controls.Add(this.convert_button);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(510, 259);
            this.MinimumSize = new System.Drawing.Size(510, 259);
            this.Name = "Converter";
            this.Text = "Converter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button convert_button;
        private System.Windows.Forms.Button open_button;
        private System.Windows.Forms.PictureBox pictureB;
        private System.Windows.Forms.OpenFileDialog openFileDialog_image;
    }
}

