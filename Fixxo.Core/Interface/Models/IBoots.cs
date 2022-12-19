using Fixxo.Core.Models.Enums;

namespace Fixxo.Core.Interface.Models;

public interface IBoots : IShoes
{
    bool IsKneeHigh { get; set; }
    Season Season { get; set; }
}