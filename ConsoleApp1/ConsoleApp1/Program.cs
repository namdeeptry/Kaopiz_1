using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var students = new[]
            {
                new Students(){Id =1,Name="Join",Mark=80,City="HaNoi",OderId = 3},
                new Students(){Id =2,Name="Alex",Mark=50,City="HaiPhong",OderId = 3},
                new Students(){Id =3,Name="Jame",Mark=86,City="HaNoi",OderId = 4},
                new Students(){Id =4,Name="Jame",Mark=90,City="SaiGon",OderId = 4},
                new Students(){Id =5,Name="Ron",Mark=67,City="DaNang",OderId = 1}
            };
            var oders = new[]
           {
                new Oder(){Id =1,Name="a"},
                new Oder(){Id =3,Name="b"},
                new Oder(){Id =4,Name="c"}
            };
            /* var std = students.ToList();
             var oder = oders.ToList();*/
            // get 1 list(std),name (oder) -> oder id = 4 && mark <60 || mark > 80

            var stds = from s in students
                       join o in oders on s.OderId equals o.Id
                       where s.OderId == 4 && (s.Mark<60 || s.Mark>80)
                      select s;

            foreach (var item in stds)
            {
                Console.WriteLine(item.Id +" "+item.Name +" "+item.Mark+ " "+item.City+" "+item.OderId);
            }
            //1. Cho danh sách như trên.Viết các câu lệnh linq thỏa mãn:
            //2. Lấy ra học sinh có id = 4
            //3. Lấy ra danh sách học sinh có tên chứa ‘am’ và sống ở thành phố ‘HaNoi’
            //4. Lấy ra tên học sinh có điểm cao nhất
            //5. Kiểm tra tất cả học sinh có điểm > 50 không.Nếu lớn hơn thì in ra dòng chữ “Pass”. Không thì in ra dòng chữ “Fail”

            //1.var Student = students.SingleOrDefault(x => x.Id == 4); 
            //    Console.WriteLine($"{Student.Name} Id = 4 ");  
            //var listStudents2 = students.Where(x => x.City =="HaNoi" && x.Name.Contains("am")).ToList();
            //2.foreach (var listStudents in listStudents2)
            //{
            //    Console.WriteLine($"{listStudents.Id +listStudents.Name}");
            //}
            //3.var HighestmarkName = students.OrderByDescending(x => x.Mark).First();
            // Console.WriteLine($"{HighestmarkName.Name + " " + HighestmarkName.Mark }");
            ////5. bool std = students.Any( x=> x.Mark >50);
            //if (std)
            //{
            //    Console.WriteLine("Pass");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}
            //  var s = students.ToList();
            //foreach (var c in s)
            //{
            //    Console.WriteLine(c.Mark > 80 ? c.Name + " Pass" : c.Name + " fail");
            //}

            /* var stds = from a in students
                        where a.Mark > 80
                        select a;*/







            Console.ReadKey();

        }
        
    }
}
