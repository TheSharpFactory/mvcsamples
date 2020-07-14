/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Repository.MainDb.Media
{
    public partial class PlaylistTrackRepository
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
    /// This class represents the Repository for: PlaylistTrack.
    /// </summary>
    public partial class PlaylistTrackRepository:WritableRepositoryBase<PlaylistTrack, PlaylistTrackProperty, PlaylistTrackNavProperty>, IPlaylistTrackRepository
    {
        #region Navigation Property Info
        //Contains information about the Navigation Properties for this entity.
        private static readonly Dictionary<PlaylistTrackNavProperty, NavPropertyInfo> _navPropInfos = new Dictionary<PlaylistTrackNavProperty, NavPropertyInfo>(2){ { PlaylistTrackNavProperty.Playlist, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.MainDb_Media_Playlist, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)MainDbE.Media.PlaylistTrackProperty.PlaylistId, OtherPropId = (int)MainDbE.Media.PlaylistProperty.PlaylistId, },} } }, { PlaylistTrackNavProperty.Track, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.MainDb_Media_Track, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)MainDbE.Media.PlaylistTrackProperty.TrackId, OtherPropId = (int)MainDbE.Media.TrackProperty.TrackId, },} } },};
        #endregion
        #region Constructors
        public PlaylistTrackRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.MainDb;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.MainDb_Media_PlaylistTrack;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK__Playlist__A4A6282E25869641) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<PlaylistTrackProperty>(2){ SortFilter.New(PlaylistTrackProperty.PlaylistId), SortFilter.New(PlaylistTrackProperty.TrackId),};
            #endregion
        }
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Entity.MainDb.Media.PlaylistTrack from the database by Primary Key.
        /// </summary>
        /// <param name="playlistid">Primary Key Field.</param>
        /// <param name="trackid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.PlaylistTrack</returns>
        public PlaylistTrack ByPK(int playlistid, int trackid)
        {
            var where = new QueryFilters<PlaylistTrackProperty>(2){QueryFilter.New(PlaylistTrackProperty.PlaylistId, FilterConditions.Equals, playlistid ), QueryFilter.New(PlaylistTrackProperty.TrackId, FilterConditions.Equals, trackid ), };
            return SelectSingle(where, DefaultSort);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Entity.MainDb.Media.PlaylistTrack from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="playlistid">Primary Key Field.</param>
        /// <param name="trackid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.PlaylistTrack</returns>
        public PlaylistTrack ByPK(int playlistid, int trackid, NavProps<PlaylistTrackNavProperty> navprops)
        {
            var where = new QueryFilters<PlaylistTrackProperty>(2){QueryFilter.New(PlaylistTrackProperty.PlaylistId, FilterConditions.Equals, playlistid ), QueryFilter.New(PlaylistTrackProperty.TrackId, FilterConditions.Equals, trackid ), };
            return SelectSingle(where, DefaultSort, navprops);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Entity.MainDb.Media.PlaylistTrack from the database by Primary Key.
        /// </summary>
        /// <param name="playlistid">Primary Key Field.</param>
        /// <param name="trackid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int playlistid, int trackid)
        {
            var where = new QueryFilters<PlaylistTrackProperty>(2){QueryFilter.New(PlaylistTrackProperty.PlaylistId, FilterConditions.Equals, playlistid), QueryFilter.New(PlaylistTrackProperty.TrackId, FilterConditions.Equals, trackid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<PlaylistTrackProperty> ComposeKeys(PlaylistTrack playlisttrack)
        {
            return new QueryFilters<PlaylistTrackProperty>{ QueryFilter.New(PlaylistTrackProperty.PlaylistId, FilterConditions.Equals, playlisttrack.PlaylistId), QueryFilter.New(PlaylistTrackProperty.TrackId, FilterConditions.Equals, playlisttrack.TrackId) };
        }
        protected override QueryFilters<PlaylistTrackProperty> GetChanges(PlaylistTrack original, PlaylistTrack changed)
        {
            return PlaylistTrackUtils.GetChanges(original, changed);
        }
        protected override void Merge(PlaylistTrack source, PlaylistTrack target)
        {
            PlaylistTrackUtils.Merge(source, target);
        }
        protected override QueryFilters<PlaylistTrackProperty> ComposeInsertPredicate(PlaylistTrack playlisttrack)
        {
            return new QueryFilters<PlaylistTrackProperty>{ QueryFilter.New(PlaylistTrackProperty.PlaylistId, FilterConditions.Equals, playlisttrack.PlaylistId), QueryFilter.New(PlaylistTrackProperty.TrackId, FilterConditions.Equals, playlisttrack.TrackId) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 2);
        }
        private static PlaylistTrack MaterializeSingleEntity(SqlDataReader r)
        {
            return new PlaylistTrack
            {
                PlaylistId = r.GetInt32(0),
                TrackId = r.GetInt32(1),
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
                var np = (PlaylistTrackNavProperty)p.Value;
                var npInfo = _navPropInfos[np];
                result.Add(npInfo);
                if(!(p.NavProps?.Count > 0))
                    continue;
                switch(np)
                {
                    case PlaylistTrackNavProperty.Playlist:
                        npInfo.NavProps = TheSharpFactory.Repository.MainDb.Media.PlaylistRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PlaylistTrackNavProperty.Track:
                        npInfo.NavProps = TheSharpFactory.Repository.MainDb.Media.TrackRepository.BuildNavPropInfos(p.NavProps);
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
                var np = (PlaylistTrackNavProperty)p.Value;
                switch(np)
                {
                    case PlaylistTrackNavProperty.Playlist:
                        result.Add(TheSharpFactory.Repository.MainDb.Media.PlaylistRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Repository.MainDb.Media.PlaylistRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PlaylistTrackNavProperty.Track:
                        result.Add(TheSharpFactory.Repository.MainDb.Media.TrackRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Repository.MainDb.Media.TrackRepository.ComposeNavPropMaterializers(p.NavProps));
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
        protected override void BuildObjectGraph(List<PlaylistTrack> entities, object[] results, NavProps navprops) 
        {
            PopulateNavProperties(entities, results, navprops);
        }
        internal static int PopulateNavProperties(List<PlaylistTrack> entities, object[] results, NavProps navprops, int resultsetindex = 0) 
        {
            if(results?.Length < resultsetindex + 1)
                return resultsetindex;
            foreach(var navprop in navprops)
            {
                resultsetindex++;
                var np = (PlaylistTrackNavProperty)navprop.Value;
                var result = results[resultsetindex];
                switch(np)
                {
                    case PlaylistTrackNavProperty.Playlist:
                    #region Playlist
                    {
                        var list = UnboxEntityList<TheSharpFactory.Entity.MainDb.Media.Playlist>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Entity.MainDb.Media.Playlist>();
                            foreach(var p in list)
                                navByKey.Add(p.PlaylistId, p);
                            foreach(var c in entities)
                            {
                                if(navByKey.ContainsKey(c.PlaylistId))
                                    c.Playlist = navByKey[c.PlaylistId];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Repository.MainDb.Media.PlaylistRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PlaylistTrackNavProperty.Track:
                    #region Track
                    {
                        var list = UnboxEntityList<TheSharpFactory.Entity.MainDb.Media.Track>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Entity.MainDb.Media.Track>();
                            foreach(var p in list)
                                navByKey.Add(p.TrackId, p);
                            foreach(var c in entities)
                            {
                                if(navByKey.ContainsKey(c.TrackId))
                                    c.Track = navByKey[c.TrackId];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Repository.MainDb.Media.TrackRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
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
