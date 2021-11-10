// MergeIntervals.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <vector>

using namespace std;

int main()
{
    std::cout << "Hello World!\n";
}

vector<Interval> insert(vector<Interval>& v, Interval i)
{
    // Do not write main() function.
    // Do not read input, instead use the arguments to the function.
    // Do not print the output, instead return values as specified
    // Still have a doubt. Checkout www.interviewbit.com/pages/sample_codes/ for more details

    vector<Interval> ans;
    int n = v.size();
    int start = i.start; int end = i.end;
    bool check = false;
    for (int i = 0; i < n; i++)
    {
        if (v[i].end < start)
        {
            ans.push_back(v[i]);
        }
        else if (v[i].start > end)
        {
            if (!check) ans.push_back({ start,end });
            check = true;
            ans.push_back(v[i]);
        }
        else
        {
            start = min(start, v[i].start);
            end = max(end, v[i].end);
        }
    }
    if (!check)
    {
        ans.push_back({ start,end });
    }
    return ans;
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