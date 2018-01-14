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
        
        private const int size = 50;
        private Graphics graphics;
        private Rectangle[] rectangle = new Rectangle[size];
        private Label[] lblNode = new Label[size];

        private bool ready = false;
        private bool reached;
        Queue queuePath = new Queue();
        Stack stackPath = new Stack();

        Pen pen = new Pen(Color.Red);
        Pen pathPen = new Pen(Color.Orange);
        Label pathname = new Label();
        private Point[] nodes = new Point[2];
        private Font pathFont = new Font("Arial", 12);
        private SolidBrush hover = new SolidBrush(Color.Red);
        private SolidBrush leaveHover = new SolidBrush(Color.Yellow);

        private int count = 0; //number all the nodes added
        private int nodecount = 0; //number of nodes being clicked
        private int leafcount = 0;
    
        private int countClick = 0;
        private int countClick1 = 0;
      
        GreedyQueue greedy = new GreedyQueue();
        AStarQueue star = new AStarQueue();
        private int diameter = 12;
        private int[] label = new int[2];
        private bool[] check = new bool[size];
        private int choice;
        private int search;

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
            mainPanel.Visible = false;
            drawMenu.Visible = false;
            traverseMenu.Visible = false;
            searchMenu.Visible = false;
            viewMenu.Visible = false;
            fileMenu.Visible = true;
        }

        private void btnPlayfair_Click(object sender, EventArgs e)
        {
            SideBar.Height = btnDraw.Height;
            SideBar.Top = btnDraw.Top;
            drawMenu.Show();
            mainPanel.Visible = false;
            drawMenu.Visible = true;
            traverseMenu.Visible = false;
            searchMenu.Visible = false;
            viewMenu.Visible = false;
            fileMenu.Visible = false;
        }

        private void btnHill_Click(object sender, EventArgs e)
        {
            SideBar.Height = btnView.Height;
            SideBar.Top = btnView.Top;
            mainPanel.Visible = false;
            drawMenu.Visible = false;
            traverseMenu.Visible = false;
            searchMenu.Visible = false;
            viewMenu.Visible = true;
            fileMenu.Visible = false;
        }

        private void btnVigenere_Click(object sender, EventArgs e)
        {
            SideBar.Height = btnTraverse.Height;
            SideBar.Top = btnTraverse.Top;
            mainPanel.Visible = false;
            drawMenu.Visible = false;
            traverseMenu.Visible = true;
            searchMenu.Visible = false;
            viewMenu.Visible = false;
            fileMenu.Visible = false;
        }

        private void btnTransposition_Click(object sender, EventArgs e)
        {
            SideBar.Height = btnSearch.Height;
            SideBar.Top = btnSearch.Top;
            mainPanel.Visible = false;
            drawMenu.Visible = false;
            traverseMenu.Visible = false;
            searchMenu.Visible = true;
            viewMenu.Visible = false;
            fileMenu.Visible = false;
        }

        private void btnRailFence_Click(object sender, EventArgs e)
        {
            SideBar.Height = btnCSP.Height;
            SideBar.Top = btnCSP.Top;
            SolidBrush brush;

            if (ready == false)
            {
                MessageBox.Show("There are no nodes plotted.");
                return;
            }

            int[] connections = new int[count];
            int[] color_error = new int[count];
            int[] colors = new int[count];
            Random color = new Random();

            /*
             1 = Red
             2 = Blue
             3 = Green
             4 = Orange
             */
            int sample;
            int previous;

            for(int i=0; i<count; i++)
            {
                sample = matrix.getConnections(i);
                connections[i] = sample;
            }

            for(int i=0; i<count; i++)
            {
                if(connections[i] == 0)
                {
                    brush = new SolidBrush(Color.Orange);
                    graphics.FillEllipse(brush, rectangle[i]);
                    continue;
                }
                int maxValue = connections.Max();
                int maxIndex = connections.ToList().IndexOf(maxValue);
                int current = color.Next(1, 5);
                int color_temp = current;

                for (int j=0; j < count; j++){
                    if(matrix.hasConnected(maxIndex, j) && current == color_error[j])
                    {
                        color_temp++;
                        if (color_temp> 4)
                        {
                            color_temp = (colors[color_temp % 5]);
                        }

                    }
                    else
                    {
                        //MessageBox.Show("Constraint Satisfaction cannot be solved with this graph.");
                        //break;
                    }
                }

                current = color_temp;
                
                if(current == 1)
                {
                    brush = new SolidBrush(Color.Red);
                    graphics.FillEllipse(brush, rectangle[maxIndex]);
                }
                else if(current == 2)
                {
                    brush = new SolidBrush(Color.Blue);
                    graphics.FillEllipse(brush, rectangle[maxIndex]);
                }
                else if (current == 3) 
                {
                    brush = new SolidBrush(Color.Green);
                    graphics.FillEllipse(brush, rectangle[maxIndex]);
                }
                else if(current == 4)
                {
                    brush = new SolidBrush(Color.Orange);
                    graphics.FillEllipse(brush, rectangle[maxIndex]);
                }
                color_error[maxIndex] = current;
                previous = maxIndex;
                connections[maxIndex] = 0;
                MessageBox.Show(i.ToString());
            }
        }
        

        private void btnQuit_Click(object sender, EventArgs e)
        {
            SideBar.Height = btnQuit.Height;
            SideBar.Top = btnQuit.Top;
            this.Close();
        }

        /*private void btnSave_Click(object sender, EventArgs e)
        {
            SideBar.Height = btnFile.Height;
            SideBar.Top = btnFile.Top;
        }*/

        private void btnBFStraverse_Click(object sender, EventArgs e)
        {

             search = 1;
             lblSearch.Text = "Breadth First Search";
           
        }

        private void btnDFStraverse_Click(object sender, EventArgs e)
        {
            search = 2;
            lblSearch.Text = "Depth First Search";
        }

        private void btnGreedy_Click(object sender, EventArgs e)
        {
            search = 3;
            lblSearch.Text = "Greedy Search";
        }

        private void btnAstar_Click(object sender, EventArgs e)
        {
            search = 4;
            lblSearch.Text = "A-Star Search";
        }

        private void btnNodes_Click(object sender, EventArgs e)
        {
            choice = 1;
        }

        private void btnEdges_Click(object sender, EventArgs e)
        {
            choice = 2;
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
                        SolidBrush brush = new SolidBrush(Color.Black);
                        SolidBrush brush1 = new SolidBrush(Color.Black);
                        Font font = new Font("Arial", 7);
                        Size boxSize1 = new Size(13, 9);
                        int XLoc = point.X + 2;
                        int YLoc = point.Y - 9;

                        if (count < size)
                        {
                            check[count] = false;
                            lblNode[count] = new Label();
                            lblNode[count].Text = count + "";
                            lblNode[count].Font = font;
                            lblNode[count].Size = boxSize1;
                            lblNode[count].ForeColor = Color.Red;
                            lblNode[count].Location = new Point(XLoc, YLoc);
                            panelArea.Controls.Add(lblNode[count]);
                            rectangle[count] = new Rectangle(point.X, point.Y, diameter, diameter);
                            graphics.FillEllipse(brush, rectangle[count]);

                            count++;
                            ready = true;
                        }
                        break;
                    }
                case 2:
                    {
                        SolidBrush brush = new SolidBrush(Color.Green);
                        Font font1 = new Font("Arial", 7);
                        double distance = 0;
                        int xmid = 0;
                        int ymid = 0;

                        int x = e.X;
                        int y = e.Y;
                        int index1 = 0;
                        int index2 = 0;

                        for (int i = 0; i < count; i++)
                        {   /*checks if the location has a node*/
                            if (rectangle[i].Contains(x, y))
                            {
                                nodes[nodecount] = new Point(rectangle[i].X + diameter / 2, rectangle[i].Y + diameter / 2);
                                label[leafcount] = i;
                                leafcount++;
                                nodecount++;
                                index1 = i;
                                break;
                            }
                        }

                        for (int i = 0; i < count; i++)
                        {
                            if (rectangle[i].Contains(x, y) && index1 != i)
                            {
                                nodes[nodecount] = new Point(rectangle[i].X + diameter / 2, rectangle[i].Y + diameter / 2);
                                label[leafcount++] = i;
                                nodecount++;
                                index2 = i;

                                if (nodecount > 0)
                                {
                                    nodecount = 1;
                                    leafcount = 1;
                                }

                                break;

                            }
                        }

                        if (nodecount == 2)
                        {
                            nodecount = 0;
                            leafcount = 0;
                            graphics.DrawLine(pen, nodes[0], nodes[1]);
                            distance = Math.Round(Math.Sqrt(Math.Pow((nodes[1].X - nodes[0].X), 2) + Math.Pow((nodes[1].Y - nodes[0].Y), 2)));
                            xmid = Math.Abs((nodes[0].X + nodes[1].X) / 2);
                            ymid = Math.Abs((nodes[0].Y + nodes[1].Y) / 2);
                            graphics.DrawString(distance + "", font1, brush, xmid + 5, ymid);

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
                reached = false;
                Queue queue = new Queue();
                Queue temp = new Queue();
                int current = start;

                queue.enqueue(current);
                temp.enqueue(current);

                while (!reached)
                {
                    if (queue.getCount() == count)
                    {
                        reached = true;
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

        private void panelArea_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            if(lblX.Visible == true)
            {
                lblX.Text = "X: " + x;
                lblY.Text = "Y: " + y;
            }
        }

        private void btnDFS_Click(object sender, EventArgs e)
        {
            if (count != 0)
            {
                int start = 0;
                reached = false;
                Stack stack = new Stack();
                Stack temp = new Stack();
                int current = start;

                stack.push(current);
                temp.push(current);

                while (!reached)
                {
                    if (stack.getCount() == count)
                    {
                        reached = true;
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
            
            if(ready == false)
            {
                MessageBox.Show("There are no nodes plotted.");
                return;
            }

                    if(txtStart.Text != "" && txtEnd.Text !="")
                    {
                        int start = int.Parse(txtStart.Text);
                        int goal = int.Parse(txtEnd.Text);
                        int current = start;
                        int prevNode = start;
                        prev = new Point(rectangle[start].X + diameter / 2, rectangle[start].Y + diameter / 2);
            

            if (search == 1)
            {
                Queue temp = new Queue();
                reached = false;
                queuePath.enqueue(current);
                temp.enqueue(current);
                graphics.FillEllipse(brush, rectangle[start]);

                while (!reached)
                {
                    if (current == goal)
                    {
                        reached = true;
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
            }
            else if (search == 2)
            {
                reached = false;
                Stack temp1 = new Stack();
                stackPath.push(current);
                temp1.push(current);
                graphics.FillEllipse(brush, rectangle[start]);

                while (!reached)
                {
                    if (current == goal)
                    {
                        reached = true;
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
            else if (search == 3)
            {
                reached = false;
                double heuristic = 0;
                GreedyQueue greedy = new GreedyQueue();

                heuristic = Math.Round(Math.Sqrt(Math.Pow((rectangle[goal].X - rectangle[start].X), 2) + Math.Pow((rectangle[goal].Y - rectangle[start].Y), 2)));
                greedy.enqueue(current, heuristic);
                graphics.FillEllipse(brush, rectangle[current]);

                while (!reached)
                {
                    if (current == goal)
                    {
                        reached = true;
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
                        }
                    }
                    current = greedy.compare();
                    greedy = new GreedyQueue();

                    if (matrix.hasConnected(prevNode, current))
                    {
                        next = new Point(rectangle[current].X + diameter / 2, rectangle[current].Y + diameter / 2);
                        graphics.FillEllipse(brush, rectangle[current]);
                        greedy.enqueue(current, 0);
                        graphics.DrawLine(pathPen, prev, next);
                        prev = next;
                        prevNode = current;
                    }
                }
            }
            else if (search == 4)
            {
                reached = false;
                double heuristic = 0;
             
                AStarQueue temp = new AStarQueue();
                int from = start;
                int to;
                    double distance = 0;
                    double function = 0;
                    double tempFunc;
                    AStarQueue star = new AStarQueue();

                    heuristic = Math.Round(Math.Sqrt(Math.Pow((rectangle[goal].X - rectangle[start].X), 2) + Math.Pow((rectangle[goal].Y - rectangle[start].Y), 2)));
                function = heuristic + distance;
                star.enqueue(current, heuristic, function);
                temp.enqueue(current, heuristic, function);
                star.enqueue(current, heuristic, function);
                graphics.FillEllipse(brush, rectangle[current]);

                while (!reached)
                {
                    if (current == goal)
                    {
                        reached = true;
                        break;
                    }
                       /*
                int[] newIndicesArray = new int[IndicesArray.Length - 1];

                int i = 0;
                int j = 0;
                while (i < IndicesArray.Length)
                {
                    if (i != RemoveAt)
                    {
                        newIndicesArray[j] = IndicesArray[i];
                        j++;
                    }

                    i++;
                }
                
            }*/
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

                    if (!star.isVisited(current))
                    {
                        next = new Point(rectangle[current].X + diameter / 2, rectangle[current].Y + diameter / 2);
                        if (matrix.hasConnected(prevNode, current) && (prevNode < current || prevNode > current))
                        {
                            graphics.FillEllipse(brush, rectangle[current]);
                            star.enqueue(current, 0, 0);
                            graphics.DrawLine(pathPen, prev, next);
                            prev = next;
                            prevNode = current;
                        }
                    }
                }
            }
                else
                {
                    MessageBox.Show("Please choose a search algorithm.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please input start point and destination.");
                return;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = true;
            drawMenu.Visible = false;
            traverseMenu.Visible = false;
            searchMenu.Visible = false;
            viewMenu.Visible = false;
        }

        private void btnCoordinates_Click(object sender, EventArgs e)
        {
            if(lblX.Visible == true)
            {
                lblX.Visible = false;
                lblY.Visible = false;
            }
            else
            {
                lblX.Visible = true;
                lblY.Visible = true;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to create new graph? ", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                countClick = 0;
                countClick1 = 0;
                ready = false;

                if (graphics != null)
                {
                    graphics.Clear(Color.White);
                    panelArea.BackgroundImage = Properties.Resources.capture;
                }

                for (int i = 0; i < count; i++)
                {
                    panelArea.Controls.Remove(lblNode[i]);
                }
                lblX.Visible = false;
                lblY.Visible = false;
                count = 0;
                matrix.reset();
                queuePath = new Queue();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter writer;
            writer = new System.IO.StreamWriter("points.txt", true);

            for (int i = 0; i < count; i++)
            {
                writer.Write(lblNode[i].Location);
                writer.WriteLine();
            }
            writer.Close();
        }
    }
}
