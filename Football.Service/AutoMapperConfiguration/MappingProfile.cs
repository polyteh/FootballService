using AutoMapper;
using Football.Service.AutoMapperConfiguration.MappingProfiles;
using StatisticsClient.AutoMapperConfiguration.MappingProfiles.Rapidapi;
using System;

namespace Football.Service.AutoMapperConfiguration
{
    public static class MappingProfile
    {
        public static MapperConfiguration GetAutoMapperConfiguration(IServiceProvider provider) 
        {
            var mapperConfiguration = new MapperConfiguration(cfg=> 
            {
                cfg.AddProfile(new LeagueMappingProfile());
                cfg.AddProfile(new LeagueMappingProfileRapidapi());
            }
            );

            return mapperConfiguration;
        }
    }
}
