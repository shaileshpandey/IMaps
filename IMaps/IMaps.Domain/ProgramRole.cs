namespace IMaps.Domain
{
  using System;
  using System.Collections.Generic;
  using System.Xml.Serialization;
  using System.Runtime.Serialization;

  /// <summary>
  /// Role specific to a program.
  /// </summary>
  [Serializable]
  [DataContract(Namespace = "")]
  public class ProgramRole
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
    /// Gets or sets the responsibilities.
    /// </summary>
    /// <value>
    /// The responsibilities.
    /// </value>
    [DataMember(Order = 2)]
    [XmlArray("PrimaryResponsibility")]
    [XmlArrayItem("PrimaryResponsibility")]
    public List<PrimaryResponsibility> Responsibilities { get; set; }
  }
}
