#region Usings
#endregion


namespace TheSharpFactory.Domain
{
    public partial class MediaBL
    {
        /*
         *  This is a partial class.  
         *  This file contains Delete functions.     
         *
         */
        #region Public Methods
        public bool DeleteAlbum(int albumId)
        {
            return DeleteAlbumHelper(albumId);
        }
        public bool DeleteArtist(int artistId)
        {
            return DeleteArtistHelper(artistId);
        }
        public bool DeleteGenre(int genreId)
        {
            return DeleteGenreHelper(genreId);
        }
        public bool DeleteMediaType(int mediaTypeId)
        {
            return DeleteMediaTypeHelper(mediaTypeId);
        }
        public bool DeletePlaylist(int playlistId)
        {
            return DeletePlaylistHelper(playlistId);
        }
        public bool DeletePlaylistTrack(int playlistId, int trackId)
        {
            return DeletePlaylistTrackHelper(playlistId, trackId);
        }
        public bool DeleteTrack(int trackId)
        {
            return DeleteTrackHelper(trackId);
        }
        #endregion


        #region Private Helpers
        private bool DeleteAlbumHelper(int albumId)
        {
            Repository.MainDb.Media.Album.DeleteByPK(albumId);

            return true;
        }
        private bool DeleteArtistHelper(int artistId)
        {
            Repository.MainDb.Media.Artist.DeleteByPK(artistId);

            return true;
        }
        private bool DeleteGenreHelper(int genreId)
        {
            Repository.MainDb.Media.Genre.DeleteByPK(genreId);

            return true;
        }
        private bool DeleteMediaTypeHelper(int mediaTypeId)
        {
            Repository.MainDb.Media.MediaType.DeleteByPK(mediaTypeId);

            return true;
        }
        private bool DeletePlaylistHelper(int playlistId)
        {
            Repository.MainDb.Media.Playlist.DeleteByPK(playlistId);

            return true;
        }
        private bool DeletePlaylistTrackHelper(int playlistId, int trackId)
        {
            Repository.MainDb.Media.PlaylistTrack.DeleteByPK(playlistId, trackId);

            return true;
        }
        private bool DeleteTrackHelper(int trackId)
        {
            Repository.MainDb.Media.Track.DeleteByPK(trackId);

            return true;
        }
        #endregion
    }
}