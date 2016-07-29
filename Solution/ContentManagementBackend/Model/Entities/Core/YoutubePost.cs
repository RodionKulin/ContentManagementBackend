﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentManagementBackend
{
    public class YoutubePost<TKey> : Post<TKey>
        where TKey : struct
    {
        public string YoutubeUrl { get; set; }
    }
}
