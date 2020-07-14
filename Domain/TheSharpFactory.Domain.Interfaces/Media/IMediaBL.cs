#region Usings
using System.Collections.Generic;
using TheSharpFactory.Entity.MainDb.Media;
#endregion


namespace TheSharpFactory.Domain
{
    /// <summary>
    /// <para>Represents the logic for the Media functional area</para>
    /// <para>This is a partial class broken into Create.cs, Retrieve.cs, Update.cs, Delete.cs.</para>
    /// </summary>
    public interface IMediaBL
    {
                           
        #region Create
        Album CreateAlbum(Album entity);
        Artist CreateArtist(Artist entity);
        Genre CreateGenre(Genre entity);
        MediaType CreateMediaType(MediaType entity);
        Playlist CreatePlaylist(Playlist entity);
        PlaylistTrack CreatePlaylistTrack(PlaylistTrack entity);
        Track CreateTrack(Track entity);
        #endregion

        #region Retrieve
        List<Album> GetAllAlbums();
        List<Artist> GetAllArtists();
        List<Genre> GetAllGenres();
        List<MediaType> GetAllMediaTypes();
        List<Playlist> GetAllPlaylists();
        List<PlaylistTrack> GetAllPlaylistTracks();
        List<Track> GetAllTracks();
        #endregion

        #region Update
        Album UpdateAlbum(Album entity);
        Artist UpdateArtist(Artist entity);
        Genre UpdateGenre(Genre entity);
        MediaType UpdateMediaType(MediaType entity);
        Playlist UpdatePlaylist(Playlist entity);
        PlaylistTrack UpdatePlaylistTrack(PlaylistTrack entity);
        Track UpdateTrack(Track entity);
        #endregion

        #region Delete
        bool DeleteAlbum(int albumId);
        bool DeleteArtist(int artistId);
        bool DeleteGenre(int genreId);
        bool DeleteMediaType(int mediaTypeId);
        bool DeletePlaylist(int playlistId);
        bool DeletePlaylistTrack(int playlistId, int trackId);
        bool DeleteTrack(int trackId);
        #endregion
    }
}
