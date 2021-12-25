
namespace ToanHinh
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
            this.components = new System.ComponentModel.Container();
       
            this.btnTamgiac = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
          
            // 
            // guna2DragControl1
            // 
        
            // 
            // btnTamgiac
            // 
            this.btnTamgiac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTamgiac.Location = new System.Drawing.Point(374, 85);
            this.btnTamgiac.Name = "btnTamgiac";
            this.btnTamgiac.Size = new System.Drawing.Size(194, 70);
            this.btnTamgiac.TabIndex = 8;
            this.btnTamgiac.Text = "Hình tam giác";
            this.btnTamgiac.UseVisualStyleBackColor = true;
            this.btnTamgiac.Click += new System.EventHandler(this.btnTamgiac_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1090, 653);
            this.Controls.Add(this.btnTamgiac);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
      
        private System.Windows.Forms.Button btnTamgiac;
    }
}

