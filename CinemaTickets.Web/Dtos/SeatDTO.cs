﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CinemaTickets.Web.Dtos
{
    public class SeatDTO
    {
        public int SeatID { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public int HallID { get; set; }
        public bool IsTaken { get; set; }
    }
}