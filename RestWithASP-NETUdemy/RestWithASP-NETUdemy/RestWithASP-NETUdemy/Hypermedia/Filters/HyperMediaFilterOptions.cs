﻿using RestWithASP_NETUdemy.Hypermedia.Abstract;
using System.Collections.Generic;

namespace RestWithASP_NETUdemy.Hypermedia.Filters
{
    public class HyperMediaFilterOptions
    {
        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}
