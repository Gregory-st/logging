using DataBaseWorker.Entites;
using System.Collections.Generic;

namespace DataBaseWorker.Comparators
{
    public class ComparatorPersonalFileActive : IComparer<EntityPersonalFileActive>
    {
        public int Compare(EntityPersonalFileActive file1, EntityPersonalFileActive file2) 
        {
            int sum1 = file1.BaseClass;
            int sum2 = file2.BaseClass;

            sum1 += file1.IdBaseAdmission;
            sum2 += file2.IdBaseAdmission;

            sum1 += file1.Course;
            sum2 += file2.Course;

            return sum2 - sum1;
        }
    }
}
