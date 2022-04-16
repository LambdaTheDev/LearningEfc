using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text.Json;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using LearningEfc.Databases;
using LearningEfc.Extensions;
using LearningEfc.Models;
using LinqKit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LearningEfc.Controllers
{
    [Route("Test")]
    public class TestController : Controller
    {
        private readonly TestDatabase _db;
        private readonly IMapper _mapper;


        public TestController(TestDatabase db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        
        [HttpGet]
        public void Tests()
        {
            var selectMultiple = _db.Foos.Select(ExpectedCodeExtensions.FooToDtoExpr);
            Console.WriteLine(selectMultiple.ToQueryString());
            Console.WriteLine();

            var selectMultipleMapped = _db.Foos.ProjectTo<FooDto>(_mapper.ConfigurationProvider);
            Console.WriteLine(selectMultipleMapped.ToQueryString());
            
            Console.WriteLine(JsonSerializer.Serialize(selectMultiple.ToList()));
            Console.WriteLine();Console.WriteLine();Console.WriteLine();
            Console.WriteLine(JsonSerializer.Serialize(selectMultipleMapped.ToList()));
        }

        [HttpGet("RandomData")]
        public void FillRandomData()
        {
            Random r = new Random();

            List<Bar> randomBars = new List<Bar>(16);
            for (int i = 0; i < 16; i++)
            {
                Bar b = new Bar
                {
                    Secret = r.Next(),
                    Something = r.Next(),
                    Something2 = r.Next(),
                };
                randomBars.Add(b);
                _db.Bars.Add(b);
            }

            _db.SaveChanges();

            List<Foo> randomFoos = new List<Foo>(3);
            for (int i = 0; i < 3; i++)
            {
                Foo foo = new Foo
                {
                    Secret = r.Next(),
                    Something = r.Next(),
                    TestBarId = randomBars[r.Next(0, 16)].Id,
                    Bars = new List<Bar>(randomBars.Where(x => r.NextDouble() > 0.75))
                };

                _db.Foos.Add(foo);
            }

            _db.SaveChanges();
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