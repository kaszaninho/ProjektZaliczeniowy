using PsychoMedik.Service.Reference;
using PsychoMedikApp.Helpers;
using PsychoMedikApp.Services.Abstract;
using System.Linq;
using System.Threading.Tasks;

namespace PsychoMedikApp.Services
{
    public class PacjentDataStore : AListDataStore<PacjentForView>
    {
        public PacjentDataStore()
            : base()
        {
        }

        public override async Task<PacjentForView> AddItemToService(PacjentForView item)
        {
            return await _service.PacjentPOSTAsync(item);
        }

        public override async Task<bool> DeleteItemFromService(PacjentForView item)
        {
            return await _service.PacjentDELETEAsync(item.Id).HandleRequest();
        }

        public override async Task<PacjentForView> Find(PacjentForView item)
        {
            return await _service.PacjentGETAsync(item.Id);
        }

        public override async Task<PacjentForView> Find(int id)
        {
            return await _service.PacjentGETAsync(id);
        }

        public override async Task RefreshListFromService()
        {
            items = _service.PacjentAllAsync().Result.ToList();
        }

        public override async Task<bool> UpdateItemInService(PacjentForView item)
        {
            return await _service.PacjentPUTAsync(item.Id, item).HandleRequest();
        }
    }
}