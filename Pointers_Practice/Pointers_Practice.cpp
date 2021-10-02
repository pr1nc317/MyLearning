// Pointers_Practice.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

void main()
{
    /*std::cout << "Hello World!\n";
    std::cout << "Hello\n";

    int testPointer = 99;
    int* a = &testPointer;
    printf("\n%d", a);
    printf("\n%d", ++ * a);
    printf("\n%d", *a++);

    a++;
    printf("\n%d", *a);
    printf("\n%d", *(a++));
    printf("\n%d", *a++);
    printf("\n%d", *(a)++);*/


    #pragma region 1D Array

    /*int array[] = { 1, 7, 3, 4, 5, 10 };
    int* pointerArray = array;
    std::cout << "\n\n" << pointerArray;
    std::cout << "\n" << array + 1;
    pointerArray++;
    std::cout << "\n" << pointerArray;
    printf("\n%d", *(pointerArray + 5));
    printf("\n%d", (*pointerArray)++);
    printf("\n%d", (*pointerArray));
    printf("\n%d", array[0]);
    printf("\n%d", array[1]);*/

    #pragma endregion
    
    #pragma region 2D Array

    int array2d[2][3] = { {5, 7, 9}, {11, 13, 15} };
    int (* pointerArray2D)[3] = array2d;

    std::cout << "\n" << array2d << "\n" << &array2d[0];
    std::cout << "\n" << *array2d << "\n" << array2d[0] << "\n" << &array2d[0][0];

    std::cout << "\n" << array2d + 1 << "\n" << &array2d[1];
    std::cout << "\n" << *(array2d + 1) << "\n" << array2d[1] << "\n" << &array2d[1][0];

    #pragma endregion

    
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
