using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo <CLASS,ID,RET>
    {
        List<CLASS> Get(); //get all
        CLASS Get(ID id); // single get
        RET Add(CLASS obj); // add
        RET Update(CLASS obj); //update
        bool Delete(ID id); // delete
    }
}
