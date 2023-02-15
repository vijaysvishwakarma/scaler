﻿using System;
using System.Collections.Generic;

namespace Heap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //LargestNumberProduct product = new LargestNumberProduct();
            ////var arr2 = new List<int>() { 1, 2, 3, 4, 5 };
            //var arr2 = new List<int>() { 10, 2, 13, 4 };
            ////var arr3 = new List<int>() { 41, 467, 334, 500, 169, 724, 478, 358, 962, 464, 705, 145, 281, 827, 961, 491, 995, 942, 827, 436, 391, 604, 902, 153, 292, 382, 421, 716, 718, 895, 447, 726, 771, 538, 869, 912, 667, 299, 35, 894, 703, 811, 322, 333, 673, 664, 141, 711, 253, 868, 547, 644, 662, 757, 37, 859, 723, 741, 529, 778, 316, 35, 190, 842, 288, 106, 40, 942, 264, 648, 446, 805, 890, 729, 370, 350, 6, 101, 393, 548, 629, 623, 84, 954, 756, 840, 966, 376, 931, 308, 944, 439, 626, 323, 537, 538, 118, 82, 929, 541, 833, 115, 639, 658, 704, 930, 977, 306, 673, 386, 21, 745, 924, 72, 270, 829, 777, 573, 97, 512, 986, 290, 161, 636, 355, 767, 655, 574, 31, 52, 350, 150, 941, 724, 966, 430, 107, 191, 7, 337, 457, 287, 753, 383, 945, 909, 209, 758, 221, 588, 422, 946, 506, 30, 413, 168, 900, 591, 762, 655, 410, 359, 624, 537, 548, 483, 595, 41, 602, 350, 291, 836, 374, 20, 596, 21, 348, 199, 668, 484, 281, 734, 53, 999, 418, 938, 900, 788, 127, 467, 728, 893, 648, 483, 807, 421, 310, 617, 813, 514, 309, 616, 935, 451, 600, 249, 519, 556, 798, 303, 224, 8, 844, 609, 989, 702, 195, 485, 93, 343, 523, 587, 314, 503, 448, 200, 458, 618, 580, 796, 798, 281, 589, 798, 9, 157, 472, 622, 538, 292, 38, 179, 190, 657, 958, 191, 815, 888, 156, 511, 202, 634, 272, 55, 328, 646, 362, 886, 875, 433, 869, 142, 844, 416, 881, 998, 322, 651, 21, 699, 557, 476, 892, 389, 75, 712, 600, 510, 3, 869, 861, 688, 401, 789, 255, 423, 2, 585, 182, 285, 88, 426, 617, 757, 832, 932, 169, 154, 721, 189, 976, 329, 368, 692, 425, 555, 434, 549, 441, 512, 145, 60, 718, 753, 139, 423, 279, 996, 687, 529, 549, 437, 866, 949, 193, 195, 297, 416, 286, 105, 488, 282, 455, 734, 114, 701, 316, 671, 786, 263, 313, 355, 185, 53, 912, 808, 832, 945, 313, 756, 321, 558, 646, 982, 481, 144, 196, 222, 129, 161, 535, 450, 173, 466, 44, 659, 292, 439, 253, 24, 154, 510, 745, 649, 186, 313, 474, 22, 168, 18, 787, 905, 958, 391, 202, 625, 477, 414, 314, 824, 334, 874, 372, 159, 833, 70, 487, 297, 518, 177, 773, 270, 763, 668, 192, 985, 102, 480, 213, 627, 802, 99, 527, 625, 543, 924, 23, 972, 61, 181, 3, 432, 505, 593, 725, 31, 492, 142, 222, 286, 64, 900, 187, 360, 413, 974, 270, 170, 235, 833, 711, 760, 896, 667, 285, 550, 140, 694, 695, 624, 19, 125, 576, 694, 658, 302, 371, 466, 678, 593, 851, 484, 18, 464, 119, 152, 800, 87, 60, 926, 10, 757, 170, 315, 576, 227, 43, 758, 164, 109, 882, 86, 565, 487, 577, 474, 625, 627, 629, 928, 423, 520, 902, 962, 123, 596, 737, 261, 195, 525, 264, 260, 202, 116, 30, 326, 11, 771, 411, 547, 153, 520, 790, 924, 188, 763, 940, 851, 662, 829, 900, 713, 958, 578, 365, 7, 477, 200, 58, 439, 303, 760, 357, 324, 477, 108, 113, 887, 801, 850, 460, 428, 993, 384, 405, 540, 111, 704, 835, 356, 72, 350, 823, 485, 556, 216, 626, 357, 526, 357, 337, 271, 869, 361, 896, 22, 617, 112, 717, 696, 585, 41, 423, 129, 229, 565, 559, 932, 296, 855, 53, 962, 584, 734, 654, 972, 457, 369, 532, 963, 607, 483, 911, 635, 67, 848, 675, 938, 223, 142, 754, 511, 741, 175, 459, 825, 221, 870, 626, 934, 205, 783, 850, 398, 279, 701, 193, 734, 637, 534, 556, 993, 176, 705, 962, 548, 881, 300, 413, 641, 855, 855, 142, 462, 611, 877, 424, 678, 752, 443, 296, 673, 40, 313, 875, 72, 818, 610, 17, 932, 112, 695, 169, 831, 40, 488, 685, 90, 497, 589, 990, 145, 353, 314, 651, 740, 44, 258, 335, 759, 192, 605, 264, 181, 503, 829, 775, 608, 292, 997, 549, 556, 561, 627, 467, 541, 129, 240, 813, 174, 601, 77, 215, 683, 213, 992, 824, 601, 392, 759, 670, 428, 27, 84, 75, 786, 498, 970, 287, 847, 604, 503, 221, 663, 706, 363, 10, 171, 489, 240, 164, 542, 619, 913, 591, 704, 818, 232, 750, 205, 975, 539, 303, 422, 98, 247, 584, 648, 971, 864, 913, 75, 545, 712, 546, 678, 769, 262, 519, 985, 289, 944, 865, 540, 245, 508, 318, 870, 601, 323, 132, 472, 152, 87, 570, 763, 901, 103, 423, 527, 600, 969, 15, 565, 28, 543, 347, 88, 943, 637, 409, 463, 49, 681, 588, 342, 608, 60, 221, 758, 954, 888, 146, 690, 949, 843, 430, 620, 748, 67, 536, 783, 35, 226, 185, 38, 853, 629, 224, 748, 923, 359, 257, 766, 944, 955, 318, 726, 411, 25, 355, 1, 549, 496, 584, 515, 964, 342, 75, 913, 142, 196, 948, 72, 426, 606, 173, 429, 404, 705, 626, 812, 375, 93, 565, 36, 736, 141, 814, 994, 256, 652, 936, 838, 482, 355, 15, 131, 230, 841, 625, 11, 637, 186, 690, 650, 662, 634, 893, 353, 416, 452, 8, 262, 233, 454, 303, 634, 303, 256, 148, 124, 317, 213, 109, 28, 200, 80, 318, 858, 50, 155, 361, 264, 903, 676, 643, 909, 902, 561, 489, 948, 282, 653, 674, 220, 402, 923, 831, 369, 878, 259, 8, 619, 971, 3, 945, 781, 504, 392, 685, 313, 698, 589, 722, 938, 37, 410, 461, 234, 508, 961, 959, 493, 515, 269, 937, 869, 58, 700, 971, 264, 117, 215, 555, 815, 330, 39, 212, 288, 82, 954, 85, 710, 484, 774, 380, 815, 951, 541, 115, 679, 110, 898, 73, 788, 977, 132, 956, 689, 113, 8, 941, 790, 723, 363, 28, 184, 778, 200, 71, 885, 974, 71, 333, 867, 153, 295, 168, 825, 676, 629, 650, 598, 309, 693, 686, 80, 116, 249 };
            //// 13 4 10 2
            //var heap = product.solve(arr2);
            ////var heap = product.solve(arr3);
            //for (int i = 0; i < heap.Count; i++)
            //{
            //    Console.WriteLine(heap[i]);
            //}
            //;

            //MaximumSumArrayAfterNegation maximumSumArrayAfterNegation = new MaximumSumArrayAfterNegation();
            ////var input = new List<int> { 24, -68, -29, -9, 84 };
            //var input = new List<int> { 57, 3, -14, -87, 42, 38, 31, -7, -28, -61};
            //Console.WriteLine(maximumSumArrayAfterNegation.Solve(input, 10));

            //ConnectedRopes connectedRopes = new ConnectedRopes();
            ////var input = new List<int> { 24, -68, -29, -9, 84 };
            //var input = new List<int> { 5, 17, 100, 11 };
            //Console.WriteLine(connectedRopes.Solve(input));

            // MagicianChocolates magicianChocolates = new MagicianChocolates();
            // //var bag = new List<int>() { 6, 5 };
            // var bag = new List<int>() { 2, 4, 6, 8, 10 };
            //// var time = 3;
            // var time = 5;
            // Console.WriteLine(magicianChocolates.nchoc(time, bag));

            //KplacesApart kplacesApart = new KplacesApart();
            ////var input = new List<int> { 1, 40, 2, 3 };
            ////var b = 2;
            //var input = new List<int> { 25, 16, 11, 31, 28, 20, 3, 8 };
            //var b = 6;
            ////var input = new List<int> { 2, 1, 17, 10, 21, 95 };
            ////var b = 1;
            //var result = kplacesApart.solve(input, b);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //RunningMedian runningMedian = new RunningMedian();
            //var input = new List<int>() { 1, 2, 5, 4, 3 };
            //var result = runningMedian.Solve(input);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //AthLargestElement athLargestElement = new AthLargestElement();
            //var input = new List<int>() { 1, 2, 3, 4, 5, 6 };
            //var result = athLargestElement.Solve(4, input);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //MinimumLargest_Advance minimumLargest_Advance = new MinimumLargest_Advance();
            ////var input = new List<int>() { 5, 1, 4, 2 };
            ////var input = new List<int>() { 5, 1, 4, 2 };
            ////var operation = 5;
            //var input = new List<int>() { 5, 7, 8 };
            //var operation = 9;
            ////var input = new List<int>() { -2, -4, -8, -16 };
            ////var operation = 10;
            //Console.WriteLine(minimumLargest_Advance.solve(input, operation));
            // Console.ReadLine();    


            //SpecialMedian specialMedian = new SpecialMedian();
            ////var input = new List<int>() { 4, 6, 8, 4 };
            //// expected output= true
            //var input = new List<int>() { 2, 7, 3, 1 };
            //// expected output= false
            //Console.WriteLine(specialMedian.solve(input));

            ListNode root1 = new ListNode(71);
            ListNode node1 = new ListNode(10);
            ListNode node2 = new ListNode(20);
            root1.next = node1;
            node1.next = node2;

            ListNode root2 = new ListNode(4);
            ListNode node3 = new ListNode(11);
            ListNode node4 = new ListNode(13);
            root2.next = node3;
            node3.next = node4;

            ListNode root3 = new ListNode(8);
            ListNode node5 = new ListNode(16);
            ListNode node6 = new ListNode(32);

            root3.next = node5;
            node5.next = node6;

            KSortedListMerged kSortedListMerged = new KSortedListMerged();
            var result = kSortedListMerged.mergeKLists(new List<ListNode>() { root1, root2, root3 });

            while (result.next != null)
            {
                Console.WriteLine(result.val);
                result = result.next;
            }
            Console.WriteLine(result.val);

        }
    }
}
