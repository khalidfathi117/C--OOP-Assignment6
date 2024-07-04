namespace Assignment_6
{
    enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
    }
    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    [Flags]
    enum Permissions
    {
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }
    enum Colors
    {
        Red,
        Green,
        Blue
    }
    internal class Program
    {
        static double DistanceBetweenTwoPoints(Point a, Point b)
        {
            double res = Math.Sqrt((Math.Pow((a.X - b.X), 2) + Math.Pow((a.Y - b.Y), 2)));
            return res;
        }
        static void Main(string[] args)
        {
            #region (1)
            //foreach (DaysOfWeek day in Enum.GetValues(typeof(DaysOfWeek)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion

            #region (2)
            //Person[] people = new Person[3];
            //for (int i = 0; i < 3; ++i)
            //{
            //    people[i] = new Person($"I am {i + 1}", i + 20);
            //}
            //foreach (var person in people)
            //{
            //    Console.WriteLine("The Person Name :");
            //    Console.WriteLine(person.Name);
            //    Console.WriteLine("The Person Age :");
            //    Console.WriteLine(person.Age);
            //}
            #endregion

            #region (3)
            //Console.Write("Enter your season: ");
            //string? s = Console.ReadLine();
            //Season season;
            //if (Enum.TryParse(s, true, out season))
            //{
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("December to February");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Season");
            //}
            #endregion

            #region (4)
            //Permissions MyPermissions = Permissions.Read | Permissions.Write;
            //Console.WriteLine("First Permissions: " + MyPermissions);

            //MyPermissions |= Permissions.Execute;
            //Console.WriteLine("After adding Execute: " + MyPermissions);

            //MyPermissions &= ~Permissions.Write;
            //Console.WriteLine("After removing Write: " + MyPermissions);

            //bool hasDeletePermission = (MyPermissions & Permissions.Delete) == Permissions.Delete;
            //Console.WriteLine("Does have Delete permission ? " + hasDeletePermission);
            #endregion

            #region (5)
            //Console.Write("Enter a color: ");
            //string? c = Console.ReadLine();
            //Colors color;
            //if (Enum.TryParse(c, true, out color))
            //{
            //    if (color == Colors.Blue || color == Colors.Red || color == Colors.Green)
            //    {
            //        Console.WriteLine($"{color} is a primary color");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"{c} isn't a primary color");
            //}
            #endregion

            #region (6)
            //Point One = new Point(3, 2);
            //Point Two = new Point(5, 6);
            //Console.WriteLine("The Distance is : ");
            //Console.WriteLine(DistanceBetweenTwoPoints(One , Two));
            #endregion

            #region (7)
            //Person[] people = new Person[3];
            //int mx = 0;
            //int index = -1;
            //for (int i = 0; i < people.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}- Enter Your Name : ");
            //    string? name = Console.ReadLine();
            //    Console.WriteLine($"{i + 1}- Enter Your Age : ");
            //    if (int.TryParse(Console.ReadLine(), out int age))
            //    {
            //        mx = Math.Max(mx, age);
            //        if (mx == age)
            //        {
            //            index = i;
            //        }
            //        people[i] = new Person(name , age);
            //    }
            //}
            //Console.WriteLine($"The Person Name : {people[index].Name}");
            //Console.WriteLine($"The Person Age : {people[index].Age}");
            #endregion

        }
    }
}
