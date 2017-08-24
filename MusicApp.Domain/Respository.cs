using MusicApp.Data;
using MusicApp.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Domain
{
    public class Respository
    {
        public void GetAllPersons(int authorId)
        {
            using (var context = new MusicAppDb())
            {
                context.Authors.ToList().Select(x => AuthorDTO.FromEntity(x)).ToList().ForEach(x => Console.WriteLine(x.FullName));
            }
        }

        public void GetAllSongs()
        {
            using (var context = new MusicAppDb())
            {
                context.Songs.ToList().Select(x => SongDTO.FromEntity(x)).ToList().ForEach(x => Console.WriteLine(x.NameAndDuration));
            }
        }
    }
}
