﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectConverter
{
public class VS2017Info: VSProjectVersionInfo, IVSIinfo, IVSVersionInfo
{
        /// <summary>
        /// The Tools Version for Visual Studio 2013 is always 4.0
        /// </summary>
        const string TOOLS_VERSION = "15.0";

        public override string OldToolsVersion
        {
            get
            {
                return Settings.Default.VS2017_OldToolsVersion;
            }//get
            set
            {
                throw new NotImplementedException();
            }//set
        }

        public override string ProductVersion
        {
            get
            {
                return string.Empty;
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        /// <summary>
        /// Gets and sets the available Target Framework Versions
        /// for Visual Studio 2017
        /// </summary>
        /// <remarks>Visual Studio 2013 supports .Net 2.0, .Net 3.0,
        /// .Net 3.5,.Net 4.0 and .Net 4.5 out of the box</remarks>
        public override string TargetFrameworkVersion
        {
            get
            {
                return Settings.Default.VS2017_TargetFramework;
            }//get
            set
            {
                throw new NotImplementedException();
            }//set
        }

        public override string ToolsVersion
        {
            get
            {
                return TOOLS_VERSION;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override string MaxFrameworkVersion
        {
            get
            {
                return "v4.6.1";
            }
        }//property

        public override string CheckFrameworkVersion(string strOldFrameworkVersion, string defaultFrameworkVersion = "v2.0")
        {
            return base.CheckFrameworkVersion(strOldFrameworkVersion, defaultFrameworkVersion);
        }

}
}
