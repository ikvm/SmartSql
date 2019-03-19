﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SmartSql.Configuration.Tags
{
    public class IsNull : Tag
    {
        public override bool IsCondition(RequestContext context)
        {
            Object reqVal = EnsurePropertyValue(context);
            return reqVal == null;
        }
    }
}
