﻿using InfiGrowth.Entity.Manage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiGrowth.Services.Services.Interfaces
{
    public interface IHotelService
    {
        Task<Hotel> GetHotelById(Guid HotelId);
    }
}
