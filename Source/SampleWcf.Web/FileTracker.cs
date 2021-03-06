﻿using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace SampleWcf.Web
{

    [ServiceContract]
    public interface IFileTracker
    {

        [OperationContract, WebInvoke(Method = "POST")]
        string Track(IEnumerable<FileDescriptor> files);

    }

}
