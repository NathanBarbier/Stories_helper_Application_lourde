using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoriesHelper.Models
{
    class LogHistory : Model
    {
        protected int rowid;
        protected int fk_author;
        protected DateTime date_creation;
        protected string action;
        protected string _object;
        protected string object_id = null;
        protected string object_name = null;
        protected string object_parent = null;
        protected string object_parent_id = null;
        protected string object_parent_name = null;
        protected int fk_organization;
        protected string status;
        protected string exception = null;
        protected string ip;
        protected string page;

        public LogHistory()
        {

        }

        public void initialize(int rowid, int fk_author, DateTime date_creation, string action, string _object, int fk_organization, string status, string ip, string object_id = null, string object_name = null, string object_parent = null, string object_parent_id = null, string object_parent_name = null, string exception = null, string page = null)
        {
            this.rowid = rowid;
            this.fk_author = fk_author;
            this.date_creation = date_creation;
            this.action = action;
            this._object = _object;
            this.object_id = object_id;
            this.object_name = object_name;
            this.object_parent = object_parent;
            this.object_parent_id = object_parent_id;
            this.object_parent_name = object_parent_name;
            this.fk_organization = fk_organization;
            this.status = status;
            this.exception = exception;
            this.ip = ip;
            this.page = page;
        }

        public int getRowid()
        {
            return rowid;
        }

        public int getFk_author()
        {
            return fk_author;
        }

        public void setFk_author(int fkAuthor)
        {
            this.fk_author = fkAuthor;
        }

        public DateTime getDate_creation()
        {
            return date_creation;
        }

        public void setDate_creation(DateTime DateCreation)
        {
            this.date_creation = DateCreation;
        }

        public string getAction()
        {
            return action;
        }

        public void setAction(string action)
        {
            this.action = action;
        }

        public string getObject()
        {
            return _object;
        }
        
        public void setObject(string _object)
        {
            this._object = _object;
        }

        public string getObject_id()
        {
            return object_id;
        }
        
        public void setObject_id(string id)
        {
            this.object_id = id;
        }

        public string getObject_name()
        {
            return object_name;
        }
        
        public void setObject_name(string name)
        {
            this.object_name = name;
        }

        public string getObject_parent()
        {
            return object_parent;
        }
        
        public void setObject_parent(string object_parent)
        {
            this.object_parent = object_parent;
        }
        
        public string getObject_parent_id()
        {
            return object_parent_id;
        }
        
        public void setObject_parent_id(string id_parent)
        {
            this.object_parent_id = id_parent;
        }        
        
        public string getObject_parent_name()
        {
            return object_parent_name;
        }
        
        public void setObject_parent_name(string name_parent)
        {
            this.object_parent_name = name_parent;
        }

        public string getStatus()
        {
            return status;
        }
        
        public void setStatus(string status)
        {
            this.status = status;
        }

        public string getException()
        {
            return exception;
        }
        
        public void setException(string exception)
        {
            this.exception = exception;
        }

        public string getIp()
        {
            return ip;
        }
        
        public void setIp(string ip)
        {
            this.ip = ip;
        }

        public string getPage()
        {
            return page;
        }
        
        public void setPage(string page)
        {
            this.page = page;
        }
    }
}