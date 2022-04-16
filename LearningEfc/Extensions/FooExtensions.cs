using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using LearningEfc.Models;

namespace LearningEfc.Extensions
{
    public static class FooExtensions
    {
        // /*
        //  *
        //  * MY GOAL: TO HAVE ONE, OR TWO MODEL-TO-DTO-CONVERTERS TO REDUCE
        //  * WRITING THE SAME CODE A LOT AMOUNT OF TIMES IN MY ACTUAL PROJECT
        //  * 
        //  */
        //
        // public static Expression<Func<Foo, FooDto>> FooExpressionA = x => new FooDto(x.Something, x.Bars.Select(y => new BarDto(y.Something, y.Something2)).ToList());
        // public static Expression<Func<Foo, FooDto>> FooExpressionB = x => new FooDto(x.Something, x.Bars.Select(BarFunc).ToList());
        // public static Expression<Func<Foo, FooDto>> FooExpressionC = x => new FooDto(x.Something, x.Bars.Select(BarMethodA).ToList());
        // public static Expression<Func<Foo, FooDto>> FooExpressionD = x => new FooDto(x.Something, x.Bars.Select(BarMethodB).ToList());
        // public static Expression<Func<Foo, FooDto>> FooExpressionE = x => new FooDto(x.Something, x.Bars.AsQueryable().Select(BarExpression).ToList());
        // public static Expression<Func<Foo, FooDto>> FooExpressionF = x => new FooDto(x.Something, x.Bars.AsQueryable().SelectBars().ToList());
        //
        // public static readonly Expression<Func<Foo, FooTestDto>> FooTestExpression = x => new FooTestDto(x.Something, BarExpression.Compile().Invoke(x.TestBar));
        // public static readonly Expression<Func<Foo, FooTestDto>> FooTestExpressionB = x => new FooTestDto(x.Something, new BarDto(x.TestBar.Something, x.TestBar.Something2));
        // public static readonly Expression<Func<Foo, FooTestDto>> FooTestExpressionC = x => new FooTestDto(x.Something, BarFunc.Invoke(x.TestBar));
        //
        // public static Expression<Func<Bar, BarDto>> BarExpression = x => x == null ? null : new BarDto(x.Something, x.Something2);
        //
        // public static Func<Bar, BarDto> BarFunc => x => x == null ? null : new BarDto(x.Something, x.Something2);
        // public static BarDto BarMethodA(Bar x) => new BarDto(x.Something, x.Something2);
        //
        // public static BarDto BarMethodB(Bar x)
        // {
        //     return new BarDto(x.Something, x.Something2);
        // }
        //
        // public static IQueryable<BarDto> SelectBars(this IQueryable<Bar> source)
        // {
        //     return source.Select(x => new BarDto(x.Something, x.Something2));
        // }
    }
}