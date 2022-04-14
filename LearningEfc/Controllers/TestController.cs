using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using LearningEfc.Databases;
using LearningEfc.Extensions;
using LearningEfc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LearningEfc.Controllers
{
    [Route("Test")]
    public class TestController : Controller
    {
        private readonly TestDatabase db;


        public TestController(TestDatabase db)
        {
            this.db = db;
        }
        
        [HttpGet]
        public void Tests()
        {
            var x = db.Foos.ToList();
            
            Dismiss("A", db.Foos, FooExtensions.FooExpressionA);
            Dismiss("B", db.Foos, FooExtensions.FooExpressionB);
            Dismiss("C", db.Foos, FooExtensions.FooExpressionC);
            Dismiss("D", db.Foos, FooExtensions.FooExpressionD);
            Dismiss("E", db.Foos, FooExtensions.FooExpressionE);
            Dismiss("F", db.Foos, FooExtensions.FooExpressionF);
        }

        public void Dismiss(string id, IQueryable<Foo> inst, Expression<Func<Foo, FooDto>> expr)
        {
            try
            {
                var query = inst.Select(expr);
                Console.WriteLine(query.ToQueryString());
            }
            catch (Exception e)
            {
                Console.WriteLine("ID: " + id);
                Console.WriteLine(e);
                Console.WriteLine();
            }
        }
    }
}