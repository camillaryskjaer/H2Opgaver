﻿using Hotel_LandLyst_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_LandLyst_WebApp.Dal
{
    //This class is responsible for communication with data base 
    public class DalManager
    {
        private static DalManager _manager = null;
        private static object controle = new object();
       
        //creates singleton with thread lock
        public static DalManager Manager
        {
            get
            {
                lock(controle)
                {
                    if(_manager == null)
                    {
                        _manager = new DalManager();
                        return _manager;
                    }
                    else
                    {
                        return _manager;
                    }
                }
            }
        }

        public void SaveNewRoomToDataBase(RoomModel roomModel, string connectionString)
        {
            SqlConnection sqlConnection = new SqlConnection();
        }


    }
}
