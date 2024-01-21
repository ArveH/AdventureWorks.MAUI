using System;
using Common.Library;

namespace AdventureWorks.EntityLayer;

public class Color : EntityBase
{
  #region Private Variables
  private int _ColorId;
  private string _ColorName = string.Empty;
  #endregion

  #region Public Properties
  public int ColorId
  {
    get { return _ColorId; }
    set
    {
      _ColorId = value;
      RaisePropertyChanged(nameof(ColorId));
    }
  }

  public string ColorName
  {
    get { return _ColorName; }
    set {
      _ColorName = value;
      RaisePropertyChanged(nameof(ColorName));
    }
  }
  #endregion
}