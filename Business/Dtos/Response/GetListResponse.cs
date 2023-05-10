using Core.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response;

public class GetListResponse<T>:BasePageableModel 
{
    public IList<T> items
    {
        get=> _items??=new List<T>();
        set => _items = value;
    }
    private IList<T> _items;
}
