﻿// <copyright company="XATA">
//      Copyright (c) 2015, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

using System;
using System.Runtime.Serialization;
using RepositoryLib;

namespace Deduplication.Maps
{
    [Serializable]
    public sealed class MapMissingException : DeduplicationException
    {
        public MapMissingException()
        {
        }

        public MapMissingException(string message) 
            : base(message)
        {
        }

        public MapMissingException(string message, Exception innerException) 
            : base(message, innerException)
        {
        }

        private MapMissingException(SerializationInfo info, StreamingContext context) 
            : base(info, context)
        {
        }
    }
}
