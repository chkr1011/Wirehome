﻿using System;
using HA4IoT.Contracts.Api;
using HA4IoT.Contracts.Services;
using HA4IoT.Contracts.Services.System;
using Newtonsoft.Json.Linq;

namespace HA4IoT.Services.System
{
    [ApiServiceClass(typeof(IDateTimeService))]
    public class DateTimeService : ServiceBase, IDateTimeService
    {
        public DateTime Date => DateTime.Now.Date;

        public TimeSpan Time => DateTime.Now.TimeOfDay;
    
        public DateTime Now => DateTime.Now;
    
        [ApiMethod(ApiCallType.Request)]
        public void Status(IApiContext apiContext)
        {
            apiContext.Response = JObject.FromObject(this);
        }
    }
}
