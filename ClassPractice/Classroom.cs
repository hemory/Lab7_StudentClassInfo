using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_ClassroomLibrary
{
    public class Classroom
    {
        public Student[] students = new Student[5];

        public Classroom()
        {
            for (int i = 0; i < students.Length; i++)
                students[i] = new Student();
            {
                students[0].Name = "Hemory";
                students[0].Hometown = "Flint";
                students[0].FavoriteFood = "Burritos and Applesauce Baby";

                students[1].Name = "Lauren";
                students[1].Hometown = "Detroit";
                students[1].FavoriteFood = "Tacos";

                students[2].Name = "Calvin";
                students[2].Hometown = "Detroit";
                students[2].FavoriteFood = "Fried Chicken";

                students[3].Name = "Sylvia";
                students[3].Hometown = "Detroit";
                students[3].FavoriteFood = "Pickles";

                students[4].Name = "Darrius";
                students[4].Hometown = "Germany";
                students[4].FavoriteFood = "Viatnamese Cuisine";

            }
        }
        
    }
 }
    

