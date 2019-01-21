using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace App3
{
    internal class Colors
    {
        public Color[] colorsList = new Color[]
        {
            Color.White,        //255,255,255
            Color.Blue,         //0,0,255
            Color.Red,          //255,0,0
            Color.PaleGreen,    //152,251,152
            Color.DarkCyan,     //0,139,139
            Color.Orange,       //255,165,0
            Color.Aquamarine,   //127,255,212
            Color.Brown,        //165,42,42
            Color.Yellow        //255,255,0
        };
        public Color getColor(int i)
        {
            return colorsList[i];
        }
        public int getListSize()
        {
            return colorsList.Length;
        }
        /*public int setIdFromColor(Color color)
        {
            int id=0,i=0;
            while (i < colorsList.Length)
            {
                if (color == colorsList[i])
                    id = i;
            }
            return id;
        }*/
    }
}
