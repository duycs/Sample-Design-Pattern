using System.Collections.Generic;
public interface ITarget
{
    //check if a page in pages exist or not
    bool IsPageExist(string pageName);

    //get pages
    List<string> GetPages();
}