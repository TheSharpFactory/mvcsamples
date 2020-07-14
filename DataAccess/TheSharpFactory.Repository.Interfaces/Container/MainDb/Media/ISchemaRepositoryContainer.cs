/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Repository.Container.Interfaces.MainDb.Media
{
    public partial interface ISchemaRepositoryContainer
    {
    }
}

************************************************/

using TheSharpFactory.Repository.Interfaces.MainDb.Media;

namespace TheSharpFactory.Repository.Container.Interfaces.MainDb.Media
{

    /// <summary>
    /// This interface represents the Repository Container for a specific Schema within the Model.
    /// </summary>
    public partial interface ISchemaRepositoryContainer
    {
        #region Entity Repositories
        IAlbumRepository Album { get; set; }
        IArtistRepository Artist { get; set; }
        IGenreRepository Genre { get; set; }
        IMediaTypeRepository MediaType { get; set; }
        IPlaylistRepository Playlist { get; set; }
        IPlaylistTrackRepository PlaylistTrack { get; set; }
        ITrackRepository Track { get; set; }
        #endregion
        #region Store Procedure Repository
        IStoredProcRepository StoredProcs { get; set; }
        #endregion
    }
}
