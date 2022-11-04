using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformslol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var text = await userControl11.current_monaco().GetText();

            MessageBox.Show(text);
            // example: API.Execute(text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl11.current_monaco().refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // example: get script off scripthub
            var text = "example text";

            userControl11.current_monaco().SetText(text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // shows the credits

            var credits = "--[[ Credits\nPareX - WebViewAPI\niDev -  Monaco\nLxnny - Tabs, Modifying WebViewAPI, Implementing it --]]";

            userControl11.add_tab_with_text(credits);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // shows the minimimap

            userControl11.current_monaco().enable_minimap();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // hides the minimimap

            userControl11.current_monaco().disable_minimap();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            // disable intellisense/autocompletion (Syntax Highlighting is not affected)

            userControl11.current_monaco().disable_autocomplete();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // enables intellisense/autocompletion (Syntax Highlighting is not affected)

            userControl11.current_monaco().enable_autocomplete();
        }
    }
}
