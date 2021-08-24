using collection_demo.Model;
using System.Collections;
using System.Collections.Generic;
namespace collection_demo.Proper_Model
{
    public class CountryDetails//pascal case
    {
         public ArrayList countryDetails1()//camel case
        {
            ArrayList arrayList = new ArrayList();//pascal case
            arrayList.Add("Ruppess");
            arrayList.Add("India");
            arrayList.Add("America");
            arrayList.Add("Dollar");
            arrayList.Add("Cameroon");
            arrayList.Add("Franc");
            return arrayList;
        }
         public List<Country> CountryDetails2()
        {
            List<Country> obj = new List<Country>();
            obj.Add(new Country
            {
                currency = "Dollar",
                cname = "Australia"
            });
            obj.Add(new Country
            {
                currency = "Euro",
                cname = "Austria"
            });
            obj.Add(new Country
            {
                currency = "Euro",
                cname = "Belgium"
            });
            return obj;

        
    }
}
}