
namespace Cube_Structure
{
    partial class Input_Form
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
            this.Create_Cube = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Create_Cube
            // 
            this.Create_Cube.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_Cube.Location = new System.Drawing.Point(73, 65);
            this.Create_Cube.Name = "Create_Cube";
            this.Create_Cube.Size = new System.Drawing.Size(158, 67);
            this.Create_Cube.TabIndex = 0;
            this.Create_Cube.Text = "Create Cube";
            this.Create_Cube.UseVisualStyleBackColor = true;
            this.Create_Cube.Click += new System.EventHandler(this.Create_Cube_Click);
            // 
            // Input_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(309, 217);
            this.Controls.Add(this.Create_Cube);
            this.Name = "Input_Form";
            this.Text = "Input_From";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Create_Cube;
    }
}

