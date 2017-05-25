using App.Business.Model;
using App.Business.ViewModel;
using AutoMapper;

namespace App.Business.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<ExampleViewModel, Example>();
        }
    }
}
