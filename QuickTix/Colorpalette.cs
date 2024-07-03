using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

public static class ColorPalette
{
    public static Color PrimaryColor = ColorTranslator.FromHtml("#4169E1"); // Royal Blue
    public static Color SecondaryColor = ColorTranslator.FromHtml("#C0C0C0"); // Silver
    public static Color BackgroundColor = ColorTranslator.FromHtml("#F8F8FF"); // Ivory
    public static Color TextColor = ColorTranslator.FromHtml("#333333"); // Dark Gray
    public static Color ButtonColor = PrimaryColor; // Royal Blue

    public static void ApplyColorPalette(Control control)
    {
        if (control is Form form)
        {
            form.BackColor = BackgroundColor;
        }
        else if (control is Panel panel)
        {
            panel.BackColor = BackgroundColor;
        }
        else if (control is Label label)
        {
            label.ForeColor = TextColor;
        }
        else if (control is TextBox textBox)
        {
            textBox.BackColor = Color.White;
            textBox.ForeColor = TextColor;
        }
        else if (control is Button button)
        {
            button.BackColor = ButtonColor;
            button.ForeColor = Color.White; // Assuming white text for buttons for contrast
        }
        else if (control is ComboBox comboBox)
        {
            comboBox.BackColor = Color.White;
            comboBox.ForeColor = TextColor;
        }
        else if (control is ListView listView)
        {
            listView.BackColor = Color.White;
            listView.ForeColor = TextColor;
            listView.BorderStyle = BorderStyle.FixedSingle;
        }
        else if (control is FlowLayoutPanel flowLayoutPanel)
        {
            flowLayoutPanel.BackColor = BackgroundColor;
        }

        // Apply recursively to child controls
        foreach (Control child in control.Controls)
        {
            ApplyColorPalette(child);
        }
    }
}

