using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMusic.Application.DTOs
{
    public class TokenResponseDto// tokengenerator da kullanılacak class
    {
        public TokenResponseDto(string token, DateTime expireDate)//property tanımlandı
        {
            Token = token;
            ExpireDate = expireDate;
        }
        public string Token { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}
