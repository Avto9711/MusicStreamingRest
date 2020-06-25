using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace InnRoadTest.Core.Specification
{
    public class BaseSpecification<TEntity> : ISpecification<TEntity>
    {
        public Expression<Func<TEntity, bool>> Criteria { get; }

        public BaseSpecification(Expression<Func<TEntity, bool>> criteria = null)
        {
            Criteria = criteria;
        }

        public List<Expression<Func<TEntity, object>>> Includes { get; } = new List<Expression<Func<TEntity, object>>>();

        public List<string> IncludeStrings { get; } = new List<string>();

        public virtual void AddInclude(Expression<Func<TEntity, object>> includeExpression)
        {
            Includes.Add(includeExpression);
        }
        public virtual void AddInclude(string includeString)
        {
            IncludeStrings.Add(includeString);
        }
    }
}
