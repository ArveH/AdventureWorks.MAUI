using AdventureWorks.EntityLayer;
using Common.Library;
using System.Collections.ObjectModel;

namespace AdventureWorks.DataLayer;

/// <summary>
/// This class creates some fake data for Colors.
/// </summary>
public partial class ColorRepository : IRepository<Color>
{
    #region Get Method
    /// <summary>
    /// Get all Color objects
    /// </summary>
    /// <returns>A list of Color objects</returns>
    public ObservableCollection<AdventureWorks.EntityLayer.Color> Get()
    {
        return new ObservableCollection<AdventureWorks.EntityLayer.Color>
    {
      new AdventureWorks.EntityLayer.Color {
        ColorId = 1,
        ColorName = "Black",
      },
      new AdventureWorks.EntityLayer.Color {
        ColorId = 2,
        ColorName = "Blue",
      },
      new AdventureWorks.EntityLayer.Color {
        ColorId = 3,
        ColorName = "Gray",
      },
      new AdventureWorks.EntityLayer.Color {
        ColorId = 4,
        ColorName = "Multi",
      },
      new AdventureWorks.EntityLayer.Color {
        ColorId = 5,
        ColorName = "Red",
      },
      new AdventureWorks.EntityLayer.Color {
        ColorId = 6,
        ColorName = "Silver",
      },
      new AdventureWorks.EntityLayer.Color {
        ColorId = 7,
        ColorName = "Silver/Black",
      },
      new AdventureWorks.EntityLayer.Color {
        ColorId = 8,
        ColorName = "White",
      },
      new AdventureWorks.EntityLayer.Color {
        ColorId = 9,
        ColorName = "Yellow",
      }
    };
    }
    #endregion

    #region Get(id) Method
    /// <summary>
    /// Get a single Color object
    /// </summary>
    /// <param name="id">The value to locate</param>
    /// <returns>A valid Color object object, or null if not found</returns>
    public AdventureWorks.EntityLayer.Color? Get(int id)
    {
        return Get().Where(row => row.ColorId == id).FirstOrDefault();
    }
    #endregion
}