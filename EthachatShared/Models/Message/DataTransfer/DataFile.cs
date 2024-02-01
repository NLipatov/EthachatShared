#nullable disable

using System;
using System.Collections.Generic;

namespace EthachatShared.Models.Message.DataTransfer;

public record DataFile
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public List<Package> Packages { get; set; } = new();
}