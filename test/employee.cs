using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class employee
    {
        public int deptno { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public float salary { get; set; }
        public override string ToString()
        {
            return $"{deptno} {fname} {lname} {salary}";
        }
    }
}
