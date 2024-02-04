using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Java.Util.Jar.Attributes;
using Xamarin.KotlinX.Coroutines;

namespace Inheritance
{
    public class Salaried : Employee
    {
        public double Salary { get; set; }

        public Salaried() { }
    }

    public Salaried(string id, string name, string address, string phone, long sin, string dob, string dept, double salary)
    {
        this.id = id;
        this.name = name;
        this.address = address;
        this.phone = phone;
        this.sin = sin;
        this.dob = dob;
        this.dept = dept;
        this.salary = salary;
    }

    public string getId(string id)
    {
        return id;
    }

    public void setId(string id)
    {
        this.id = id;
    }

    public string getName(string name)
    {
        return name;
    }

    public void setName(string name)
    {
        this.name = name;
    }

    public string getAddress(string address)
    {
        return address;
    }

    public void setAddress(string address)
    {
        this.address = address;
    }

    public string getPhone(string phone)
    {
        return phone;
    }

    public void setPhone(string phone)
    {
        this.phone = phone;
    }

    public long getSin(long sin)
    {
        return sin;
    }

    public void setSin(long sin)
    {
        this.sin = sin;
    }

    public string getDob(string dob)
    {
        return dob;
    }

    public void setDob(string dob)
    {
        this.dob = dob;
    }

    public string getDept(string dept)
    {
        return dept;
    }

    public string setDept(string dept)
    {
        this.dept = dept;
    }

    public double getSalary(double salary)
    {
        return salary;
    }

    public double setSalary(double salary)
    {
        this.salary = salary;
    }

    public double GetPay() { }

     public string ToString() { }
}    