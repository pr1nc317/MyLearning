namespace Repeat_and_Missing_Number_Array
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Solution
    {
        public static bool DetectIfCountGreaterThanOne(this List<int> A, int x)
        {
            int count = 0;
            for (int i = 0; i < A.Count; i++)
            {
                if (x == A[i])
                    count++;
                if (count > 1)
                    return true;
            }
            return false;
        }

        public static List<int> RepeatedNumber(List<int> A)
        {
            #region Solution 1 - Using extension methods - O(n^2) time and constant space
            //var list = new List<int>();
            //int x = 0, y = 0;
            //for (int i = 0; i < A.Count; i++)
            //{
            //    if (x == 0)
            //    {
            //        if (A.DetectIfCountGreaterThanOne(A[i]))
            //        {
            //            x = A[i];
            //        }
            //    }
            //    if (y == 0)
            //    {
            //        if (!A.Contains(i+1))
            //        {
            //            y = i + 1;
            //        }
            //    }
            //}
            //list.Add(x); list.Add(y);
            //return list;
            #endregion

            #region Solution 2 - Use elements as Index and mark the visited places - O(n) time and constant space
            //int repeatedNum = 0, missingNum = 0;
            //for (int i = 0; i < A.Count; i++)
            //{
            //    int absVal = Math.Abs(A[i]);
            //    if (A[absVal - 1] > 0)
            //        A[absVal - 1] = -A[absVal - 1];
            //    else if (A[absVal - 1] < 0)
            //        repeatedNum = absVal;
            //}

            //for (int i = 0; i < A.Count; i++)
            //{
            //    if (A[i] > 0) missingNum = i + 1;
            //}
            //return new List<int> { repeatedNum, missingNum };
            #endregion

            #region Solution 3 - Use Sorting
            // Approach:
            // Sort the input array.
            // Traverse the array and check for missing and repeating.
            // Time Complexity: O(nLogn)

            //int repeatedNum = 0, missingNum = 0;
            //A.Sort();
            //for (int i = 0; i < A.Count - 1; i++)
            //{
            //    if (A[i] == A[i + 1])
            //    {
            //        repeatedNum = A[i];
            //    }
            //    if (!A.Contains(i + 1))
            //    {
            //        missingNum = i + 1;
            //    }
            //}
            //return new List<int> { repeatedNum, missingNum };
            #endregion

            #region Solution 4 - Using Count Array
            /*
            Approach: 

            Create a temp array temp[] of size n with all initial values as 0.
            Traverse the input array arr[], and do following for each arr[i] 
            if(temp[arr[i]] == 0) temp[arr[i]] = 1;
            if(temp[arr[i]] == 1) output “arr[i]” //repeating
            Traverse temp[] and output the array element having value as 0 (This is the missing element)
            
            Time Complexity: O(n)
            Auxiliary Space: O(n)
             */
            int n = A.Count;
            int[] temp = new int[n];
            int repeatedNum = 0, missingNum = 0;
            for (int i = 0; i < n; i++)
            {
                if (temp[A[i] - 1] == 0)
                    temp[A[i] - 1] = 1;
                else if (temp[A[i] - 1] == 1) 
                    repeatedNum = A[i];
            }
            for (int i = 0; i < n; i++)
            {
                if (temp[i] == 0)
                    missingNum = i + 1;
            }
            return new List<int> { repeatedNum, missingNum };
            #endregion

            #region Solution 5 - Make two equations
            /*
            Approach:

            Let x be the missing and y be the repeating element.
            Get the sum of all numbers using formula S = n(n+1)/2 – x + y
            Get product of all numbers using formula P = 1*2*3*…*n * y / x
            The above two steps give us two equations, we can solve the equations and get the values of x and y.
            Time Complexity: O(n)
            Thanks to disappearedng for suggesting this solution. 

            Note: This method can cause arithmetic overflow as we calculate product and sum of all array elements.
             */
            #endregion

            #region Solution 6 - Using sum of array elements and sum of squares of array elements equations
            /*
            Approach:

            Let x be the missing and y be the repeating element.
            Let N is the size of array.
            Get the sum of all numbers using formula S = N(N+1)/2
            Get the sum of square of all numbers using formula Sum_Sq = N(N+1)(2N+1)/6
            Iterate through a loop from i=1….N
            S -= A[i]
            Sum_Sq -= (A[i]*A[i])
            It will give two equations 
            x-y = S – (1) 
            x^2 – y^2 = Sum_sq 
            x+ y = (Sum_sq/S) – (2) 
 
            Time Complexity: O(n) 
             */
            #endregion

            #region Solution 7 - Using a Dictionary or a Map
            /*
            Approach: 
            This method involves creating a Hashtable with the help of Map. In this, the elements are mapped to their natural index. 
            In this process, if an element is mapped twice, then it is the repeating element. 
            And if an element’s mapping is not there, then it is the missing element.
             */
            #endregion
        }

        static void Main(string[] args)
        {
            RepeatedNumber(new List<int> { 759, 752, 892, 304, 10, 305, 106, 557, 205, 292, 362, 28, 756, 754, 872, 778, 178, 291, 198, 331, 191, 616, 47, 625, 629, 853, 503, 425, 78, 408, 9, 39, 394, 207, 427, 880, 223, 693, 492, 116, 662, 80, 646, 626, 495, 763, 555, 286, 415, 100, 615, 447, 71, 500, 400, 698, 873, 234, 765, 416, 262, 535, 520, 218, 546, 649, 694, 818, 19, 654, 411, 368, 303, 845, 246, 856, 37, 343, 221, 783, 601, 843, 862, 848, 392, 341, 45, 846, 449, 714, 180, 877, 775, 465, 277, 204, 136, 114, 552, 407, 437, 828, 607, 316, 241, 813, 445, 232, 23, 94, 564, 915, 788, 379, 410, 202, 260, 426, 691, 166, 404, 580, 637, 866, 231, 904, 18, 239, 459, 901, 349, 281, 684, 52, 611, 361, 147, 167, 784, 435, 732, 664, 677, 824, 139, 203, 213, 130, 469, 530, 56, 852, 748, 377, 569, 364, 466, 736, 399, 902, 482, 301, 851, 63, 254, 200, 266, 830, 41, 14, 832, 668, 332, 159, 439, 484, 119, 758, 559, 310, 253, 397, 859, 627, 806, 62, 622, 146, 81, 2, 641, 51, 105, 390, 443, 740, 354, 558, 89, 263, 755, 386, 638, 905, 378, 844, 315, 728, 706, 43, 631, 645, 860, 817, 567, 501, 870, 99, 721, 553, 269, 151, 850, 750, 280, 185, 184, 888, 526, 31, 20, 32, 418, 236, 480, 460, 584, 735, 235, 140, 545, 518, 712, 797, 505, 746, 50, 452, 602, 240, 247, 572, 665, 893, 417, 376, 244, 803, 802, 76, 237, 704, 302, 723, 371, 4, 102, 857, 798, 49, 762, 389, 83, 667, 838, 887, 289, 620, 571, 760, 861, 471, 61, 713, 75, 346, 187, 233, 592, 682, 95, 369, 181, 243, 186, 895, 834, 800, 502, 161, 847, 885, 653, 430, 916, 488, 899, 816, 249, 182, 458, 327, 841, 59, 676, 491, 554, 659, 776, 17, 786, 671, 780, 468, 594, 849, 917, 908, 259, 716, 890, 475, 60, 652, 82, 493, 636, 85, 508, 812, 533, 536, 46, 689, 598, 444, 751, 34, 385, 576, 670, 211, 73, 419, 455, 805, 563, 162, 479, 477, 150, 282, 128, 779, 630, 320, 345, 423, 396, 11, 642, 53, 272, 7, 579, 685, 539, 225, 868, 322, 744, 323, 796, 174, 562, 473, 176, 278, 699, 839, 374, 842, 148, 33, 414, 581, 27, 201, 494, 504, 58, 506, 283, 647, 782, 296, 863, 25, 227, 129, 250, 522, 127, 42, 311, 919, 382, 597, 661, 133, 208, 574, 710, 226, 93, 69, 695, 328, 64, 511, 16, 920, 155, 101, 708, 585, 36, 720, 450, 487, 799, 711, 462, 697, 403, 729, 321, 342, 265, 317, 192, 701, 29, 384, 432, 894, 809, 792, 734, 703, 658, 456, 299, 295, 517, 855, 131, 854, 440, 810, 98, 790, 639, 612, 547, 586, 648, 229, 193, 727, 312, 688, 92, 112, 21, 333, 635, 833, 66, 113, 15, 194, 588, 773, 84, 318, 831, 772, 420, 719, 380, 777, 604, 722, 135, 30, 515, 358, 766, 442, 910, 428, 55, 804, 77, 308, 363, 457, 340, 789, 733, 632, 700, 197, 214, 911, 261, 134, 521, 807, 903, 336, 219, 398, 276, 715, 157, 548, 696, 216, 375, 405, 768, 125, 413, 570, 669, 795, 483, 245, 3, 168, 656, 217, 605, 730, 351, 441, 801, 835, 307, 827, 556, 560, 583, 109, 785, 678, 406, 900, 575, 96, 690, 724, 820, 867, 794, 747, 651, 8, 681, 692, 170, 525, 884, 738, 623, 434, 542, 527, 156, 891, 177, 808, 258, 814, 314, 454, 339, 673, 103, 921, 534, 881, 165, 68, 122, 87, 359, 431, 115, 918, 79, 914, 284, 412, 573, 190, 618, 883, 365, 344, 309, 516, 826, 530, 485, 373, 188, 499, 290, 675, 294, 220, 858, 357, 86, 209, 461, 875, 287, 864, 111, 663, 811, 549, 507, 707, 561, 619, 350, 793, 672, 5, 825, 242, 401, 822, 749, 634, 741, 297, 725, 913, 496, 256, 726, 215, 171, 829, 121, 476, 108, 1, 117, 149, 175, 324, 640, 657, 355, 298, 224, 273, 255, 153, 650, 12, 257, 587, 26, 44, 118, 683, 230, 300, 874, 628, 633, 391, 367, 774, 680, 513, 271, 643, 172, 666, 821, 823, 179, 550, 463, 338, 787, 566, 313, 599, 402, 565, 306, 909, 274, 13, 739, 679, 771, 453, 753, 486, 67, 541, 285, 123, 577, 388, 144, 293, 781, 764, 769, 621, 366, 383, 907, 124, 372, 72, 35, 173, 606, 519, 451, 353, 54, 348, 617, 761, 152, 137, 132, 836, 514, 409, 70, 370, 387, 524, 6, 88, 163, 160, 718, 745, 472, 869, 40, 481, 248, 551, 889, 898, 709, 886, 897, 268, 912, 154, 478, 538, 819, 467, 97, 644, 596, 104, 251, 206, 145, 199, 878, 319, 608, 497, 195, 737, 448, 529, 65, 582, 489, 57, 613, 490, 158, 600, 252, 686, 438, 275, 393, 238, 757, 624, 183, 589, 270, 267, 169, 326, 767, 815, 421, 352, 24, 578, 126, 356, 687, 446, 544, 141, 865, 436, 603, 532, 674, 429, 731, 91, 896, 90, 120, 196, 329, 360, 717, 660, 591, 512, 593, 381, 325, 395, 876, 212, 48, 424, 337, 610, 222, 334, 882, 906, 264, 509, 871, 702, 705, 537, 189, 107, 474, 609, 743, 543, 422, 138, 837, 330, 164, 433, 143, 498, 879, 22, 590, 528, 655, 210, 288, 464, 742, 568, 228, 840, 770, 510, 540, 347, 142, 470, 523, 335, 595, 279, 531, 110, 74, 614, 38 })
                .ForEach(x => Console.WriteLine(x));
        }
    }
}
