﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public interface ITemplatePayload : IPayload
    {
        string template_type { get; set; }
    }
}
