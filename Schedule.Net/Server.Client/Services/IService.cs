using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Client
{
    public abstract class IService<T> where T : class
    {
        protected ClientHelper<T> SvrHelper = new ClientHelper<T>();
        protected T MyService
        {
            get
            {
                return SvrHelper.GetService();
            }
        }

        protected abstract string GetTestActionName();

        public bool Initialize()
        {
            return SvrHelper.Initialize(GetTestActionName());
        }
    }
}
