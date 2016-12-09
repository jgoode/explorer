using AutoMapper;
using explorer_api.Models;

namespace explorer_api.ViewModels.Mappings {
    public class ViewModelToDomainMappingProfile: Profile {
        protected override void Configure() {
            CreateMap<JournalFileViewModel, JournalFile>();
        }
    }
}