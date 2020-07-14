/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Repository.Interfaces.MainDb.Media
{
    public partial interface IPlaylistRepository
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;
using TheSharpFactory.Query;
using TheSharpFactory.Entity.MainDb.Media;

namespace TheSharpFactory.Repository.Interfaces.MainDb.Media
{

    /// <summary>
    /// This interface represents the contract to exchange data with a Repository for a Playlist.
    /// </summary>
    public partial interface IPlaylistRepository
    {
        #region Get
        /// <summary>
        /// Gets the specified TheSharpFactory.Entity.MainDb.Media.Playlist from the database by Primary Key.
        /// </summary>
        /// <param name="playlistid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Playlist</returns>
        Playlist ByPK(int playlistid);
        /// <summary>
        /// Gets the specified TheSharpFactory.Entity.MainDb.Media.Playlist from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="playlistid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Playlist</returns>
        Playlist ByPK(int playlistid, NavProps<PlaylistNavProperty> navprops);
        #endregion
        #region Top
        /// <summary>
        /// Performs a select top N TheSharpFactory.Entity.MainDb.Media.Playlist from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Entity.MainDb.Media.Playlist</returns>
        List<Playlist> Top(int topcount, Query<PlaylistProperty> query);
        /// <summary>
        /// Performs a select top N TheSharpFactory.Entity.MainDb.Media.Playlist from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Entity.MainDb.Media.Playlist</returns>
        List<Playlist> Top(int topcount, Query<PlaylistProperty, PlaylistNavProperty> query);
        #endregion
        #region FirstOrDefault
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Entity.MainDb.Media.Playlist from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Playlist</returns>
        Playlist FirstOrDefault(Query<PlaylistProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Entity.MainDb.Media.Playlist from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Playlist</returns>
        Playlist FirstOrDefault(Query<PlaylistProperty, PlaylistNavProperty> query);
        #endregion
        #region First
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Entity.MainDb.Media.Playlist from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Playlist</returns>
        Playlist First(Query<PlaylistProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Entity.MainDb.Media.Playlist from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Playlist</returns>
        Playlist First(Query<PlaylistProperty, PlaylistNavProperty> query);
        #endregion
        #region SingleOrDefault
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Entity.MainDb.Media.Playlist from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Playlist</returns>
        Playlist SingleOrDefault(Query<PlaylistProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Entity.MainDb.Media.Playlist from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Playlist</returns>
        Playlist SingleOrDefault(Query<PlaylistProperty, PlaylistNavProperty> query);
        #endregion
        #region Single
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Entity.MainDb.Media.Playlist from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Playlist</returns>
        Playlist Single(Query<PlaylistProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Entity.MainDb.Media.Playlist from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Playlist</returns>
        Playlist Single(Query<PlaylistProperty, PlaylistNavProperty> query);
        #endregion
        #region ToList
        /// <summary>
        /// Gets List of TheSharpFactory.Entity.MainDb.Media.Playlist from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Entity.MainDb.Media.Playlist</returns>
        List<Playlist> ToList(Query<PlaylistProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Entity.MainDb.Media.Playlist from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Entity.MainDb.Media.Playlist</returns>
        List<Playlist> ToList(Query<PlaylistProperty, PlaylistNavProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Entity.MainDb.Media.Playlist from the database. No filtering.
        /// </summary>
        /// <returns>List of TheSharpFactory.Entity.MainDb.Media.Playlist</returns>
        List<Playlist> ToList();
        #endregion
        #region Create
        /// <summary>
        /// Creates the specified TheSharpFactory.Entity.MainDb.Media.Playlist in the database.
        /// </summary>
        /// <param name="playlist">The TheSharpFactory.Entity.MainDb.Media.Playlist to create.</param>
        /// <returns>True if succeeded. False if it already exists.</returns>
        bool Create(Playlist playlist);
        /// <summary>
        /// Creates each TheSharpFactory.Entity.MainDb.Media.Playlist from the list in the database.
        /// </summary>
        /// <param name="playlists">List of TheSharpFactory.Entity.MainDb.Media.Playlist to create.</param>
        /// <returns>void</returns>
        void Create(List<Playlist> playlists);
        #endregion
        #region Update
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Entity.MainDb.Media.Playlist in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="playlist">The TheSharpFactory.Entity.MainDb.Media.Playlist to update.</param>
        /// <returns>True if succeeded. False if it does not exist or if no changes were made.</returns>
        bool Update(Playlist playlist);
        /// <summary>
        /// Updates all Entities from the database that match the query specified. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The list of updated entities.</returns>
        List<Playlist> Update(Query<PlaylistProperty> query);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Entity.MainDb.Media.Playlist in the database.</para><para>This method only updates those fields that have changed. Compares original to changed.</para><para>If no fields have changed then no call is made to the database.</para><para>WARNING: This method allows changes to PrimaryKey, Unique Keys, and Identity.</para>
        /// </summary>
        /// <param name="original">The original Entity.</param>
        /// <param name="changed">The changed Entity.</param>
        /// <returns>True if succeeded. False if no changes found.</returns>
        bool Update(Playlist original, Playlist changed);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Entity.MainDb.Media.Playlist in the database. If not found then it is created.</para><para>This function only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="playlist">The TheSharpFactory.Entity.MainDb.Media.Playlist to update or create.</param>
        /// <returns>True if succeeded. False if it already exists but no chages were made.</returns>
        bool UpdateOrCreate(Playlist playlist);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Entity.MainDb.Media.Playlist from the list in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="playlists">List of TheSharpFactory.Entity.MainDb.Media.Playlist to update.</param>
        /// <returns>void</returns>
        void Update(List<Playlist> playlists);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Entity.MainDb.Media.Playlist from the list in the database. Creates them if not found.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="playlists">List of TheSharpFactory.Entity.MainDb.Media.Playlist to update or create.</param>
        /// <returns>void</returns>
        void UpdateOrCreate(List<Playlist> playlists);
        #endregion
        #region Delete
        /// <summary>
        /// Deletes the specified TheSharpFactory.Entity.MainDb.Media.Playlist from the database by Primary Key.
        /// </summary>
        /// <param name="playlistid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByPK(int playlistid);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Entity.MainDb.Media.Playlist from the database.
        /// </summary>
        /// <param name="playlist">The TheSharpFactory.Entity.MainDb.Media.Playlist to update.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool Delete(Playlist playlist);
        /// <summary>
        /// Deletes all Entities from the database that match the filters specified in the Query. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The number of deleted records.</returns>
        int Delete(Query<PlaylistProperty> query);
        /// <summary>
        /// Deletes each TheSharpFactory.Entity.MainDb.Media.Playlist in the list from the database.
        /// </summary>
        /// <param name="playlists">List of TheSharpFactory.Entity.MainDb.Media.Playlist to delete.</param>
        /// <returns>void</returns>
        void Delete(List<Playlist> playlists);
        #endregion
    }
}
