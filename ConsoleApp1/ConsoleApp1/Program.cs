using ClassLibrary1;
using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;

#region Day7-UsingNamespaceDemo
// Using the below line we could directly Access the Employee class 
// using ConsoleApp1.myOrg.HR; 
#endregion

#region Day-7-IMPImporting.NetCoreClassLibrary
// using MyOrganizationApp; 
#endregion

namespace ConsoleApp1
{
    #region Day3-Structures
    /*
    struct student
    {
        public string name;
        public string id;
        public double marks;
        public void show()
        {
            Console.WriteLine("Name: " + this.name + " ID: " + this.id + " Marks: " + this.marks);
        }
    }
*/
    #endregion

    #region Day4-Classes and Objects
    /*
    class Person
    {
        string name;
        string contactno;
        double marks;
        public Person(string name, string contactno)
        {
            this.name = name;
            this.contactno = contactno;
        }
        public Person(string name,string contactno,double marks):this(name,contactno)
        {
            this.marks = marks;
        }
        public void show()
        {
            Console.WriteLine("Name: " + this.name + " Contact No.: " + this.contactno + " Marks: "+this.marks);
        }
        public void show(string txt)
        {
            Console.WriteLine(txt);
        }

    }
    class Student
    {
        string name;
        int id;
        double m1, m2;
        public Student()
        {

        }
        public Student(string name,int id,double m1,double m2)
        {
            this.name = name;
            this.id = id;
            this.m1 = m1;
            this.m2 = m2;
        }
        public void createStudent(string name,int id)
        {
            this.name = name;
            this.id = id;
        }
        public void setMarks(double m1,double m2)
        {
            this.m1 = m1;
            this.m2 = m2;
        }
        public double getAvg()
        {
            return ((m1 + m2) / 2);
        }
    }
*/
    #endregion

    #region Day5-Properties Alternatives of getter/setters
    /*
    class getSet
    {
        string _name;
        string _id;
        public getSet(string _name,string _id)
        {
            this._name = _name;
            this._id = _id;
        }
        public string name
        {
            set{ 
                if(value.Length<50)
                {
                    _name = value;
                }
                else
                {
                    _name = "Random";
                }
            }
            get{ return _name; }
        }
        public string id
        {
            get { return _id; }
        }
    }
*/
    #endregion

    #region Day5-AutoProperties
    /*
    class autoProps
    {
        // prop tab tab
        [Required]
        [MaxLength(50,ErrorMessage ="Name's length must not exceed 50")]
        public string Name{ get; set; }
        [Required]
        public string Id { get; set; }
        public void show()
        {
            Console.WriteLine("Name: " + Name + " ID: " + Id);
        }
    }
*/
    #endregion

    #region Day6-StaticFields-Constructors-Methods
    /*
    class HouseLoan
    {
        int custId;
        string name;
        double loanAmt;
        static double _ROI;
        // Memory for static variable is allocated only once and all the objects 
        // will share the same static variable value.

        public static double ROI { get { return _ROI; } set { _ROI = value; } }
        static HouseLoan()
        {
            // Overloading of static constructor is not possible
            _ROI=11.2;
        }
        public HouseLoan(int custId,string name,double loanAmt)
        {
            this.custId = custId;
            this.name = name;
            this.loanAmt = loanAmt;
        }
        public double calInterest()
        {
            return loanAmt * _ROI / 100 + loanAmt;
        }
        // Static method
        public static void myMethodStatic()
        {
            // static methods work only on static fields.
            Console.WriteLine("ROI: " + ROI);
        }
    }
*/
    #endregion

    #region Day6-StaticClass
    // Static class is the class which has all the methods in it as static
    // Static class cannot have an object or a reference.
    /*
        static class Calculation
        {
            public static dynamic add(dynamic a,dynamic b)
            {
                dynamic c = a + b;
                return c;
            }
            public static dynamic multiply(dynamic a,dynamic b)
            {
                dynamic c = (a * b);
                return c;
            }
        }
    */
    #endregion

    #region Day7-NameSpaceImplementation
    /*
        namespace Admin
        {
            class Employee
            {
                public void Add()
                {

                }
                public void Update()
                {

                }
            }
        }

        namespace HR
        {
            class Employee
            {
                public void CalculateSalary()
                {

                }
            }
        }
    */
    #endregion

    #region Day7-UsingNamespaceDemo
    /*
    namespace myOrg
    {
        namespace HR
        {
            class Employee
            {
                 public void calculateSalary()
                 {

                 }
            }
        }
    }
*/
    #endregion

    #region Day-8-Inheritance
    /*
    class Customer
    {
        public int custId { get; set; }
        public string name { get; set; }
        public string email { get; set; }

        public Customer()
        {
            Console.WriteLine("Customer's Default");
        }
        public Customer(int custId,string name,string email)
        {
            this.custId = custId;
            this.name = name;
            this.email = email;
        }
        // Protected members of a class can be inherited in the child class
        // Protected members of a class cannot be accessed from outside the class.
        public void custShow()
        {
            Console.WriteLine("ID: " + custId +" Name: "+name+" Email: "+email);
        }
        public virtual void getDetails()
        {
            Console.WriteLine("ID: " + custId + " Name: " + name );
        }

    }
    class BankCustomer : Customer
    {
        public int accountNo { get; set; }
        public double balance { get; set; }

        public BankCustomer()
        {
            Console.WriteLine("Bank Customer's Default");
        }
        public BankCustomer(int custId, string name, string email,int accountNo,double balance):base(custId,name,email)
        {
            this.accountNo = accountNo;
            this.balance = balance;
        }
        public void bankShow()
        {
            base.custShow();
            Console.WriteLine("Acc. No. " + accountNo + " Balance: " + balance);
        }
        public override void getDetails()
        {
            Console.WriteLine("Acc. No. " + accountNo + " Balance: " + balance);
        }
        // Base class's method was overriden

    }
*/
    #endregion

    #region Day-9-SealedMethodsClasses
    /*
    class A
    {
        public virtual void show()
        {

        }
    }
    class B : A
    {
        public override sealed void show()
        {

        }
    }
    sealed class C : B
    {
        /*
            public override void show()
            {

            }
        */
}

/*
    class D : C
    {

    }
*/
#endregion

    #region Day-10-AbstractClassMethods
/*
abstract class A
{
public void show()
{
    Console.WriteLine("Show of A");
}
public abstract void display();
}
class B : A
{
public override void display()
{
    Console.WriteLine("This is B display");
}
}
*/
#endregion

    #region Day-10-RuntimePolymorphism
/*
    abstract class Employee
    {
        public int empId { get; set; }
        public string name { get; set; }
        public double salPerHr { get; set; }
        public virtual void details()
        {
            Console.WriteLine("EmpId: " + empId);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Sal/hr: " + salPerHr);
        }
        public abstract void calculateSal(int noWorkHrs);
    }
    class SDE : Employee
    {
        public string technology { get; set; }
        public override void details()
        {
            base.details();
            Console.WriteLine("Technology: " + technology);
        }
        public override void calculateSal(int noWorkHrs)
        {
            double basic = (salPerHr * noWorkHrs);
            double hra = basic * 15 / 100;
            double GS = basic + hra;
            Console.WriteLine("Gross Sal of SDE: "+GS);
        }
    }
    class TeamLead : Employee
    {
        public int size { get; set; }
        public override void details()
        {
            base.details();
            Console.WriteLine("Team Size: " + size);
        }
        public override void calculateSal(int noWorkHrs)
        {
            double basic = (salPerHr * noWorkHrs);
            double hra = basic * 30.6 / 100;
            double GS = basic + hra;
            Console.WriteLine("Gross Sal of teamLead: " + GS);
        }
    }
*/
#endregion

    #region Day-11-Interfaces

/*
      interface iOperations
    {
     void getAll();
     void getById();
     void create();
     void update();
     void delete();
    }
     interface bulkOperations
    {
     void deleteAll();
    }
    class Employee : iOperations,bulkOperations
    {
     public void create()
     {
         Console.WriteLine("create employee");
     }

     public void delete()
     {
         Console.WriteLine("delete employee");
     }

     public void getAll()
     {
         Console.WriteLine("get all employees");
     }

     public void getById()
     {
         Console.WriteLine("get employee by id");
     }

     public void update()
     {
         Console.WriteLine("update employee");
     }
     public void deleteAll()
     {
         Console.WriteLine("delete all employees");
     }
    }
 */
#endregion

    #region Day-11-PartialClasses
/*
public partial class A
{
public void show()
{
    Console.WriteLine("Show in program.cs");
    // Add a new item i.e. class in the same dir as current name it as
    // A and make it partial
}
} 
*/ 
#endregion

    
class Program
    {
    #region Day3-VarDynamic
    /*
        static void addVal(dynamic a,dynamic b)
        {
            Console.WriteLine(a + b);
        }
    */
    #endregion

    #region Day-13,14-Delegates
    /*
    delegate void anotherTest(string name);

    delegate void Test(string name);
    class Sample
    {
        anotherTest t1;
        public void callBack(anotherTest t1)
        {
            this.t1 = t1;
            t1("Callback");
        }
    }
*/


    #endregion

    static void Main(string[] args)
        {
        #region Day1-Intro
        /*
            Console.WriteLine("Hello World!");
            string str = Console.ReadLine();
            Console.WriteLine(str);
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine(a + b);
            Console.WriteLine("Sum is {0}", a + b);
            int c = a + b;
            Console.WriteLine("Sum=" + c);
        */
        #endregion

        #region Day2-ControlStructures
        /*
                Console.WriteLine(int.MaxValue);
                Console.WriteLine(int.MinValue);
                int x, y;
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
                if (x > y)
                {
                    Console.WriteLine("{0} is greater than {1}", x, y);
                }
                else
                {
                    Console.WriteLine("{0} is greater than {1}",y, x);
                }
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Sai Vamshi");
                }
                Console.WriteLine("enter Num:");
                int num = int.Parse(Console.ReadLine());
                int sum = 0;
                while(num!=0)
                {
                    sum = sum + (num % 10);
                    num = num / 10;
                }
                Console.WriteLine("Sum is" + sum);
            */
        #endregion

        #region Day3-Arrays
        /*
                int[] arr1 = new int[5];
                int[] arr2 = { 1, 2, 3 };
                int[,] mat1 = new int[2,3];
                for(int i=0;i<5;i++)
                {
                    arr1[i] = i + 1;
                }
                int cnt = 0;
                for(int i=0;i<2;i++)
                {
                    for(int j=0;j<3;j++)
                    {
                        mat1[i,j] = cnt++;
                    }
                }
                Console.WriteLine("Elements of matrix:");
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(mat1[i, j]+" ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Array:");
                for (int i = 0; i < arr1.Length; i++)
                {
                    Console.WriteLine(arr1[i] + " ");
                }
                Console.WriteLine("for each:");
                foreach(int i in arr1)
                {
                    Console.WriteLine(i + " ");
                }
                int[] new_arr = new int[5];
                int ans = 0;
                Console.WriteLine("Enter array elements:");
                for (int i = 0; i < 5; i++)
                {
                    new_arr[i] = int.Parse(Console.ReadLine());
                    ans = ans + new_arr[i];
                }
                Console.WriteLine("Sum is {0}", ans);
                Console.WriteLine("Elements in sorted order");
                Array.Sort(new_arr);
                foreach(int i in new_arr)
                {
                    Console.WriteLine(i + " ");
                }
                Console.WriteLine("Elements in reverse order");
                Array.Reverse(new_arr);
                foreach (int i in new_arr)
                {
                    Console.WriteLine(i + " ");
                }
                Console.WriteLine("Enter element to find");
                int p = int.Parse(Console.ReadLine());
                int val = Array.IndexOf(new_arr, p);
                Console.WriteLine("Index of {0} is {1}", p, val);  
            */
        #endregion

        #region Day3-Structures
        /*
                student s = new student();
                s.name = "SaiVamshi";
                s.id = "2345";
                s.marks = 34.44;
                Console.WriteLine("Name: " + s.name);
                Console.WriteLine("ID: " + s.id);
                Console.WriteLine("Marks: " + s.marks);
                Console.WriteLine("Using function:");
                s.show();
                student[] arr = new student[2];
                for(int i=0;i<2;i++)
                {
                    Console.WriteLine("Enter {0} name: ", i + 1);
                    string temp1 = Console.ReadLine();
                    arr[i].name = temp1;
                    Console.WriteLine("Enter {0} ID: ", i + 1);
                    string temp2 = Console.ReadLine();
                    arr[i].id = temp2;
                    Console.WriteLine("Enter {0} marks: ", i + 1);
                    int temp3 = int.Parse(Console.ReadLine());
                    arr[i].marks = temp3;
                }
                foreach(student i in arr)
                {
                    Console.WriteLine("Name: " + i.name + " ID: " + i.id + " Marks: " + i.marks);
                } 
            */
        #endregion

        #region Day3-VarDynamic
        /*
                var x = 10;
                Console.WriteLine(x);
                // var's datatype is known at compile time itself if we initialize it to be int we cannot change it further.
                // var variable must be initialized at the time of declaration
                dynamic y;
                y = 10;
                Console.WriteLine(y);
                y = "Sai Vamshi";
                Console.WriteLine(y);
                // dynamic's datatype is known at runtime 
                // it can change its datatype at runtime.
                addVal(2, 4);
                addVal(44.30, 8.40);
                // Using dynamic keyword we can write a single function instead of 2 functions
                // The single function can handle the addition for all the datatypes 
            */
        #endregion

        #region Day4-Classes and Objects
        /*
                Student s = new Student();
                s.createStudent("Sai Vamshi",123);
                s.setMarks(90, 98);
                Console.WriteLine(s.getAvg());

                Student s1 = new Student("KL Rahul", 10, 90, 95);
                Console.WriteLine(s1.getAvg());
                Person p1 = new Person("Sai Vamshi","965335435",97.6);
                // Compile time Polymorphism - method to be invoked is decided at compile time. (Method Overloading)
                p1.show();
                p1.show("hello");
        */
        #endregion

        #region Day5-Properties Alternatives of getter/setters
        /*
                Console.WriteLine("Alternative for Getters and Setters");
                getSet obj = new getSet("Sai Vamshi", "67443");
                Console.WriteLine("Name: " + obj.name+" ID: "+obj.id);
                obj.name = "Kl Rahsdxfcgvhbjgfdsdcfvbnmjnhgfddfghnjmhgffgfghgfghgfghgfghghgfghgghghgghgfuytyuiuygnngul";
                // For id we removed the set method so the below line is wrong like this we can prevent the change of ID.
                // obj.id = "748";
                Console.WriteLine("Name: " + obj.name + " ID: " + obj.id);
                obj.name = "KL Rahul";
                Console.WriteLine("Name: " + obj.name + " ID: " + obj.id);
            */
        #endregion

        #region Day5-AutoProperties
        /*
                Console.WriteLine("Auto Properties");
                autoProps obj1 = new autoProps();
                obj1.Name = "SaiVamshi";
                obj1.Id = "7748";
                obj1.show();
                autoProps obj2 = new autoProps() { Id = "7667", Name = "KL Rahul" };
                obj2.show();
            */
        #endregion

        #region Day6-StaticFields-Constructors-Methods
        /*
                HouseLoan cust1 = new HouseLoan(1, "Kl", 50000);
                HouseLoan cust2 = new HouseLoan(2, "MS", 54000);
                HouseLoan cust3 = new HouseLoan(3, "DK", 24000);
                HouseLoan cust4 = new HouseLoan(4, "VK", 34000);
                // ROI is same for every customer. 
                // Using ROI as static so that only one copy of it would be there.
                // Write Line is a static method.
                Console.WriteLine("Amt to be paid: "+cust1.calInterest());
                HouseLoan.ROI = 12.5;
                Console.WriteLine("Amt to be paid: " + cust1.calInterest());
                HouseLoan.myMethodStatic();
            */
        #endregion

        #region Day6-StaticClass
        /*
                Console.WriteLine("Sum= "+Calculation.add(3, 44.3));
                Console.WriteLine("Multiply= " + Calculation.multiply(4.5, 5.2));
            */
        #endregion

        #region Day7-NameSpacesTheory
        // Namespaces are a logical group of classes and namespaces.
        // It is used for avoiding name clashes between two sets of code.
        /*
            namespace Admin
            {
                class Employee
                {
                    public void Add() { }
                    public void Update() { }
                }
            }
            // to create an object 
            var e1=new Admin.Employee();
            e1.Add();
            e1.Update();
            namespace HR
            {
                class Employee
                {
                    public void CalculateSalary() { }
                    public void CalculateLeaves() { }
                }
            }
            var e2=HR.Employee();
            e2.CalculateSalary();
            e2.CalculateLeaves();
     **************** STANDARD WAY OF CREATING NAMESPACES ***************
            namespace MyOrganization
            {
                namespace Admin
                {
                    class Employee
                    {
                        public void add() {}
                        public void update() {}
                    }
                }
            }
            var obj=MyOrganization.Admin.Employee();
    **************** STANDARD WAY OF CREATING NAMESPACES ***************

        */
        #endregion

        #region Day7-NameSpaceImplementation
        /*
                Admin.Employee e1 = new Admin.Employee();
                e1.Add();
                e1.Update();

                HR.Employee e2 = new HR.Employee();
                e2.CalculateSalary();
            */
        #endregion

        #region Day7-UsingNamespaceDemo
        /*
                Employee e1 = new Employee();
                e1.calculateSalary();
                // Console is a class in system namespace so the 1st line we wrote 
                // using System;
                Console.WriteLine();
            */
        #endregion

        #region Day-7-IMPImporting.NetCoreClassLibrary
        /*
                Employee emp = new Employee()
                {
                    empID = 1,
                    name = "KL Rahul",
                    salaryPerDay = 34000,
                    HRA = 9.2
                };
                Console.WriteLine("Emp Salary= "+emp.getSal(7)); 
            */
        #endregion

        #region Day-8-Inheritance
        /*
                Customer c = new Customer
                {
                    custId = 1,
                    name="Kl Rahul",
                    email="k.rahul@180092.com"
                };
                c.custShow();
                // Private Fields cannot be inherited
                BankCustomer bc = new BankCustomer
                {
                    custId = 2,
                    name = "Rohit",
                    email = "k.rohit@180092.com",
                    accountNo = 23,
                    balance = 34.4
                };
                bc.custShow();
                bc.bankShow();
                // Default constructor of child class invokes the default constructor of base class
                // Calling the base class constructor from child class constructor using the base keyword is constructor chaining.
                // base keyword is a default object of its base class
                // It is also used to refer the members of the base class from derived class
                BankCustomer temp=new BankCustomer(233,"Kl rahul","saivamshi@gmail.com",747478,847.34);
                temp.getDetails();
                // Method Overiding
                // If a method in a derived class has the same signature with diff implementation
                // from the base class then it has overridden the method in base class
                // Method of the base class must be virtual and method in derived class
                // must be declared as override
            */
        #endregion

        #region Day-9-SealedMethodsClasses
        /*
                // Sealed method is a method which is declared with a keyword as sealed
                // and it cannot be overriden by the derived class.
                // But we may invoke this method.
                // Sealed keyword is always used in combination with override keyword.
                // Sealed class is the class which is declared with the keyword sealed and it cannot be derived by other classes.
                // A->B->C
                // if A has a virtual method , B has overriden the virtual method and
                // sealed it so now C cannot override it.
                C obj = new C();
                obj.show();
            */
        #endregion

        #region Day-10-AbstractClassMethods
        /*
            // Abstract Methods:
            // Method declared with keyword abstract
            // Does not have body
            // Should be implemented by derived class
            // If method is abstact then the class should be abstract
            // Abstract Class:
            // It is the blueprint of the problem.
            // Says what to do not how to do
            // Abstract class is the class declared with keyword abstract
            // It has atleast one abstract method
            // Object creation not possible
            // Reference Creation is possible
            // Used to implement runtime polymorphism
            A a;
            a = new B();
            a.show();
            a.display();
        */
        #endregion

        #region Day-10-RuntimePolymorphism
        /*
                    // Runtime Polymorphism:
            // Derive the abstact class by one or more classes and overriding 
            // all the abstracy methods.
            // Creating a reference of the abstarct class and making it an
            // object of the derived class based on user input.
            // Calling the method of abstact class.
            // Method gets referred from derived class at runtime based on
            // user input.
            Employee e;
            Console.WriteLine("1.SDE 2.Team Lead");
            int type = int.Parse(Console.ReadLine());
            switch (type)
            {
                case 1:
                    e = new SDE()
                    {
                        empId=1,
                        name="KL Rahul",
                        salPerHr=45,
                        technology=".Net"
                    };
                    break;
                case 2:
                    e = new TeamLead()
                    {
                        empId=2,
                        name="VK",
                        salPerHr=90,
                        size=10
                    };
                    break;
                default:
                    e = new TeamLead()
                    {
                        empId = 2,
                        name = "VK",
                        salPerHr = 90,
                        size = 10
                    };
                    break;
            }
            e.details();
            e.calculateSal(10);
            // Only those methods which are present in the base class can be invoked with the base class's reference
        */
        #endregion

        #region Day-11-Interfaces
        /*
            /*
            INterface is a pure abstract class
            It is a reference type and it contains only abstract members.
            any implementation must be places in clas that implements it.
            all member declarations inside interface are implicity public and abstarct.
            We can implement multiple inheritance using interfaces.
            iOperations obj;
            obj = new Employee();
            obj.create();
            bulkOperations obj1;
            obj1 = new Employee();
            obj1.deleteAll();
        */
        #endregion

        #region Day-11-PartialClasses
        /*
            /*
            Partial class is a class declared with partial keyword.
            Its implementation can be spread over multiple files.
            Multiple classes prefixed with partial keyword with same class
            name and diff methods in diff files acts as a single class
            with all the methods.
        
            A a = new A();
            a.show();

            // a.display() is not working see afterwards.
        */
        #endregion

        #region Day-11-Collections
        /*
         * /*
            Collections is an alternate way of storing multiple variable number of elements or objects.
            Like Stack,Queue,ArrayList etc. are collection classes present in System.Collection namespace.
            In collection object of a queue we can store few integers and few strings.
            We need to type cast the elements while accessing it.
            Stack s = new Stack();
            s.Push(23);
            s.Push(34);
            Console.WriteLine(s.Pop().ToString());
            Console.WriteLine("Count= " + s.Count);
            Console.WriteLine(s.Peek().GetType());

            Queue q = new Queue();
            q.Enqueue("KL R");
            q.Enqueue("Sai Vamshi");
            q.Enqueue("Virat Kohli");
            Console.WriteLine("Elem: " + q.Dequeue());
        */
        #endregion

        #region Day-12-ExceptionHandling
        /*
            Runtime error is exception.
            Exception handling is an in-built mechanism in .net core to detect and handle runtime errors.
            C# provides try, catch and finally to do exception handling.
            try
            {
                int[] a = new int[2];
                a[0] = 4;
                a[1] = 44;
                a[2] = 78473;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            // Above e is the main class runtime polymorphisn is happening here.
            try
            {
                int[] a = new int[2];
                a[0] = 4;
                int x = 0;
                a[1] = 44 / x;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            DivClass obj = new DivClass();
            // Div Class is the class library created in the root dir whose project reference has been added.
            try
            {
                Console.WriteLine("Div Result: " + obj.divide(30, 0));
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }  
        */
        #endregion

        #region Day-13,14-Delegates
        /*
         // Delegate is a method signature.
            Test t = new Test(show);
            t("Sai Vamshi");
            t = new Test(display);
            t("KL Rahul");

            Console.WriteLine("Both Invoked");

            Test t1 = new Test(show);
            // Multi casting delegates
            t1 += new Test(display);
            t1("Virat Kohli");

            Console.WriteLine("Only one now");

            t1 -= new Test(display);
            t1("MS Dhoni");

            anotherTest obj = new anotherTest(show);
            Sample sample = new Sample();
            sample.callBack(obj);

            Console.WriteLine("Directly passing the method name");
            sample.callBack(display);
         */ 
        #endregion

    }
    #region Day-13,14-Delegates
    /*
    static void show(string name)
    {
        Console.WriteLine("Show: "+name);
    }
    static void display(string name)
    {
        Console.WriteLine("Display: " + name);
    }
*/ 
    #endregion

}
