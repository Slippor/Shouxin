using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShouxinServer.Common;

namespace ShouxinServer.ViewModels
{
    public class BaseViewModel
    {
        public String CommonCssPath { get { return StyleConfigs.CommonVirtualPath; } }
    }
}