﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atomia.OrderPage.Core.Services
{
    

    public class DomainSearchResult
    {
    }

    public interface IDomainSearchService
    {
        DomainSearchResult FindDomains(DomainSearchQuery query);
    }
}
