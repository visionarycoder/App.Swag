﻿using Access.Numbers.Contract.Models;

namespace Access.Numbers.Service.Helpers;

public static class SwagExtension
{
    
    public static Swag Convert(this Resource.Data.NumbersDB.Models.ThreePointEstimate source)
    {
        var target = new Swag
        {
            Id = source.Id,
            Optimistic = source.Optimistic,
            MostLikely = source.MostLikely,
            Pessimistic = source.Pessimistic,
            Calculated = source.Calculated
        };
        return target;
    }

    public static Resource.Data.NumbersDB.Models.ThreePointEstimate Convert(this Swag source)
    {
        var target = new Resource.Data.NumbersDB.Models.ThreePointEstimate
        {
            Id = source.Id,
            Optimistic = source.Optimistic,
            MostLikely = source.MostLikely,
            Pessimistic = source.Pessimistic,
            Calculated = source.Calculated
        };
        return target;
    }

    public static IEnumerable<Swag> Convert(this IEnumerable<Resource.Data.NumbersDB.Models.ThreePointEstimate> source)
    {
        return source.Select(i => i.Convert());
    }

    public static IEnumerable<Resource.Data.NumbersDB.Models.ThreePointEstimate> Convert(this IEnumerable<Swag> source)
    {
        return source.Select(i => i.Convert());
    }

}