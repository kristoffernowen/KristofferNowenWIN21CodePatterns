using Fixxo.Core.Models;

namespace Fixxo.Core.Interface.Services
{
    public interface IDisplayProductService
    {
        // ansvarar för att en hämta produkt - en sak
        // delar på Products, för det blir så mycket annars. Annars kunde crud ha varit en sak



        public Task<Shoes> GetShoesAsync(Guid id);
        public Task<Jacket> GetJacketAsync(Guid id);
        public Task<Boots> GetBootsAsync(Guid id);
        public Task<HighHeels> GetHighHeelsAsync(Guid id);

    }
}
