using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileBased
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fpath = "C:\\Users\\Keerthana\\OneDrive\\Desktop\\job\\simpli\\PhaseEndProjects\\TextFileBased\\TeacherData.txt";
            Operation op=new Operation(fpath);
            char ch;
            do
            {
                Console.WriteLine("Select\n1.Add Teacher\t2.View all Teachers\t3.Update Existing Data");
                int selectop = int.Parse(Console.ReadLine());
                switch (selectop)
                {
                    case 1:
                        Console.WriteLine("Enter Teacher Id");
                        int id=int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Teacher Name");
                        string name=Console.ReadLine(); 
                        Console.WriteLine("Enter Teacher Class");
                        int cls=int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Teacher Section");
                        string sec=Console.ReadLine();
                        Teachers t = new Teachers
                        {
                            Id = id,
                            Name = name,
                            Class = cls,
                            Section = sec
                        };
                        op.AddTeacher(t);
                        break;
                    case 2:
                        Console.WriteLine("Teachers details");
                        op.ViewAll();
                        break;
                    case 3:
                        Console.WriteLine("Enter Teacher Id");
                        int uid = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Teacher Name");
                        string uname = Console.ReadLine();
                        Console.WriteLine("Enter Teacher Class");
                        int ucls = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Teacher Section");
                        string usec = Console.ReadLine();
                        Teachers udata = new Teachers
                        {
                            Id=uid,
                            Name=uname,
                            Class=ucls,
                            Section = usec
                        };
                        op.UpdateData(udata);
                        op.ViewAll();
                        break;
                    default:
                        Console.WriteLine("Invalid selection");
                        break;
                }
                
                    Console.WriteLine("If you want to continue press y");
                    ch = char.Parse(Console.ReadLine().ToLower());
                } while (ch == 'y') ;
            }
    }
}
