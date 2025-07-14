﻿using PSD_LAB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LAB.Repositories
{
    public class DatabaseSingleton
    {
        private static Database1Entities db = null;
        
        public static Database1Entities GetInstance()
        {
            if (db == null)
            {
                db = new Database1Entities();
            }
            return db;
        }
    }
}