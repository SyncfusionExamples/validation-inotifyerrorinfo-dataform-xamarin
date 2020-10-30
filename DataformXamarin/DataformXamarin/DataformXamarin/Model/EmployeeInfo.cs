using Syncfusion.XForms.DataForm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataformXamarin
{
    public class EmployeeInfo : NotificationObject, INotifyDataErrorInfo
    {
        private int employeeID;
        private string name;
        private string title;
        private DateTime? joindate;
        private int customerid;
        public EmployeeInfo()
        {

        }

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;
        public int EmployeeID
        {
            get { return this.employeeID; }
            set
            {
                this.employeeID = value;
                this.RaisePropertyChanged("EmployeeID");
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;
                this.RaisePropertyChanged("Name");
            }
        }
        public string Title
        {
            get { return this.title; }
            set
            {
                this.title = value;
                this.RaisePropertyChanged("Title");
            }
        }

        public int CustomerID
        {
            get { return this.customerid; }
            set
            {
                this.customerid = value;
                this.RaisePropertyChanged("CustomerID");
            }
        }
        public DateTime? JoinDate
        {
            get { return joindate; }
            set
            {
                joindate = value;
                this.RaisePropertyChanged("JoinDate");
            }
        }

        [Display(AutoGenerateField = false)]
        public bool HasErrors
        {
            get
            {
                return false;
            }
        }
        public IEnumerable GetErrors(string propertyName)
        {
            var list = new List<string>();
            if (!propertyName.Equals("Title"))
                return list;

            if (this.Title.Contains("Marketing"))
                list.Add("Marketing is not allowed");
            return list;
        }
    }
}
