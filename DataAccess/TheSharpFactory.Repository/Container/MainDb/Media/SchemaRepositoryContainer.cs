/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Repository.Container.MainDb.Media
{
    public partial class SchemaRepositoryContainer
    {
    }
}

************************************************/

using TheSharpFactory.Repository.MainDb.Media;
using TheSharpFactory.Repository.Interfaces.MainDb.Media;
using TheSharpFactory.Repository.Container.Interfaces.MainDb.Media;

namespace TheSharpFactory.Repository.Container.MainDb.Media
{

    /// <summary>
    /// This class represents the Repository Container for a specific Schema within the Model.
    /// </summary>
    public partial class SchemaRepositoryContainer:ISchemaRepositoryContainer
    {
        #region Entity Repositories
        public IAlbumRepository Album { get; set; }
        public IArtistRepository Artist { get; set; }
        public IGenreRepository Genre { get; set; }
        public IMediaTypeRepository MediaType { get; set; }
        public IPlaylistRepository Playlist { get; set; }
        public IPlaylistTrackRepository PlaylistTrack { get; set; }
        public ITrackRepository Track { get; set; }
        #endregion
        #region Store Procedure Repository
        public IStoredProcRepository StoredProcs { get; set; }
        #endregion
        public SchemaRepositoryContainer()
        {
            #region Entity Repositories
            Album = new AlbumRepository();
            Artist = new ArtistRepository();
            Genre = new GenreRepository();
            MediaType = new MediaTypeRepository();
            Playlist = new PlaylistRepository();
            PlaylistTrack = new PlaylistTrackRepository();
            Track = new TrackRepository();
            #endregion
            #region Store Procedure Repository
            StoredProcs = new StoredProcRepository();
            #endregion
            // If not implemented this method is removed during compilation
            LoadCustomRepositories();
        }
        // Implement this method in a partial class to load custom repositories
        partial void LoadCustomRepositories();
    }
}
