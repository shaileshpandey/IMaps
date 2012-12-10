// -----------------------------------------------------------------------
// <copyright file="Responsibility.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace IMaps.Domain
{
  using System;
  using System.Collections.Generic;
  using System.Xml.Serialization;
  using System.Runtime.Serialization;

  /// <summary>
  /// Functional responsbility of a role.
  /// </summary>
  [Serializable]
  [DataContract(Namespace = "")]
  public class PrimaryResponsibility
  {
    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>
    /// The name.
    /// </value>
    [DataMember(Order = 0)]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the responsibility items.
    /// </summary>
    /// <value>
    /// The responsibility items.
    /// </value>
    [XmlArray("PrimaryResponsibilityItem")]
    [XmlArrayItem("PrimaryResponsibilityItem")]
    //[DataMember(Order = 2)]
    public List<PrimaryResponsibilityItem> ResponsibilityItems { get; set; }
  }
}
