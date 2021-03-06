﻿using NUnit.Framework;
using Sanatana.Contents.Caching;
using Sanatana.Contents.Objects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Should;

namespace Sanatana.ContentsSpecs.Caching
{
    [TestFixture]
    public class UrnIdSpecs
    {
        [Test]
        public void then_does_not_add_entry_with_already_present_key()
        {
            //then_does_not_add_entry_with_already_present_key
            string cacheKey = UrnId.Create<List<CategoryRolePermission<long>>>();
            string expected = "urn:System.Collections.Generic.List`1[[Sanatana.Contents.Objects.Entities.CategoryRolePermission`1[[System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], Sanatana.Contents, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null]]:all";
            cacheKey.ShouldEqual(expected);
        }
    }
}
