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
    public partial class Form1 : Form
    {

        private const int size = 50;        //number of all nodes
        private Graphics graphics;
        private Rectangle[] rectangle = new Rectangle[size];     //array of rectangles for the points
        private Label[] nodeLabel = new Label[size];               //array of the labels of the rectangle
        private Point[] nodes = new Point[2];                   
        private Font pathFont = new Font("Century Gothic", 10);
        private SolidBrush onHover = new SolidBrush(Color.Red);
        private SolidBrush leaveHover = new SolidBrush(Color.CornflowerBlue);
        Pen pen = new Pen(Color.CornflowerBlue);
        Pen pathPen = new Pen(Color.Orange);
        Label pathLabel = new Label();
     
        private int count = 0;                      //number all the nodes added
        private int nCount = 0;                     //number of nodes being clicked
        private int lCount = 0;
        private int diameter = 10;                  // diameter of a circle
        private int[] label = new int[2];
        private bool[] check = new bool[size];
        private int choice;
        private int countClick = 0;
        private int countClick1 = 0;
        private bool hasReachedGoal;

        public Form1()
        {
            InitializeComponent();
            graphics = panelArea.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SideBar.Height = btnMenu.Height;
            SideBar.Top = btnMenu.Top;
            DialogResult res = MessageBox.Show("Are you sure you want to create new graph? ", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void btnPlayfair_Click(object sender, EventArgs e)
        {
            SideBar.Height = btnDraw.Height;
            SideBar.Top = btnDraw.Top;
            if(drawPanel.Visible == true)
            {
                drawPanel.Visible = false;
            }
            else
            {
                drawPanel.Visible = true;
                viewPanel.Visible = false;
                traversePanel.Visible = false;
                searchPanel.Visible = false;
                configPanel.Visible = false;
            }
        }

        private void btnHill_Click(object sender, EventArgs e)
        {
            SideBar.Height = btnView.Height;
            SideBar.Top = btnView.Top;
            if (viewPanel.Visible == true)
            {
                viewPanel.Visible = false;
            }
            else
            {
                viewPanel.Visible = true;
                drawPanel.Visible = false;
                traversePanel.Visible = false;
                searchPanel.Visible = false;
                configPanel.Visible = false;
            }
        }

        private void btnVigenere_Click(object sender, EventArgs e)
        {
            SideBar.Height = btnTraverse.Height;
            SideBar.Top = btnTraverse.Top;
            if (traversePanel.Visible == true)
            {
                traversePanel.Visible = false;
            }
            else
            {
                traversePanel.Visible = true;
                drawPanel.Visible = false;
                viewPanel.Visible = false;
                searchPanel.Visible = false;
                configPanel.Visible = false;
            }
        }

        private void btnTransposition_Click(object sender, EventArgs e)
        {
            SideBar.Height = btnSearch.Height;
            SideBar.Top = btnSearch.Top;
            if (searchPanel.Visible == true)
            {
                searchPanel.Visible = false;
                configPanel.Visible = false;
            }
            else
            {
                searchPanel.Visible = true;
                drawPanel.Visible = false;
                viewPanel.Visible = false;
                traversePanel.Visible = false;
                configPanel.Visible = false;
            }
        }

        private void btnRailFence_Click(object sender, EventArgs e)
        {
            SideBar.Height = btnCSP.Height;
            SideBar.Top = btnCSP.Top;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            SideBar.Height = btnQuit.Height;
            SideBar.Top = btnQuit.Top;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SideBar.Height = btnSave.Height;
            SideBar.Top = btnSave.Top;
        }

        private void btnBFStraverse_Click(object sender, EventArgs e)
        {
         
             configPanel.Visible = true;
             lblSearch.Text = "Breadth First Search";
           
        }

        private void btnDFStraverse_Click(object sender, EventArgs e)
        {
            configPanel.Visible = true;
            lblSearch.Text = "Depth First Search";
        }

        private void btnGreedy_Click(object sender, EventArgs e)
        {
            configPanel.Visible = true;
            lblSearch.Text = "Greedy Search";
        }

        private void btnAstar_Click(object sender, EventArgs e)
        {
            configPanel.Visible = true;
            lblSearch.Text = "A-Star Search";
        }

        private void btnNodes_Click(object sender, EventArgs e)
        {
            choice = 1;
            drawPanel.Visible = false;
        }

        private void btnEdges_Click(object sender, EventArgs e)
        {
            choice = 2;
            drawPanel.Visible = false;
        }

        private void panelArea_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelArea_MouseDown(object sender, MouseEventArgs e)
        {
            switch (choice)
            {

                case 1:

                Point point = new Point(e.X, e.Y);
                SolidBrush brush = new SolidBrush(Color.Red);
                SolidBrush brush1 = new SolidBrush(Color.Black);
                Font font = new Font("Century Gothic", 5);
                Size boxSize1 = new Size(13, 9);
                int XLoc = point.X + 2;
                int YLoc = point.Y - 9;

                if (count < size)
                {
                    check[count] = false;
                    nodeLabel[count] = new Label();
                    nodeLabel[count].Text = count + "";
                    nodeLabel[count].Font = font;
                    nodeLabel[count].Size = boxSize1;
                    nodeLabel[count].Location = new Point(XLoc, YLoc);
                    panelArea.Controls.Add(nodeLabel[count]);
                    rectangle[count] = new Rectangle(point.X, point.Y, diameter, diameter);
                    graphics.FillEllipse(brush, rectangle[count]);

                    count++;
                }
                    break;

                case 2:
                    SolidBrush brush2 = new SolidBrush(Color.Green);
                    Font font1 = new Font("Century Gothic", 7);
                    double distance = 0;
                    int Xmidpoint = 0;
                    int Ymidpoint = 0;

                    int x = e.X;
                    int y = e.Y;
                    int index1 = 0;
                    int index2 = 0;

                    for (int i = 0; i < count; i++)
                    {   /*checks if the location has a node*/
                        if (rectangle[i].Contains(x, y))
                        {
                            nodes[nCount] = new Point(rectangle[i].X + diameter / 2, rectangle[i].Y + diameter / 2);
                            label[lCount] = i;
                            lCount++;
                            nCount++;
                            index1 = i;
                            break;
                        }
                    }

                    for (int i = 0; i < count; i++)
                    {
                        if (rectangle[i].Contains(x, y) && index1 != i)
                        {
                            nodes[nCount] = new Point(rectangle[i].X + diameter / 2, rectangle[i].Y + diameter / 2);
                            label[lCount++] = i;
                            nCount++;
                            index2 = i;

                            if (nCount > 0)
                            {
                                nCount = 1;
                                lCount = 1;
                            }

                            break;

                        }
                    }

                    if (nCount == 2)
                    {
                        nCount = 0;
                        lCount = 0;
                        graphics.DrawLine(pen, nodes[0], nodes[1]);
                        distance = Math.Round(Math.Sqrt(Math.Pow((nodes[1].X - nodes[0].X), 2) + Math.Pow((nodes[1].Y - nodes[0].Y), 2)));
                        Xmidpoint = Math.Abs((nodes[0].X + nodes[1].X) / 2);
                        Ymidpoint = Math.Abs((nodes[0].Y + nodes[1].Y) / 2);
                        graphics.DrawString(distance + "", font1, brush2, Xmidpoint + 5, Ymidpoint);

                        //matrix.setValue(label[0], label[1]);
                    }
                    break;
            }
        }
    }
}
