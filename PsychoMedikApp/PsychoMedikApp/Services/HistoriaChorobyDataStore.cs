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
    public class HistoriaChorobyDataStore : AListDataStore<HistoriaChorobyForView>
    {
        public HistoriaChorobyDataStore()
            : base()
        {
        }

        public override async Task<HistoriaChorobyForView> AddItemToService(HistoriaChorobyForView item)
        {
            return await _service.HistoriaChorobyPOSTAsync(item);
        }

        public override async Task<bool> DeleteItemFromService(HistoriaChorobyForView item)
        {
            return await _service.HistoriaChorobyDELETEAsync(item.Id).HandleRequest();
        }

        public override async Task<HistoriaChorobyForView> Find(HistoriaChorobyForView item)
        {
            return await _service.HistoriaChorobyGETAsync(item.Id);
        }

        public override async Task<HistoriaChorobyForView> Find(int id)
        {
            return await _service.HistoriaChorobyGETAsync(id);
        }

        public override async Task RefreshListFromService()
        {
            items = _service.HistoriaChorobyAllAsync().Result.ToList();
        }

        public override async Task<bool> UpdateItemInService(HistoriaChorobyForView item)
        {
            return await _service.HistoriaChorobyPUTAsync(item.Id, item).HandleRequest();
        }
    }
}