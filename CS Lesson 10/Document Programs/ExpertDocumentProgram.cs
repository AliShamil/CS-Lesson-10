using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_10.Document_Programs
{
    internal class ExpertDocumentProgram: ProDocumentProgram
    {
        public override sealed void SaveDocument() => Console.WriteLine("Document Saved in pdf format");
    }
}
