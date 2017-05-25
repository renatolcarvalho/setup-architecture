using App.Business.Model;
using App.Business.ViewModel;
using AutoMapper;

namespace App.Business.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Example, ExampleViewModel>();
        }
    }
}
