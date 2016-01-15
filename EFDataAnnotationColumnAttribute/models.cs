using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDataAnnotationColumnAttribute
{

    //Code First Default Convention. EmployeeID is Primary key
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
    }




    public class Employee1
    {
        [Key]
        public int EmployeeID { get; set; }

        [Column("EmployeeName")]
        public string Name { get; set; }

    }


    public class Employee2
    {
        [Key]
        public int EmployeeID { get; set; }

        [Column("EmployeeName", TypeName = "varchar")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar")]
        public string Name1 { get; set; }

        [Column(TypeName = "text")]
        public string TextColumn { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }
        
    }


    public class Employee3
    {
        [Key]
        public int EmployeeID { get; set; }

        public string Name { get; set; }

        [Column(Order = 4, TypeName = "varchar")]
        public string Column1 { get; set; }

        [Column(Order = 3, TypeName = "Varchar")]
        public string Column2 { get; set; }

    }
}
