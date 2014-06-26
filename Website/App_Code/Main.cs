﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class Computer
{
    public Computer()
    {
        this.Orders = new HashSet<Order>();
    }

    public int ID { get; set; }
    public string Name { get; set; }
    public string Model { get; set; }
    public string Price { get; set; }
    public string ScreenSize { get; set; }
    public string Processor { get; set; }
    public string ListPicture { get; set; }
    public string DetailPicture { get; set; }

    public virtual ICollection<Order> Orders { get; set; }
}

public partial class Order
{
    public int ID { get; set; }
    public int UserID { get; set; }
    public int ComputerID { get; set; }
    public System.DateTime Date { get; set; }

    public virtual Computer Computer { get; set; }
    public virtual User User { get; set; }
}

public partial class User
{
    public User()
    {
        this.Orders = new HashSet<Order>();
    }

    public int ID { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public string ZipCode { get; set; }
    public bool IsAdmin { get; set; }

    public virtual ICollection<Order> Orders { get; set; }
}
