// -----------------------------------------------------------------------
// <copyright file="PrimaryResponsibilityItem.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------
namespace IMaps.Domain
{
  using System;
  using System.Runtime.Serialization;

  /// <summary>
  /// TODO: Update summary.
  /// </summary>
  [Serializable]
  [DataContract(Namespace = "")]
  public class PrimaryResponsibilityItem
  {
    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>
    /// The name.
    /// </value>
    [DataMember]
    public string Name { get; set; }
  }
}
