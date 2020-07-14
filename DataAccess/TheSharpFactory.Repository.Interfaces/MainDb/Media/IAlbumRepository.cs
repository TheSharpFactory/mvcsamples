/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Repository.Interfaces.MainDb.Media
{
    public partial interface IAlbumRepository
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
    /// This interface represents the contract to exchange data with a Repository for a Album.
    /// </summary>
    public partial interface IAlbumRepository
    {
        #region Get
        /// <summary>
        /// Gets the specified TheSharpFactory.Entity.MainDb.Media.Album from the database by Primary Key.
        /// </summary>
        /// <param name="albumid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Album</returns>
        Album ByPK(int albumid);
        /// <summary>
        /// Gets the specified TheSharpFactory.Entity.MainDb.Media.Album from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="albumid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Album</returns>
        Album ByPK(int albumid, NavProps<AlbumNavProperty> navprops);
        #endregion
        #region Top
        /// <summary>
        /// Performs a select top N TheSharpFactory.Entity.MainDb.Media.Album from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Entity.MainDb.Media.Album</returns>
        List<Album> Top(int topcount, Query<AlbumProperty> query);
        /// <summary>
        /// Performs a select top N TheSharpFactory.Entity.MainDb.Media.Album from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Entity.MainDb.Media.Album</returns>
        List<Album> Top(int topcount, Query<AlbumProperty, AlbumNavProperty> query);
        #endregion
        #region FirstOrDefault
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Entity.MainDb.Media.Album from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Album</returns>
        Album FirstOrDefault(Query<AlbumProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Entity.MainDb.Media.Album from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Album</returns>
        Album FirstOrDefault(Query<AlbumProperty, AlbumNavProperty> query);
        #endregion
        #region First
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Entity.MainDb.Media.Album from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Album</returns>
        Album First(Query<AlbumProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Entity.MainDb.Media.Album from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Album</returns>
        Album First(Query<AlbumProperty, AlbumNavProperty> query);
        #endregion
        #region SingleOrDefault
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Entity.MainDb.Media.Album from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Album</returns>
        Album SingleOrDefault(Query<AlbumProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Entity.MainDb.Media.Album from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Album</returns>
        Album SingleOrDefault(Query<AlbumProperty, AlbumNavProperty> query);
        #endregion
        #region Single
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Entity.MainDb.Media.Album from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Album</returns>
        Album Single(Query<AlbumProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Entity.MainDb.Media.Album from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Album</returns>
        Album Single(Query<AlbumProperty, AlbumNavProperty> query);
        #endregion
        #region ToList
        /// <summary>
        /// Gets List of TheSharpFactory.Entity.MainDb.Media.Album from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Entity.MainDb.Media.Album</returns>
        List<Album> ToList(Query<AlbumProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Entity.MainDb.Media.Album from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Entity.MainDb.Media.Album</returns>
        List<Album> ToList(Query<AlbumProperty, AlbumNavProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Entity.MainDb.Media.Album from the database. No filtering.
        /// </summary>
        /// <returns>List of TheSharpFactory.Entity.MainDb.Media.Album</returns>
        List<Album> ToList();
        #endregion
        #region Create
        /// <summary>
        /// Creates the specified TheSharpFactory.Entity.MainDb.Media.Album in the database.
        /// </summary>
        /// <param name="album">The TheSharpFactory.Entity.MainDb.Media.Album to create.</param>
        /// <returns>True if succeeded. False if it already exists.</returns>
        bool Create(Album album);
        /// <summary>
        /// Creates each TheSharpFactory.Entity.MainDb.Media.Album from the list in the database.
        /// </summary>
        /// <param name="albums">List of TheSharpFactory.Entity.MainDb.Media.Album to create.</param>
        /// <returns>void</returns>
        void Create(List<Album> albums);
        #endregion
        #region Update
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Entity.MainDb.Media.Album in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="album">The TheSharpFactory.Entity.MainDb.Media.Album to update.</param>
        /// <returns>True if succeeded. False if it does not exist or if no changes were made.</returns>
        bool Update(Album album);
        /// <summary>
        /// Updates all Entities from the database that match the query specified. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The list of updated entities.</returns>
        List<Album> Update(Query<AlbumProperty> query);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Entity.MainDb.Media.Album in the database.</para><para>This method only updates those fields that have changed. Compares original to changed.</para><para>If no fields have changed then no call is made to the database.</para><para>WARNING: This method allows changes to PrimaryKey, Unique Keys, and Identity.</para>
        /// </summary>
        /// <param name="original">The original Entity.</param>
        /// <param name="changed">The changed Entity.</param>
        /// <returns>True if succeeded. False if no changes found.</returns>
        bool Update(Album original, Album changed);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Entity.MainDb.Media.Album in the database. If not found then it is created.</para><para>This function only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="album">The TheSharpFactory.Entity.MainDb.Media.Album to update or create.</param>
        /// <returns>True if succeeded. False if it already exists but no chages were made.</returns>
        bool UpdateOrCreate(Album album);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Entity.MainDb.Media.Album from the list in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="albums">List of TheSharpFactory.Entity.MainDb.Media.Album to update.</param>
        /// <returns>void</returns>
        void Update(List<Album> albums);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Entity.MainDb.Media.Album from the list in the database. Creates them if not found.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="albums">List of TheSharpFactory.Entity.MainDb.Media.Album to update or create.</param>
        /// <returns>void</returns>
        void UpdateOrCreate(List<Album> albums);
        #endregion
        #region Delete
        /// <summary>
        /// Deletes the specified TheSharpFactory.Entity.MainDb.Media.Album from the database by Primary Key.
        /// </summary>
        /// <param name="albumid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByPK(int albumid);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Entity.MainDb.Media.Album from the database.
        /// </summary>
        /// <param name="album">The TheSharpFactory.Entity.MainDb.Media.Album to update.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool Delete(Album album);
        /// <summary>
        /// Deletes all Entities from the database that match the filters specified in the Query. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The number of deleted records.</returns>
        int Delete(Query<AlbumProperty> query);
        /// <summary>
        /// Deletes each TheSharpFactory.Entity.MainDb.Media.Album in the list from the database.
        /// </summary>
        /// <param name="albums">List of TheSharpFactory.Entity.MainDb.Media.Album to delete.</param>
        /// <returns>void</returns>
        void Delete(List<Album> albums);
        #endregion
    }
}
