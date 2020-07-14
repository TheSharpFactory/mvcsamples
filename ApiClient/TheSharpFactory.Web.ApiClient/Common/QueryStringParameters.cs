#region Usings
using System;
using System.Collections.Generic;
using System.Globalization; 
#endregion

namespace TheSharpFactory.Web.Client
{
    internal class QueryStringParameters
    {
        public Dictionary<string, string> Parameters { get { return _parameters ?? null; } }
        private readonly Dictionary<string, string> _parameters;

        public QueryStringParameters()
        {
            _parameters = new Dictionary<string, string>(5);
        }
        public QueryStringParameters(int capacity)
        {
            _parameters = new Dictionary<string, string>(capacity);

        }

        public void Add(string paramName, string paramVal)
        {
            if(string.IsNullOrWhiteSpace(paramVal))
                return;

            _parameters.Add(paramName, paramVal);
        }

        public void Add(string paramName, Guid? paramVal)
        {
            if(!paramVal.HasValue)
                return;
            _parameters.Add(paramName, paramVal.Value.ToString());
        }
        public void Add(string paramName, Guid paramVal)
        {
            _parameters.Add(paramName, paramVal.ToString());
        }

        public void Add(string paramName, char? paramVal)
        {
            if(!paramVal.HasValue)
                return;
            _parameters.Add(paramName, paramVal.Value.ToString(CultureInfo.InvariantCulture));
        }
        public void Add(string paramName, char paramVal)
        {
            _parameters.Add(paramName, paramVal.ToString(CultureInfo.InvariantCulture));
        }

        public void Add(string paramName, int? paramVal)
        {
            if(!paramVal.HasValue)
                return;
            _parameters.Add(paramName, paramVal.Value.ToString(CultureInfo.InvariantCulture));
        }
        public void Add(string paramName, int paramVal)
        {
            _parameters.Add(paramName, paramVal.ToString(CultureInfo.InvariantCulture));
        }

        public void Add(string paramName, short? paramVal)
        {
            if(!paramVal.HasValue)
                return;
            _parameters.Add(paramName, paramVal.Value.ToString(CultureInfo.InvariantCulture));
        }
        public void Add(string paramName, short paramVal)
        {
            _parameters.Add(paramName, paramVal.ToString(CultureInfo.InvariantCulture));
        }

        public void Add(string paramName, long? paramVal)
        {
            if(!paramVal.HasValue)
                return;
            _parameters.Add(paramName, paramVal.Value.ToString(CultureInfo.InvariantCulture));
        }
        public void Add(string paramName, long paramVal)
        {
            _parameters.Add(paramName, paramVal.ToString(CultureInfo.InvariantCulture));
        }

        public void Add(string paramName, float? paramVal)
        {
            if(!paramVal.HasValue)
                return;
            _parameters.Add(paramName, paramVal.Value.ToString(CultureInfo.InvariantCulture));
        }
        public void Add(string paramName, float paramVal)
        {
            _parameters.Add(paramName, paramVal.ToString(CultureInfo.InvariantCulture));
        }

        public void Add(string paramName, double? paramVal)
        {
            if(!paramVal.HasValue)
                return;
            _parameters.Add(paramName, paramVal.Value.ToString(CultureInfo.InvariantCulture));
        }
        public void Add(string paramName, double paramVal)
        {
            _parameters.Add(paramName, paramVal.ToString(CultureInfo.InvariantCulture));
        }

        public void Add(string paramName, decimal? paramVal)
        {
            if(!paramVal.HasValue)
                return;
            _parameters.Add(paramName, paramVal.Value.ToString(CultureInfo.InvariantCulture));
        }
        public void Add(string paramName, decimal paramVal)
        {
            _parameters.Add(paramName, paramVal.ToString(CultureInfo.InvariantCulture));
        }

        public void Add(string paramName, DateTime? paramVal)
        {
            if(!paramVal.HasValue)
                return;
            _parameters.Add(paramName, paramVal.Value.ToString(CultureInfo.InvariantCulture));
        }
        public void Add(string paramName, DateTime paramVal)
        {
            _parameters.Add(paramName, paramVal.ToString(CultureInfo.InvariantCulture));
        }

        public void Add(string paramName, byte? paramVal)
        {
            if(!paramVal.HasValue)
                return;
            _parameters.Add(paramName, paramVal.Value.ToString(CultureInfo.InvariantCulture));
        }
        public void Add(string paramName, byte paramVal)
        {
            _parameters.Add(paramName, paramVal.ToString(CultureInfo.InvariantCulture));
        }

        public void Add(string paramName, bool? paramVal)
        {
            if(!paramVal.HasValue)
                return;
            _parameters.Add(paramName, paramVal.Value.ToString(CultureInfo.InvariantCulture));
        }
        public void Add(string paramName, bool paramVal)
        {
            _parameters.Add(paramName, paramVal.ToString(CultureInfo.InvariantCulture));
        }
    }
}
