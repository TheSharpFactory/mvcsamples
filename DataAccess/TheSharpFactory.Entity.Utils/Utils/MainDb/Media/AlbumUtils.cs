/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Entity.Utils.MainDb.Media
{
    public static partial class AlbumUtils
    {
    }
}

************************************************/

using TheSharpFactory.Entity.MainDb.Media;
using TheSharpFactory.Query;

namespace TheSharpFactory.Entity.Utils.MainDb.Media
{

    /// <summary>
    /// This class is a utility class for a TheSharpFactory.Entity.MainDb.Media.Album.
    /// </summary>
    public static partial class AlbumUtils
    {
        /// <summary>
        /// Compare 2 Entities for changes. NavProperties are NOT taken into account. For NavProperties use the corresponding utils for those Entities
        /// </summary>
        /// <param name="one">Entity One.</param>
        /// <param name="two">Entity Two.</param>
        /// <returns>True if there is changes. False if no changes found.</returns>
        public static bool HasChanges(Album one, Album two)
        {
            // this method returns true if differences are found between the 2 entities.
            #region Detect Changes
            if(one.AlbumId != two.AlbumId)
                return true;
            if(string.CompareOrdinal(one.Title, two.Title) != 0)
                return true;
            if(one.ArtistId != two.ArtistId)
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
        public static void Merge(Album source, Album target)
        {
            // this method merges 2 Entities.
            #region Merge Values
            target.AlbumId = source.AlbumId;
            target.Title = source.Title;
            target.ArtistId = source.ArtistId;
            #endregion
        }
        /// <summary>
        /// Get a list of QueryFilter that represent changed fields.
        /// </summary>
        /// <param name="original">Original Entity. The unchanged entity.</param>
        /// <param name="changed">Changed Entity. The entity holding the changed fields.</param>
        /// <returns>QueryFilters of AlbumProperty</returns>
        public static QueryFilters<AlbumProperty> GetChanges(Album original, Album changed)
        {
            // this method returns a list of changes.
            var changes = new QueryFilters<AlbumProperty>(3);
            #region Detect Changes
            if(original.AlbumId != changed.AlbumId)
                changes.Add(QueryFilter.New(AlbumProperty.AlbumId, FilterConditions.Equals, changed.AlbumId));
            if(string.CompareOrdinal(original.Title, changed.Title) != 0)
                changes.Add(QueryFilter.New(AlbumProperty.Title, FilterConditions.Equals, changed.Title));
            if(original.ArtistId != changed.ArtistId)
                changes.Add(QueryFilter.New(AlbumProperty.ArtistId, FilterConditions.Equals, changed.ArtistId));
            #endregion
            return changes.Count > 0 ? changes : null;
        }
    }
}
