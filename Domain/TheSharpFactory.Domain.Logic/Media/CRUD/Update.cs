#region Usings
using TheSharpFactory.Entity.MainDb.Media;
#endregion


namespace TheSharpFactory.Domain
{
    public partial class MediaBL
    {
        /*
         *  This is a partial class.  
         *  This file contains Update functions.     
         *
         */
        #region Public Methods
        public Album UpdateAlbum(Album entity)
        {
            return UpdateAlbumHelper(entity);
        }
        public Artist UpdateArtist(Artist entity)
        {
            return UpdateArtistHelper(entity);
        }
        public Genre UpdateGenre(Genre entity)
        {
            return UpdateGenreHelper(entity);
        }
        public MediaType UpdateMediaType(MediaType entity)
        {
            return UpdateMediaTypeHelper(entity);
        }
        public Playlist UpdatePlaylist(Playlist entity)
        {
            return UpdatePlaylistHelper(entity);
        }
        public PlaylistTrack UpdatePlaylistTrack(PlaylistTrack entity)
        {
            return UpdatePlaylistTrackHelper(entity);
        }
        public Track UpdateTrack(Track entity)
        {
            return UpdateTrackHelper(entity);
        }
        #endregion


        #region Private Helpers
        private Album UpdateAlbumHelper(Album entity)
        {
            Repository.MainDb.Media.Album.Update(entity);

            return Repository.MainDb.Media.Album.ByPK(entity.AlbumId);
        }
        private Artist UpdateArtistHelper(Artist entity)
        {
            Repository.MainDb.Media.Artist.Update(entity);

            return Repository.MainDb.Media.Artist.ByPK(entity.ArtistId);
        }
        private Genre UpdateGenreHelper(Genre entity)
        {
            Repository.MainDb.Media.Genre.Update(entity);

            return Repository.MainDb.Media.Genre.ByPK(entity.GenreId);
        }
        private MediaType UpdateMediaTypeHelper(MediaType entity)
        {
            Repository.MainDb.Media.MediaType.Update(entity);

            return Repository.MainDb.Media.MediaType.ByPK(entity.MediaTypeId);
        }
        private Playlist UpdatePlaylistHelper(Playlist entity)
        {
            Repository.MainDb.Media.Playlist.Update(entity);

            return Repository.MainDb.Media.Playlist.ByPK(entity.PlaylistId);
        }
        private PlaylistTrack UpdatePlaylistTrackHelper(PlaylistTrack entity)
        {
            Repository.MainDb.Media.PlaylistTrack.Update(entity);

            return Repository.MainDb.Media.PlaylistTrack.ByPK(entity.PlaylistId, entity.TrackId);
        }
        private Track UpdateTrackHelper(Track entity)
        {
            Repository.MainDb.Media.Track.Update(entity);

            return Repository.MainDb.Media.Track.ByPK(entity.TrackId);
        }
        #endregion
    }
}
