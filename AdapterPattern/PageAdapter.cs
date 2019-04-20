using System.Collections.Generic;
using System.Linq;
public class PageAdapter : ITarget
{
    PageAdaptee PageAdaptee {get;set;}

    //constructor an Adapter with matching Adaptee
    public PageAdapter(){
        PageAdaptee = new PageAdaptee();
    }

    public List<string> GetPages()
    {
        return PageAdaptee.GetPages();
    }

    public bool IsPageExist(string pageName)
    {
        var pages = PageAdaptee.GetPages();
        if(!pages.Any())
            return false;

        if(pages.Contains(pageName))
            return true;

        //default false
        return false;
    }
}