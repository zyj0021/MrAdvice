﻿#region Mr. Advice
// Mr. Advice
// A simple post build weaving package
// http://mradvice.arxone.com/
// Released under MIT license http://opensource.org/licenses/mit-license.php
#endregion
namespace MethodLevelTest.Advices
{
    using System;
    using ArxOne.MrAdvice.Advice;

    public class RecordCall : Attribute, IMethodAdvice
    {
        public static int Count;

        public void Advise(MethodAdviceContext call)
        {
            Count++;
            call.Proceed();
        }
    }
}
