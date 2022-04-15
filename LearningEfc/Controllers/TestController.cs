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
            var expr = db.Foos.Select(FooExtensions.FooTestExpression);
            Console.WriteLine(expr.ToQueryString());
            
            var expr2 = db.Foos.Select(FooExtensions.FooTestExpressionB);
            Console.WriteLine(expr2.ToQueryString());
            
            var expr3 = db.Foos.Select(FooExtensions.FooTestExpressionC);
            Console.WriteLine(expr3.ToQueryString());
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