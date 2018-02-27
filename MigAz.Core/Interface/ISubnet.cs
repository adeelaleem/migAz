// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace MigAz.Core.Interface
{
    public interface ISubnet
    {
        string Id { get; }
        string Name { get; }
        string AddressPrefix { get; }
    }
}

