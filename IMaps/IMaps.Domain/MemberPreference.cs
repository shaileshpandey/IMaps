// -----------------------------------------------------------------------
// <copyright file="MemberPreference.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace IMaps.Domain
{
  using System.Runtime.Serialization;

  /// <summary>
  /// TODO: Update summary.
  /// </summary>
  [DataContract(Namespace = "")]
  public class MemberPreference
  {
    /// <summary>
    /// Gets or sets the dependency preference.
    /// </summary>
    /// <value>
    /// The dependency preference.
    /// </value>
    [DataMember]
    public MemberDependencyPreference DependencyPreference { get; set; }

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    /// <value>
    /// The description.
    /// </value>
    [DataMember]
    public string Description { get; set; }

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
