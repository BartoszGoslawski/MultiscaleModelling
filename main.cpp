#include <iostream>
#include <fstream>
using namespace std;
//const int sizeXY=12;

void clearArray(int **tab, int sizeXY){
    for(int i=0; i<sizeXY; i++){
        for(int j=0; j<sizeXY; j++)
            tab[i][j]=0;
    }
}
void printArray(int **tab, int sizeXY){
    for(int i=0; i<sizeXY; i++){
        for(int j=0; j<sizeXY; j++)
            cout<<tab[i][j]<<"   ";
        cout<<"\n\n";
    }
}
void copyArray(int **tabCopyFrom, int**tabCopyTo, int sizeXY){
    for(int i=0; i<sizeXY; i++){
        for(int j=0; j<sizeXY; j++)
            tabCopyTo[i][j]=tabCopyFrom[i][j];
    }
}
void vonNeuman(int **tab, int sizeXY){
    int**tabTemp = new int*[sizeXY];         //new 2d array
    for(int i=0; i<sizeXY; i++)
        tabTemp[i]=new int [sizeXY];
    copyArray(tab,tabTemp,sizeXY);           //copy values to tabTemp
    cout<<"Original array:"<<endl;
    printArray(tabTemp, sizeXY);
    int lrtb[4][2];                          //left,right,top,bot values and counter for every of them
    lrtb[0][1]=lrtb[1][1]=lrtb[2][1]=lrtb[3][1]=0;  //clear lrtb values counters
    for(int i=0; i<sizeXY; i++){
        for(int j=0; j<sizeXY; j++){
            if(tabTemp[i][j]==0){

                if(i==0 && j==0){                               //0,0 element
                    if(tabTemp[i][j+1]!=0)
                       tabTemp[i][j]=tabTemp[i][j+1];
                    else if(tabTemp[i+1][j]!=0)
                        tabTemp[i][j]=tabTemp[i+1][j];
                }
                else if(i==sizeXY-1 && j==sizeXY-1){               //sizeXY,sizeXY element
                    if(tabTemp[i][j-1]!=0)
                        tabTemp[i][j]=tabTemp[i][j-1];
                    else if(tabTemp[i-1][j]!=0)
                        tabTemp[i][j]=tabTemp[i-1][j];
                }
                else if(i==0 && j==sizeXY-1){               //sizeXY,sizeXY element
                    if(tabTemp[i][j-1]!=0)
                        tabTemp[i][j]=tabTemp[i][j-1];
                    else if(tabTemp[i+1][j]!=0)
                        tabTemp[i][j]=tabTemp[i+1][j];
                }
                else if(i==sizeXY-1 && j==0){               //sizeXY,sizeXY element
                    if(tabTemp[i][j+1]!=0)
                        tabTemp[i][j]=tabTemp[i][j+1];
                    else if(tabTemp[i-1][j]!=0)
                        tabTemp[i][j]=tabTemp[i-1][j];
                }
                // ELEMENTY NAROZNE ^
                else if(i==0 && j!=0){                      // jesli mamy element skrajny na gorze
                    if(tabTemp[i][j-1]!=0 || tabTemp[i][j+1]!=0 || tabTemp[i+1][j]!=0){ //jesli choc jeden sasiad !=0

                    }
                }



            }
        }
    }

    /*for(int i=1; i<sizeXY-1; i++){
        for(int j=1; j<sizeXY-1; j++){
            lrtb[0][0] = tab[i-1][j];
            lrtb[1][0] = tab[i][j-1];
            lrtb[2][0] = tab[i][j+1];
            lrtb[3][0] = tab[i+1][j];       //take left,r,t,b to [4][2] array;

            if(tab[i][j]==0 && (lrtb[0][0]!=0 || lrtb[1][0]!=0 || lrtb[2][0]!=0 || lrtb[3][0]!=0))
            {

            }

            lrtb[0][0]=lrtb[1][0]=lrtb[2][0]=lrtb[3][0] = 0;
        }

    }*/
    copyArray(tabTemp,tab,sizeXY);
    cout<<"\n"<<"vonNeuman array:"<<endl;
    printArray(tab, sizeXY);
    for(int i=0; i<sizeXY; i++)
        delete [] tabTemp[i];
}

int loadArraySize(string fileName)
{
    ifstream plik;
    plik.open( fileName.c_str() );
    if( !plik.good() )
         return false;
    int arraySize;
    plik >> arraySize;
    cout<<"rozmiar: "<< arraySize;
    return arraySize;
}

int loadArray(string fileName, int **tab, int sizeXY)
{
    ifstream plik;
    plik.open( fileName.c_str() );
    if( !plik.good() )
         return false;

    int x, y, value;
    plik >> x >> x;

    while( true ){
        if( plik.good() )
        {
            plik>> x >> y >> value;
            tab[x][y]=value;
        }
        else
             break; //zakoñcz wczytywanie danych - wyst¹pi³ jakiœ b³¹d (np. nie ma wiêcej danych w pliku)

    } //while
}

int main()
{
    int sizeXY = loadArraySize("C:/Users/thebapo/Desktop/agh/MM. Multiscale modelling/lab1_2/plik.txt");             //array size
    int**tab = new int*[sizeXY];         //new 2d array
    for(int i=0; i<sizeXY; i++)
        tab[i]=new int [sizeXY];
    clearArray(tab, sizeXY);

    loadArray("C:/Users/thebapo/Desktop/agh/MM. Multiscale modelling/lab1_2/plik.txt", tab, sizeXY);
    /*tab[1][0]=2;
    tab[1][4]=2;
    tab[3][0]=2;
    tab[3][4]=2;
    tab[0][1]=7;
    tab[4][1]=7;
    tab[0][3]=7;
    tab[4][3]=7;*/

    vonNeuman(tab,sizeXY);
    //vonNeuman2(tab,sizeXY);


    return 0;
    cout << "Hello world!" << endl;
    return 0;
}
