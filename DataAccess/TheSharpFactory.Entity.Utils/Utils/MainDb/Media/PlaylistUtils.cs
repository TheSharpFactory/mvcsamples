/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Entity.Utils.MainDb.Media
{
    public static partial class PlaylistUtils
    {
    }
}

************************************************/

using TheSharpFactory.Entity.MainDb.Media;
using TheSharpFactory.Query;

namespace TheSharpFactory.Entity.Utils.MainDb.Media
{

    /// <summary>
    /// This class is a utility class for a TheSharpFactory.Entity.MainDb.Media.Playlist.
    /// </summary>
    public static partial class PlaylistUtils
    {
        /// <summary>
        /// Compare 2 Entities for changes. NavProperties are NOT taken into account. For NavProperties use the corresponding utils for those Entities
        /// </summary>
        /// <param name="one">Entity One.</param>
        /// <param name="two">Entity Two.</param>
        /// <returns>True if there is changes. False if no changes found.</returns>
        public static bool HasChanges(Playlist one, Playlist two)
        {
            // this method returns true if differences are found between the 2 entities.
            #region Detect Changes
            if(one.PlaylistId != two.PlaylistId)
                return true;
            if(string.CompareOrdinal(one.Name, two.Name) != 0)
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
        public static void Merge(Playlist source, Playlist target)
        {
            // this method merges 2 Entities.
            #region Merge Values
            target.PlaylistId = source.PlaylistId;
            target.Name = source.Name;
            #endregion
        }
        /// <summary>
        /// Get a list of QueryFilter that represent changed fields.
        /// </summary>
        /// <param name="original">Original Entity. The unchanged entity.</param>
        /// <param name="changed">Changed Entity. The entity holding the changed fields.</param>
        /// <returns>QueryFilters of PlaylistProperty</returns>
        public static QueryFilters<PlaylistProperty> GetChanges(Playlist original, Playlist changed)
        {
            // this method returns a list of changes.
            var changes = new QueryFilters<PlaylistProperty>(2);
            #region Detect Changes
            if(original.PlaylistId != changed.PlaylistId)
                changes.Add(QueryFilter.New(PlaylistProperty.PlaylistId, FilterConditions.Equals, changed.PlaylistId));
            if(string.CompareOrdinal(original.Name, changed.Name) != 0)
                changes.Add(QueryFilter.New(PlaylistProperty.Name, FilterConditions.Equals, changed.Name));
            #endregion
            return changes.Count > 0 ? changes : null;
        }
    }
}
