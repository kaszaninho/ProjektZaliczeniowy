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
    public class PracownikDataStore : AListDataStore<PracownikForView>
    {
        public PracownikDataStore()
            : base()
        {
        }

        public override async Task<PracownikForView> AddItemToService(PracownikForView item)
        {
            return await _service.PracownikPOSTAsync(item);
        }

        public override async Task<bool> DeleteItemFromService(PracownikForView item)
        {
            return await _service.PracownikDELETEAsync(item.Id).HandleRequest();
        }

        public override async Task<PracownikForView> Find(PracownikForView item)
        {
            return await _service.PracownikGETAsync(item.Id);
        }

        public override async Task<PracownikForView> Find(int id)
        {
            return await _service.PracownikGETAsync(id);
        }

        public override async Task RefreshListFromService()
        {
            items = _service.PracownikAllAsync().Result.ToList();
        }

        public override async Task<bool> UpdateItemInService(PracownikForView item)
        {
            return await _service.PracownikPUTAsync(item.Id, item).HandleRequest();
        }
    }
}