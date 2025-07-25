using System;
using System.Collections.Generic;

namespace ACE.Database.Models.Shard;

/// <summary>
/// Attribute Properties of Weenies
/// </summary>
public partial class BiotaPropertiesAttribute
{
    /// <summary>
    /// Id of the object this property belongs to
    /// </summary>
    public uint ObjectId { get; set; }

    /// <summary>
    /// Type of Property the value applies to (PropertyAttribute.????)
    /// </summary>
    public ushort Type { get; set; }

    /// <summary>
    /// innate points
    /// </summary>
    public uint InitLevel { get; set; }

    /// <summary>
    /// points raised
    /// </summary>
    public uint LevelFromCP { get; set; }

    /// <summary>
    /// XP spent on this attribute
    /// </summary>
    public uint CPSpent { get; set; }

    public virtual Biota Object { get; set; }
}
