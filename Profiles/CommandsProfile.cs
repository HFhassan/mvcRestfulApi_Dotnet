using AutoMapper;
using Commander.Dtos;
using Commander.Models;

namespace Commander.profiles
{
    public class CommandsProfile :Profile
    {
        public  CommandsProfile()
        {
            //source -> target
            CreateMap<Command,CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
            CreateMap<Command,CommandUpdateDto>();
        }
    }
}