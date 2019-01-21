using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace App3
{
    public partial class Form1 : Form
    {
        static int width = 400, height = 400;
        int tempWidth = width, tempHeight = height;
        Cell[,] cellArray = new Cell[width, height];
        

        public Form1()
        {
            InitializeComponent();
            generateCells(width,height);
            pictureBox1.MouseDown += picturebox1_MouseDown;
            pictureBox1.MouseDown += picturebox1_MouseDownPPM;

            //inicializing();

        }

        public void inicializing()
        {
            if (comboInclusionType.Text == "Dot")
                txtInclusionsSize.Visible = false;
        }

        private void btnRandomGrow_Click(object sender, EventArgs e)
        {
            int numberOfGrows = Int32.Parse(txtNumberOfGrains.Text);
            int numberOfColors = Int32.Parse(txtNumberOfColors.Text);
            Random random = new Random();
            int rnd1 = 0, rnd2 = 0, rnd3 = 0;
            int emptyCells = 0;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (cellArray[i, j].getId() == 0)
                        emptyCells++;
                }
            }
            if (numberOfGrows <= emptyCells)
            {
                int i = 0;
                while (i < numberOfGrows)
                {
                    rnd1 = random.Next(0, width);
                    rnd2 = random.Next(0, height);
                    rnd3 = random.Next(1, numberOfColors + 1);
                    if (cellArray[rnd1, rnd2].getId() == 0)
                    {
                        //cellArray[rnd1, rnd2].setColor(colorsList.getColor(rnd3));
                        cellArray[rnd1, rnd2].setId(rnd3);
                        
                        i++;
                    }
                }
                //coloring(board, cellArray);
                //pictureBox1.Image = board;
                cellsToBitmap(cellArray);
            }
            else
            {
                MessageBox.Show("There are only " + emptyCells + " free cells while you try to fill " + numberOfGrows);
                txtNumberOfGrains.Text = emptyCells.ToString();
            }


        }
        public void clearBoard()
        {
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                {
                    cellArray[i, j].setId(0);
                    cellArray[i, j].setDualPhase(0);
                    cellArray[i, j].setInclusionFlag(0);
                    cellArray[i, j].setGbFlag(0);
                }

            cellsToBitmap(cellArray);
            width = tempWidth; height = tempHeight;
            txtNumberOfGrains.Text = 1000.ToString();
        }
        //Clear board + clear cellArray
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearBoard();
        }
        //VonNeumann Growth
        private void btnVonNeumann_Click(object sender, EventArgs e) ////VonNeumann grain grown algorithm
        {
            Cell[,] cellArrayTemp = new Cell[width, height];
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                {
                    cellArrayTemp[i, j] = new Cell();
                    cellArrayTemp[i, j].setId(cellArray[i, j].getId());
                    cellArrayTemp[i, j].setDualPhase(cellArray[i, j].getDualPhase());

                }
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                {
                    //Cells inside
                    if (cellArray[i, j].getDualPhase() == 1)
                    {
                        //cellArray[i, j].setColor(cellArray[i, j].getColor());
                        //Console.Write(i); Console.Write(" "); Console.WriteLine(j);
                    }
                    else if (i != 0 && j != 0 && i != width - 1 && j != height - 1)
                    {
                        if(cellArray[i,j].getId()==0 && cellArray[i, j].getInclusionFlag() == 0 )
                        {
                            if (cellArray[i, j].getInclusionFlag() == 0)
                            {

                            }
                            //Old style compare: cellArray[i, j].setId(compare(cellArrayTemp[i - 1, j].getId(), cellArrayTemp[i, j + 1].getId(), cellArrayTemp[i + 1, j].getId(), cellArrayTemp[i, j - 1].getId()));

                            int a = 0, b = 0, c = 0, d = 0;
                            if (cellArrayTemp[i - 1, j].getDualPhase() == 1)
                            {
                                a = 0;
                            }
                            else
                                a = cellArrayTemp[i - 1, j].getId();

                            if (cellArrayTemp[i + 1, j].getDualPhase() == 1)
                            {
                                b = 0;
                            }
                            else
                                b = cellArrayTemp[i + 1, j].getId();

                            if (cellArrayTemp[i, j - 1].getDualPhase() == 1)
                            {
                                c = 0;
                            }
                            else
                                c = cellArrayTemp[i, j - 1].getId();

                            if (cellArrayTemp[i, j + 1].getDualPhase() == 1)
                            {
                                d = 0;
                            }
                            else
                                d = cellArrayTemp[i, j + 1].getId();

                            int[] neighbours = new int[] {
                            a,b,c,d
                            };
                            cellArray[i, j].setId(compare(neighbours));
                        }
                    }
                    //Cell on corner (0,0)
                    else if (i == 0 && j ==0 && cellArray[i, j].getInclusionFlag() == 0)
                    {
                        if (cellArray[i, j].getId() == 0)
                        {
                            int[] neighbours = new int[] {
                            cellArrayTemp[i + 1, j].getId(),
                            cellArrayTemp[i, j + 1].getId()
                            };
                            cellArray[i, j].setId(compare(neighbours));
                        }
                    }
                    //Cell on corner (0,max)
                    else if (i == 0 && j == height-1 && cellArray[i, j].getInclusionFlag() == 0)
                    {
                        if (cellArray[i, j].getId() == 0)
                        {
                            int[] neighbours = new int[] {
                            cellArrayTemp[i + 1, j].getId(),
                            cellArrayTemp[i, j - 1].getId()
                            };
                            cellArray[i, j].setId(compare(neighbours));
                        }
                    }
                    //Cell on corner (max,0)
                    else if (i == width-1 && j == 0 && cellArray[i, j].getInclusionFlag() == 0)
                    {
                        if (cellArray[i, j].getId() == 0)
                        {
                            int[] neighbours = new int[] {
                            cellArrayTemp[i - 1, j].getId(),
                            cellArrayTemp[i, j + 1].getId()
                            };
                            cellArray[i, j].setId(compare(neighbours));
                        }
                    }
                    //Cell on corner (max,max)
                    else if (i == width-1 && j == height-1 && cellArray[i, j].getInclusionFlag() == 0)
                    {
                        if (cellArray[i, j].getId() == 0)
                        {
                            int[] neighbours = new int[] {
                            cellArrayTemp[i - 1, j].getId(),
                            cellArrayTemp[i, j - 1].getId()
                            };
                            cellArray[i, j].setId(compare(neighbours));
                        }
                    }

                    //Cells on top side
                    else if (i != 0 && i !=width-1 && j== 0 && cellArray[i, j].getInclusionFlag() == 0)
                    {
                        if (cellArray[i, j].getId() == 0)
                        {
                            int[] neighbours = new int[] {
                             cellArrayTemp[i - 1, j].getId(),
                             cellArrayTemp[i + 1, j].getId(),
                             cellArrayTemp[i, j + 1].getId()
                             };
                             cellArray[i, j].setId(compare(neighbours));
                            
                        }
                    }
                    //Cells on bot side
                    else if (i != 0 && i != width - 1 && j == height-1 && cellArray[i, j].getInclusionFlag() == 0)
                    {
                        if (cellArray[i, j].getId() == 0)
                        {
                            int[] neighbours = new int[] {
                             cellArrayTemp[i - 1, j].getId(),
                             cellArrayTemp[i + 1, j].getId(),
                             cellArrayTemp[i, j - 1].getId()
                             };
                            cellArray[i, j].setId(compare(neighbours));

                        }
                    }
                    //Cells on left side
                    else if (i == 0 && j != 0 && j!= height-1 && cellArray[i, j].getInclusionFlag() == 0)
                    {
                        if (cellArray[i, j].getId() == 0)
                        {
                            int[] neighbours = new int[] {
                             cellArrayTemp[i + 1, j].getId(),
                             cellArrayTemp[i, j - 1].getId(),
                             cellArrayTemp[i, j + 1].getId()
                             };
                            cellArray[i, j].setId(compare(neighbours));

                        }
                    }
                    //Cells on right side
                    else if (i == width-1 && j != 0 && j !=height-1 && cellArray[i, j].getInclusionFlag() == 0)
                    {
                        if (cellArray[i, j].getId() == 0)
                        {
                            int[] neighbours = new int[] {
                             cellArrayTemp[i - 1, j].getId(),
                             cellArrayTemp[i, j - 1].getId(),
                             cellArrayTemp[i, j + 1].getId()
                             };
                            cellArray[i, j].setId(compare(neighbours));

                        }
                    }

                }
            cellsToBitmap(cellArray);
        }
        //Moore Growth
        private void btnMoore_Click(object sender, EventArgs e) //Moore grain grown algorithm
        {
            
            Cell[,] cellArrayTemp = new Cell[width, height];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    cellArrayTemp[i, j] = new Cell();
                    cellArrayTemp[i, j].setId(cellArray[i, j].getId());
                }
            }
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (i != 0 && j != 0 && i != width - 1 && j != height - 1)
                    {
                        if (cellArray[i, j].getId() == 0 && cellArray[i, j].getInclusionFlag() == 0 && cellArray[i, j].dualPhase == 0)
                        {
                            //cellArray[i, j].setId(compare(cellArrayTemp[i - 1, j].getId(), cellArrayTemp[i, j + 1].getId(), cellArrayTemp[i + 1, j].getId(), cellArrayTemp[i, j - 1].getId()));
                            int[] neighbours = new int[] {
                            cellArrayTemp[i - 1, j].getId(),
                            cellArrayTemp[i + 1, j].getId(),
                            cellArrayTemp[i, j - 1].getId(),
                            cellArrayTemp[i, j + 1].getId(),
                            cellArrayTemp[i - 1, j - 1].getId(),
                            cellArrayTemp[i + 1, j - 1].getId(),
                            cellArrayTemp[i - 1, j + 1].getId(),
                            cellArrayTemp[i + 1, j + 1].getId(),
                            };
                            for (int k = 0; k < neighbours.Length; k++)
                            {
                                if (neighbours[k] != 0)
                                {
                                    cellArray[i, j].setId(compare(neighbours));
                                    break;
                                }
                            }

                        }
                    }
                }
            }
               
            cellsToBitmap(cellArray);
        }

        //Create new cells and insert to cellArray
        public void generateCells(int width, int height)
        {
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                    cellArray[i, j] = new Cell();
        }
        //put cellArrays ids to bitmap -> then copy bitmap to picturebox!
        public void cellsToBitmap(Cell[,] array) //print bitmap on the pictureBox1
        {
            Bitmap bitmapa = new Bitmap(width, height);
            for (int i = 0; i < bitmapa.Width; i++)
                for (int j = 0; j < bitmapa.Height; j++)
                {
                    if (array[i, j].getInclusionFlag() == 1)
                    {
                        array[i, j].setColor(Color.Black);
                        bitmapa.SetPixel(i, j, array[i, j].getColor());
                    }
                    else if (array[i, j].getGbFlag() == 1)
                    {
                        array[i, j].setColor(Color.Black);
                        bitmapa.SetPixel(i, j, array[i, j].getColor());
                    }
                    else
                        bitmapa.SetPixel(i, j, array[i, j].getColor());

                }
            pictureBox1.Image = bitmapa;
            checkSizes();

        }


        //Compare neighbourhood algorithm
        public int compare(int oa, int ob, int oc, int od)
        {
            int[] counts = new int[4] { 0, 0, 0, 0 };
            int tempValue = 0, tempCounter = 0;
            if (oa != 0)
            {
                counts[0]++;
                if (oa == ob) counts[0]++;
                if (oa == oc) counts[0]++;
                if (oa == od) counts[0]++;
            }


            if (ob != 0)
            {
                counts[1]++;
                if (ob == oc) counts[1]++;
                if (ob == od) counts[1]++;
            }


            if (oc != 0)
            {
                counts[2]++;
                if (oc == od) counts[2]++;
            }


            if (od != 0) counts[3]++;

            if (oa != 0 || ob != 0 || oc != 0 || od != 0)
            {
                int[] value = new int[4] { oa, ob, oc, od };
                for (int i = 0; i < 4; i++)
                    if (counts[i] > 0)
                    {
                        tempCounter = counts[i];
                        tempValue = value[i];
                    }
                return tempValue;
            }
            else
                return tempValue;
        }
        public int compare(int [] neighbour)
        {
            int size = neighbour.Length;
            int[] counts = new int[size];
            for (int i = 0; i < size; i++)
                counts[i] = 0;

            int tempValue = 0, tempCounter = 0;

            for(int i = 0; i < size; i++)
            {
                if (neighbour[i] != 0)
                {
                    counts[i]++;
                    for (int j = i + 1; j < size - 1; j++)
                    {
                        if (neighbour[j] == neighbour[i])
                            counts[i]++;
                    }
                }
                   
                
            }


            int[] value = new int[size];
            for(int i = 0; i < size; i++)
            {
                value[i] = neighbour[i];
            }
            for (int i = 0; i < size; i++)
                if (counts[i] > 0)
                {
                    tempCounter = counts[i];
                    tempValue = value[i];
                }
            //Console.WriteLine(tempValue);
            return tempValue;

        }
        public int compareRules(int[] neighbour,int condition)
        {
            int size = neighbour.Length;
            int[] counts = new int[size];
            for (int i = 0; i < size; i++)
                counts[i] = 0;

            int tempValue = 0, tempCounter = 0;

            for (int i = 0; i < size; i++)
            {
                if (neighbour[i] != 0)
                {
                    counts[i]++;
                    for (int j = i + 1; j < size - 1; j++)
                    {
                        if (neighbour[j] == neighbour[i])
                            counts[i]++;
                    }
                }
            }
            
            int[] value = new int[size];
            for (int i = 0; i < size; i++)
            {
                value[i] = neighbour[i];
            }
            for (int i = 0; i < size; i++)
                //RUELE CONDITION
                if (counts[i] >=condition)
                {
                    tempCounter = counts[i];
                    tempValue = value[i];
                }
            return tempValue;
        }
        
        public int checkColorOfPixel(Color color) //allows to detect color from RGB values
        {
            if (color.R == 255 && color.G == 255 && color.B == 255)
                return 0;
            else if (color.R == 0 && color.G == 0 && color.B == 255)
                return 1;
            else if (color.R == 255 && color.G == 0 && color.B == 0)
                return 2;
            else if (color.R == 152 && color.G == 251 && color.B == 152)
                return 3;
            else if (color.R == 0 && color.G == 139 && color.B == 139)
                return 4;
            else if (color.R == 255 && color.G == 165 && color.B == 0)
                return 5;
            else if (color.R == 127 && color.G == 255 && color.B == 212)
                return 6;
            else if (color.R == 165 && color.G == 42 && color.B == 42)
                return 7;
            else if (color.R == 255 && color.G == 255 && color.B == 0)
                return 8;
            else
                return 0;
        }

        private void menuImportBitmap_Click_1(object sender, EventArgs e) //import bitmap from bmp file
        {
            clearBoard();

            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bitmap = new Bitmap(open.FileName);
                    int width = bitmap.Width;
                    int height = bitmap.Height;
                    pictureBox1.Image = bitmap;
                    
                    for(int  i= 0; i < width; i++)
                    {
                        for(int j = 0; j < height; j++)
                        {
                            cellArray[i, j].setId(checkColorOfPixel(bitmap.GetPixel(i, j)));
                            cellArray[i, j].setDualPhase(0);
                        }
                    }
                    cellsToBitmap(cellArray);
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }
        private void menuImportFile_Click(object sender, EventArgs e) //import bitmap from txt file
        {
            clearBoard();
            int x = 0, y = 0;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(openFileDialog.FileName);
                string line = lines[0];
                string[] values = line.Split('\t');
                x = int.Parse(values[0]);
                y = int.Parse(values[1]);
                Console.WriteLine("X: "+ x);
                Console.WriteLine("Y: "+ y);
                width = x;
                height = y;
                //DZIALA KUR*AAAAAAA
                Console.WriteLine(lines.Length);
                for(int i=1; i < lines.Length; i++)
                {
                    line = lines[i];
                    values = line.Split('\t');
                    x = int.Parse(values[0]);
                    y = int.Parse(values[1]);
                    int z = int.Parse(values[2]);
                    cellArray[x, y].setId(z);
                }
            }
            cellsToBitmap(cellArray);
            //width = tempWidth;
            //height = tempHeight;
        }

        private void menuExportFile_Click(object sender, EventArgs e) //export bitmap to txt file 
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
           

            saveFileDialog.Title = "Save an Image File";
            if (saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                StreamWriter dialog = new StreamWriter(saveFileDialog.FileName);
                dialog.WriteLine(width + "\t" + height);
                for(int i = 0; i<width;i++)
                {
                    for (int j=0;j<height;j++)
                    {
                        dialog.WriteLine(i + "\t" + j + "\t" + cellArray[i, j].getId()+" rgb: "+ cellArray[i, j].getColor());
                    }
                }
                dialog.Close();
            }
        }

        private void menuExportBitmap_Click(object sender, EventArgs e) //export bitmap to bmp file
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(width, height);
                for (int i = 0; i < width; i++)
                    for (int j = 0; j < height; j++)
                        bitmap.SetPixel(i, j, cellArray[i, j].getColor());
                //bitmap.Save("new.png", ImageFormat.Png);
                bitmap.Save(dialog.FileName, ImageFormat.Bmp);
            }
        }

        private void btnInclusionsBefore_Click(object sender, EventArgs e) //insert inclusions
        {
            int inclusionsNumber = Int32.Parse(txtInclusionNumber.Text);
            int counter = 0, rnd1 = 0, rnd2 = 0, error = 0;
            Random random = new Random();
            while (counter < inclusionsNumber)
            {
                rnd1 = random.Next(0, width);
                rnd2 = random.Next(0, height);
                if(comboInclusionType.Text=="Dot")
                {
                    if (cellArray[rnd1, rnd2].getInclusionFlag() == 0)
                    {
                        cellArray[rnd1, rnd2].setInclusionFlag(1);
                        counter++;
                    }
                }
                //inclusions Square:
                else if (comboInclusionType.Text == "Square")
                {
                    int size = Int32.Parse(txtInclusionsSize.Text);
                    if (cellArray[rnd1, rnd2].getInclusionFlag() == 0 &&  rnd1>size && rnd1<(width-size-1) && rnd2>size && rnd2<(height-size-1))
                    {
                        for (int i =-size; i <= size; i++)
                        {
                            for (int j = -size; j <= size; j++)
                            {
                                try
                                {
                                    cellArray[rnd1 + i, rnd2 + j].setInclusionFlag(1);
                                    cellArray[rnd1 + i, rnd2 + j].setColor(Color.Black);
                                }
                                catch
                                {
                                    Console.WriteLine(rnd1 + 1 + " " + rnd2 + 1);
                                }
                                
                            }
                        }
                        counter++;
                    }
                }
                else if (comboInclusionType.Text == "Circle")
                {
                    int size = Int32.Parse(txtInclusionsSize.Text);
                    Console.Write(size + " ");
                    if (cellArray[rnd1, rnd2].getInclusionFlag() == 0 && rnd1 > size && rnd1 < (width - size - 1) && rnd2 > size && rnd2 < (height - size - 1))
                    {
                        Console.Write(rnd1 + "  " + rnd2);
                        for (int i = -size; i <= size; i++)
                        {
                            for (int j = -size; j <= size; j++)
                            {
                                if ( i!=-size && i!=size && j!=-size && j!=size)
                                {
                                    if (size < 0)
                                    {
                                        cellArray[rnd1 + i+1, rnd2 + j+1].setInclusionFlag(1);
                                        cellArray[rnd1 + i+1, rnd2 + j+1].setColor(Color.Black);
                                    }
                                    else if (size > 0)
                                    {
                                        cellArray[rnd1 - i, rnd2 - j].setInclusionFlag(1);
                                        cellArray[rnd1 - i, rnd2 - j].setColor(Color.Black);
                                    }
                                    
                                }
                                else
                                {
                                    cellArray[rnd1, rnd2 + j].setInclusionFlag(1);
                                    cellArray[rnd1, rnd2 + j].setColor(Color.Black);
                                    cellArray[rnd1 + i, rnd2].setInclusionFlag(1);
                                    cellArray[rnd1 + i, rnd2].setColor(Color.Black);
                                }
                                    


                                   // cellArray[rnd1 + i, rnd2 + j].setInclusionFlag(1);
                                    //cellArray[rnd1 + i, rnd2 + j].setColor(Color.Black);

                            }
                        }
                        counter++;
                    }
                }
                else
                {
                    error++;
                }
                if (error >= 1000)
                    break;


            }
            cellsToBitmap(cellArray);
        }

        private void btnGrainBoundaryShapeControl_Click(object sender, EventArgs e) //GRAIN BOUNDRY SHAPE CONTROL GROWN
        {
            Cell[,] cellArrayTemp = new Cell[width, height];
            Random random = new Random();
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                {
                    cellArrayTemp[i, j] = new Cell();
                    cellArrayTemp[i, j].setId(cellArray[i, j].getId());
                }
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                {
                    if (i != 0 && j != 0 && i != width - 1 && j != height - 1)
                    {
                        if (cellArray[i, j].getId() == 0 && cellArray[i, j].getInclusionFlag() == 0)
                        {
                            //RULE 1 - DONE
                            int[] neighbours = new int[] {
                            cellArrayTemp[i - 1, j].getId(),
                            cellArrayTemp[i + 1, j].getId(),
                            cellArrayTemp[i, j - 1].getId(),
                            cellArrayTemp[i, j + 1].getId(),
                            cellArrayTemp[i - 1, j - 1].getId(),
                            cellArrayTemp[i + 1, j - 1].getId(),
                            cellArrayTemp[i - 1, j + 1].getId(),
                            cellArrayTemp[i + 1, j + 1].getId(),
                            };
                            if (compareRules(neighbours,5) != 0)
                                cellArray[i, j].setId(compareRules(neighbours,5));
                                
                            //RULE 2
                            neighbours = new int[] {
                            cellArrayTemp[i - 1, j].getId(),
                            cellArrayTemp[i + 1, j].getId(),
                            cellArrayTemp[i, j - 1].getId(),
                            cellArrayTemp[i, j + 1].getId()
                            };
                            if (compareRules(neighbours,3) != 0)
                                cellArray[i, j].setId(compareRules(neighbours,3));
                               
                            //RULE 3
                            neighbours = new int[] {
                            cellArrayTemp[i - 1, j - 1].getId(),
                            cellArrayTemp[i + 1, j - 1].getId(),
                            cellArrayTemp[i - 1, j + 1].getId(),
                            cellArrayTemp[i + 1, j + 1].getId(),
                            };
                            if (compareRules(neighbours, 3) != 0)
                                cellArray[i, j].setId(compareRules(neighbours, 3));

                            //RULE 4
                            neighbours = new int[] {
                            cellArrayTemp[i - 1, j].getId(),
                            cellArrayTemp[i + 1, j].getId(),
                            cellArrayTemp[i, j - 1].getId(),
                            cellArrayTemp[i, j + 1].getId(),
                            cellArrayTemp[i - 1, j - 1].getId(),
                            cellArrayTemp[i + 1, j - 1].getId(),
                            cellArrayTemp[i - 1, j + 1].getId(),
                            cellArrayTemp[i + 1, j + 1].getId(),
                            };
                            if(compare(neighbours)!=0)
                            {
                                int rnd = random.Next(1, 100);
                                if (Int32.Parse(textBox1.Text)>=rnd)
                                    cellArray[i, j].setId(compare(neighbours));
                            }
                        }
                    }
                }
            cellsToBitmap(cellArray);
        }
        public void checkSizes() //function which can check sizes of phase, inclusion, future-GB
        {
            Colors colors = new Colors();
            int[] colorCounter = new int[colors.getListSize()]; for (int i = 0; i < colors.getListSize(); i++) colorCounter[i] = 0;
            float inclusion = 0;
            float phase = 0;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (cellArray[i,j].getInclusionFlag()==0)
                        if (cellArray[i,j].getId()!=0)
                            phase++;
                    if (cellArray[i, j].getInclusionFlag() == 1)
                        inclusion++;
                }
            }
            lblPhases.Text = Math.Round(100 * (phase / (width * height))).ToString() + " / 100 %";
            lblInclusions.Text = Math.Round(100 * (inclusion / (width * height))).ToString() + " / 100 %";
        }
        private void btnCheckSizes_Click(object sender, EventArgs e) //btn check size of phases and inclusions
        {
            checkSizes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < width-1; i++)
            {
                for (int j = 1; j < height-1; j++)
                {
                    if (cellArray[i, j].getId() != cellArray[i, j + 1].getId())
                    {
                        cellArray[i, j].setGbFlag(1);
                        cellArray[i, j+1].setGbFlag(1);
                    }
                    if (cellArray[i, j].getId() != cellArray[i, j - 1].getId())
                    {
                        cellArray[i, j].setGbFlag(1);
                        cellArray[i, j - 1].setGbFlag(1);
                    }
                    if (cellArray[i, j].getId() != cellArray[i + 1, j].getId())
                    {
                        cellArray[i, j].setGbFlag(1);
                        cellArray[i + 1, j].setGbFlag(1);
                    }
                    if (cellArray[i, j].getId() != cellArray[i - 1, j].getId())
                    {
                        cellArray[i, j].setGbFlag(1);
                        cellArray[i - 1, j].setGbFlag(1);
                    }
                }
            }
            cellsToBitmap(cellArray);

        }

        private void comboInclusionType_SelectedIndexChanged(object sender, EventArgs e) //unvisible size while dot inclusion type is set
        {
            if (comboInclusionType.Text == "Dot")
                txtInclusionsSize.Visible = false;
            else
                txtInclusionsSize.Visible = true;
        }

        private void btnLeaveboundaries_Click(object sender, EventArgs e) //leave boundaries beteween cells
        {
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                {
                    cellArray[i, j].setId(0);
                    cellArray[i, j].setInclusionFlag(0);
                    
                }

            cellsToBitmap(cellArray);
            txtNumberOfGrains.Text = 1000.ToString();
        }

        private int energyOfLattice(Cell[,]cellarray,int i, int j)
        {
            int energy = 0;
            if (cellarray[i, j].color != cellarray[i - 1, j - 1].color)
                energy++;
            if (cellarray[i,j].color!= cellarray[i,j-1].color)
                energy++;
            if (cellarray[i,j].color!= cellarray[i+1,j-1].color)
                energy++;
            if (cellarray[i,j].color!= cellarray[i-1,j].color)
                energy++;
            if (cellarray[i,j].color!= cellarray[i+1,j].color)
                energy++;
            if (cellarray[i,j].color!= cellarray[i-1,j+1].color)
                energy++;
            if (cellarray[i,j].color!= cellarray[i,j+1].color)
                energy++;
            if (cellarray[i,j].color!= cellarray[i+1,j+1].color)
                energy++;
            return energy;
        }

        private void changeColorFromOmega(Cell[,] cellarray, int i, int j)
        {
            List<Color> colorList = new List<Color>();
            if (cellarray[i, j].color != cellarray[i - 1, j - 1].color && cellarray[i - 1, j - 1].color!= Color.White)
                colorList.Add(cellarray[i-1, j-1].color);
            if (cellarray[i, j].color != cellarray[i, j - 1].color && cellarray[i, j - 1].color!=Color.White)
                colorList.Add(cellarray[i, j-1].color);
            if (cellarray[i, j].color != cellarray[i + 1, j - 1].color && cellarray[i + 1, j - 1].color!=Color.White)
                colorList.Add(cellarray[i+1, j-1].color);
            if (cellarray[i, j].color != cellarray[i - 1, j].color && cellarray[i - 1, j].color!=Color.White)
                colorList.Add(cellarray[i-1, j].color);
            if (cellarray[i, j].color != cellarray[i + 1, j].color && cellarray[i + 1, j].color!= Color.White)
                colorList.Add(cellarray[i+1, j].color);
            if (cellarray[i, j].color != cellarray[i - 1, j + 1].color && cellarray[i - 1, j + 1].color!=Color.White)
                colorList.Add(cellarray[i-1, j+1].color);
            if (cellarray[i, j].color != cellarray[i, j + 1].color && cellarray[i, j + 1].color!=Color.White)
                colorList.Add(cellarray[i, j+1].color);
            if (cellarray[i, j].color != cellarray[i + 1, j + 1].color && cellarray[i + 1, j + 1].color!=Color.White)
                colorList.Add(cellarray[i+1, j+1].color);
            if (colorList.Count > 0)
            {
                Random random = new Random();
                int rnd1 = random.Next(0, colorList.Count);
                cellArray[i, j].setColor(colorList[rnd1]);
            }
            
        }

        private void btnMonteCarlo_Click(object sender, EventArgs e)
        {
            Cell[,] cellArrayTemp = new Cell[width, height];
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                {
                    cellArrayTemp[i, j] = cellArray[i, j];
                }
            int iteration = Int32.Parse(txtMCiteration.Text)-2;
            if (iteration == 1) iteration = 1;
            for (int k = 0; k < iteration; k++)
            {
                int sumBefore = 0;
                int sumaAfter = 0;
                double sum = 0;
                double p = Convert.ToDouble(comboMonteCarloP.Text);
                Color tempColor;

                for (int i = 1; i < width - 1; i++)
                {
                    for (int j = 1; j < height - 1; j++)
                    {
                        if (cellArrayTemp[i, j].color != Color.White && cellArrayTemp[i,j].getDualPhase()==0 && cellArrayTemp[i-1, j].getDualPhase() == 0 && cellArrayTemp[i+1, j].getDualPhase() == 0 && cellArrayTemp[i, j-1].getDualPhase() == 0 && cellArrayTemp[i, j+1].getDualPhase() == 0)
                        {
                            tempColor = cellArray[i, j].getColor();      //set temp color (old one)
                            sumBefore = energyOfLattice(cellArrayTemp, i, j);//count sumBefore
                            changeColorFromOmega(cellArrayTemp, i, j);      //change color
                            sumaAfter = energyOfLattice(cellArrayTemp, i, j);//count sumAfter
                            sum = (sumaAfter - sumBefore) * p;
                            if (sum > 0)
                                cellArrayTemp[i, j].setColor(tempColor);
                            //else
                            // cellArray[i, j].setIdFromColor(cellArray[i, j].getColor());
                            //Console.WriteLine("-"+sumBefore+"  -"+sumaAfter+"  -final:"+sum);
                        }
                    }
                }
            }
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    cellArray[i, j].setColor(cellArrayTemp[i, j].getColor());
                }
            }
            cellsToBitmap(cellArray);

        }



        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (cellArray[i, j].getColor() != Color.White)
                    {

                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnMonteCarloBegin_Click(object sender, EventArgs e)
        {
            int numberOfColors = Int32.Parse(txtMCphases.Text);
            int numberOfGrows = width * height;
            Random random = new Random();
            int rnd1 = 0, rnd2 = 0, rnd3 = 0;
            int emptyCells = 0;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (cellArray[i, j].getId() == 0)
                    {
                        rnd1 = random.Next(1, numberOfColors);
                        cellArray[i, j].setId(rnd1);
                    }
                }
            }
            
                cellsToBitmap(cellArray);
        }
            


        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btnCordinates_Click(object sender, EventArgs e) //select cordinates - only phase (x,y) will stay, clear rest
        {

            int x = Int32.Parse(txtX.Text);
            int y = Int32.Parse(txtY.Text);
            Color selectedColor = new Color();
            selectedColor = cellArray[x, y].getColor();

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (cellArray[i, j].getColor() != selectedColor)
                    {
                        cellArray[i, j].setId(0);
                        cellArray[i, j].setDualPhase(0);
                    }
                    if (cellArray[i, j].getColor() == selectedColor)
                    {
                        cellArray[i, j].setDualPhase(1);
                    }
                        
                }
            }
            cellsToBitmap(cellArray);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < width - 1; i++)
            {
                for (int j = 1; j < height - 1; j++)
                {
                    if (cellArray[i, j].getId() != cellArray[i, j + 1].getId())
                    {
                        cellArray[i, j].energy=8;
                    }
                    else if (cellArray[i, j].getId() != cellArray[i, j - 1].getId())
                    {
                        cellArray[i, j].energy = 8;
                    }
                    else if (cellArray[i, j].getId() != cellArray[i + 1, j].getId())
                    {
                        cellArray[i, j].energy = 8;
                    }
                    else if (cellArray[i, j].getId() != cellArray[i - 1, j].getId())
                    {
                        cellArray[i, j].energy = 8;
                    }
                    else
                    {
                        cellArray[i, j].energy = 2;
                    }
                }
            }

            for(int i = 1; i < width; i++)
            {
                for(int j = 0; j < height; j++)
                {
                    if (cellArray[i, j].energy == 8)
                    {
                        cellArray[i, j].setColor(Color.Red);
                    }
                    else
                        cellArray[i, j].setColor(Color.Blue);
                }
            }
            cellsToBitmap(cellArray);
        }

        private void picturebox1_MouseDown(object sender, MouseEventArgs e) // click to clear every phase expect clicked
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                //var imagePos = e.Location; //location of x and y
                int x = e.Location.X;
                int y = e.Location.Y;
                Color selectedColor = new Color();
                selectedColor = cellArray[x, y].getColor();
                for (int i = 0; i < width; i++)
                    for (int j = 0; j < height; j++)
                        if (cellArray[i, j].getColor() != selectedColor)
                            cellArray[i, j].setId(0);
                cellsToBitmap(cellArray);
            }
        }

        private void picturebox1_MouseDownPPM(object sender, MouseEventArgs e) // click to clear every phase expect clicked
        {
            if ((e.Button & MouseButtons.Right) == MouseButtons.Left)
            {
                //var imagePos = e.Location; //location of x and y
                int x = e.Location.X;
                int y = e.Location.Y;
                Color selectedColor = new Color();
                selectedColor = cellArray[x, y].getColor();
                for (int i = 0; i < width; i++)
                    for (int j = 0; j < height; j++)
                        if (cellArray[i, j].getColor() != selectedColor)
                            cellArray[i, j].setId(0);
                cellsToBitmap(cellArray);
            }
        }


        /*public Color GetColorAt(Point location)
        {
            Bitmap screenPixel = new Bitmap(1, 1);
            Graphics gfx = Graphics.FromImage((Image)screenPixel);
             gfx.CopyFromScreen(location.X, location.Y, 0, 0, new Size(1, 1));
            return screenPixel.GetPixel(0, 0);
        }
        Color kolorek = new Color();*/

    }
}






























