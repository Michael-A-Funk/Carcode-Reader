using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZedGraph;


namespace SS_OpenCV
{
    public partial class Histogram : Form
    {
            
        
      public Histogram(int [] array)
{
InitializeComponent();
// get a reference to the GraphPane
GraphPane myPane = graf.GraphPane;
// Set the Titles
myPane.Title.Text = "Histograma";
myPane.XAxis.Title.Text = "Intensidade";
myPane.YAxis.Title.Text = "Contagem";
//list points
PointPairList list1 = new PointPairList();
for (int i = 0; i < array.Length; i++)
{
list1.Add(i, array[i]);
}
myPane.AddBar("imagem", list1, Color.Gray);
myPane.XAxis.Scale.Min = 0;
myPane.XAxis.Scale.Max = array.Length-1;
graf.AxisChange();
}

        private void zedGraphControl1_Load(object sender, EventArgs e)
        { 

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
