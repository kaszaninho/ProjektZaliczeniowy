using PsychoMedik.Service.Reference;
using PsychoMedikApp.Helpers;
using PsychoMedikApp.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsychoMedikApp.Services
{
    public class HarmonogramDataStore : AListDataStore<HarmonogramForView>
    {
        public HarmonogramDataStore()
            : base()
        {
        }

        public override async Task<HarmonogramForView> AddItemToService(HarmonogramForView item)
        {
            return await _service.HarmonogramPOSTAsync(item);
        }

        public override async Task<bool> DeleteItemFromService(HarmonogramForView item)
        {
            return await _service.HarmonogramDELETEAsync(item.Id).HandleRequest();
        }

        public override async Task<HarmonogramForView> Find(HarmonogramForView item)
        {
            return await _service.HarmonogramGETAsync(item.Id);
        }

        public override async Task<HarmonogramForView> Find(int id)
        {
            return await _service.HarmonogramGETAsync(id);
        }

        public override async Task RefreshListFromService()
        {
            items = _service.HarmonogramAllAsync().Result.ToList();
        }

        public override async Task<bool> UpdateItemInService(HarmonogramForView item)
        {
            return await _service.HarmonogramPUTAsync(item.Id, item).HandleRequest();
        }
    }
}