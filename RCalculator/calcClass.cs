using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCalculator
{
    class calcClass
    {
        private String operation = "";
        private Boolean OperationPress = false;
        private String num1 = "";
        private String num2 = "";
        private Double memory = 0;

        public string Operation
        {
            get
            {
                return operation;
            }

            set
            {
                operation = value;
            }
        }

        public bool OperationPress1
        {
            get
            {
                return OperationPress;
            }

            set
            {
                OperationPress = value;
            }
        }

        public string Num1
        {
            get
            {
                return num1;
            }

            set
            {
                num1 = value;
            }
        }

        public string Num2
        {
            get
            {
                return num2;
            }

            set
            {
                num2 = value;
            }
        }

        public double Memory
        {
            get
            {
                return memory;
            }

            set
            {
                memory = value;
            }
        }
    }
}
