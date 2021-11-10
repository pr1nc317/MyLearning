// Merge Overlapping Intervals.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <vector>

using namespace std;

int main()
{
    std::cout << "Hello World!\n";
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

/**
 * Definition for an interval.
 * struct Interval {
 *     int start;
 *     int end;
 *     Interval() : start(0), end(0) {}
 *     Interval(int s, int e) : start(s), end(e) {}
 * };
 */

bool comparer(Interval a, Interval b)
{
    return a.start < b.start;
}
vector<Interval> Solution::merge(vector<Interval>& v) {
    // Do not write main() function.
    // Do not read input, instead use the arguments to the function.
    // Do not print the output, instead return values as specified
    // Still have a doubt. Checkout www.interviewbit.com/pages/sample_codes/ for more details

    sort(v.begin(), v.end(), comparer);
    vector<Interval> ans;
    int n = v.size();
    for (int i = 0; i < n - 1; i++)
    {
        if (v[i].end >= v[i + 1].start)
        {
            v[i + 1].start = min(v[i].start, v[i + 1].start);
            v[i + 1].end = max(v[i].end, v[i + 1].end);
        }
        else
        {
            ans.push_back(v[i]);
        }
    }
    ans.push_back(v[n - 1]);
    return ans;
}
