/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Repository.MainDb.Media
{
    public partial class PlaylistRepository
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TheSharpFactory.Repository.Common;
using TheSharpFactory.Repository.Interfaces.MainDb.Media;
using TheSharpFactory.Query;
using TheSharpFactory.Entity.MainDb.Media;
using TheSharpFactory.Entity.Utils.MainDb.Media;
using MainDbE = TheSharpFactory.Entity.MainDb;

namespace TheSharpFactory.Repository.MainDb.Media
{

    /// <summary>
    /// This class represents the Repository for: Playlist.
    /// </summary>
    public partial class PlaylistRepository:WritableRepositoryBase<Playlist, PlaylistProperty, PlaylistNavProperty>, IPlaylistRepository
    {
        #region Navigation Property Info
        //Contains information about the Navigation Properties for this entity.
        private static readonly Dictionary<PlaylistNavProperty, NavPropertyInfo> _navPropInfos = new Dictionary<PlaylistNavProperty, NavPropertyInfo>(1){ { PlaylistNavProperty.PlaylistTracks, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.MainDb_Media_PlaylistTrack, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)MainDbE.Media.PlaylistProperty.PlaylistId, OtherPropId = (int)MainDbE.Media.PlaylistTrackProperty.PlaylistId, },} } },};
        #endregion
        #region Constructors
        public PlaylistRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.MainDb;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.MainDb_Media_Playlist;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK__Playlist__B30167A021B6055D) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<PlaylistProperty>(1){ SortFilter.New(PlaylistProperty.PlaylistId),};
            #endregion
        }
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Entity.MainDb.Media.Playlist from the database by Primary Key.
        /// </summary>
        /// <param name="playlistid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Playlist</returns>
        public Playlist ByPK(int playlistid)
        {
            var where = new QueryFilters<PlaylistProperty>(1){QueryFilter.New(PlaylistProperty.PlaylistId, FilterConditions.Equals, playlistid ), };
            return SelectSingle(where, DefaultSort);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Entity.MainDb.Media.Playlist from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="playlistid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Playlist</returns>
        public Playlist ByPK(int playlistid, NavProps<PlaylistNavProperty> navprops)
        {
            var where = new QueryFilters<PlaylistProperty>(1){QueryFilter.New(PlaylistProperty.PlaylistId, FilterConditions.Equals, playlistid ), };
            return SelectSingle(where, DefaultSort, navprops);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Entity.MainDb.Media.Playlist from the database by Primary Key.
        /// </summary>
        /// <param name="playlistid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int playlistid)
        {
            var where = new QueryFilters<PlaylistProperty>(1){QueryFilter.New(PlaylistProperty.PlaylistId, FilterConditions.Equals, playlistid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<PlaylistProperty> ComposeKeys(Playlist playlist)
        {
            return new QueryFilters<PlaylistProperty>{ QueryFilter.New(PlaylistProperty.PlaylistId, FilterConditions.Equals, playlist.PlaylistId) };
        }
        protected override QueryFilters<PlaylistProperty> GetChanges(Playlist original, Playlist changed)
        {
            return PlaylistUtils.GetChanges(original, changed);
        }
        protected override void Merge(Playlist source, Playlist target)
        {
            PlaylistUtils.Merge(source, target);
        }
        protected override QueryFilters<PlaylistProperty> ComposeInsertPredicate(Playlist playlist)
        {
            return new QueryFilters<PlaylistProperty>{ QueryFilter.New(PlaylistProperty.Name, FilterConditions.Equals, playlist.Name) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 2);
        }
        private static Playlist MaterializeSingleEntity(SqlDataReader r)
        {
            return new Playlist
            {
                PlaylistId = r.GetInt32(0),
                Name = r.GetString(1),
            };
        }
        /// <summary>
        /// Composes the Navigation Property tree sent to the Database class.
        /// </summary>
        /// <returns>
        /// List of NavPropertyInfo
        /// </returns>
        protected override List<NavPropertyInfo> BuildNavPropInfoTree(NavProps navprops) 
        {
            return BuildNavPropInfos(navprops);
        }
        /// <summary>
        /// Composes the Navigation Property tree sent to the Database class
        /// </summary>
        /// <returns>
        /// List of NavPropertyInfo
        /// </returns>
        internal static List<NavPropertyInfo> BuildNavPropInfos(NavProps navprops) 
        {
            if(!(navprops?.Count > 0))
                    return null;
            var result = new List<NavPropertyInfo>(navprops.Count);
            foreach(var p in navprops)
            {
                var np = (PlaylistNavProperty)p.Value;
                var npInfo = _navPropInfos[np];
                result.Add(npInfo);
                if(!(p.NavProps?.Count > 0))
                    continue;
                switch(np)
                {
                    case PlaylistNavProperty.PlaylistTracks:
                        npInfo.NavProps = TheSharpFactory.Repository.MainDb.Media.PlaylistTrackRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    default:
                        throw new ArgumentException($"NavigationProperty {np} is not valid.");
                }
            }
            return result;
        }
        /// <summary>
        /// Composes the Navigation Property tree materializers.
        /// </summary>
        /// <returns>
        /// List of Func of SqlDataReader, object
        /// </returns>
        protected override List<Func<SqlDataReader, object>> GetNavPropMaterializers(NavProps navprops) 
        {
            return ComposeNavPropMaterializers(navprops);
        }
        internal static List<Func<SqlDataReader, object>> ComposeNavPropMaterializers(NavProps navprops) 
        {
            if(!(navprops?.Count > 0))
                return new List<Func<SqlDataReader, object>>(0);
            var result = new List<Func<SqlDataReader, object>>(navprops.TotalCount);
            foreach(var p in navprops)
            {
                var np = (PlaylistNavProperty)p.Value;
                switch(np)
                {
                    case PlaylistNavProperty.PlaylistTracks:
                        result.Add(TheSharpFactory.Repository.MainDb.Media.PlaylistTrackRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Repository.MainDb.Media.PlaylistTrackRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    default:
                        throw new ArgumentException($"NavigationProperty {np} is not valid.");
                }
            }
            return result;
        }
        /// <summary>
        /// Populates the object graph with the materialized results.
        /// </summary>
        /// <returns>
        /// void
        /// </returns>
        protected override void BuildObjectGraph(List<Playlist> entities, object[] results, NavProps navprops) 
        {
            PopulateNavProperties(entities, results, navprops);
        }
        private static MultiKeyDictionary<int, Playlist> ComposeDictionaryByPK(List<Playlist> entities, MultiKeyDictionary<int, Playlist> entByKey) 
        {
            // creates a dictionary by Primary Key
            if(entByKey?.Count > 0)
                return entByKey;
            entByKey = new MultiKeyDictionary<int, Playlist>(entities.Count);
            foreach(var p in entities)
                entByKey.Add(p.PlaylistId, p);
            return entByKey;
        }
        internal static int PopulateNavProperties(List<Playlist> entities, object[] results, NavProps navprops, int resultsetindex = 0) 
        {
            if(results?.Length < resultsetindex + 1)
                return resultsetindex;
            var entByPK = (MultiKeyDictionary<int, Playlist>)null;
            foreach(var navprop in navprops)
            {
                resultsetindex++;
                var np = (PlaylistNavProperty)navprop.Value;
                var result = results[resultsetindex];
                switch(np)
                {
                    case PlaylistNavProperty.PlaylistTracks:
                    #region PlaylistTracks
                    {
                        var list = UnboxEntityList<TheSharpFactory.Entity.MainDb.Media.PlaylistTrack>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.PlaylistId];
                                p.PlaylistTracks = AddEntityToList<TheSharpFactory.Entity.MainDb.Media.PlaylistTrack>(p.PlaylistTracks, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Repository.MainDb.Media.PlaylistTrackRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    default:
                        throw new ArgumentException($"NavigationProperty {np} is not valid.");
                }
            }
            return resultsetindex;
        }
        #endregion
    }
}
