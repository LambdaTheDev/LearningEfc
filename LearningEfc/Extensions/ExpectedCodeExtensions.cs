using System;
using System.Linq;
using System.Linq.Expressions;
using LearningEfc.Models;
using LinqKit;

namespace LearningEfc.Extensions
{
    public static class ExpectedCodeExtensions
    {
        public static Expression<Func<Bar, BarDto>> BarToDtoExpr = x => new BarDto { Something = x.Something, Something2 = x.Something2}; 
        public static Expression<Func<Foo, FooTestDto>> FooToTestDtoExpr = x => new FooTestDto{ Something = x.Something, TestBar = BarToDtoExpr.Invoke(x.TestBar)};
        public static Expression<Func<Foo, FooDto>> FooToDtoExpr = x => new FooDto { Something = x.Something, Bars = x.Bars.AsQueryable().Select(BarToDtoExpr).ToList()};

        public static Func<Bar, BarDto> BarToDtoProjection = BarToDtoExpr.Compile();
        public static Func<Foo, FooDto> FooToDtoProjection = FooToDtoExpr.Compile();
        public static Func<Foo, FooTestDto> FooToTestDtoProjection = FooToTestDtoExpr.Compile();

        // public static Expression<Func<Foo, FooDto>> ManuallyTypedQuery = x => x == null ? null : new FooDto(x.Something, x.Bars.Select(y => new BarDto(y.Something, y.Something2)).ToList());
    }
}