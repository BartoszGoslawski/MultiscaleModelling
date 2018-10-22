#include <iostream>
#include <fstream>
#include <cstdlib>
#include <time.h>



using namespace std;
//const int sizeXY=12;
void inicialization(){
srand(time(NULL));
}
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

int compare3(int oa, int ob, int oc){ //'t' means tabTemp, 'o' means tab(original tab)
    int counts[3]={0,0,0};
    int tempValue=0, tempCounter=0;
    //Compare first element with 2 other (if equal counts++).
    //Then compare 2nd only with 3rd. And if 3 != 0 just increase his counter.
    if (oa!=0){
        counts[0]++;
        if(oa==ob)    counts[0]++;
        if(oa==oc)    counts[0]++;
    }
    if (ob!=0){
        counts[1]++;
        if(ob==oc)    counts[1]++;
        }
    if (oc!=0){
        counts[2]++;
    }

    int value[3];
    value[0]=oa;
    value[1]=ob;
    value[2]=oc;
    for(int i=0; i<3; i++){
        if(counts[i]>tempCounter){
            tempCounter=counts[i];
            tempValue=value[i];
            if (tempValue==value[0]){
//srand
            }
        }
    }
    cout<<"Most common value: "<<tempValue<<endl;
    return tempValue;

}

int compare4(int oa, int ob, int oc, int od){ //'t' means tabTemp, 'o' means tab(original tab)
    int counts[4] ={0,0,0,0};

    int tempValue=0, tempCounter=0;

    if (oa!=0){
        counts[0]++;
        if(oa==ob)    counts[0]++;
        if(oa==oc)    counts[0]++;
        if(oa==od)    counts[0]++;
    }
    if (ob!=0){
        counts[1]++;
        if(ob==oc)    counts[1]++;
        if(ob==od)    counts[1]++;
    }
    if (oc!=0){
        counts[2]++;
        if(oc==od)  counts[2]++;
    }
    if (od!=0){
        counts[3]++;
    }

    int value[4];
    value[0]=oa;
    value[1]=ob;
    value[2]=oc;
    value[3]=od;
    for(int i=0; i<4; i++){
        if(counts[i]>tempCounter){
            tempCounter=counts[i];
            tempValue=value[i];
            //if (tempValue==value[0]){}
//srand

        }
    }
    cout<<"Most common value: "<<tempValue<<endl;
    return tempValue;

}


void vonNeuman(int **tab, int sizeXY){
    int**tabTemp = new int*[sizeXY];         //new 2d array
    for(int i=0; i<sizeXY; i++)
        tabTemp[i]=new int [sizeXY];
    copyArray(tab,tabTemp,sizeXY);           //copy values to tabTemp
    cout<<"Original array:"<<endl;
    printArray(tabTemp, sizeXY);
    for(int i=0; i<sizeXY; i++){
        for(int j=0; j<sizeXY; j++){
            if(tabTemp[i][j]==0){
                int abc[3][2];
                int tempCounter=0;
                int tempValue=0;
                 // ***********ELEMENTY NAROZNE*************
                if(i==0 && j==0){                               //0,0 element
                    if(tab[i][j+1]!=0)
                       tabTemp[i][j]=tabTemp[i][j+1];
                    else if(tab[i+1][j]!=0)
                        tabTemp[i][j]=tabTemp[i+1][j];
                }
                else if(i==sizeXY-1 && j==sizeXY-1){               //sizeXY,sizeXY element
                    if(tab[i][j-1]!=0)
                        tabTemp[i][j]=tabTemp[i][j-1];
                    else if(tab[i-1][j]!=0)
                        tabTemp[i][j]=tabTemp[i-1][j];
                }
                else if(i==0 && j==sizeXY-1){               //0,sizeXY element
                    if(tab[i][j-1]!=0)
                        tabTemp[i][j]=tabTemp[i][j-1];
                    else if(tab[i+1][j]!=0)
                        tabTemp[i][j]=tabTemp[i+1][j];
                }
                else if(i==sizeXY-1 && j==0){               //sizeXY,0 element
                    if(tab[i][j+1]!=0)
                        tabTemp[i][j]=tabTemp[i][j+1];
                    else if(tab[i-1][j]!=0)
                        tabTemp[i][j]=tabTemp[i-1][j];
                }
               // ***********************ELEMENTY NA KRAWEDZI***********
                if(i==0 && j!=0 && j!=sizeXY-1){
                                        // top
                    if(tabTemp[i][j-1]!=0 || tabTemp[i+1][j]!=0 || tabTemp[i][j+1]!=0){ //if any neighbour !=0
                        cout<<"Element:"<<i<<","<<j<<"  left:"<<tab[i][j-1]<<"  bot:"<<tab[i+1][j]<<"  right:"<<tab[i][j+1]<<endl;
                        tabTemp[i][j]=compare3(tab[i][j-1],tab[i+1][j],tab[i][j+1]);
                    }
                }

                else if(i==sizeXY-1 && j!=0 && j!=sizeXY-1){
                                        // bot
                    if(tabTemp[i][j-1]!=0 || tabTemp[i-1][j]!=0 || tabTemp[i][j+1]!=0){ //if any neighbour !=0
                        cout<<"Element:"<<i<<","<<j<<"  left:"<<tab[i][j-1]<<"  bot:"<<tab[i-1][j]<<"  right:"<<tab[i][j+1]<<endl;
                        tabTemp[i][j]=compare3(tab[i][j-1],tab[i-1][j],tab[i][j+1]);
                    }
                }

                else if(j==0 && i!=0 && i!=sizeXY-1){
                                        // top
                    if(tabTemp[i-1][j]!=0 || tabTemp[i+1][j]!=0 || tabTemp[i][j+1]!=0){ //if any neighbour !=0
                        cout<<"Element:"<<i<<","<<j<<"  top:"<<tab[i-1][j]<<"  bot:"<<tab[i+1][j]<<"  right:"<<tab[i][j+1]<<endl;
                        tabTemp[i][j]=compare3(tab[i-1][j],tab[i+1][j],tab[i][j+1]);
                    }
                }

                else if(j==sizeXY-1 && i!=0 && i!=sizeXY-1){
                                        // bot
                    if(tabTemp[i+1][j]!=0 || tabTemp[i-1][j]!=0 || tabTemp[i][j-1]!=0){ //if any neighbour !=0
                        cout<<"Element:"<<i<<","<<j<<"  top:"<<tab[i-1][j]<<"  bot:"<<tab[i+1][j]<<"  left:"<<tab[i][j-1]<<endl;
                        tabTemp[i][j]=compare3(tab[i+1][j],tab[i-1][j],tab[i][j-1]);
                    }
                }
                // ***********************ELEMENTY W SRODKU***********
                if(i!=0 && i!=sizeXY-1 && j!=0 && j!=sizeXY-1){
                    if(tabTemp[i-1][j]!=0 || tabTemp[i][j+1]!=0 || tabTemp[i+1][j]!=0 || tabTemp[i][j-1]!=0 ){
                        cout<<"Element:"<<i<<","<<j<<"  top:"<<tab[i-1][j]<<"  right:"<<tab[i][j+1]<<"  bot:"<<tab[i+1][j]<<" left:"<<tab[i][j-1]<<endl;
                        tabTemp[i][j]=compare4(tab[i-1][j],tab[i][j+1],tab[i+1][j],tab[i][j-1]);
                    }
                }
            }
        }
    }
    copyArray(tabTemp,tab,sizeXY);
    cout<<"\n"<<"vonNeuman array:"<<endl;
    printArray(tab, sizeXY);
    for(int i=0; i<sizeXY; i++)
        delete [] tabTemp[i];
}

int loadArraySize(string fileName){
    ifstream plik;
    plik.open( fileName.c_str() );
    if( !plik.good() )
         return false;
    int arraySize;
    plik >> arraySize;
    cout<<"rozmiar: "<< arraySize<<"\n";
    return arraySize;
}

int loadArray(string fileName, int **tab, int sizeXY){
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
             break;

    }
}

bool safeArray(int **tab)
{/*
    ofstream plik("fileNew.txt");
    plik.open("fileNew.txt", ios::in);

    if(plik.good())
    {
        int licznik=0;
        string line;
        while(!plik.eof()){
            getline(plik, line);
            liczby[licznik]=atof(linia.c_str());
            licznik++;
        }
    }
    plik.close();
    int licznik=0;
    while(!plik.eof())
    {
        getline(plik, linia);
        liczby[licznik]=atof(linia.c_str());
        licznik++;
    }*/
}

unsigned char* ReadBMP(char* filename)
{
    int i;
    FILE* f = fopen(filename, "rb");

    if(f == NULL)
        throw "Argument Exception";

    unsigned char info[54];
    fread(info, sizeof(unsigned char), 54, f); // read the 54-byte header

    // extract image height and width from header
    int width = *(int*)&info[18];
    int height = *(int*)&info[22];

    cout << endl;
    cout << "  Name: " << filename << endl;
    cout << "Width: " << width << endl;
    cout << "Height: " << height << endl;

    int row_padded = (width*3 + 3) & (~3);
    unsigned char* data = new unsigned char[row_padded];
    unsigned char tmp;
    int ij = 0;

    for(int i = 0; i < height; i++)
    {
        fread(data, sizeof(unsigned char), row_padded, f);
        for(int j = 0; j < width*3; j += 3)
        {
            // Convert (B, G, R) to (R, G, B)
            tmp = data[j];
            data[j] = data[j+2];
            data[j+2] = tmp;

            cout << "R: "<< (int)data[j] << " G: " << (int)data[j+1]<< " B: " << (int)data[j+2]<< endl;
        } ij++;
    }

    fclose(f);
    cout<<"wysokosc chujku:"<<ij;
    return data;
}

int main()
{
    inicialization();
    //CHECK SIZE, CREATE ARRAY
    int sizeXY = loadArraySize("C:/Users/thebapo/Desktop/agh/MM. Multiscale modelling/lab1_2/plik.txt");             //array size
    int**tab = new int*[sizeXY];         //new 2d array
    for(int i=0; i<sizeXY; i++)
        tab[i]=new int [sizeXY];
    clearArray(tab, sizeXY);

    // LOAD ARRAY FROM FILE
    loadArray("C:/Users/thebapo/Desktop/agh/MultiscaleModelling/plikSkos.txt", tab, sizeXY);

    //MAIN FUNCTION
    vonNeuman(tab,sizeXY);


    ReadBMP("C:/Users/thebapo/Desktop/agh/MultiscaleModelling/picture.bmp");


    return 0;
    cout << "Hello world!" << endl;
    return 0;
}
