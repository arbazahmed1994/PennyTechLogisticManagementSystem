﻿using PennyTechManagementSystem.Models;
using PennyTechManagementSystem.Repository;
using PennyTechManagementSystem.View_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PennyTechManagementSystem.Constant
{
    public static class ProcedureNameHandling
    {
        private static TripEndRepository _endTripRep = new TripEndRepository();

        public static string GetSP;

        public static string GetByIdSP;

        public static string CreateSP;
        
        public static string UpdateSP;

        public static string DeleteSP;

        // Public VARIABLES

        public static List<TripExpenceViewModel> list;

        public static int TripReference;

        public static List<TripBeginViewModel> TripBeginList;
    }
}