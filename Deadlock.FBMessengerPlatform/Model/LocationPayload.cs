﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class LocationPayload : IPayload
    {
        public Coordinates coordinates { get; set; }
    }
}
