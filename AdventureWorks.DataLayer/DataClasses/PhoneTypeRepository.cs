using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using AdventureWorks.EntityLayer;
using Common.Library;

namespace AdventureWorks.DataLayer;

/// <summary>
/// This class creates some fake data for Phone Types.
/// </summary>
public partial class PhoneTypeRepository : IRepository<PhoneType>
{
  #region Get Method
  /// <summary>
  /// Get all PhoneType objects
  /// </summary>
  /// <returns>A list of PhoneType objects</returns>
  public ObservableCollection<PhoneType> Get()
  {
    return new ObservableCollection<PhoneType>
    {
      new PhoneType {
         PhoneTypeId = 1,
         TypeDescription = "Home",
      },
      new PhoneType {
         PhoneTypeId = 2,
         TypeDescription = "Mobile",
      },
      new PhoneType {
         PhoneTypeId = 3,
         TypeDescription = "Other",
      }
    };
  }
  #endregion

  #region Get(id) Method
  /// <summary>
  /// Get a single PhoneType object
  /// </summary>
  /// <param name="id">The value to locate</param>
  /// <returns>A valid PhoneType object object, or null if not found</returns>
  public PhoneType? Get(int id)
  {
    return Get().Where(row => row.PhoneTypeId == id).FirstOrDefault();
  }
  #endregion
}