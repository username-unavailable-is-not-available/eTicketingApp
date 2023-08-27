using AutoMapper;

namespace BLL.Services
{
    public class MapperService<Src, Dest>
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Src, Dest>();
            }
            );
            var mapper = new Mapper(config);
            return mapper;
        }
    }
}