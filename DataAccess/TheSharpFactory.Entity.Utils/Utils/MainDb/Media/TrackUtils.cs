/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Entity.Utils.MainDb.Media
{
    public static partial class TrackUtils
    {
    }
}

************************************************/

using TheSharpFactory.Entity.MainDb.Media;
using TheSharpFactory.Query;

namespace TheSharpFactory.Entity.Utils.MainDb.Media
{

    /// <summary>
    /// This class is a utility class for a TheSharpFactory.Entity.MainDb.Media.Track.
    /// </summary>
    public static partial class TrackUtils
    {
        /// <summary>
        /// Compare 2 Entities for changes. NavProperties are NOT taken into account. For NavProperties use the corresponding utils for those Entities
        /// </summary>
        /// <param name="one">Entity One.</param>
        /// <param name="two">Entity Two.</param>
        /// <returns>True if there is changes. False if no changes found.</returns>
        public static bool HasChanges(Track one, Track two)
        {
            // this method returns true if differences are found between the 2 entities.
            #region Detect Changes
            if(one.TrackId != two.TrackId)
                return true;
            if(string.CompareOrdinal(one.Name, two.Name) != 0)
                return true;
            if(one.AlbumId != two.AlbumId)
                return true;
            if(one.MediaTypeId != two.MediaTypeId)
                return true;
            if(one.GenreId != two.GenreId)
                return true;
            if(string.CompareOrdinal(one.Composer, two.Composer) != 0)
                return true;
            if(one.Milliseconds != two.Milliseconds)
                return true;
            if(one.Bytes != two.Bytes)
                return true;
            if(one.UnitPrice != two.UnitPrice)
                return true;
            #endregion
            return false;
        }
        /// <summary>
        /// Merge all values from one Entity into another one.
        /// </summary>
        /// <param name="source">Source Entity. Will be copied to the target.</param>
        /// <param name="target">Target Entity. Will receive the values from the source.</param>
        /// <returns>void.</returns>
        public static void Merge(Track source, Track target)
        {
            // this method merges 2 Entities.
            #region Merge Values
            target.TrackId = source.TrackId;
            target.Name = source.Name;
            target.AlbumId = source.AlbumId;
            target.MediaTypeId = source.MediaTypeId;
            target.GenreId = source.GenreId;
            target.Composer = source.Composer;
            target.Milliseconds = source.Milliseconds;
            target.Bytes = source.Bytes;
            target.UnitPrice = source.UnitPrice;
            #endregion
        }
        /// <summary>
        /// Get a list of QueryFilter that represent changed fields.
        /// </summary>
        /// <param name="original">Original Entity. The unchanged entity.</param>
        /// <param name="changed">Changed Entity. The entity holding the changed fields.</param>
        /// <returns>QueryFilters of TrackProperty</returns>
        public static QueryFilters<TrackProperty> GetChanges(Track original, Track changed)
        {
            // this method returns a list of changes.
            var changes = new QueryFilters<TrackProperty>(9);
            #region Detect Changes
            if(original.TrackId != changed.TrackId)
                changes.Add(QueryFilter.New(TrackProperty.TrackId, FilterConditions.Equals, changed.TrackId));
            if(string.CompareOrdinal(original.Name, changed.Name) != 0)
                changes.Add(QueryFilter.New(TrackProperty.Name, FilterConditions.Equals, changed.Name));
            if(original.AlbumId != changed.AlbumId)
                changes.Add(QueryFilter.New(TrackProperty.AlbumId, FilterConditions.Equals, changed.AlbumId));
            if(original.MediaTypeId != changed.MediaTypeId)
                changes.Add(QueryFilter.New(TrackProperty.MediaTypeId, FilterConditions.Equals, changed.MediaTypeId));
            if(original.GenreId != changed.GenreId)
                changes.Add(QueryFilter.New(TrackProperty.GenreId, FilterConditions.Equals, changed.GenreId));
            if(string.CompareOrdinal(original.Composer, changed.Composer) != 0)
                changes.Add(QueryFilter.New(TrackProperty.Composer, FilterConditions.Equals, changed.Composer));
            if(original.Milliseconds != changed.Milliseconds)
                changes.Add(QueryFilter.New(TrackProperty.Milliseconds, FilterConditions.Equals, changed.Milliseconds));
            if(original.Bytes != changed.Bytes)
                changes.Add(QueryFilter.New(TrackProperty.Bytes, FilterConditions.Equals, changed.Bytes));
            if(original.UnitPrice != changed.UnitPrice)
                changes.Add(QueryFilter.New(TrackProperty.UnitPrice, FilterConditions.Equals, changed.UnitPrice));
            #endregion
            return changes.Count > 0 ? changes : null;
        }
    }
}
