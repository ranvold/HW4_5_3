using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4_5_3
{
    public partial class Form1 : Form
    {
        private RightTriangle _rightTriangle;
        private IsoscelesTriangle _isoscelesTriangle;
        public Form1()
        {
            InitializeComponent();
        }

        private bool NewRightTriangle()
        {
            if (Triangle.ValidateSides(TextBoxFirstSide.Text, 
                TextBoxSecondSide.Text, TextBoxAngleBS.Text))
            {
                _rightTriangle = new RightTriangle()
                {
                    FirstSide = Convert.ToDouble(TextBoxFirstSide.Text),
                    SecondSide = Convert.ToDouble(TextBoxSecondSide.Text),
                    AngleBetweenSides = Convert.ToDouble(TextBoxAngleBS.Text)
                };
                return true;
            }
            else
            {
                MessageBox.Show("Input error! All data must be positive.");
                return false;
            }
        }

        private bool NewIsoscelesTriangle()
        {
            if (Triangle.ValidateSides(TextBoxFirstSide.Text, 
                TextBoxSecondSide.Text, TextBoxAngleBS.Text))
            {
                _isoscelesTriangle = new IsoscelesTriangle()
                {
                    FirstSide = Convert.ToDouble(TextBoxFirstSide.Text),
                    SecondSide = Convert.ToDouble(TextBoxSecondSide.Text),
                    AngleBetweenSides = Convert.ToDouble(TextBoxAngleBS.Text)
                };
                return true;
            }
            else
            {
                MessageBox.Show("Input error! All data must be positive.");
                return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RadioButtonRightTriangle.Checked = true;
        }

        private void ButtonGetArea_Click(object sender, EventArgs e)
        {
            if(RadioButtonRightTriangle.Checked && NewRightTriangle())
            {
                _rightTriangle.CalcArea();
                TextBoxResult.Text = Convert.ToString(_rightTriangle.Area);
            }
            else if(RadioButtonIsoscelesTriangle.Checked && NewIsoscelesTriangle())
            {
                _isoscelesTriangle.CalcArea();
                TextBoxResult.Text = Convert.ToString(_isoscelesTriangle.Area);
            }
        }

        private void ButtonGetPerimeter_Click(object sender, EventArgs e)
        {
            if (RadioButtonRightTriangle.Checked && NewRightTriangle())
            {
                _rightTriangle.CalcPerimeter();
                TextBoxResult.Text = Convert.ToString(_rightTriangle.Perimeter);
            }
            else if (RadioButtonIsoscelesTriangle.Checked && NewIsoscelesTriangle())
            {
                _isoscelesTriangle.CalcPerimeter();
                TextBoxResult.Text = Convert.ToString(_isoscelesTriangle.Perimeter);
            }
        }

        private void RadioButtonRightTriangle_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxFirstSide.Text = "";
            TextBoxSecondSide.Text = "";
            TextBoxAngleBS.Text = "";
            TextBoxResult.Text = "";

        }

        private void RadioButtonIsoscelesTriangle_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxFirstSide.Text = "";
            TextBoxSecondSide.Text = "";
            TextBoxAngleBS.Text = "";
            TextBoxResult.Text = "";
        }

        private void TextBoxFirstSide_Enter(object sender, EventArgs e)
        {
            //TextBoxFirstSide.SelectAll();
        }

        private void TextBoxSecondSide_Enter(object sender, EventArgs e)
        {
            TextBoxSecondSide.SelectAll();
        }

        private void TextBoxAngleBS_Enter(object sender, EventArgs e)
        {
            TextBoxAngleBS.SelectAll();
        }

        private void TextBoxResult_Enter(object sender, EventArgs e)
        {
            TextBoxResult.SelectAll();
        }

    }
}

