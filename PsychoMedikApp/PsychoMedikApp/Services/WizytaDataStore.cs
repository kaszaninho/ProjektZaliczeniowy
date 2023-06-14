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
    public class WizytaDataStore : AListDataStore<WizytaForView>
    {
        public WizytaDataStore()
            : base()
        {
        }

        public override async Task<WizytaForView> AddItemToService(WizytaForView item)
        {
            return await _service.WizytaPOSTAsync(item);
        }

        public override async Task<bool> DeleteItemFromService(WizytaForView item)
        {
            return await _service.WizytaDELETEAsync(item.Id).HandleRequest();
        }

        public override async Task<WizytaForView> Find(WizytaForView item)
        {
            return await _service.WizytaGETAsync(item.Id);
        }

        public override async Task<WizytaForView> Find(int id)
        {
            return await _service.WizytaGETAsync(id);
        }

        public override async Task RefreshListFromService()
        {
            items = _service.WizytaAllAsync().Result.ToList();
        }

        public override async Task<bool> UpdateItemInService(WizytaForView item)
        {
            return await _service.WizytaPUTAsync(item.Id, item).HandleRequest();
        }
    }
}