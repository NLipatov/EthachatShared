﻿#nullable disable
using Microsoft.AspNetCore.Components.Forms;

namespace LimpShared.Models.Message.DataTransfer;

public record DataFile
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public List<Package> Packages { get; set; } = new();
}