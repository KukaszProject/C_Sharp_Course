using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public delegate int Comparison<T>(T x, T y);

public class PersonDelegate
{
    public int Age { get; set; }
    public string Name { get; set; }
}

public class PersonSorter
{
    public void Sort(PersonDelegate[] people, Comparison<PersonDelegate> comparison)
    {
        for(int i = 0; i < people.Length -1; i++)
        {
            for(int j = i+1; j < people.Length; j++)
            {
                if (comparison(people[i], people[j]) > 0)
                {
                    PersonDelegate temp = people[i];
                    people[i] = people[j];
                    people[j] = temp;
                }
            }

        }
    }
}


//========================================================//
// DELEGATES SORTER - PASTE TO Program.cs

//PersonDelegate[] people =
//{
//                new PersonDelegate{Name = "Bob", Age = 30 },
//                new PersonDelegate{Name = "Alice", Age = 20 },
//                new PersonDelegate{Name = "Charlie", Age = 25 }
//            };

//PersonSorter sorter = new PersonSorter();
//sorter.Sort(people, CompareByAge);

//foreach (PersonDelegate personDelegate in people)
//{
//    Console.WriteLine(personDelegate.Name + ": " + personDelegate.Age);
//}

//sorter.Sort(people, CompareByName);

//foreach (PersonDelegate personDelegate in people)
//{
//    Console.WriteLine(personDelegate.Name + ": " + personDelegate.Age);
//}


//static int CompareByAge(PersonDelegate x, PersonDelegate y)
//{
//    return x.Age.CompareTo(y.Age);
//}

//static int CompareByName(PersonDelegate x, PersonDelegate y)
//{
//    return x.Name.CompareTo(y.Name);
//}
//========================================================//
