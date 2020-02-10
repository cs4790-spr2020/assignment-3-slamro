
namespace BlabberApp.Domain
{
    public class Blab : IDatum
    {
        private System.DateTime _dttm;
        public System.DateTime DTTM
        {
            get { return this._dttm; }
            set { this._dttm = value; }
        }
        private string _message;
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }
        private string _userId;
        public string UserID
        {
            get { return this._message; }
            set { this._message = value; }
        }
        
        public string getSysID()
        {
            return "";
        }

    }
}