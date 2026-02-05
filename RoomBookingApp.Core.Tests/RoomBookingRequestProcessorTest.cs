using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoomBookingApp.Core.Tests
{
    public  class RoomBookingRequestProcessorTest
    {
        [Fact]
        public void Should_Return_Room_Booking_Request()
        {
            //Arrange
            var request = new RoomBookingRequest
            {
                FullName = "Test User",
                Email = "test@test.com",
                Date = new DateTime(2021, 12, 12)
            };

            var processor = new RoomBookingRequestProcessor();

            //Act
            RoomBookingResult result = processor.BookRoom(request);

            //Assert
            //Assert.Equal(request.FullName, result.FullName);
            //Assert.Equal(request.Email, result.Email);
            //Assert.Equal(request.Date, result.Date);

            //Shouldly Library Assertions
            result.ShouldNotBeNull();
            result.FullName.ShouldBe(request.FullName);
            result.Email.ShouldBe(request.Email);
            result.Date.ShouldBe(request.Date);
        }
    }


}
