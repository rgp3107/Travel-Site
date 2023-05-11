using AutoMapper;
using InfiGrowth.Entity.Manage;
using InfiGrowth.Models.Dto;
//using InfiGrowth.Entity.Manage;
using dto = InfiGrowth.Models.Dto;
using model = InfiGrowth.Models.Models;

namespace InfiGrowth.Services.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //CreateMap<model.Customer, Customer>();
            //CreateMap<Customer, model.Customer>();

            CreateMap<Booking, BookingRequest>();
            CreateMap<BookingRequest, Booking>();
        }
    }
}
