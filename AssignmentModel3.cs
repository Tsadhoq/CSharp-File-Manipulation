using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVManipulation
{
    public class AssignmentModel3
    {

        private int _id;
        private string _assignmentName;
        private string _assignmentLocation;

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string AssignmentName 
        {
            get
            {
                return _assignmentName;
            }
            set
            {
                _assignmentName = value;
            }
        }
        public string AssignmentLocation
        {
            get
            {
                return _assignmentLocation;
            }
            set
            {
                _assignmentLocation = value;
            }
        }

    }
}
