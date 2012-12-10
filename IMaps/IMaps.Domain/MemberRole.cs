// -----------------------------------------------------------------------
// <copyright file="MemberRole.cs" company="">
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
  /// TODO: Update summary.
  /// </summary>
  [Serializable]
  [DataContract(Namespace = "")]
  public class MemberRole
  {
    /// <summary>
    /// Gets or sets the responsibilities.
    /// </summary>
    /// <value>
    /// The responsibilities.
    /// </value>
    [DataMember]
    [XmlArray("PrimaryResponsibility")]
    [XmlArrayItem("PrimaryResponsibility")]  
    public List<PrimaryResponsibility> Responsibilities { get; set; }
  }
}
