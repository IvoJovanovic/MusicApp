using MusicApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Domain.DTOs
{
    public class SongDTO
    {
        public int Id { get; set; }

        public string NameAndDuration { get; set; }

        public static SongDTO FromEntity(Song song)
        {
            return new SongDTO()
            {
                Id = song.Id,
                NameAndDuration = song.SName + " " + song.Duration.Value.Hours + " sat " + song.Duration.Value.Minutes + " minuta i " + song.Duration.Value.Seconds + " sekundi."
            };
        }
    }
}
