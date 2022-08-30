
namespace Hide_Part_Assignment_2
{
    partial class frm_User_Input_Form
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
            this.txtBox_PartName = new System.Windows.Forms.TextBox();
            this.btn_Show_Part = new System.Windows.Forms.Button();
            this.btn_Insert_Part = new System.Windows.Forms.Button();
            this.lbl_FormTittle = new System.Windows.Forms.Label();
            this.cbx_ModelType = new System.Windows.Forms.ComboBox();
            this.lbl_PartType = new System.Windows.Forms.Label();
            this.lbl_PartName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox_PartName
            // 
            this.txtBox_PartName.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_PartName.Location = new System.Drawing.Point(212, 131);
            this.txtBox_PartName.Name = "txtBox_PartName";
            this.txtBox_PartName.Size = new System.Drawing.Size(259, 30);
            this.txtBox_PartName.TabIndex = 0;
            this.txtBox_PartName.TextChanged += new System.EventHandler(this.txtBox_PartName_TextChanged);
            // 
            // btn_Show_Part
            // 
            this.btn_Show_Part.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Show_Part.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show_Part.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Show_Part.Location = new System.Drawing.Point(295, 197);
            this.btn_Show_Part.Name = "btn_Show_Part";
            this.btn_Show_Part.Size = new System.Drawing.Size(176, 39);
            this.btn_Show_Part.TabIndex = 1;
            this.btn_Show_Part.Text = "Show Part";
            this.btn_Show_Part.UseVisualStyleBackColor = false;
            this.btn_Show_Part.Click += new System.EventHandler(this.btn_Show_Part_Click);
            // 
            // btn_Insert_Part
            // 
            this.btn_Insert_Part.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Insert_Part.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insert_Part.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Insert_Part.Location = new System.Drawing.Point(50, 197);
            this.btn_Insert_Part.Name = "btn_Insert_Part";
            this.btn_Insert_Part.Size = new System.Drawing.Size(176, 39);
            this.btn_Insert_Part.TabIndex = 3;
            this.btn_Insert_Part.Text = "Insert Part";
            this.btn_Insert_Part.UseVisualStyleBackColor = false;
            this.btn_Insert_Part.Click += new System.EventHandler(this.btn_Insert_Part_Click);
            // 
            // lbl_FormTittle
            // 
            this.lbl_FormTittle.AutoSize = true;
            this.lbl_FormTittle.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FormTittle.Location = new System.Drawing.Point(165, 9);
            this.lbl_FormTittle.Name = "lbl_FormTittle";
            this.lbl_FormTittle.Size = new System.Drawing.Size(188, 25);
            this.lbl_FormTittle.TabIndex = 4;
            this.lbl_FormTittle.Text = "Assignment No - 2";
            this.lbl_FormTittle.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbx_ModelType
            // 
            this.cbx_ModelType.DropDownWidth = 121;
            this.cbx_ModelType.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_ModelType.FormattingEnabled = true;
            this.cbx_ModelType.Items.AddRange(new object[] {
            "I-Beam",
            "Hollow-Pipe",
            "Column-Welded Box Profile",
            "Polybeam-L Angle",
            "Contour Plate"});
            this.cbx_ModelType.Location = new System.Drawing.Point(212, 69);
            this.cbx_ModelType.Name = "cbx_ModelType";
            this.cbx_ModelType.Size = new System.Drawing.Size(259, 30);
            this.cbx_ModelType.TabIndex = 5;
            this.cbx_ModelType.SelectedIndexChanged += new System.EventHandler(this.cbx_ModelType_SelectedIndexChanged);
            // 
            // lbl_PartType
            // 
            this.lbl_PartType.AutoSize = true;
            this.lbl_PartType.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PartType.Location = new System.Drawing.Point(46, 77);
            this.lbl_PartType.Name = "lbl_PartType";
            this.lbl_PartType.Size = new System.Drawing.Size(139, 22);
            this.lbl_PartType.TabIndex = 6;
            this.lbl_PartType.Text = "Select Part Type";
            // 
            // lbl_PartName
            // 
            this.lbl_PartName.AutoSize = true;
            this.lbl_PartName.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PartName.Location = new System.Drawing.Point(46, 134);
            this.lbl_PartName.Name = "lbl_PartName";
            this.lbl_PartName.Size = new System.Drawing.Size(144, 22);
            this.lbl_PartName.TabIndex = 7;
            this.lbl_PartName.Text = "Enter Part Name";
            this.lbl_PartName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // frm_User_Input_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(555, 281);
            this.Controls.Add(this.lbl_PartName);
            this.Controls.Add(this.lbl_PartType);
            this.Controls.Add(this.cbx_ModelType);
            this.Controls.Add(this.lbl_FormTittle);
            this.Controls.Add(this.btn_Insert_Part);
            this.Controls.Add(this.btn_Show_Part);
            this.Controls.Add(this.txtBox_PartName);
            this.Name = "frm_User_Input_Form";
            this.Text = "User_Input_Form";
            this.Load += new System.EventHandler(this.frm_User_Input_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_PartName;
        private System.Windows.Forms.Button btn_Show_Part;
        private System.Windows.Forms.Button btn_Insert_Part;
        private System.Windows.Forms.Label lbl_FormTittle;
        private System.Windows.Forms.ComboBox cbx_ModelType;
        private System.Windows.Forms.Label lbl_PartType;
        private System.Windows.Forms.Label lbl_PartName;
    }
}

