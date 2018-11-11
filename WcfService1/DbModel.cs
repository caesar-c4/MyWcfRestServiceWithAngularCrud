using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService1
{
    public class DbModel:DbContext
    {
        public DbModel():base("Name=dbmodel")
        {

        }

        public DbSet<Employee> employee { get; set; }

    }
    [DataContract]
    public class Employee
    {
        [Key]
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Contact { get; set; }
        [DataMember]
        public string Address { get; set; }

    }

}