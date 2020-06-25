using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace InnRoadTest.Core.Specification
{
    public interface ISpecification<TEntity>
    {
        Expression<Func<TEntity, bool>> Criteria { get; }
        List<Expression<Func<TEntity, object>>> Includes { get; }
        List<string> IncludeStrings { get; }
    }
}
