using System;

class EmployeeRecord
{
    static void Main(string[] args)
    {
        string firstName = "Alexandar";
        string lastName = "Ginovski";
        sbyte age = 15;
        string gender = "male";
        int id = 000103031203;
        int employeeNum = 27565823;

        Console.WriteLine("Profile of Employee with number {0} is:\n First name: {1} \n Last name {2} \n Age: {3} \n Gender {4} \n ID: {5}" , employeeNum, firstName, lastName, age, gender,          id);
    }
}

