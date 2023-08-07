using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileBased
{
    public class Operation
    {
        private string fpath;
        public Operation(string fpath)
        {
            this.fpath = fpath;
        }
        public void AddTeacher(Teachers teacher)
        {
            string TDate=$"{teacher.Id},{teacher.Name},{teacher.Class},{teacher.Section}";
            File.AppendAllLines(fpath, new[] { TDate });
        }
        public List<Teachers> ViewAll()
        {
            List<Teachers> teacher=new List<Teachers>();
            if(File.Exists(fpath))
            {
                string[] lines=File.ReadAllLines(fpath); 
                foreach(string line in lines)
                {
                    string[] str=line.Split(',');
                    if (str.Length == 4)
                    {
                        int id = int.Parse(str[0]);
                        string name = str[1];
                        int cls = int.Parse(str[2]);
                        string section = str[3];
                        teacher.Add(new Teachers
                        {
                            Id = id,
                            Name = name,
                            Class = cls,
                            Section = section
                        });
                    }
                }
            }
            return teacher;
        }
        public void SaveFile(List<Teachers> teacher)
        {
            List<string> lines = new List<string>();
            foreach (Teachers t in teacher)
            {
                string T_Date = $"{t.Id},{t.Name},{t.Class},{t.Section}";
                lines.Add(T_Date);
            }
            File.WriteAllLines(fpath, lines);
        }
        public void UpdateData(Teachers UData)
        {
            List<Teachers> teacher=ViewAll();
            for(int i=0;i<teacher.Count;i++)
            {
                if (teacher[i].Id == UData.Id)
                {
                    teacher[i] = UData;
                    break;
                }
            }
            SaveFile(teacher);
        }

    }
}
