// -----------------------------------------------------------------------
// <copyright file="IDomainService.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------
namespace IMaps.BusinessRules.Contracts
{
  using System.Collections.Generic;
  using Domain;

  /// <summary>
  /// TODO: Update summary.
  /// </summary>
  public interface IDomainRepository
  {
    /// <summary>
    /// Gets the member preferences.
    /// </summary>
    /// <returns>
    /// List of MemberPreference objects
    /// </returns>
    List<MemberPreference> GetMemberPreferences();

    /// <summary>
    /// Gets the team preferences.
    /// </summary>
    /// <returns>
    /// List of TeamPreference objects
    /// </returns>
    List<TeamPreference> GetTeamPreferences();

    /// <summary>
    /// Gets the program.
    /// </summary>
    /// <returns>
    /// Program having role and funtional details
    /// </returns>
    Program GetProgram();
  }
}
