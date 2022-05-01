#include <bits/stdc++.h>
#include <vector>
#include <algorithm>
#include <iostream>
#include <fstream>

//#define DEBUG

using namespace std;
#define MAX 100

int n;               //số đỉnh
int ChuaXet[MAX];    //thăm đỉnh
int X[MAX];          //mảng chứa đường đi
int v0;              //đỉnh bắt đầu đi
int data_[MAX][MAX]; //mảng 2 này chứa dữ liệu: trọng số
int sum = 0;         //tổng của 1 đường đi
int select = 999999; //giá trị vô cùng để so sánh với sum trong hàm hamilton
int main_[MAX];      //mảng xuất đường đi ngắn nhất
int nMin;

vector<int> dinhSelect;
bool flag[MAX];
vector<int> min_Path; //lưu đường đi thỏa

void docFile();       //đọc file
void Hamilton(int k); //chạy hamilton
void Xuat();          //xuất tất cả đường đi
void xuat();          //xuất 1 đường đi cần tìm
void Select_V();      ///Nhập các đỉnh muốn đi qua vào vector

int main(int argc, char const *argv[])
{
    docFile(); //thực hiện đọc data từ file

    Select_V();

    //gán tất cả các giá trị bằng 1 tương ứng với đỉnh chưa thăm
    for (int v = 1; v <= n; v++)
    {
        ChuaXet[v] = 1;
    } /**/
    for (int i = 1; i <= n; i++)
    {
        //gán tất cả các giá trị bằng 1 tương ứng với đỉnh chưa thăm
        for (int v = 1; v <= n; v++)
        {
            ChuaXet[v] = 1;
        }
        v0 = i;
        X[1] = i;       //gán vị trí đầu tiên là v0 trong mảng đường đi
        ChuaXet[i] = 0; //đã thăm v0
        Hamilton(2);    //thực hiện hamil
        cout << endl
             << "==========================" << endl;
    }
    xuat(); //xuất đường đi nhỏ nhất*/
    return 0;
}

void Hamilton(int k)
{
    for (int i = 1; i <= n; i++)
    {

        if (data_[X[k - 1]][i] != 0)
        {
            //cout << data_[X[k-1]][i] << " ";
            int y = i; //lấy giá trị của các cạnh kề với đỉnh X[k-1]

            //kiểm tra điều kiện out.
            if ((k == n + 1) && (y == v0))
            {
                //tính tổng của từng đường đi, qa mỗi trường hợp
                X[n + 1] = v0;
                for (int j = 1; j < n + 1; j++)
                {
                    sum += data_[X[j]][X[j + 1]];
                    flag[X[j]] = false;
                    flag[X[j + 1]] = false;

                    min_Path.push_back(X[j]);

                    int count_ = count(flag + 1, flag + n - 1, true);
                    if (count_ == 0)
                    {
                        min_Path.push_back(X[j + 1]);
                        cout << "Sum: " << sum << endl;
                        for (int x : min_Path)
                        {
                            cout << x << " -> ";
                        }
                        cout << endl;
                        break;
                    }
                }
                if (select > sum)
                {
                    select = sum;
                    for (int k = 0; k < min_Path.size(); k++)
                    {
                        main_[k] = min_Path.at(k);
                    }
                    nMin = min_Path.size();
                }
                min_Path.clear();
                for (int x : dinhSelect)
                {
                    flag[x] = true;
                }
                sum = 0;
            }
            else if (ChuaXet[y]) //nếu đỉnh y chưa thăm
            {
                X[k] = y;        //thêm đỉnh vào mảng đường đi
                ChuaXet[y] = 0;  // đã thăm y
                Hamilton(k + 1); //chạy hamilton cho k+1, xét những đỉnh kề với X[k]
                ChuaXet[y] = 1;  //sau khi chạy xong hamilton với trường hợp i=...
                //thì quay lại chưa thăm y để xét tiếp trường hợp i++
            }
        }
    }
}

void Select_V()
{
    cout << "Nhap so dinh muon di qua: ";
    int count;
    cin >> count;
    while (count > 0)
    {
        --count;
        int nhap;
        cout << "Nhap dinh: ";
        cin >> nhap;
        dinhSelect.push_back(nhap);
        flag[nhap] = true;
    }
    cout << "Success!!!" << endl;
}

void xuat() //xuất đường đi nhỏ nhất
{
    cout << "Value: " << select << endl;
    for (int i = 0; i < nMin; i++)
    {
        cout << main_[i] << " --> ";
    }
}

void Xuat() //xuất đường đi
{
    for (int i = 1; i < n + 1; i++)
    {
        cout << X[i] << " --> ";
    }
    cout << X[n + 1] << endl;
    cout << "==========" << endl;
}

void docFile() //đọc file từ .txt
{
    ifstream file;
    file.open("hamil_new.txt");
    file >> n;
    //đưa các đỉnh vào vector ke
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= n; j++)
        {
            file >> data_[i][j];
        }
    }
    file.close();
}
