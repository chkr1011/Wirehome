﻿using System;
using HA4IoT.Contracts.Api;
using Newtonsoft.Json.Linq;

namespace HA4IoT.Api
{
    public class ApiContext : IApiContext
    {
        public ApiContext(ApiCallType callType, string uri, JObject request, JObject response)
        {
            if (uri == null) throw new ArgumentNullException(nameof(uri));
            if (request == null) throw new ArgumentNullException(nameof(request));
            if (response == null) throw new ArgumentNullException(nameof(response));

            ResultCode = ApiResultCode.Success;

            CallType = callType;
            Uri = uri;
            Request = request;
            Response = response;
        }

        public ApiCallType CallType { get; }
        public string Uri { get; }
        public ApiResultCode ResultCode { get; set; }
        public JObject Request { get; }
        public JObject Response { get; set; }
    }
}
