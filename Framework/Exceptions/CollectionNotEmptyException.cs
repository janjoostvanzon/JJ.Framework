﻿using System;
using System.Linq.Expressions;
using JJ.Framework.Reflection;

namespace JJ.Framework.Exceptions
{
    public class CollectionNotEmptyException : Exception
    {
        private const string MESSAGE = "{0} collection should be empty.";

        public CollectionNotEmptyException(Expression<Func<object>> expression)
            : base(string.Format(MESSAGE, ExpressionHelper.GetText(expression)))
        { }
    }
}