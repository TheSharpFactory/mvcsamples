/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Repository.MainDb.Media
{
    public partial class StoredProcRepository
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TheSharpFactory.Entity.MainDb.Media;
using TheSharpFactory.Repository.Interfaces.MainDb.Media;
using TheSharpFactory.Repository.Common;
using TheSharpFactory.Query;

namespace TheSharpFactory.Repository.MainDb.Media
{

    /// <summary>
    /// This class represents the Repository for all Stored Procedures under the Media schema.
    /// </summary>
    public partial class StoredProcRepository:StoredProcedureRepositoryBase, IStoredProcRepository
    {
        #region Constructors
        public StoredProcRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.MainDb;
        }
        #endregion
        /// <summary>
        /// Executes Stored Procedure named CheckAlbum.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of CheckAlbum_Result</returns>
        public StoredProcResult<CheckAlbum_Result> CheckAlbum(CheckAlbum_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<CheckAlbum_RequestProperty>{ QueryFilter.New(CheckAlbum_RequestProperty.AlbumId, FilterConditions.Equals, request.AlbumId) };
            #endregion
            var result = new List<CheckAlbum_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new CheckAlbum_Result
                    {
                        BlankName_0 = r.GetValue(0) as bool?,
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_CheckAlbum, parameters.IFilters, materialize);
            var procResult = new StoredProcResult<CheckAlbum_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named CheckArtist.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of CheckArtist_Result</returns>
        public StoredProcResult<CheckArtist_Result> CheckArtist(CheckArtist_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<CheckArtist_RequestProperty>{ QueryFilter.New(CheckArtist_RequestProperty.ArtistId, FilterConditions.Equals, request.ArtistId) };
            #endregion
            var result = new List<CheckArtist_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new CheckArtist_Result
                    {
                        BlankName_0 = r.GetValue(0) as bool?,
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_CheckArtist, parameters.IFilters, materialize);
            var procResult = new StoredProcResult<CheckArtist_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named CheckGenre.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of CheckGenre_Result</returns>
        public StoredProcResult<CheckGenre_Result> CheckGenre(CheckGenre_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<CheckGenre_RequestProperty>{ QueryFilter.New(CheckGenre_RequestProperty.GenreId, FilterConditions.Equals, request.GenreId) };
            #endregion
            var result = new List<CheckGenre_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new CheckGenre_Result
                    {
                        BlankName_0 = r.GetValue(0) as bool?,
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_CheckGenre, parameters.IFilters, materialize);
            var procResult = new StoredProcResult<CheckGenre_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named CheckMediaType.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of CheckMediaType_Result</returns>
        public StoredProcResult<CheckMediaType_Result> CheckMediaType(CheckMediaType_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<CheckMediaType_RequestProperty>{ QueryFilter.New(CheckMediaType_RequestProperty.MediaTypeId, FilterConditions.Equals, request.MediaTypeId) };
            #endregion
            var result = new List<CheckMediaType_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new CheckMediaType_Result
                    {
                        BlankName_0 = r.GetValue(0) as bool?,
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_CheckMediaType, parameters.IFilters, materialize);
            var procResult = new StoredProcResult<CheckMediaType_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named CheckPlaylist.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of CheckPlaylist_Result</returns>
        public StoredProcResult<CheckPlaylist_Result> CheckPlaylist(CheckPlaylist_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<CheckPlaylist_RequestProperty>{ QueryFilter.New(CheckPlaylist_RequestProperty.PlaylistId, FilterConditions.Equals, request.PlaylistId) };
            #endregion
            var result = new List<CheckPlaylist_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new CheckPlaylist_Result
                    {
                        BlankName_0 = r.GetValue(0) as bool?,
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_CheckPlaylist, parameters.IFilters, materialize);
            var procResult = new StoredProcResult<CheckPlaylist_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named CheckPlaylistTrack.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of CheckPlaylistTrack_Result</returns>
        public StoredProcResult<CheckPlaylistTrack_Result> CheckPlaylistTrack(CheckPlaylistTrack_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<CheckPlaylistTrack_RequestProperty>{ QueryFilter.New(CheckPlaylistTrack_RequestProperty.PlaylistId, FilterConditions.Equals, request.PlaylistId), QueryFilter.New(CheckPlaylistTrack_RequestProperty.TrackId, FilterConditions.Equals, request.TrackId) };
            #endregion
            var result = new List<CheckPlaylistTrack_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new CheckPlaylistTrack_Result
                    {
                        BlankName_0 = r.GetValue(0) as bool?,
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_CheckPlaylistTrack, parameters.IFilters, materialize);
            var procResult = new StoredProcResult<CheckPlaylistTrack_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named CheckTrack.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of CheckTrack_Result</returns>
        public StoredProcResult<CheckTrack_Result> CheckTrack(CheckTrack_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<CheckTrack_RequestProperty>{ QueryFilter.New(CheckTrack_RequestProperty.TrackId, FilterConditions.Equals, request.TrackId) };
            #endregion
            var result = new List<CheckTrack_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new CheckTrack_Result
                    {
                        BlankName_0 = r.GetValue(0) as bool?,
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_CheckTrack, parameters.IFilters, materialize);
            var procResult = new StoredProcResult<CheckTrack_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named DeleteAlbum.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        public int DeleteAlbum(DeleteAlbum_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<DeleteAlbum_RequestProperty>{ QueryFilter.New(DeleteAlbum_RequestProperty.AlbumId, FilterConditions.Equals, request.AlbumId) };
            #endregion
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_DeleteAlbum, parameters.IFilters, null);
            return (int)procReturnVals[ReturnParamId];
        }
        /// <summary>
        /// Executes Stored Procedure named DeleteArtist.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        public int DeleteArtist(DeleteArtist_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<DeleteArtist_RequestProperty>{ QueryFilter.New(DeleteArtist_RequestProperty.ArtistId, FilterConditions.Equals, request.ArtistId) };
            #endregion
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_DeleteArtist, parameters.IFilters, null);
            return (int)procReturnVals[ReturnParamId];
        }
        /// <summary>
        /// Executes Stored Procedure named DeleteGenre.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        public int DeleteGenre(DeleteGenre_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<DeleteGenre_RequestProperty>{ QueryFilter.New(DeleteGenre_RequestProperty.GenreId, FilterConditions.Equals, request.GenreId) };
            #endregion
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_DeleteGenre, parameters.IFilters, null);
            return (int)procReturnVals[ReturnParamId];
        }
        /// <summary>
        /// Executes Stored Procedure named DeleteMediaType.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        public int DeleteMediaType(DeleteMediaType_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<DeleteMediaType_RequestProperty>{ QueryFilter.New(DeleteMediaType_RequestProperty.MediaTypeId, FilterConditions.Equals, request.MediaTypeId) };
            #endregion
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_DeleteMediaType, parameters.IFilters, null);
            return (int)procReturnVals[ReturnParamId];
        }
        /// <summary>
        /// Executes Stored Procedure named DeletePlaylist.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        public int DeletePlaylist(DeletePlaylist_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<DeletePlaylist_RequestProperty>{ QueryFilter.New(DeletePlaylist_RequestProperty.PlaylistId, FilterConditions.Equals, request.PlaylistId) };
            #endregion
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_DeletePlaylist, parameters.IFilters, null);
            return (int)procReturnVals[ReturnParamId];
        }
        /// <summary>
        /// Executes Stored Procedure named DeletePlaylistTrack.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        public int DeletePlaylistTrack(DeletePlaylistTrack_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<DeletePlaylistTrack_RequestProperty>{ QueryFilter.New(DeletePlaylistTrack_RequestProperty.PlaylistId, FilterConditions.Equals, request.PlaylistId), QueryFilter.New(DeletePlaylistTrack_RequestProperty.TrackId, FilterConditions.Equals, request.TrackId) };
            #endregion
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_DeletePlaylistTrack, parameters.IFilters, null);
            return (int)procReturnVals[ReturnParamId];
        }
        /// <summary>
        /// Executes Stored Procedure named DeleteTrack.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        public int DeleteTrack(DeleteTrack_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<DeleteTrack_RequestProperty>{ QueryFilter.New(DeleteTrack_RequestProperty.TrackId, FilterConditions.Equals, request.TrackId) };
            #endregion
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_DeleteTrack, parameters.IFilters, null);
            return (int)procReturnVals[ReturnParamId];
        }
        /// <summary>
        /// Executes Stored Procedure named GetAlbum.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetAlbum_Result</returns>
        public StoredProcResult<GetAlbum_Result> GetAlbum(GetAlbum_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<GetAlbum_RequestProperty>{ QueryFilter.New(GetAlbum_RequestProperty.AlbumId, FilterConditions.Equals, request.AlbumId) };
            #endregion
            var result = new List<GetAlbum_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new GetAlbum_Result
                    {
                        AlbumId = r.GetInt32(0),
                        Title = r.GetString(1),
                        ArtistId = r.GetInt32(2),
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_GetAlbum, parameters.IFilters, materialize);
            var procResult = new StoredProcResult<GetAlbum_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named GetAlbumsByArtist.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetAlbumsByArtist_Result</returns>
        public StoredProcResult<GetAlbumsByArtist_Result> GetAlbumsByArtist(GetAlbumsByArtist_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<GetAlbumsByArtist_RequestProperty>{ QueryFilter.New(GetAlbumsByArtist_RequestProperty.ArtistId, FilterConditions.Equals, request.ArtistId) };
            #endregion
            var result = new List<GetAlbumsByArtist_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new GetAlbumsByArtist_Result
                    {
                        AlbumId = r.GetInt32(0),
                        Title = r.GetString(1),
                        ArtistId = r.GetInt32(2),
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_GetAlbumsByArtist, parameters.IFilters, materialize);
            var procResult = new StoredProcResult<GetAlbumsByArtist_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named GetAllAlbums.
        /// </summary>
        /// <returns>StoredProcResult of GetAllAlbums_Result</returns>
        public StoredProcResult<GetAllAlbums_Result> GetAllAlbums()
        {
            var result = new List<GetAllAlbums_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new GetAllAlbums_Result
                    {
                        AlbumId = r.GetInt32(0),
                        Title = r.GetString(1),
                        ArtistId = r.GetInt32(2),
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_GetAllAlbums, null, materialize);
            var procResult = new StoredProcResult<GetAllAlbums_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named GetAllArtists.
        /// </summary>
        /// <returns>StoredProcResult of GetAllArtists_Result</returns>
        public StoredProcResult<GetAllArtists_Result> GetAllArtists()
        {
            var result = new List<GetAllArtists_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new GetAllArtists_Result
                    {
                        ArtistId = r.GetInt32(0),
                        Name = r.GetString(1),
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_GetAllArtists, null, materialize);
            var procResult = new StoredProcResult<GetAllArtists_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named GetAllGenres.
        /// </summary>
        /// <returns>StoredProcResult of GetAllGenres_Result</returns>
        public StoredProcResult<GetAllGenres_Result> GetAllGenres()
        {
            var result = new List<GetAllGenres_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new GetAllGenres_Result
                    {
                        GenreId = r.GetInt32(0),
                        Name = r.GetString(1),
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_GetAllGenres, null, materialize);
            var procResult = new StoredProcResult<GetAllGenres_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named GetAllMediaTypes.
        /// </summary>
        /// <returns>StoredProcResult of GetAllMediaTypes_Result</returns>
        public StoredProcResult<GetAllMediaTypes_Result> GetAllMediaTypes()
        {
            var result = new List<GetAllMediaTypes_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new GetAllMediaTypes_Result
                    {
                        MediaTypeId = r.GetInt32(0),
                        Name = r.GetString(1),
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_GetAllMediaTypes, null, materialize);
            var procResult = new StoredProcResult<GetAllMediaTypes_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named GetAllPlaylists.
        /// </summary>
        /// <returns>StoredProcResult of GetAllPlaylists_Result</returns>
        public StoredProcResult<GetAllPlaylists_Result> GetAllPlaylists()
        {
            var result = new List<GetAllPlaylists_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new GetAllPlaylists_Result
                    {
                        PlaylistId = r.GetInt32(0),
                        Name = r.GetString(1),
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_GetAllPlaylists, null, materialize);
            var procResult = new StoredProcResult<GetAllPlaylists_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named GetAllPlaylistTracks.
        /// </summary>
        /// <returns>StoredProcResult of GetAllPlaylistTracks_Result</returns>
        public StoredProcResult<GetAllPlaylistTracks_Result> GetAllPlaylistTracks()
        {
            var result = new List<GetAllPlaylistTracks_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new GetAllPlaylistTracks_Result
                    {
                        PlaylistId = r.GetInt32(0),
                        TrackId = r.GetInt32(1),
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_GetAllPlaylistTracks, null, materialize);
            var procResult = new StoredProcResult<GetAllPlaylistTracks_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named GetAllTracks.
        /// </summary>
        /// <returns>StoredProcResult of GetAllTracks_Result</returns>
        public StoredProcResult<GetAllTracks_Result> GetAllTracks()
        {
            var result = new List<GetAllTracks_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new GetAllTracks_Result
                    {
                        TrackId = r.GetInt32(0),
                        Name = r.GetString(1),
                        AlbumId = r.GetValue(2) as int?,
                        MediaTypeId = r.GetInt32(3),
                        GenreId = r.GetValue(4) as int?,
                        Composer = r.GetValue(5) as string,
                        Milliseconds = r.GetInt32(6),
                        Bytes = r.GetValue(7) as int?,
                        UnitPrice = r.GetDecimal(8),
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_GetAllTracks, null, materialize);
            var procResult = new StoredProcResult<GetAllTracks_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named GetArtist.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetArtist_Result</returns>
        public StoredProcResult<GetArtist_Result> GetArtist(GetArtist_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<GetArtist_RequestProperty>{ QueryFilter.New(GetArtist_RequestProperty.ArtistId, FilterConditions.Equals, request.ArtistId) };
            #endregion
            var result = new List<GetArtist_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new GetArtist_Result
                    {
                        ArtistId = r.GetInt32(0),
                        Name = r.GetString(1),
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_GetArtist, parameters.IFilters, materialize);
            var procResult = new StoredProcResult<GetArtist_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named GetGenre.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetGenre_Result</returns>
        public StoredProcResult<GetGenre_Result> GetGenre(GetGenre_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<GetGenre_RequestProperty>{ QueryFilter.New(GetGenre_RequestProperty.GenreId, FilterConditions.Equals, request.GenreId) };
            #endregion
            var result = new List<GetGenre_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new GetGenre_Result
                    {
                        GenreId = r.GetInt32(0),
                        Name = r.GetString(1),
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_GetGenre, parameters.IFilters, materialize);
            var procResult = new StoredProcResult<GetGenre_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named GetMediaType.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetMediaType_Result</returns>
        public StoredProcResult<GetMediaType_Result> GetMediaType(GetMediaType_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<GetMediaType_RequestProperty>{ QueryFilter.New(GetMediaType_RequestProperty.MediaTypeId, FilterConditions.Equals, request.MediaTypeId) };
            #endregion
            var result = new List<GetMediaType_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new GetMediaType_Result
                    {
                        MediaTypeId = r.GetInt32(0),
                        Name = r.GetString(1),
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_GetMediaType, parameters.IFilters, materialize);
            var procResult = new StoredProcResult<GetMediaType_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named GetPlaylist.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetPlaylist_Result</returns>
        public StoredProcResult<GetPlaylist_Result> GetPlaylist(GetPlaylist_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<GetPlaylist_RequestProperty>{ QueryFilter.New(GetPlaylist_RequestProperty.PlaylistId, FilterConditions.Equals, request.PlaylistId) };
            #endregion
            var result = new List<GetPlaylist_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new GetPlaylist_Result
                    {
                        PlaylistId = r.GetInt32(0),
                        Name = r.GetString(1),
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_GetPlaylist, parameters.IFilters, materialize);
            var procResult = new StoredProcResult<GetPlaylist_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named GetPlaylistsByTrack.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetPlaylistsByTrack_Result</returns>
        public StoredProcResult<GetPlaylistsByTrack_Result> GetPlaylistsByTrack(GetPlaylistsByTrack_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<GetPlaylistsByTrack_RequestProperty>{ QueryFilter.New(GetPlaylistsByTrack_RequestProperty.TrackId, FilterConditions.Equals, request.TrackId) };
            #endregion
            var result = new List<GetPlaylistsByTrack_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new GetPlaylistsByTrack_Result
                    {
                        PlaylistId = r.GetInt32(0),
                        Name = r.GetString(1),
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_GetPlaylistsByTrack, parameters.IFilters, materialize);
            var procResult = new StoredProcResult<GetPlaylistsByTrack_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named GetPlaylistTrack.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetPlaylistTrack_Result</returns>
        public StoredProcResult<GetPlaylistTrack_Result> GetPlaylistTrack(GetPlaylistTrack_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<GetPlaylistTrack_RequestProperty>{ QueryFilter.New(GetPlaylistTrack_RequestProperty.PlaylistId, FilterConditions.Equals, request.PlaylistId), QueryFilter.New(GetPlaylistTrack_RequestProperty.TrackId, FilterConditions.Equals, request.TrackId) };
            #endregion
            var result = new List<GetPlaylistTrack_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new GetPlaylistTrack_Result
                    {
                        PlaylistId = r.GetInt32(0),
                        TrackId = r.GetInt32(1),
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_GetPlaylistTrack, parameters.IFilters, materialize);
            var procResult = new StoredProcResult<GetPlaylistTrack_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named GetTrack.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetTrack_Result</returns>
        public StoredProcResult<GetTrack_Result> GetTrack(GetTrack_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<GetTrack_RequestProperty>{ QueryFilter.New(GetTrack_RequestProperty.TrackId, FilterConditions.Equals, request.TrackId) };
            #endregion
            var result = new List<GetTrack_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new GetTrack_Result
                    {
                        TrackId = r.GetInt32(0),
                        Name = r.GetString(1),
                        AlbumId = r.GetValue(2) as int?,
                        MediaTypeId = r.GetInt32(3),
                        GenreId = r.GetValue(4) as int?,
                        Composer = r.GetValue(5) as string,
                        Milliseconds = r.GetInt32(6),
                        Bytes = r.GetValue(7) as int?,
                        UnitPrice = r.GetDecimal(8),
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_GetTrack, parameters.IFilters, materialize);
            var procResult = new StoredProcResult<GetTrack_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named GetTracksByAlbum.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetTracksByAlbum_Result</returns>
        public StoredProcResult<GetTracksByAlbum_Result> GetTracksByAlbum(GetTracksByAlbum_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<GetTracksByAlbum_RequestProperty>{ QueryFilter.New(GetTracksByAlbum_RequestProperty.AlbumId, FilterConditions.Equals, request.AlbumId) };
            #endregion
            var result = new List<GetTracksByAlbum_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new GetTracksByAlbum_Result
                    {
                        TrackId = r.GetInt32(0),
                        Name = r.GetString(1),
                        AlbumId = r.GetValue(2) as int?,
                        MediaTypeId = r.GetInt32(3),
                        GenreId = r.GetValue(4) as int?,
                        Composer = r.GetValue(5) as string,
                        Milliseconds = r.GetInt32(6),
                        Bytes = r.GetValue(7) as int?,
                        UnitPrice = r.GetDecimal(8),
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_GetTracksByAlbum, parameters.IFilters, materialize);
            var procResult = new StoredProcResult<GetTracksByAlbum_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named GetTracksByArtist.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetTracksByArtist_Result</returns>
        public StoredProcResult<GetTracksByArtist_Result> GetTracksByArtist(GetTracksByArtist_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<GetTracksByArtist_RequestProperty>{ QueryFilter.New(GetTracksByArtist_RequestProperty.ArtistId, FilterConditions.Equals, request.ArtistId) };
            #endregion
            var result = new List<GetTracksByArtist_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new GetTracksByArtist_Result
                    {
                        TrackId = r.GetInt32(0),
                        Name = r.GetString(1),
                        AlbumId = r.GetValue(2) as int?,
                        MediaTypeId = r.GetInt32(3),
                        GenreId = r.GetValue(4) as int?,
                        Composer = r.GetValue(5) as string,
                        Milliseconds = r.GetInt32(6),
                        Bytes = r.GetValue(7) as int?,
                        UnitPrice = r.GetDecimal(8),
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_GetTracksByArtist, parameters.IFilters, materialize);
            var procResult = new StoredProcResult<GetTracksByArtist_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named GetTracksByGenre.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetTracksByGenre_Result</returns>
        public StoredProcResult<GetTracksByGenre_Result> GetTracksByGenre(GetTracksByGenre_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<GetTracksByGenre_RequestProperty>{ QueryFilter.New(GetTracksByGenre_RequestProperty.GenreId, FilterConditions.Equals, request.GenreId) };
            #endregion
            var result = new List<GetTracksByGenre_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new GetTracksByGenre_Result
                    {
                        TrackId = r.GetInt32(0),
                        Name = r.GetString(1),
                        AlbumId = r.GetValue(2) as int?,
                        MediaTypeId = r.GetInt32(3),
                        GenreId = r.GetValue(4) as int?,
                        Composer = r.GetValue(5) as string,
                        Milliseconds = r.GetInt32(6),
                        Bytes = r.GetValue(7) as int?,
                        UnitPrice = r.GetDecimal(8),
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_GetTracksByGenre, parameters.IFilters, materialize);
            var procResult = new StoredProcResult<GetTracksByGenre_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named GetTracksByInvoice.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetTracksByInvoice_Result</returns>
        public StoredProcResult<GetTracksByInvoice_Result> GetTracksByInvoice(GetTracksByInvoice_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<GetTracksByInvoice_RequestProperty>{ QueryFilter.New(GetTracksByInvoice_RequestProperty.InvoiceId, FilterConditions.Equals, request.InvoiceId) };
            #endregion
            var result = new List<GetTracksByInvoice_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new GetTracksByInvoice_Result
                    {
                        TrackId = r.GetInt32(0),
                        Name = r.GetString(1),
                        AlbumId = r.GetValue(2) as int?,
                        MediaTypeId = r.GetInt32(3),
                        GenreId = r.GetValue(4) as int?,
                        Composer = r.GetValue(5) as string,
                        Milliseconds = r.GetInt32(6),
                        Bytes = r.GetValue(7) as int?,
                        UnitPrice = r.GetDecimal(8),
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_GetTracksByInvoice, parameters.IFilters, materialize);
            var procResult = new StoredProcResult<GetTracksByInvoice_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named GetTracksByMediaType.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetTracksByMediaType_Result</returns>
        public StoredProcResult<GetTracksByMediaType_Result> GetTracksByMediaType(GetTracksByMediaType_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<GetTracksByMediaType_RequestProperty>{ QueryFilter.New(GetTracksByMediaType_RequestProperty.MediaTypeId, FilterConditions.Equals, request.MediaTypeId) };
            #endregion
            var result = new List<GetTracksByMediaType_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new GetTracksByMediaType_Result
                    {
                        TrackId = r.GetInt32(0),
                        Name = r.GetString(1),
                        AlbumId = r.GetValue(2) as int?,
                        MediaTypeId = r.GetInt32(3),
                        GenreId = r.GetValue(4) as int?,
                        Composer = r.GetValue(5) as string,
                        Milliseconds = r.GetInt32(6),
                        Bytes = r.GetValue(7) as int?,
                        UnitPrice = r.GetDecimal(8),
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_GetTracksByMediaType, parameters.IFilters, materialize);
            var procResult = new StoredProcResult<GetTracksByMediaType_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named GetTracksByPlaylist.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetTracksByPlaylist_Result</returns>
        public StoredProcResult<GetTracksByPlaylist_Result> GetTracksByPlaylist(GetTracksByPlaylist_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<GetTracksByPlaylist_RequestProperty>{ QueryFilter.New(GetTracksByPlaylist_RequestProperty.PlaylistId, FilterConditions.Equals, request.PlaylistId) };
            #endregion
            var result = new List<GetTracksByPlaylist_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new GetTracksByPlaylist_Result
                    {
                        TrackId = r.GetInt32(0),
                        Name = r.GetString(1),
                        AlbumId = r.GetValue(2) as int?,
                        MediaTypeId = r.GetInt32(3),
                        GenreId = r.GetValue(4) as int?,
                        Composer = r.GetValue(5) as string,
                        Milliseconds = r.GetInt32(6),
                        Bytes = r.GetValue(7) as int?,
                        UnitPrice = r.GetDecimal(8),
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_GetTracksByPlaylist, parameters.IFilters, materialize);
            var procResult = new StoredProcResult<GetTracksByPlaylist_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named InsertAlbum.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        public int InsertAlbum(InsertAlbum_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<InsertAlbum_RequestProperty>{ QueryFilter.New(InsertAlbum_RequestProperty.Title, FilterConditions.Equals, request.Title), QueryFilter.New(InsertAlbum_RequestProperty.ArtistId, FilterConditions.Equals, request.ArtistId), QueryFilter.New(InsertAlbum_RequestProperty.AlbumId, FilterConditions.Equals, request.AlbumId) };
            #endregion
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_InsertAlbum, parameters.IFilters, null);
            #region Assign Ouput Values
            request.AlbumId = procReturnVals[(int)InsertAlbum_RequestProperty.AlbumId] as int?;
            #endregion
            return (int)procReturnVals[ReturnParamId];
        }
        /// <summary>
        /// Executes Stored Procedure named InsertArtist.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        public int InsertArtist(InsertArtist_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<InsertArtist_RequestProperty>{ QueryFilter.New(InsertArtist_RequestProperty.Name, FilterConditions.Equals, request.Name), QueryFilter.New(InsertArtist_RequestProperty.ArtistId, FilterConditions.Equals, request.ArtistId) };
            #endregion
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_InsertArtist, parameters.IFilters, null);
            #region Assign Ouput Values
            request.ArtistId = procReturnVals[(int)InsertArtist_RequestProperty.ArtistId] as int?;
            #endregion
            return (int)procReturnVals[ReturnParamId];
        }
        /// <summary>
        /// Executes Stored Procedure named InsertGenre.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        public int InsertGenre(InsertGenre_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<InsertGenre_RequestProperty>{ QueryFilter.New(InsertGenre_RequestProperty.Name, FilterConditions.Equals, request.Name), QueryFilter.New(InsertGenre_RequestProperty.GenreId, FilterConditions.Equals, request.GenreId) };
            #endregion
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_InsertGenre, parameters.IFilters, null);
            #region Assign Ouput Values
            request.GenreId = procReturnVals[(int)InsertGenre_RequestProperty.GenreId] as int?;
            #endregion
            return (int)procReturnVals[ReturnParamId];
        }
        /// <summary>
        /// Executes Stored Procedure named InsertMediaType.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        public int InsertMediaType(InsertMediaType_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<InsertMediaType_RequestProperty>{ QueryFilter.New(InsertMediaType_RequestProperty.Name, FilterConditions.Equals, request.Name), QueryFilter.New(InsertMediaType_RequestProperty.MediaTypeId, FilterConditions.Equals, request.MediaTypeId) };
            #endregion
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_InsertMediaType, parameters.IFilters, null);
            #region Assign Ouput Values
            request.MediaTypeId = procReturnVals[(int)InsertMediaType_RequestProperty.MediaTypeId] as int?;
            #endregion
            return (int)procReturnVals[ReturnParamId];
        }
        /// <summary>
        /// Executes Stored Procedure named InsertPlaylist.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        public int InsertPlaylist(InsertPlaylist_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<InsertPlaylist_RequestProperty>{ QueryFilter.New(InsertPlaylist_RequestProperty.Name, FilterConditions.Equals, request.Name), QueryFilter.New(InsertPlaylist_RequestProperty.PlaylistId, FilterConditions.Equals, request.PlaylistId) };
            #endregion
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_InsertPlaylist, parameters.IFilters, null);
            #region Assign Ouput Values
            request.PlaylistId = procReturnVals[(int)InsertPlaylist_RequestProperty.PlaylistId] as int?;
            #endregion
            return (int)procReturnVals[ReturnParamId];
        }
        /// <summary>
        /// Executes Stored Procedure named InsertPlaylistTrack.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        public int InsertPlaylistTrack(InsertPlaylistTrack_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<InsertPlaylistTrack_RequestProperty>{ QueryFilter.New(InsertPlaylistTrack_RequestProperty.PlaylistId, FilterConditions.Equals, request.PlaylistId), QueryFilter.New(InsertPlaylistTrack_RequestProperty.TrackId, FilterConditions.Equals, request.TrackId) };
            #endregion
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_InsertPlaylistTrack, parameters.IFilters, null);
            return (int)procReturnVals[ReturnParamId];
        }
        /// <summary>
        /// Executes Stored Procedure named InsertTrack.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        public int InsertTrack(InsertTrack_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<InsertTrack_RequestProperty>{ QueryFilter.New(InsertTrack_RequestProperty.Name, FilterConditions.Equals, request.Name), QueryFilter.New(InsertTrack_RequestProperty.AlbumId, FilterConditions.Equals, request.AlbumId), QueryFilter.New(InsertTrack_RequestProperty.MediaTypeId, FilterConditions.Equals, request.MediaTypeId), QueryFilter.New(InsertTrack_RequestProperty.GenreId, FilterConditions.Equals, request.GenreId), QueryFilter.New(InsertTrack_RequestProperty.Composer, FilterConditions.Equals, request.Composer), QueryFilter.New(InsertTrack_RequestProperty.Milliseconds, FilterConditions.Equals, request.Milliseconds), QueryFilter.New(InsertTrack_RequestProperty.Bytes, FilterConditions.Equals, request.Bytes), QueryFilter.New(InsertTrack_RequestProperty.UnitPrice, FilterConditions.Equals, request.UnitPrice), QueryFilter.New(InsertTrack_RequestProperty.TrackId, FilterConditions.Equals, request.TrackId) };
            #endregion
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_InsertTrack, parameters.IFilters, null);
            #region Assign Ouput Values
            request.TrackId = procReturnVals[(int)InsertTrack_RequestProperty.TrackId] as int?;
            #endregion
            return (int)procReturnVals[ReturnParamId];
        }
        /// <summary>
        /// Executes Stored Procedure named UpdateAlbum.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        public int UpdateAlbum(UpdateAlbum_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<UpdateAlbum_RequestProperty>{ QueryFilter.New(UpdateAlbum_RequestProperty.AlbumId, FilterConditions.Equals, request.AlbumId), QueryFilter.New(UpdateAlbum_RequestProperty.Title, FilterConditions.Equals, request.Title), QueryFilter.New(UpdateAlbum_RequestProperty.ArtistId, FilterConditions.Equals, request.ArtistId) };
            #endregion
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_UpdateAlbum, parameters.IFilters, null);
            return (int)procReturnVals[ReturnParamId];
        }
        /// <summary>
        /// Executes Stored Procedure named UpdateArtist.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        public int UpdateArtist(UpdateArtist_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<UpdateArtist_RequestProperty>{ QueryFilter.New(UpdateArtist_RequestProperty.ArtistId, FilterConditions.Equals, request.ArtistId), QueryFilter.New(UpdateArtist_RequestProperty.Name, FilterConditions.Equals, request.Name) };
            #endregion
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_UpdateArtist, parameters.IFilters, null);
            return (int)procReturnVals[ReturnParamId];
        }
        /// <summary>
        /// Executes Stored Procedure named UpdateGenre.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        public int UpdateGenre(UpdateGenre_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<UpdateGenre_RequestProperty>{ QueryFilter.New(UpdateGenre_RequestProperty.GenreId, FilterConditions.Equals, request.GenreId), QueryFilter.New(UpdateGenre_RequestProperty.Name, FilterConditions.Equals, request.Name) };
            #endregion
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_UpdateGenre, parameters.IFilters, null);
            return (int)procReturnVals[ReturnParamId];
        }
        /// <summary>
        /// Executes Stored Procedure named UpdateMediaType.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        public int UpdateMediaType(UpdateMediaType_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<UpdateMediaType_RequestProperty>{ QueryFilter.New(UpdateMediaType_RequestProperty.MediaTypeId, FilterConditions.Equals, request.MediaTypeId), QueryFilter.New(UpdateMediaType_RequestProperty.Name, FilterConditions.Equals, request.Name) };
            #endregion
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_UpdateMediaType, parameters.IFilters, null);
            return (int)procReturnVals[ReturnParamId];
        }
        /// <summary>
        /// Executes Stored Procedure named UpdatePlaylist.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        public int UpdatePlaylist(UpdatePlaylist_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<UpdatePlaylist_RequestProperty>{ QueryFilter.New(UpdatePlaylist_RequestProperty.PlaylistId, FilterConditions.Equals, request.PlaylistId), QueryFilter.New(UpdatePlaylist_RequestProperty.Name, FilterConditions.Equals, request.Name) };
            #endregion
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_UpdatePlaylist, parameters.IFilters, null);
            return (int)procReturnVals[ReturnParamId];
        }
        /// <summary>
        /// Executes Stored Procedure named UpdatePlaylistTrack.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        public int UpdatePlaylistTrack(UpdatePlaylistTrack_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<UpdatePlaylistTrack_RequestProperty>{ QueryFilter.New(UpdatePlaylistTrack_RequestProperty.PlaylistId, FilterConditions.Equals, request.PlaylistId), QueryFilter.New(UpdatePlaylistTrack_RequestProperty.TrackId, FilterConditions.Equals, request.TrackId) };
            #endregion
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_UpdatePlaylistTrack, parameters.IFilters, null);
            return (int)procReturnVals[ReturnParamId];
        }
        /// <summary>
        /// Executes Stored Procedure named UpdateTrack.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        public int UpdateTrack(UpdateTrack_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<UpdateTrack_RequestProperty>{ QueryFilter.New(UpdateTrack_RequestProperty.TrackId, FilterConditions.Equals, request.TrackId), QueryFilter.New(UpdateTrack_RequestProperty.Name, FilterConditions.Equals, request.Name), QueryFilter.New(UpdateTrack_RequestProperty.AlbumId, FilterConditions.Equals, request.AlbumId), QueryFilter.New(UpdateTrack_RequestProperty.MediaTypeId, FilterConditions.Equals, request.MediaTypeId), QueryFilter.New(UpdateTrack_RequestProperty.GenreId, FilterConditions.Equals, request.GenreId), QueryFilter.New(UpdateTrack_RequestProperty.Composer, FilterConditions.Equals, request.Composer), QueryFilter.New(UpdateTrack_RequestProperty.Milliseconds, FilterConditions.Equals, request.Milliseconds), QueryFilter.New(UpdateTrack_RequestProperty.Bytes, FilterConditions.Equals, request.Bytes), QueryFilter.New(UpdateTrack_RequestProperty.UnitPrice, FilterConditions.Equals, request.UnitPrice) };
            #endregion
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Media_UpdateTrack, parameters.IFilters, null);
            return (int)procReturnVals[ReturnParamId];
        }
    }
}
