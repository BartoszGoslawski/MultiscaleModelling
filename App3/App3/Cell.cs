using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace App3
{
    public class Cell
    {
        private int id;
        public Color color;
        Colors colors = new Colors();
        public int inclusionFlag = 0;
        public int gb = 0;
        public int dualPhase =0;
        public int energy = 0;

        public Cell(){
            id = 0;
            color = colors.getColor(id);
            inclusionFlag=0;
            gb = 0;
            dualPhase = 0;
            energy = 0;
        }
        public void setDualPhase(int i)
        {
            dualPhase = i;
        }
        public int getDualPhase()
        {
            return dualPhase;
        }

        public void setId(int i){
            id = i;
            color = colors.getColor(i);
            if (i == 0)
                dualPhase = 0;
        }
        public int getId() {
            return id;
        }

        public void setColor(Color i){
            color = i;
        }
        public Color getColor(){
            return color;
        }

        public void setInclusionFlag(int inf)
        {
            inclusionFlag = inf;
            if (inclusionFlag == 1)
                setColor(Color.Black);
        }
        public int getInclusionFlag()
        {
            return inclusionFlag;
        }
        public void setGbFlag(int inf)
        {
            gb = inf;
            if (gb == 1)
                setColor(Color.Black);
        }
        public int getGbFlag()
        {
            return gb;
        }

        public int setIdFromColor(Color color)
        {
            int id = 0, i = 0;
            while (i < colors.colorsList.Length)
            {
                if (color == colors.colorsList[i])
                    id = i;
            }
            return id;
        }
    }
    
}
