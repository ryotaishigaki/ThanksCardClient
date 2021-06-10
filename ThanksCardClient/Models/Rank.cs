using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThanksCardClient.Services;

namespace ThanksCardClient.Models
{
    public class Rank : BindableBase
    {
        #region Property
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { SetProperty(ref _Name, value); }
        }
        #endregion

        #region Property
        private int _Count;
        public int Count
        {
            get { return _Count; }
            set { SetProperty(ref _Count, value); }
        }
        #endregion

        #region GetRank 
        public async Task<List<Rank>> GetRanksAsync()
        {

            IRestService rest = new RestService();

            List<Rank> getRanks = await rest.GetRanksAsync();

            return getRanks;

        }

        #endregion
    }
}
