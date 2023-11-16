using AutoMapper;
using BusinessObject.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Mapper
{
    public class MemberConfig
    {
        public static void createMap(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Member, MemberDTO>();
                //.ForMember(dest => dest.Password, opt => opt.Ignore()); ;

        }
    }
}
