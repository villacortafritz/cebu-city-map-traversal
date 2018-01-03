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

        private const int size = 50; //number of all nodes limited
        private Graphics graphics;
        private Rectangle[] rectangle = new Rectangle[size];
        private Label[] nodeLabel = new Label[size];
        private Point[] nodes = new Point[2];
        private Font pathFont = new Font("Century Gothic", 10);
        private SolidBrush onHover = new SolidBrush(Color.Red);
        private SolidBrush leaveHover = new SolidBrush(Color.CornflowerBlue);
        Pen pen = new Pen(Color.CornflowerBlue);
        Pen pathPen = new Pen(Color.Orange);
        Label pathLabel = new Label();

        private int count = 0; //number all the nodes added
        private int nCount = 0; //number of nodes being clicked
        private int lCount = 0;
        private int diameter = 10; // diameter of a circle
        private int[] label = new int[2];
        private bool[] check = new bool[size];
        private int choice;
        private int searchChoice;
        private int countClick = 0;
        private int countClick1 = 0;
        private bool hasReachedGoal;
        Queue queuePath = new Queue();
        Stack stackPath = new Stack();
        GreedyQueue greedyPath = new GreedyQueue();
        AStarQueue starPath = new AStarQueue();

        private Form2 matrix;

        public Form1()
        {
            InitializeComponent();
            graphics = panelArea.CreateGraphics();
            matrix = new Form2();
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
                    {
                        Point point = new Point(e.X, e.Y);
                        SolidBrush brush = new SolidBrush(Color.CornflowerBlue);
                        SolidBrush brush1 = new SolidBrush(Color.Black);
                        Font font = new Font("Century Gothic", 5);
                        Size boxSize1 = new Size(13, 9);
                        int XLoc = point.X + 2;
                        int YLoc = point.Y - 9;

                        if (count < size)
                        {
                            //graphics.DrawString(count + "", font, brush, point.X + 2, point.Y - 9);
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
                    }
                case 2:
                    {
                        SolidBrush brush = new SolidBrush(Color.Green);
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
                            graphics.DrawString(distance + "", font1, brush, Xmidpoint + 5, Ymidpoint);

                            matrix.setValue(label[0], label[1]);
                        }
                        break;
                    }
            }
        }

        private void btnBFS_Click(object sender, EventArgs e)
        {
            if (count != 0)
            {
                int start = 0;
                hasReachedGoal = false;
                Queue queue = new Queue();
                Queue temp = new Queue();
                int current = start;

                queue.enqueue(current);
                temp.enqueue(current);

                while (!hasReachedGoal)
                {
                    if (queue.getCount() == count)
                    {
                        hasReachedGoal = true;
                        break;
                    }

                    for (int i = 0; i < count; i++)
                    {
                        if (matrix.hasConnected(current, i))
                        {
                            temp.enqueue(i);
                        }
                    }

                    temp.dequeue();
                    current = temp.peek();

                    if (!queue.isVisited(current))
                        queue.enqueue(current);
                }
                MessageBox.Show(queue.display());
            }
        }

        private void btnMatrix_Click(object sender, EventArgs e)
        {
            matrix.Show();
            countClick++;
        }

        private void panelArea_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panelArea_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void btnDFS_Click(object sender, EventArgs e)
        {
            if (count != 0)
            {
                int start = 0;
                hasReachedGoal = false;
                Stack stack = new Stack();
                Stack temp = new Stack();
                int current = start;

                stack.push(current);
                temp.push(current);

                while (!hasReachedGoal)
                {
                    if (stack.getCount() == count)
                    {
                        hasReachedGoal = true;
                        break;
                    }

                    for (int i = 0; i < count; i++)
                    {
                        if (matrix.hasConnected(current, i))
                        {
                            if (!stack.isVisited(i))
                                temp.push(i);
                        }
                    }
                    current = temp.peek();
                    temp.pop();

                    if (!stack.isVisited(current))
                        stack.push(current);
                }

                MessageBox.Show(stack.display() + "");
            }
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.Orange);
            Pen pen = new Pen(Color.Orange);
            Point prev = new Point();
            Point next = new Point();
            int start = int.Parse(txtStart.Text);
            int goal = int.Parse(txtEnd.Text);
            int current = start;
            int prevNode = start;
            prev = new Point(rectangle[start].X + diameter / 2, rectangle[start].Y + diameter / 2);

            if (searchChoice == 1)
            {
                Queue temp = new Queue();
                hasReachedGoal = false;
                queuePath.enqueue(current);
                temp.enqueue(current);
                graphics.FillEllipse(brush, rectangle[start]);

                while (!hasReachedGoal)
                {
                    if (current == goal)
                    {
                        hasReachedGoal = true;
                        break;
                    }

                    for (int i = 0; i < count; i++)
                    {
                        if (matrix.hasConnected(current, i))
                        {
                            temp.enqueue(i);
                        }
                    }
                    MessageBox.Show(temp.display());
                    temp.dequeue();
                    current = temp.peek();

                    if (!queuePath.isVisited(current))
                    {
                        next = new Point(rectangle[current].X + diameter / 2, rectangle[current].Y + diameter / 2);
                        if (matrix.hasConnected(prevNode, current) && (prevNode < current || prevNode > current))
                        {
                            graphics.FillEllipse(brush, rectangle[current]);
                            queuePath.enqueue(current);
                            graphics.DrawLine(pathPen, prev, next);
                            prev = next;
                            prevNode = current;
                        }
                    }
                }
                MessageBox.Show(queuePath.display());
            }
            else if (searchChoice == 2)
            {
                hasReachedGoal = false;
                Stack temp1 = new Stack();
                stackPath.push(current);
                temp1.push(current);
                graphics.FillEllipse(brush, rectangle[start]);

                while (!hasReachedGoal)
                {
                    if (current == goal)
                    {
                        hasReachedGoal = true;
                        break;
                    }

                    for (int i = 0; i < count; i++)
                    {
                        if (matrix.hasConnected(current, i))
                        {
                            if (!stackPath.isVisited(i))
                                temp1.push(i);
                        }
                    }
                    current = temp1.peek();
                    temp1.pop();

                    if (!stackPath.isVisited(current))
                    {
                        next = new Point(rectangle[current].X + diameter / 2, rectangle[current].Y + diameter / 2);
                        if (matrix.hasConnected(prevNode, current) && (prevNode < current || prevNode > current))
                        {
                            graphics.FillEllipse(brush, rectangle[current]);
                            stackPath.push(current);
                            graphics.DrawLine(pathPen, prev, next);
                            prev = next;
                            prevNode = current;
                        }
                    }
                }
            }
            else if (searchChoice == 3)
            {
                hasReachedGoal = false;
                double heuristic = 0;
                GreedyQueue greedy = new GreedyQueue();

                heuristic = Math.Round(Math.Sqrt(Math.Pow((rectangle[goal].X - rectangle[start].X), 2) + Math.Pow((rectangle[goal].Y - rectangle[start].Y), 2)));
                greedyPath.enqueue(current, heuristic);
                graphics.FillEllipse(brush, rectangle[current]);

                while (!hasReachedGoal)
                {
                    if (current == goal)
                    {
                        hasReachedGoal = true;
                        break;
                    }

                    for (int i = 0; i < count; i++)
                    {
                        if (matrix.hasConnected(current, i))
                        {
                            heuristic = 0;
                            heuristic = Math.Round(Math.Sqrt(Math.Pow((rectangle[goal].X - rectangle[i].X), 2) + Math.Pow((rectangle[goal].Y - rectangle[i].Y), 2)));

                            if (!greedy.isVisited(i))
                                greedy.enqueue(i, heuristic);

                            MessageBox.Show(i + " " + heuristic);
                        }
                    }
                    current = greedy.compare();
                    MessageBox.Show(current + "");
                    greedy = new GreedyQueue();

                    if (matrix.hasConnected(prevNode, current))
                    {
                        next = new Point(rectangle[current].X + diameter / 2, rectangle[current].Y + diameter / 2);
                        graphics.FillEllipse(brush, rectangle[current]);
                        greedyPath.enqueue(current, 0);
                        graphics.DrawLine(pathPen, prev, next);
                        prev = next;
                        prevNode = current;
                    }
                }
            }
            else if (searchChoice == 4)
            {
                hasReachedGoal = false;
                double heuristic = 0;
                double distance = 0;
                double function = 0;
                double tempFunc;
                AStarQueue star = new AStarQueue();
                AStarQueue temp = new AStarQueue();
                int from = start;
                int to;

                heuristic = Math.Round(Math.Sqrt(Math.Pow((rectangle[goal].X - rectangle[start].X), 2) + Math.Pow((rectangle[goal].Y - rectangle[start].Y), 2)));
                function = heuristic + distance;
                star.enqueue(current, heuristic, function);
                temp.enqueue(current, heuristic, function);
                starPath.enqueue(current, heuristic, function);
                graphics.FillEllipse(brush, rectangle[current]);

                while (!hasReachedGoal)
                {
                    if (current == goal)
                    {
                        hasReachedGoal = true;
                        break;
                    }

                    for (int i = 0; i < count; i++)
                    {
                        if (matrix.hasConnected(current, i))
                        {
                            heuristic = Math.Round(Math.Sqrt(Math.Pow((rectangle[goal].X - rectangle[i].X), 2) + Math.Pow((rectangle[goal].Y - rectangle[i].Y), 2)));
                            distance = Math.Round(Math.Sqrt(Math.Pow((rectangle[i].X - rectangle[current].X), 2) + Math.Pow((rectangle[i].Y - rectangle[current].Y), 2)));
                            function = heuristic + distance;
                            if (!star.isVisited(i))
                            {
                                star.enqueue(i, heuristic, function);
                            }
                            MessageBox.Show(i + " " + "Heuristic: " + heuristic + " Distance: " + distance + " Function: " + function);
                        }
                    }

                    current = star.compare();
                    MessageBox.Show("Current: " + current);

                    if (matrix.hasNeighbors(current))
                    {
                        tempFunc = 0;
                        while (!star.isEmpty() && from != current)
                        {
                            star.dequeue();
                            to = star.peek();
                            distance = Math.Round(Math.Sqrt(Math.Pow((rectangle[to].X - rectangle[from].X), 2) + Math.Pow((rectangle[to].Y - rectangle[from].Y), 2)));
                            from = to;
                            tempFunc += distance;
                        }

                        for (int i = 0; i < count; i++)
                        {
                            if (matrix.hasConnected(current, i))
                            {
                                heuristic = Math.Round(Math.Sqrt(Math.Pow((rectangle[goal].X - rectangle[i].X), 2) + Math.Pow((rectangle[goal].Y - rectangle[i].Y), 2)));
                                distance = Math.Round(Math.Sqrt(Math.Pow((rectangle[i].X - rectangle[current].X), 2) + Math.Pow((rectangle[i].Y - rectangle[current].Y), 2)));
                                function = heuristic + tempFunc + distance;
                                if (!star.isVisited(i))
                                {
                                    star.enqueue(i, heuristic, function);
                                }
                                MessageBox.Show("[ " + i + " ]" + " Above: " + tempFunc + " Heuristic: " + heuristic + " Distance: " + distance + " Function: " + function);
                            }
                        }
                    }

                    current = star.compare();
                    temp.enqueue(current, 0, 0);
                    MessageBox.Show(current + "");
                    star = new AStarQueue();

                    if (!starPath.isVisited(current))
                    {
                        next = new Point(rectangle[current].X + diameter / 2, rectangle[current].Y + diameter / 2);
                        if (matrix.hasConnected(prevNode, current) && (prevNode < current || prevNode > current))
                        {
                            graphics.FillEllipse(brush, rectangle[current]);
                            starPath.enqueue(current, 0, 0);
                            graphics.DrawLine(pathPen, prev, next);
                            prev = next;
                            prevNode = current;
                        }
                    }
                }
            }
            }
        }
    }
