﻿using System;

namespace NaiveBayesClassifiyer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Data Set Information:

    This data set includes votes for each of the U.S. House of Representatives Congressmen on the 16 key votes identified by the CQA. The CQA lists    nine different types of votes: voted for, paired for, and announced for (these three simplified to yea), voted against, paired against, and announced against (these three simplified to nay), voted present, voted present to avoid conflict of interest, and did not vote or otherwise make a position known (these three simplified to an unknown disposition).");

            Console.WriteLine(@"Attribute Information:

    1. Class Name: 2 (democrat, republican)
    2. handicapped-infants: 2 (y,n)
    3. water-project-cost-sharing: 2 (y,n)
    4. adoption-of-the-budget-resolution: 2 (y,n)
    5. physician-fee-freeze: 2 (y,n)
    6. el-salvador-aid: 2 (y,n)
    7. religious-groups-in-schools: 2 (y,n)
    8. anti-satellite-test-ban: 2 (y,n)
    9. aid-to-nicaraguan-contras: 2 (y,n)
    10. mx-missile: 2 (y,n)
    11. immigration: 2 (y,n)
    12. synfuels-corporation-cutback: 2 (y,n)
    13. education-spending: 2 (y,n)
    14. superfund-right-to-sue: 2 (y,n)
    15. crime: 2 (y,n)
    16. duty-free-exports: 2 (y,n)
    17. export-administration-act-south-africa: 2 (y,n)");
            
            string fn = "..\\..\\..\\..\\house-votes-84.data";
            string[][] dataSet = DataSetManager.MatrixLoad(fn, 17, ',');
            //DataSetManager.MatrixShow(dataSet, 1, 6);

            KFoldCrossValidator.RandomizeOrder(dataSet);
            KFoldCrossValidator.CrossValidate(dataSet, 8);

            Console.ReadKey();
        }
        
    }
}
