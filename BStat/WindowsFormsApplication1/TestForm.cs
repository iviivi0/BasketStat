using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
  public partial class TestForm : Form
  {
    public TestForm()
    {
      InitializeComponent();
    }

    private void button1_Click( object sender, EventArgs e )
    {
      int i;
      Int32.TryParse( this.textBox1.Text, out i );
      i = BStat.BStatLib.first( i );
      this.label1.Text = i.ToString();

    }
  }
}
