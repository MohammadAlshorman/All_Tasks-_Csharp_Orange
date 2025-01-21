using System; // مكتبة لإجراء عمليات الإدخال والإخراج الأساسية
using System.Collections.Generic; // مكتبة لتوفير هياكل البيانات العامة
using System.Linq; // مكتبة تحتوي على استعلامات LINQ
using System.Text; // مكتبة لمعالجة النصوص
using System.Threading.Tasks; // مكتبة للتعامل مع البرمجة متعددة المهام
using static System.Collections.Specialized.BitVector32; // استيراد نوع معين لتسهيل العمل مع الكود

namespace ConsoleApp1 // تعريف مساحة الأسماء الرئيسية
{
    internal class Program // تعريف الكلاس الرئيسي للبرنامج
    {
        class Student // تعريف كلاس الطالب
        {
            public string Name { get; set; } // خاصية لاسم الطالب

            private int _age; // الحقل الخاص لتخزين عمر الطالب

            public int Age // خاصية لعمر الطالب
            {
                set
                {
                    if (value >= MinAge && value <= MaxAge) // التحقق من أن القيمة ضمن الحدود المسموح بها
                    {
                        _age = value; // تعيين القيمة إذا كانت صحيحة
                    }
                    else
                    {
                        _age = MinAge; // تعيين العمر كحد أدنى إذا كانت القيمة غير صحيحة
                    }
                }
                get
                {
                    return _age; // إرجاع قيمة الحقل الخاص
                }
            }

            public int StudentID { get; set; } // خاصية لرقم الطالب
            public int Email { get; set; } // خاصية للإيميل

            public const int MinAge = 18; // ثابت يمثل الحد الأدنى للعمر
            public const int MaxAge = 40; // ثابت يمثل الحد الأعلى للعمر

            public void GetDetails() // ميثود لطباعة تفاصيل الطالب
            {
                Console.WriteLine($"Student Name: {Name}, Age: {Age}, {StudentID}"); // طباعة التفاصيل
            }

            public Student() // مُنشئ بدون باراميترز
            {
                Name = ""; // تعيين اسم افتراضي
                Age = MinAge; // تعيين العمر الافتراضي
                StudentID = 1; // تعيين رقم الطالب الافتراضي
            }

            public Student(string name, int age, int id) // مُنشئ مع باراميترز
            {
                Name = name; // تعيين الاسم
                Age = age; // تعيين العمر
                StudentID = id; // تعيين رقم الطالب
            }

            ~Student() // دالة للتخلص من الكائن عند انتهاء عمره
            {
                Console.WriteLine("finish"); // طباعة رسالة عند الانتهاء
            }

        }

        static void Main(string[] args) // الدالة الرئيسية للبرنامج
        {
            Student student1 = new Student(); // إنشاء كائن من كلاس الطالب
            student1.Name = "Shehadeh"; // تعيين اسم الطالب
            student1.Age = 50; // تعيين عمر الطالب
            student1.StudentID = 0777077970; // تعيين رقم الطالب
            student1.GetDetails(); // طباعة تفاصيل الطالب

            Student student2 = new Student("Mohammad", 22, 2002); // إنشاء كائن آخر مع تمرير قيم
            student2.GetDetails(); // طباعة تفاصيل الطالب

            Student student3 = new Student("Ali", 6, 2018); // إنشاء كائن ثالث
            student3.GetDetails(); // طباعة تفاصيل الطالب

          //1. * *What is class?**  
            //   A class is a blueprint for creating objects, defining their properties and methods.

            //2. **What is object?**
            //   An object is an instance of a class, containing data and behavior defined by the class.

            //3. **Difference between class && object**
            //   A class is a template, while an object is a specific instance of that template.

            //4. **Mention the OOP Principles**  
            //   - Encapsulation
            //   - Inheritance
            //   - Polymorphism
            //   - Abstraction

            //5. **What is property?**
            //   A property is a special method in a class used to get or set the value of a field.

            //6. **What is field?**
            //   A field is a variable declared in a class to store data.

            //7. **What is constructor?**
            //   A constructor is a special method in a class that initializes objects when they are created.

            //8. **What is encapsulation?**
            //   Encapsulation is restricting access to data by bundling it with methods, ensuring controlled interaction.
        }

    }
}
