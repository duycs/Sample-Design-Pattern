using System.Collections.Generic;
public class PageAdaptee{ 
    public List<string> GetPages(){
        List<string> pages = new List<string>();
        pages.Add("News Page");
        pages.Add("Offer Page");
        pages.Add("About Us");
        return pages;
    }
}