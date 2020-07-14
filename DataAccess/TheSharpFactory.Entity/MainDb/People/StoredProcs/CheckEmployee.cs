/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Entity.MainDb.People
{
    public partial class CheckEmployee_Request
    {
    }
}

************************************************/

/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Entity.MainDb.People
{
    public partial class CheckEmployee_Result
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;

namespace TheSharpFactory.Entity.MainDb.People
{

    /// <summary>
    /// This class represents the request parameters of this StoredProcedure
    /// </summary>
    public partial class CheckEmployee_Request
    {
        #region Parameters
        /// <summary>
        /// Direction In
        /// </summary>
        public int? EmployeeId { get; set; } 
        #endregion
    }

    /// <summary>
    /// This class represents the result of this StoredProcedure
    /// </summary>
    public partial class CheckEmployee_Result
    {
        #region Simple Properties
        public bool? BlankName_0 { get; set; } 
        #endregion
    }
}
