using System.Collections;
using System;
using BlabberApp.Domain;

namespace BlabberApp.DataStore
{
    public class InMemory : IDataStore
    {
        private ArrayList _items = new ArrayList();
        public bool Create(IDatum datum){
            int idx = this._items.Add(datum);
            if (idx <0){
                throw new ArgumentOutOfRangeException("OH HELL!!");
            }
            return true;
        }

        public IDatum Read(int idx){
            return (IDatum)this._items[idx];
        }

        public bool Update(IDatum datum){
            return true;
        }

        public bool Delete(int idx){
            //int idx = specimen.getint();
            try{
            this._items.RemoveAt(idx);
            }
            catch(ArgumentOutOfRangeException e){
                throw e;
            }

            return true;
        }


    }
}
