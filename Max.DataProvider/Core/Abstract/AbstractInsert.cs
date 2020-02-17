using System;
using System.Collections.Generic;
using System.Text;

namespace Max.DataProvider.Core.Abstract
{
    using Max.DataProvider.BaseClass;
    using Max.DataProvider.Core.CodeAnalysis;
    using Max.DataProvider.Core.Interface;
    using System.Data;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    public abstract class AbstractInsert<T> : InsOrUpdOrDelBase<T>, IInsert<T>
    {
        protected MemberInitExpression memberInitExpression { get; set; }
        public AbstractInsert(MemberInitExpression _MemberInitExpression, AbstractAdo _Ado, Analysis _Analysis)
          : base(_Ado, _Analysis)
        {
            this.memberInitExpression = _MemberInitExpression;
        }

        public abstract IInsert<T> Execute(List<SQL> SqlContainer, out object Id);
        public abstract object Execute();
        public abstract Task<object> ExecuteAsync();
        public abstract IInsert<T> IgnoreCols(Expression<Func<T, dynamic>> IgnoreColumns);
        public abstract IInsert<T> IgnoreColsIF(bool IF, Expression<Func<T, dynamic>> IgnoreColumns);
        public abstract SQL ToSql(out object Id);
    }
}
