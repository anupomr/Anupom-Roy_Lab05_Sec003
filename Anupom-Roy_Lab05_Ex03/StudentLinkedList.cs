using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anupom_Roy_Lab05_Ex03
{
    class StudentLinkedList
    {        
       
        static void Main()
        {
            LinkedList<Student> linkedStudents = new LinkedList<Student>();
            Student studentAnu = new Student(106, "Anupom ");
            Student stuChan = new Student(107, "Chandan Roy ");
            AddLinkedListItem(linkedStudents, new Student(101, "Anupom Roy"));
           
            AddLinkedListItem(linkedStudents, new Student(102, "Chandan Roy"));
            AddLinkedListItem(linkedStudents, studentAnu);
            PrintLinkedList(linkedStudents);
            //RemoveLinkedListItem(linkedStudents, studentAnu);
            Console.WriteLine("After Remove");
           PrintLinkedList(linkedStudents);
            SearchLinkedListItem(linkedStudents, studentAnu);
        }
        public static void AddLinkedListItem(LinkedList<Student> name, Student studentObj)
        {
            name.AddLast(studentObj);
        }
        public static void RemoveLinkedListItem(LinkedList<Student> name, Student studentObj)
        {
            LinkedListNode<Student> currentNode = name.Find(studentObj);
            // RemoveLinkedListItem(name.);
            name.Remove(currentNode);
        }
        public static void PrintLinkedList(LinkedList<Student> name)
        {
            LinkedListNode<Student> currentNode = name.First;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value); 
                currentNode = currentNode.Next; // get next node             
            }

        }

        public static void SearchLinkedListItem(LinkedList<Student> name, Student studentObj)
        {
            LinkedListNode<Student> currentNode = name.Find(studentObj);
            if (currentNode.Value != null)
            { Console.WriteLine("Data found !!!"); }
            else
            { Console.WriteLine("Data  not found !!!"); }
        }
    }
}
