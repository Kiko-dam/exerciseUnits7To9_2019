#include <iostream>

using namespace std;

int main()
{
    const int total = 10;
    int numbers[total];
    int increment = 0;
    int decrement = 0;
    
    cout << "Welcome, enter  possitive numbers." << endl;
    
        for(int i = 0; i < total; i++)
        {
            cout << "Enter the data" << " "<< i + 1 << endl;
            cin >> numbers[i];
            
            if(numbers[i] < 0)
                {
                    cout<< "Enter only possitive data." << endl;
                    i--;
                }
        } 
        for(int r = 0; r < total-1 ;r++)
        {
            if(numbers[r] < numbers[r+1])
            {
                increment++;
            }
            
            else if(numbers[r] > numbers[r+1])
            {
                decrement++;
            }
            
        }
        cout << "Increments " << increment << endl;
        cout << "Decrements " << decrement << endl;
}
