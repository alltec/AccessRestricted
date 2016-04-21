using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Configuration;

using APISerializable.ViewModels;

namespace APISerializable.Controllers
{
    public class ValuesController : ApiController
    {
        //// GET api/values
        public IEnumerable<Employee> Get()
        {
            return new Employee[]
            {
                new Employee() {
                EmpNumber=35, EmpName="Vishal Bajaj"},
                new Employee() {
                EmpNumber=36, EmpName="Ashutosh Dikshit"},
                new Employee() {
                EmpNumber=37, EmpName="D Panda"}
            };
        }

        // GET api/values/5
        public Employee Get(int id)
        {
            return new Employee()
            {
                EmpNumber=1,EmpName="test"
            };
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }

    public class Employee
    {
    
        public int EmpNumber { get; set; }
        public string EmpName { get; set; }

    }
}
