using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVManipulation
{
    public class RunProgram
    {
        public void RunMethods()
        {

        AssignmentModel1 assignmentModel = new AssignmentModel1()
        {
            Id = 1,
            AssignmentName = "Zadok",
            AssignmentLocation = "Lokoja",
            AssignmentModel2 = new AssignmentModel2() 
            { 
                Id = 2,
                AssignmentName = "James",
                AssignmentLocation  = "Kano",
                AssignmentModel3 = new AssignmentModel3() 
                {
                    Id = 3,
                    AssignmentName = "Sam",
                    AssignmentLocation = "London"
                }
            }
        };

        string DataToBeWritten = 
                $"{assignmentModel.Id},{assignmentModel.AssignmentName},{assignmentModel.AssignmentLocation}\n" +
                $"{assignmentModel.AssignmentModel2.Id},{assignmentModel.AssignmentModel2.AssignmentName},{assignmentModel.AssignmentModel2.AssignmentLocation}\n" +
                $"{assignmentModel.AssignmentModel2.AssignmentModel3.Id},{assignmentModel.AssignmentModel2.AssignmentModel3.AssignmentName},{assignmentModel.AssignmentModel2.AssignmentModel3.AssignmentLocation}";

        FileWriterClass fileWriterClass = new FileWriterClass();
        fileWriterClass.FileWriteToCsv(DataToBeWritten);
        
        }
    }
}
