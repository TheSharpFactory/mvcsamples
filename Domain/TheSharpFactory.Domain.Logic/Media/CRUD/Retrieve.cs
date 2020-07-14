#region Usings
using System.Collections.Generic;
using TheSharpFactory.Entity.MainDb.Media;
#endregion


namespace TheSharpFactory.Domain
{
    public partial class MediaBL
    {
        /*
         *  This is a partial class.  
         *  This file contains Retrieve functions.     
         *
         */

        #region Public Methods
        public List<Album> GetAllAlbums()
        {
            return GetAllAlbumsHelper();
        }
        public List<Artist> GetAllArtists()
        {
            return GetAllArtistsHelper();
        }
        public List<Genre> GetAllGenres()
        {
            return GetAllGenresHelper();
        }
        public List<MediaType> GetAllMediaTypes()
        {
            return GetAllMediaTypesHelper();
        }
        public List<Playlist> GetAllPlaylists()
        {
            return GetAllPlaylistsHelper();
        }
        public List<PlaylistTrack> GetAllPlaylistTracks()
        {
            return GetAllPlaylistTracksHelper();
        }
        public List<Track> GetAllTracks()
        {
            return GetAllTracksHelper();
        }
        #endregion


        #region Private Helpers
        private List<Album> GetAllAlbumsHelper()
        {
            return Repository.MainDb.Media.Album.ToList();
        }
        private List<Artist> GetAllArtistsHelper()
        {
            return Repository.MainDb.Media.Artist.ToList();
        }
        private List<Genre> GetAllGenresHelper()
        {
            return Repository.MainDb.Media.Genre.ToList();
        }
        private List<MediaType> GetAllMediaTypesHelper()
        {
            return Repository.MainDb.Media.MediaType.ToList();
        }
        private List<Playlist> GetAllPlaylistsHelper()
        {
            return Repository.MainDb.Media.Playlist.ToList();
        }
        private List<PlaylistTrack> GetAllPlaylistTracksHelper()
        {
            return Repository.MainDb.Media.PlaylistTrack.ToList();
        }
        private List<Track> GetAllTracksHelper()
        {
            return Repository.MainDb.Media.Track.ToList();
        }
        #endregion
    }
}
