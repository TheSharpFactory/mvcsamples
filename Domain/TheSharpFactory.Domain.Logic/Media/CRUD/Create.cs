#region Usings
using TheSharpFactory.Entity.MainDb.Media;
#endregion


namespace TheSharpFactory.Domain
{
    public partial class MediaBL
    {
        /*
         *  This is a partial class.  
         *  This file contains Create functions.     
         *
         */
        #region Public Methods
        public Album CreateAlbum(Album entity)
        {
            return CreateAlbumHelper(entity);
        }
        public Artist CreateArtist(Artist entity)
        {
            return CreateArtistHelper(entity);
        }
        public Genre CreateGenre(Genre entity)
        {
            return CreateGenreHelper(entity);
        }
        public MediaType CreateMediaType(MediaType entity)
        {
            return CreateMediaTypeHelper(entity);
        }
        public Playlist CreatePlaylist(Playlist entity)
        {
            return CreatePlaylistHelper(entity);
        }
        public PlaylistTrack CreatePlaylistTrack(PlaylistTrack entity)
        {
            return CreatePlaylistTrackHelper(entity);
        }
        public Track CreateTrack(Track entity)
        {
            return CreateTrackHelper(entity);
        }
        #endregion


        #region Private Helpers
        private Album CreateAlbumHelper(Album entity)
        {
            if(Repository.MainDb.Media.Album.Create(entity))
                return Repository.MainDb.Media.Album.ByPK(entity.AlbumId);

            return null;
        }
        private Artist CreateArtistHelper(Artist entity)
        {
            if(Repository.MainDb.Media.Artist.Create(entity))
                return Repository.MainDb.Media.Artist.ByPK(entity.ArtistId);

            return null;
        }
        private Genre CreateGenreHelper(Genre entity)
        {
            if(Repository.MainDb.Media.Genre.Create(entity))
                return Repository.MainDb.Media.Genre.ByPK(entity.GenreId);

            return null;
        }
        private MediaType CreateMediaTypeHelper(MediaType entity)
        {
            if(Repository.MainDb.Media.MediaType.Create(entity))
                return Repository.MainDb.Media.MediaType.ByPK(entity.MediaTypeId);

            return null;
        }
        private Playlist CreatePlaylistHelper(Playlist entity)
        {
            if(Repository.MainDb.Media.Playlist.Create(entity))
                return Repository.MainDb.Media.Playlist.ByPK(entity.PlaylistId);

            return null;
        }
        private PlaylistTrack CreatePlaylistTrackHelper(PlaylistTrack entity)
        {
            if(Repository.MainDb.Media.PlaylistTrack.Create(entity))
                return Repository.MainDb.Media.PlaylistTrack.ByPK(entity.PlaylistId, entity.TrackId);

            return null;
        }
        private Track CreateTrackHelper(Track entity)
        {
            if(Repository.MainDb.Media.Track.Create(entity))
                return Repository.MainDb.Media.Track.ByPK(entity.TrackId);

            return null;
        }
        #endregion
    }
}
