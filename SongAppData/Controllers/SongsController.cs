using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SongAppDataAccess;

namespace SongAppData.Controllers
{
    public class SongsController : ApiController
    {
        public IEnumerable<Song>Get()
        {
            using (SongAppDbEntities entities = new SongAppDbEntities())
            {
                return entities.Songs.ToList();
            }
        }
        public Song Get(int id)
        {
            using (SongAppDbEntities entities = new SongAppDbEntities())
            {
                return entities.Songs.FirstOrDefault(e => e.SongID == id);
            }
        }
    }
}
