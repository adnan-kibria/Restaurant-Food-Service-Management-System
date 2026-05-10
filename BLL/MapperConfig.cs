using AutoMapper;

namespace BLL
{
    public class MapperConfig
    {
        public static MapperConfiguration config = new MapperConfiguration(cfg =>
        {
            
        });

        public static Mapper GetMapper()
        {
            return new Mapper(config);
        }

    }
}
