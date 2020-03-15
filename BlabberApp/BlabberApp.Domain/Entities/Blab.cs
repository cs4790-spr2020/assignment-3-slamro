using System;
namespace BlabberApp.Domain.Entities
{
    public class Blab : BaseEntity
    {
        private System.DateTime _dttm = DateTime.Now;
        
        public DateTime DTTM 
        { 
            get{return this._dttm;}
            set{this._dttm = value;}
        }
        public string Message { get; set;}
        public string UserID { get; set;}
        


    }
}