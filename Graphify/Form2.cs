using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphify
{
    public partial class Form2 : Form
    {
        private const int size = 50;

        private Label[] columnLabel = new Label[size];
        private Label[] rowLabel = new Label[size];
        private Label[,] nodes = new Label[size, size];

        private Font font = new Font("Century Gothic", 7, FontStyle.Bold);
        private Font entrees = new Font("Century Gothic", 7);
        private Size boxSize1 = new Size(15, 16);
        private Size boxSize2 = new Size(24, 16);

        int XLoc;
        int YLoc;

        public Form2()
        {
            InitializeComponent();


            XLoc = 28;
            YLoc = 5;
            for (int i = 0; i < size; i++)
            {
                columnLabel[i] = new Label();
                columnLabel[i].Text = i + "";
                columnLabel[i].Font = font;

                if (i > 9)
                    columnLabel[i].Size = boxSize2;
                else
                    columnLabel[i].Size = boxSize1;
                columnLabel[i].Location = new Point(XLoc, YLoc);
                GraphMatrix.Controls.Add(columnLabel[i]);
                XLoc += 21;
            }

            XLoc = 5;
            YLoc = 22;
            for (int i = 0; i < size; i++)
            {
                rowLabel[i] = new Label();
                rowLabel[i].Text = i + "";
                rowLabel[i].Font = font;

                if (i > 9)
                    rowLabel[i].Size = boxSize2;
                else
                    rowLabel[i].Size = boxSize1;
                rowLabel[i].Location = new Point(XLoc, YLoc);
                GraphMatrix.Controls.Add(rowLabel[i]);
                YLoc += 13;
            }

            XLoc = 28;
            YLoc = 22;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    nodes[i, j] = new Label();
                    nodes[i, j].Text = "0";
                    nodes[i, j].Font = entrees;
                    if (i > 9)
                        nodes[i, j].Size = boxSize2;
                    else
                        nodes[i, j].Size = boxSize1;
                    nodes[i, j].Location = new Point(XLoc, YLoc);
                    GraphMatrix.Controls.Add(nodes[i, j]);
                    XLoc += 21;
                }
                XLoc = 28;
                YLoc += 13;
            }
        }

        public void setValue(int start, int end)
        {
            nodes[start, end].Text = 1 + "";
            nodes[end, start].Text = 1 + "";
        }

        public bool hasConnected(int i, int j)
        {
            bool flag = false;
            if (nodes[i, j].Text.Equals("1"))
                flag = true;

            return flag;
        }

        public void reset()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    nodes[i, j].Text = "0";
                }
            }
        }

        public bool hasNeighbors(int node)
        {
            bool flag = false;
            for (int i = 0; i < size; i++)
            {
                if (nodes[node, i].Text.Equals("1"))
                {
                    flag = true;
                    break;
                }

            }
            return flag;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void GraphMatrix_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
