using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4
{
    [CrmPluginRegistration("Create", 
    "account", StageEnum.PreOperation, ExecutionModeEnum.Synchronous,
    "","PreCreate Account", 1, 
    IsolationModeEnum.Sandbox 
    ,Id = "f3a94f1c-7627-ed11-9db1-00224823e0ed" 
    )]
    public class CreateAccountPlugin : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            //TODO:
        }
    }
}
