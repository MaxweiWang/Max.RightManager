using System;
using System.Collections.Generic;
using System.Text;

namespace Max.DataProvider.Core.Abstract.Query
{
    //
    using Max.DataProvider.BaseClass;
    using Max.DataProvider.Core.Abstract;
    using Max.DataProvider.Core.CodeAnalysis;

    //
    public abstract class AbstractBase
    {
        protected SQL SqlCode { get; set; }

        protected AbstractAdo Ado { get; set; }

        protected Analysis analysis { get; set; }

    }
}
