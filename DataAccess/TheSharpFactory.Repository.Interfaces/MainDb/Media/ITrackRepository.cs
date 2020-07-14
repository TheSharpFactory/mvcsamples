/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Repository.Interfaces.MainDb.Media
{
    public partial interface ITrackRepository
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
    /// This interface represents the contract to exchange data with a Repository for a Track.
    /// </summary>
    public partial interface ITrackRepository
    {
        #region Get
        /// <summary>
        /// Gets the specified TheSharpFactory.Entity.MainDb.Media.Track from the database by Primary Key.
        /// </summary>
        /// <param name="trackid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Track</returns>
        Track ByPK(int trackid);
        /// <summary>
        /// Gets the specified TheSharpFactory.Entity.MainDb.Media.Track from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="trackid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Track</returns>
        Track ByPK(int trackid, NavProps<TrackNavProperty> navprops);
        #endregion
        #region Top
        /// <summary>
        /// Performs a select top N TheSharpFactory.Entity.MainDb.Media.Track from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Entity.MainDb.Media.Track</returns>
        List<Track> Top(int topcount, Query<TrackProperty> query);
        /// <summary>
        /// Performs a select top N TheSharpFactory.Entity.MainDb.Media.Track from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Entity.MainDb.Media.Track</returns>
        List<Track> Top(int topcount, Query<TrackProperty, TrackNavProperty> query);
        #endregion
        #region FirstOrDefault
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Entity.MainDb.Media.Track from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Track</returns>
        Track FirstOrDefault(Query<TrackProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Entity.MainDb.Media.Track from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Track</returns>
        Track FirstOrDefault(Query<TrackProperty, TrackNavProperty> query);
        #endregion
        #region First
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Entity.MainDb.Media.Track from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Track</returns>
        Track First(Query<TrackProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Entity.MainDb.Media.Track from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Track</returns>
        Track First(Query<TrackProperty, TrackNavProperty> query);
        #endregion
        #region SingleOrDefault
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Entity.MainDb.Media.Track from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Track</returns>
        Track SingleOrDefault(Query<TrackProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Entity.MainDb.Media.Track from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Track</returns>
        Track SingleOrDefault(Query<TrackProperty, TrackNavProperty> query);
        #endregion
        #region Single
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Entity.MainDb.Media.Track from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Track</returns>
        Track Single(Query<TrackProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Entity.MainDb.Media.Track from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Track</returns>
        Track Single(Query<TrackProperty, TrackNavProperty> query);
        #endregion
        #region ToList
        /// <summary>
        /// Gets List of TheSharpFactory.Entity.MainDb.Media.Track from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Entity.MainDb.Media.Track</returns>
        List<Track> ToList(Query<TrackProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Entity.MainDb.Media.Track from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Entity.MainDb.Media.Track</returns>
        List<Track> ToList(Query<TrackProperty, TrackNavProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Entity.MainDb.Media.Track from the database. No filtering.
        /// </summary>
        /// <returns>List of TheSharpFactory.Entity.MainDb.Media.Track</returns>
        List<Track> ToList();
        #endregion
        #region Create
        /// <summary>
        /// Creates the specified TheSharpFactory.Entity.MainDb.Media.Track in the database.
        /// </summary>
        /// <param name="track">The TheSharpFactory.Entity.MainDb.Media.Track to create.</param>
        /// <returns>True if succeeded. False if it already exists.</returns>
        bool Create(Track track);
        /// <summary>
        /// Creates each TheSharpFactory.Entity.MainDb.Media.Track from the list in the database.
        /// </summary>
        /// <param name="tracks">List of TheSharpFactory.Entity.MainDb.Media.Track to create.</param>
        /// <returns>void</returns>
        void Create(List<Track> tracks);
        #endregion
        #region Update
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Entity.MainDb.Media.Track in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="track">The TheSharpFactory.Entity.MainDb.Media.Track to update.</param>
        /// <returns>True if succeeded. False if it does not exist or if no changes were made.</returns>
        bool Update(Track track);
        /// <summary>
        /// Updates all Entities from the database that match the query specified. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The list of updated entities.</returns>
        List<Track> Update(Query<TrackProperty> query);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Entity.MainDb.Media.Track in the database.</para><para>This method only updates those fields that have changed. Compares original to changed.</para><para>If no fields have changed then no call is made to the database.</para><para>WARNING: This method allows changes to PrimaryKey, Unique Keys, and Identity.</para>
        /// </summary>
        /// <param name="original">The original Entity.</param>
        /// <param name="changed">The changed Entity.</param>
        /// <returns>True if succeeded. False if no changes found.</returns>
        bool Update(Track original, Track changed);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Entity.MainDb.Media.Track in the database. If not found then it is created.</para><para>This function only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="track">The TheSharpFactory.Entity.MainDb.Media.Track to update or create.</param>
        /// <returns>True if succeeded. False if it already exists but no chages were made.</returns>
        bool UpdateOrCreate(Track track);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Entity.MainDb.Media.Track from the list in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="tracks">List of TheSharpFactory.Entity.MainDb.Media.Track to update.</param>
        /// <returns>void</returns>
        void Update(List<Track> tracks);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Entity.MainDb.Media.Track from the list in the database. Creates them if not found.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="tracks">List of TheSharpFactory.Entity.MainDb.Media.Track to update or create.</param>
        /// <returns>void</returns>
        void UpdateOrCreate(List<Track> tracks);
        #endregion
        #region Delete
        /// <summary>
        /// Deletes the specified TheSharpFactory.Entity.MainDb.Media.Track from the database by Primary Key.
        /// </summary>
        /// <param name="trackid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByPK(int trackid);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Entity.MainDb.Media.Track from the database.
        /// </summary>
        /// <param name="track">The TheSharpFactory.Entity.MainDb.Media.Track to update.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool Delete(Track track);
        /// <summary>
        /// Deletes all Entities from the database that match the filters specified in the Query. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The number of deleted records.</returns>
        int Delete(Query<TrackProperty> query);
        /// <summary>
        /// Deletes each TheSharpFactory.Entity.MainDb.Media.Track in the list from the database.
        /// </summary>
        /// <param name="tracks">List of TheSharpFactory.Entity.MainDb.Media.Track to delete.</param>
        /// <returns>void</returns>
        void Delete(List<Track> tracks);
        #endregion
    }
}
