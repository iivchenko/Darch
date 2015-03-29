﻿// <copyright company="XATA">
//      Copyright (c) 2015, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

namespace Deduplication
{
    /// <summary>
    /// Provides functionality to create map storage.
    /// </summary>
    public interface IMapStorageFactory
    {
        RepositoryLib.IRepository<MapRecord, ulong> Create();
    }
}
