using MusicApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Domain.DTOs
{
    public class AuthorDTO
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public List<SongDTO> Songs { get; set; }

        public static AuthorDTO FromEntity(Author author)
        {
            return new AuthorDTO()
            {
                Id = author.Id,
                FullName = author.FullName,
                Songs = author.Songs.Where(x=>x.Author == author).Select(song => SongDTO.FromEntity(song)).ToList()
            };
        }
    }
}
