using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShouxinServer.Common;

namespace ShouxinServer.ViewModels
{
    /// <summary>
    /// Base View Model
    /// </summary>
    public class BaseViewModel
    {
        public String CommonCssPath { get { return StyleConfigs.CommonVirtualPath; } }

        /// <summary>
        /// 
        /// </summary>
        public virtual List<String> CustomCssPathes { get { return null; } set { } }
    }
}