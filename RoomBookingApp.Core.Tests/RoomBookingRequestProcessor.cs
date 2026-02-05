using System;
using System.Collections.Generic;
using System.Text;

namespace RoomBookingApp.Core.Tests
{
    public class RoomBookingRequestProcessor
    {
        public RoomBookingResult BookRoom(RoomBookingRequest request)
        {
            return new RoomBookingResult
            {
                FullName = request.FullName,
                Email = request.Email,
                Date = request.Date
            };
        }
    }
}
