namespace FFp
{
    partial class AnswerForm
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
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.nameOperationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // answerTextBox
            // 
            this.answerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerTextBox.Location = new System.Drawing.Point(0, 45);
            this.answerTextBox.Multiline = true;
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(393, 216);
            this.answerTextBox.TabIndex = 0;
            // 
            // nameOperationLabel
            // 
            this.nameOperationLabel.AutoSize = true;
            this.nameOperationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameOperationLabel.Location = new System.Drawing.Point(30, 13);
            this.nameOperationLabel.Name = "nameOperationLabel";
            this.nameOperationLabel.Size = new System.Drawing.Size(0, 22);
            this.nameOperationLabel.TabIndex = 1;
            // 
            // AnswerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 262);
            this.Controls.Add(this.nameOperationLabel);
            this.Controls.Add(this.answerTextBox);
            this.Name = "AnswerForm";
            this.Text = "AnswerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Label nameOperationLabel;
    }
}