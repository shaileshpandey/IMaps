// -----------------------------------------------------------------------
// <copyright file="Program.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace IMaps.Domain
{
  using System;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using System.Xml.Serialization;

  /// <summary>
  /// Contains list of Roles.
  /// </summary>
  [Serializable]
  [DataContract(Namespace = "")]
  public class Program
  {
    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>
    /// The name.
    /// </value>
    [DataMember]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the program roles.
    /// </summary>
    /// <value>
    /// The program roles.
    /// </value>
    [DataMember]
    [XmlArray("ProgramRole")]
    [XmlArrayItem("ProgramRole")]  
    public List<ProgramRole> ProgramRoles { get; set; }

  }
}
