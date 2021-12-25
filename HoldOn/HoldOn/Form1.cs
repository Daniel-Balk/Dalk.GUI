using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoldOn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Hide();
            while (true)
            {
                var p = Cursor.Position;
                var pt = new Point(p.X - 5, p.Y - 5);
                Cursor.Position = pt;
                Thread.Sleep(5);
                Cursor.Position = p;
                Thread.Sleep(100);
            }
        }
    }
}
