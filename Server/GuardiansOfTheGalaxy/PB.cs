﻿using GuardiansOfTheGalaxy.DAL.Entities;
using GuardiansOfTheGalaxy.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuardiansOfTheGalaxy
{
    public class PB
    {
        /// <summary>
        /// a shorter name for the settings/properties objects.
        /// </summary>
        public static Settings P = Settings.Default;

        public static GuardsDB DB = new GuardsDB();        
    }
}