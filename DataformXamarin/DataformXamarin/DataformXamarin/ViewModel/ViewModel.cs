using System;
using System.Collections.Generic;
using System.Text;

namespace DataformXamarin
{
    public class ViewModel
    {
        private EmployeeInfo employeeInfo;
        public EmployeeInfo EmployeeInfo
        {
            get { return this.employeeInfo; }
            set { this.employeeInfo = value; }
        }
        public ViewModel()
        {
            this.employeeInfo = new EmployeeInfo();
        }
    }
}
