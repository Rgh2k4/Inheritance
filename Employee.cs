﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Employee
    {
        private string id;

        private string name;

        private string address;

        private string phone;

        private long sin;

        private string dob;

        private string dept;

        public Employee()
        {
            new Employee();
        }
    }

    public Employee(string id, string name, string address, string phone, long sin, string dob, string dept)
    {
        this.id = id;
        this.name = name;
        this.address = address;
        this.phone = phone;
        this.sin = sin;
        this.dob = dob;
        this.dept = dept;
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

    public string GetDept(string dept)
    {
        return dept;
    }

    public void setDept(string dept)
    {
        this.dept = dept;
    }
    public string toString()
    {
        return "Employee";
    }
}