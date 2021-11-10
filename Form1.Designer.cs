
namespace HW4_5_3
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
            this.GroupBoxTriangle = new System.Windows.Forms.GroupBox();
            this.RadioButtonIsoscelesTriangle = new System.Windows.Forms.RadioButton();
            this.RadioButtonRightTriangle = new System.Windows.Forms.RadioButton();
            this.LableFirstSide = new System.Windows.Forms.Label();
            this.TextBoxFirstSide = new System.Windows.Forms.TextBox();
            this.LabelSecondSide = new System.Windows.Forms.Label();
            this.TextBoxSecondSide = new System.Windows.Forms.TextBox();
            this.LabelAngleBetweenSides = new System.Windows.Forms.Label();
            this.TextBoxAngleBS = new System.Windows.Forms.TextBox();
            this.TextBoxResult = new System.Windows.Forms.TextBox();
            this.LabelInfo = new System.Windows.Forms.Label();
            this.ButtonGetArea = new System.Windows.Forms.Button();
            this.ButtonGetPerimeter = new System.Windows.Forms.Button();
            this.GroupBoxTriangle.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxTriangle
            // 
            this.GroupBoxTriangle.Controls.Add(this.RadioButtonIsoscelesTriangle);
            this.GroupBoxTriangle.Controls.Add(this.RadioButtonRightTriangle);
            this.GroupBoxTriangle.Location = new System.Drawing.Point(12, 171);
            this.GroupBoxTriangle.Name = "GroupBoxTriangle";
            this.GroupBoxTriangle.Size = new System.Drawing.Size(151, 74);
            this.GroupBoxTriangle.TabIndex = 0;
            this.GroupBoxTriangle.TabStop = false;
            this.GroupBoxTriangle.Text = "Triangle:";
            // 
            // RadioButtonIsoscelesTriangle
            // 
            this.RadioButtonIsoscelesTriangle.AutoSize = true;
            this.RadioButtonIsoscelesTriangle.Location = new System.Drawing.Point(6, 42);
            this.RadioButtonIsoscelesTriangle.Name = "RadioButtonIsoscelesTriangle";
            this.RadioButtonIsoscelesTriangle.Size = new System.Drawing.Size(110, 17);
            this.RadioButtonIsoscelesTriangle.TabIndex = 1;
            this.RadioButtonIsoscelesTriangle.TabStop = true;
            this.RadioButtonIsoscelesTriangle.Text = "Isosceles Triangle";
            this.RadioButtonIsoscelesTriangle.UseVisualStyleBackColor = true;
            this.RadioButtonIsoscelesTriangle.CheckedChanged += new System.EventHandler(this.RadioButtonIsoscelesTriangle_CheckedChanged);
            // 
            // RadioButtonRightTriangle
            // 
            this.RadioButtonRightTriangle.AutoSize = true;
            this.RadioButtonRightTriangle.Location = new System.Drawing.Point(6, 19);
            this.RadioButtonRightTriangle.Name = "RadioButtonRightTriangle";
            this.RadioButtonRightTriangle.Size = new System.Drawing.Size(91, 17);
            this.RadioButtonRightTriangle.TabIndex = 0;
            this.RadioButtonRightTriangle.TabStop = true;
            this.RadioButtonRightTriangle.Text = "Right Triangle";
            this.RadioButtonRightTriangle.UseVisualStyleBackColor = true;
            this.RadioButtonRightTriangle.CheckedChanged += new System.EventHandler(this.RadioButtonRightTriangle_CheckedChanged);
            // 
            // LableFirstSide
            // 
            this.LableFirstSide.AutoSize = true;
            this.LableFirstSide.Location = new System.Drawing.Point(399, 142);
            this.LableFirstSide.Name = "LableFirstSide";
            this.LableFirstSide.Size = new System.Drawing.Size(53, 13);
            this.LableFirstSide.TabIndex = 1;
            this.LableFirstSide.Text = "First Side:";
            // 
            // TextBoxFirstSide
            // 
            this.TextBoxFirstSide.Location = new System.Drawing.Point(399, 158);
            this.TextBoxFirstSide.Name = "TextBoxFirstSide";
            this.TextBoxFirstSide.Size = new System.Drawing.Size(111, 20);
            this.TextBoxFirstSide.TabIndex = 2;
            this.TextBoxFirstSide.Enter += new System.EventHandler(this.TextBoxFirstSide_Enter);
            // 
            // LabelSecondSide
            // 
            this.LabelSecondSide.AutoSize = true;
            this.LabelSecondSide.Location = new System.Drawing.Point(399, 194);
            this.LabelSecondSide.Name = "LabelSecondSide";
            this.LabelSecondSide.Size = new System.Drawing.Size(71, 13);
            this.LabelSecondSide.TabIndex = 3;
            this.LabelSecondSide.Text = "Second Side:";
            // 
            // TextBoxSecondSide
            // 
            this.TextBoxSecondSide.Location = new System.Drawing.Point(399, 213);
            this.TextBoxSecondSide.Name = "TextBoxSecondSide";
            this.TextBoxSecondSide.Size = new System.Drawing.Size(111, 20);
            this.TextBoxSecondSide.TabIndex = 4;
            this.TextBoxSecondSide.Enter += new System.EventHandler(this.TextBoxSecondSide_Enter);
            // 
            // LabelAngleBetweenSides
            // 
            this.LabelAngleBetweenSides.AutoSize = true;
            this.LabelAngleBetweenSides.Location = new System.Drawing.Point(399, 255);
            this.LabelAngleBetweenSides.Name = "LabelAngleBetweenSides";
            this.LabelAngleBetweenSides.Size = new System.Drawing.Size(111, 13);
            this.LabelAngleBetweenSides.TabIndex = 5;
            this.LabelAngleBetweenSides.Text = "Angle Between Sides:";
            // 
            // TextBoxAngleBS
            // 
            this.TextBoxAngleBS.Location = new System.Drawing.Point(399, 271);
            this.TextBoxAngleBS.Name = "TextBoxAngleBS";
            this.TextBoxAngleBS.Size = new System.Drawing.Size(111, 20);
            this.TextBoxAngleBS.TabIndex = 6;
            this.TextBoxAngleBS.Enter += new System.EventHandler(this.TextBoxAngleBS_Enter);
            // 
            // TextBoxResult
            // 
            this.TextBoxResult.Location = new System.Drawing.Point(210, 402);
            this.TextBoxResult.Name = "TextBoxResult";
            this.TextBoxResult.Size = new System.Drawing.Size(157, 20);
            this.TextBoxResult.TabIndex = 8;
            this.TextBoxResult.Enter += new System.EventHandler(this.TextBoxResult_Enter);
            // 
            // LabelInfo
            // 
            this.LabelInfo.AutoSize = true;
            this.LabelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInfo.Location = new System.Drawing.Point(38, 60);
            this.LabelInfo.Name = "LabelInfo";
            this.LabelInfo.Size = new System.Drawing.Size(540, 20);
            this.LabelInfo.TabIndex = 9;
            this.LabelInfo.Text = "Select the type of triangle and enter the appropriate information in the fields";
            // 
            // ButtonGetArea
            // 
            this.ButtonGetArea.Location = new System.Drawing.Point(210, 373);
            this.ButtonGetArea.Name = "ButtonGetArea";
            this.ButtonGetArea.Size = new System.Drawing.Size(75, 23);
            this.ButtonGetArea.TabIndex = 10;
            this.ButtonGetArea.Text = "GetArea";
            this.ButtonGetArea.UseVisualStyleBackColor = true;
            this.ButtonGetArea.Click += new System.EventHandler(this.ButtonGetArea_Click);
            // 
            // ButtonGetPerimeter
            // 
            this.ButtonGetPerimeter.Location = new System.Drawing.Point(292, 373);
            this.ButtonGetPerimeter.Name = "ButtonGetPerimeter";
            this.ButtonGetPerimeter.Size = new System.Drawing.Size(75, 23);
            this.ButtonGetPerimeter.TabIndex = 11;
            this.ButtonGetPerimeter.Text = "GetPerimeter";
            this.ButtonGetPerimeter.UseVisualStyleBackColor = true;
            this.ButtonGetPerimeter.Click += new System.EventHandler(this.ButtonGetPerimeter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 450);
            this.Controls.Add(this.ButtonGetPerimeter);
            this.Controls.Add(this.ButtonGetArea);
            this.Controls.Add(this.LabelInfo);
            this.Controls.Add(this.TextBoxResult);
            this.Controls.Add(this.TextBoxAngleBS);
            this.Controls.Add(this.LabelAngleBetweenSides);
            this.Controls.Add(this.TextBoxSecondSide);
            this.Controls.Add(this.LabelSecondSide);
            this.Controls.Add(this.TextBoxFirstSide);
            this.Controls.Add(this.LableFirstSide);
            this.Controls.Add(this.GroupBoxTriangle);
            this.Name = "Form1";
            this.Text = "CalcTriangle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBoxTriangle.ResumeLayout(false);
            this.GroupBoxTriangle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxTriangle;
        private System.Windows.Forms.RadioButton RadioButtonIsoscelesTriangle;
        private System.Windows.Forms.RadioButton RadioButtonRightTriangle;
        private System.Windows.Forms.Label LableFirstSide;
        private System.Windows.Forms.TextBox TextBoxFirstSide;
        private System.Windows.Forms.Label LabelSecondSide;
        private System.Windows.Forms.TextBox TextBoxSecondSide;
        private System.Windows.Forms.Label LabelAngleBetweenSides;
        private System.Windows.Forms.TextBox TextBoxAngleBS;
        private System.Windows.Forms.TextBox TextBoxResult;
        private System.Windows.Forms.Label LabelInfo;
        private System.Windows.Forms.Button ButtonGetArea;
        private System.Windows.Forms.Button ButtonGetPerimeter;
    }
}

