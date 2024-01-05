using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;


namespace _23пр
{
    public partial class Colors : Form
    {
        Color colorResult;
        public delegate void ColorSelectedEventHandler(Color color);
        public event ColorSelectedEventHandler ColorSelected;
        
        public Colors(Color color)
        {
            InitializeComponent();
            red_hScrollBar.Tag = red_numericUpDown;
            green_hScrollBar.Tag = green_numericUpDown;
            blue_hScrollBar.Tag = blue_numericUpDown;
            red_numericUpDown.Tag = red_hScrollBar;
            green_numericUpDown.Tag = green_hScrollBar;
            blue_numericUpDown.Tag = blue_hScrollBar;
            red_numericUpDown.Value = color.R;
            green_numericUpDown.Value = color.G;
            blue_numericUpDown.Value = color.B;
          

        }

        private void red_hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            ScrollBar scrollBar = (ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)red_hScrollBar.Tag;
            numericUpDown.Value = red_hScrollBar.Value;
            UpdateColor();
        }

        private void green_hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            ScrollBar scrollBar = (ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)green_hScrollBar.Tag;
            numericUpDown.Value = green_hScrollBar.Value;
            UpdateColor();
        }

        private void blue_hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            ScrollBar scrollBar = (ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)blue_hScrollBar.Tag;
            numericUpDown.Value = blue_hScrollBar.Value;
            UpdateColor();
        }

        private void red_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)red_numericUpDown.Tag;
            scrollBar.Value = (int)red_numericUpDown.Value;
            UpdateColor();

        }

        private void green_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)green_numericUpDown.Tag;
            scrollBar.Value = (int)green_numericUpDown.Value;
            UpdateColor();
        }

        private void blue_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)blue_numericUpDown.Tag;
            scrollBar.Value = (int)blue_numericUpDown.Value;
            UpdateColor();
        }
        private void UpdateColor()
        {
            colorResult = Color.FromArgb(red_hScrollBar.Value, green_hScrollBar.Value, blue_hScrollBar.Value); 
            picResultColor.BackColor = colorResult;
        }

        private void other_btn_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                red_hScrollBar.Value = colorDialog.Color.R;
                green_hScrollBar.Value = colorDialog.Color.G;
                blue_hScrollBar.Value = colorDialog.Color.B;
                colorResult = colorDialog.Color;
                UpdateColor();
            }
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            if (ColorSelected != null)
            {
                ColorSelected(colorResult);
            }
            this.Close();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void HSBRed_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateColor();
        }

        private void HSBGreen_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateColor();
        }

        private void HSBBlue_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateColor();
        }

    }
}
