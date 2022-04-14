using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using LearningEfc.Models;

namespace LearningEfc.Extensions
{
    public static class FooExtensions
    {
        public static Expression<Func<Foo, FooDto>> FooExpressionA = x => new FooDto(x.Something, x.Bars.Select(y => new BarDto(y.Something, y.Something2)).ToList());
        public static Expression<Func<Foo, FooDto>> FooExpressionB = x => new FooDto(x.Something, x.Bars.Select(BarFunc).ToList());
        public static Expression<Func<Foo, FooDto>> FooExpressionC = x => new FooDto(x.Something, x.Bars.Select(BarMethodA).ToList());
        public static Expression<Func<Foo, FooDto>> FooExpressionD = x => new FooDto(x.Something, x.Bars.Select(BarMethodB).ToList());

        public static Expression<Func<Bar, BarDto>> BarExpression = x => new BarDto(x.Something, x.Something2);

        public static Func<Bar, BarDto> BarFunc => x => new BarDto(x.Something, x.Something2);
        public static BarDto BarMethodA(Bar x) => new BarDto(x.Something, x.Something2);

        public static BarDto BarMethodB(Bar x)
        {
            return new BarDto(x.Something, x.Something2);
        }
    }
}