using AutoMapper;
using explorer_api.Models;

namespace explorer_api.ViewModels.Mappings {
    public class DomainToViewModelMappingProfile: Profile {
        protected override void Configure()
        {
            CreateMap<JournalFile, JournalFileViewModel>() ;
            CreateMap<Journal, JournalViewModel>();
            CreateMap<Expedition, ExpeditionViewModel>();
        }
    }
}